grammar MathExpr;

options {
  language=CSharp2;
  output=AST;
  ASTLabelType = AstNode;
  backtrack=true;
  memoize=true;
}


tokens {
  UNKNOWN             ;
  BLOCK               ;
  PARAMS              ;
  CALL                ;
  IF      = 'if'      ;
  THEN    = 'then'    ;
  ELSE    = 'else'    ;
  FOR     = 'for'     ;
  TO      = 'to'      ;
  WHILE   = 'while'   ;
  DO      = 'do'      ;
  REPEAT  = 'repeat'  ;
  UNTIL   = 'until'   ;
  BEGIN   = 'begin'   ;
  END     = 'end'     ;
  AND     = 'and'     ;
  OR      = 'or'      ;
  NOT     = 'not'     ;
  XOR     = 'xor'     ;
  MOD = 'mod'     ;
  IN      = 'in'      ;
  VAR_BLOCK = 'var';
  PROCEDURE = 'procedure' ;
  FUNCTION  = 'function'  ;
  PROGRAM   = 'program'   ;
  ARRAY = 'array';
  OF = 'of'; 
  TRUE = 'true';
  FALSE = 'false';
  //VAR = 'var';
}


@lexer::namespace { MathExpr }
@parser::namespace { MathExpr }

@header {
  using System.Collections.Generic;
  using System.Globalization;
}

@members {
  // number format with decimal separator - '.'
  public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
  
  // identifier values
  private Dictionary<string, IdentDescr> identTable = new Dictionary<string, IdentDescr>();
}


WS:
  ( ' ' | '\t' | '\f' | '\r' | '\n' )+ {
    $channel=HIDDEN;
  }
;


NUMBER: ('0'..'9')+ ('.' ('0'..'9')+)?
;
bool_value: TRUE | FALSE
;
IDENT:  ( 'a'..'z' | 'A'..'Z' | '_' )
        ( 'a'..'z' | 'A'..'Z' | '_' | '0'..'9' )* 
;

ADD:     '+'    ;
SUB:     '-'    ;
MUL:     '*'    ;
DIV:     '/'    ;
BIT_AND: '&'    ;
BIT_OR:  '|'    ;
ASSIGN: ':='    ;
GE:       '>='  ;
LE:       '<='  ;
NEQUALS:  '<>'  ;
EQUALS:   '='   ;
GT:       '>'   ;
LT:       '<'   ;



ident: IDENT /*( '['! term ']'! )?*/
;


params_: ( term (','! term)* )?  ;
call: ident '(' params_ ')'  -> ^(CALL ident ^(PARAMS params_)) ;

num: NUMBER -> NUMBER<NumAstNode>[double.Parse($NUMBER.text, NFI)] ;

group:
  '('! term ')'!
| bool_value
| num
| ident
| call
;

var_block : VAR_BLOCK^ (var_declaration)*;
var_declaration: ident (','! ident)* ':'! var_type^ ';'! ;
var_type: ARRAY^ '['! term ','! term ']'! OF! ident | ident;

not:   group | NOT^ not ;
mult:  not ( ( MUL | DIV | BIT_AND | MOD )^ not )*  ;
add:   mult  ( ( ADD | SUB | BIT_OR )^ mult  )*                   ;
compare: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT )^ add )?   ;
and_logic: compare ( AND^ compare )*    ;
or_logic: and_logic ( OR^ and_logic )*  ;
term: or_logic  ;

param_decl: VAR_BLOCK^? ident ;
params_decl: param_decl (',' param_decl)* ':' ident -> ^(ident param_decl*) ;
func_declr:
  FUNCTION ident '(' (  params_decl (';' params_decl)*  )? ')' ':' var_type
  (declr_block)*
  BEGIN exprList END ';'
  -> ^(FUNCTION ident ^(PARAMS params_decl*) var_type declr_block* exprList)
;
declr_block: func_declr | var_block ;

expr:
  ident ASSIGN^ term
| ident -> ^(CALL ident PARAMS)
| call
| IF^ term THEN! expr (ELSE! expr)?
| BEGIN exprList END -> ^(BLOCK exprList)
| WHILE^ term DO! expr
| FOR^ ident ASSIGN! num TO! num DO! expr
| REPEAT^ expr UNTIL! term
;

exprList: ( expr ( ';'!+ expr )* )? ';'!*  ;

program: (declr_block)* BEGIN! exprList END! '.'!;

result: program -> ^(PROGRAM program);

execute:
  result
;
