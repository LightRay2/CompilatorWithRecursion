// $ANTLR 3.2 Sep 23, 2009 12:02:23 MathExpr.g 2015-01-08 11:45:56

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


  using System.Collections.Generic;
  using System.Globalization;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  MathExpr 
{
public partial class MathExprParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"UNKNOWN", 
		"BLOCK", 
		"PARAMS", 
		"CALL", 
		"IF", 
		"THEN", 
		"ELSE", 
		"FOR", 
		"TO", 
		"WHILE", 
		"DO", 
		"REPEAT", 
		"UNTIL", 
		"BEGIN", 
		"END", 
		"AND", 
		"OR", 
		"NOT", 
		"XOR", 
		"MOD", 
		"IN", 
		"VAR_BLOCK", 
		"PROCEDURE", 
		"FUNCTION", 
		"PROGRAM", 
		"ARRAY", 
		"OF", 
		"TRUE", 
		"FALSE", 
		"WS", 
		"NUMBER", 
		"IDENT", 
		"ADD", 
		"SUB", 
		"MUL", 
		"DIV", 
		"BIT_AND", 
		"BIT_OR", 
		"ASSIGN", 
		"GE", 
		"LE", 
		"NEQUALS", 
		"EQUALS", 
		"GT", 
		"LT", 
		"','", 
		"'('", 
		"')'", 
		"':'", 
		"';'", 
		"'['", 
		"']'", 
		"'.'"
    };

    public const int FUNCTION = 27;
    public const int LT = 48;
    public const int BIT_AND = 40;
    public const int WHILE = 13;
    public const int MOD = 23;
    public const int FOR = 11;
    public const int DO = 14;
    public const int SUB = 37;
    public const int EQUALS = 46;
    public const int NOT = 21;
    public const int AND = 19;
    public const int VAR_BLOCK = 25;
    public const int EOF = -1;
    public const int NEQUALS = 45;
    public const int IF = 8;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__51 = 51;
    public const int THEN = 9;
    public const int T__52 = 52;
    public const int IN = 24;
    public const int T__53 = 53;
    public const int BIT_OR = 41;
    public const int UNKNOWN = 4;
    public const int T__54 = 54;
    public const int BEGIN = 17;
    public const int IDENT = 35;
    public const int T__50 = 50;
    public const int ARRAY = 29;
    public const int ADD = 36;
    public const int PARAMS = 6;
    public const int GE = 43;
    public const int XOR = 22;
    public const int TO = 12;
    public const int T__49 = 49;
    public const int ELSE = 10;
    public const int NUMBER = 34;
    public const int OF = 30;
    public const int MUL = 38;
    public const int TRUE = 31;
    public const int PROCEDURE = 26;
    public const int WS = 33;
    public const int UNTIL = 16;
    public const int BLOCK = 5;
    public const int OR = 20;
    public const int ASSIGN = 42;
    public const int GT = 47;
    public const int PROGRAM = 28;
    public const int REPEAT = 15;
    public const int CALL = 7;
    public const int DIV = 39;
    public const int END = 18;
    public const int FALSE = 32;
    public const int LE = 44;

    // delegates
    // delegators



        public MathExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public MathExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[70+1];
             
             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return MathExprParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "MathExpr.g"; }
    }


      // number format with decimal separator - '.'
      public static readonly NumberFormatInfo NFI = new NumberFormatInfo();
      
      // identifier values
      private Dictionary<string, IdentDescr> identTable = new Dictionary<string, IdentDescr>();


    public class bool_value_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "bool_value"
    // MathExpr.g:72:1: bool_value : ( TRUE | FALSE );
    public MathExprParser.bool_value_return bool_value() // throws RecognitionException [1]
    {   
        MathExprParser.bool_value_return retval = new MathExprParser.bool_value_return();
        retval.Start = input.LT(1);
        int bool_value_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set1 = null;

        AstNode set1_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:72:11: ( TRUE | FALSE )
            // MathExpr.g:
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	set1 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= TRUE && input.LA(1) <= FALSE) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (AstNode)adaptor.Create(set1));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, bool_value_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "bool_value"

    public class ident_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "ident"
    // MathExpr.g:94:1: ident : IDENT ;
    public MathExprParser.ident_return ident() // throws RecognitionException [1]
    {   
        MathExprParser.ident_return retval = new MathExprParser.ident_return();
        retval.Start = input.LT(1);
        int ident_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken IDENT2 = null;

        AstNode IDENT2_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:94:6: ( IDENT )
            // MathExpr.g:94:8: IDENT
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	IDENT2=(IToken)Match(input,IDENT,FOLLOW_IDENT_in_ident837); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENT2_tree = (AstNode)adaptor.Create(IDENT2);
            		adaptor.AddChild(root_0, IDENT2_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, ident_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "ident"

    public class params__return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "params_"
    // MathExpr.g:98:1: params_ : ( term ( ',' term )* )? ;
    public MathExprParser.params__return params_() // throws RecognitionException [1]
    {   
        MathExprParser.params__return retval = new MathExprParser.params__return();
        retval.Start = input.LT(1);
        int params__StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal4 = null;
        MathExprParser.term_return term3 = default(MathExprParser.term_return);

        MathExprParser.term_return term5 = default(MathExprParser.term_return);


        AstNode char_literal4_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:98:8: ( ( term ( ',' term )* )? )
            // MathExpr.g:98:10: ( term ( ',' term )* )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:98:10: ( term ( ',' term )* )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NOT || (LA2_0 >= TRUE && LA2_0 <= FALSE) || (LA2_0 >= NUMBER && LA2_0 <= IDENT) || LA2_0 == 50) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // MathExpr.g:98:12: term ( ',' term )*
            	        {
            	        	PushFollow(FOLLOW_term_in_params_850);
            	        	term3 = term();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term3.Tree);
            	        	// MathExpr.g:98:17: ( ',' term )*
            	        	do 
            	        	{
            	        	    int alt1 = 2;
            	        	    int LA1_0 = input.LA(1);

            	        	    if ( (LA1_0 == 49) )
            	        	    {
            	        	        alt1 = 1;
            	        	    }


            	        	    switch (alt1) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:98:18: ',' term
            	        			    {
            	        			    	char_literal4=(IToken)Match(input,49,FOLLOW_49_in_params_853); if (state.failed) return retval;
            	        			    	PushFollow(FOLLOW_term_in_params_856);
            	        			    	term5 = term();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term5.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop1;
            	        	    }
            	        	} while (true);

            	        	loop1:
            	        		;	// Stops C# compiler whining that label 'loop1' has no statements


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, params__StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "params_"

    public class call_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "call"
    // MathExpr.g:99:1: call : ident '(' params_ ')' -> ^( CALL ident ^( PARAMS params_ ) ) ;
    public MathExprParser.call_return call() // throws RecognitionException [1]
    {   
        MathExprParser.call_return retval = new MathExprParser.call_return();
        retval.Start = input.LT(1);
        int call_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal7 = null;
        IToken char_literal9 = null;
        MathExprParser.ident_return ident6 = default(MathExprParser.ident_return);

        MathExprParser.params__return params_8 = default(MathExprParser.params__return);


        AstNode char_literal7_tree=null;
        AstNode char_literal9_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_params_ = new RewriteRuleSubtreeStream(adaptor,"rule params_");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:99:5: ( ident '(' params_ ')' -> ^( CALL ident ^( PARAMS params_ ) ) )
            // MathExpr.g:99:7: ident '(' params_ ')'
            {
            	PushFollow(FOLLOW_ident_in_call869);
            	ident6 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident6.Tree);
            	char_literal7=(IToken)Match(input,50,FOLLOW_50_in_call871); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal7);

            	PushFollow(FOLLOW_params__in_call873);
            	params_8 = params_();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_params_.Add(params_8.Tree);
            	char_literal9=(IToken)Match(input,51,FOLLOW_51_in_call875); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal9);



            	// AST REWRITE
            	// elements:          ident, params_
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 99:30: -> ^( CALL ident ^( PARAMS params_ ) )
            	{
            	    // MathExpr.g:99:33: ^( CALL ident ^( PARAMS params_ ) )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CALL, "CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MathExpr.g:99:46: ^( PARAMS params_ )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_2);

            	    adaptor.AddChild(root_2, stream_params_.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, call_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "call"

    public class num_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "num"
    // MathExpr.g:101:1: num : NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] ;
    public MathExprParser.num_return num() // throws RecognitionException [1]
    {   
        MathExprParser.num_return retval = new MathExprParser.num_return();
        retval.Start = input.LT(1);
        int num_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken NUMBER10 = null;

        AstNode NUMBER10_tree=null;
        RewriteRuleTokenStream stream_NUMBER = new RewriteRuleTokenStream(adaptor,"token NUMBER");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:101:4: ( NUMBER -> NUMBER[double.Parse($NUMBER.text, NFI)] )
            // MathExpr.g:101:6: NUMBER
            {
            	NUMBER10=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_num898); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_NUMBER.Add(NUMBER10);



            	// AST REWRITE
            	// elements:          NUMBER
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 101:13: -> NUMBER[double.Parse($NUMBER.text, NFI)]
            	{
            	    adaptor.AddChild(root_0, new NumAstNode(NUMBER, double.Parse(((NUMBER10 != null) ? NUMBER10.Text : null), NFI)));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, num_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "num"

    public class group_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "group"
    // MathExpr.g:103:1: group : ( '(' term ')' | bool_value | num | ident | call );
    public MathExprParser.group_return group() // throws RecognitionException [1]
    {   
        MathExprParser.group_return retval = new MathExprParser.group_return();
        retval.Start = input.LT(1);
        int group_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal11 = null;
        IToken char_literal13 = null;
        MathExprParser.term_return term12 = default(MathExprParser.term_return);

        MathExprParser.bool_value_return bool_value14 = default(MathExprParser.bool_value_return);

        MathExprParser.num_return num15 = default(MathExprParser.num_return);

        MathExprParser.ident_return ident16 = default(MathExprParser.ident_return);

        MathExprParser.call_return call17 = default(MathExprParser.call_return);


        AstNode char_literal11_tree=null;
        AstNode char_literal13_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:103:6: ( '(' term ')' | bool_value | num | ident | call )
            int alt3 = 5;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt3 = 1;
                }
                break;
            case TRUE:
            case FALSE:
            	{
                alt3 = 2;
                }
                break;
            case NUMBER:
            	{
                alt3 = 3;
                }
                break;
            case IDENT:
            	{
                int LA3_4 = input.LA(2);

                if ( (LA3_4 == EOF || (LA3_4 >= THEN && LA3_4 <= ELSE) || LA3_4 == DO || LA3_4 == UNTIL || (LA3_4 >= END && LA3_4 <= OR) || LA3_4 == MOD || (LA3_4 >= ADD && LA3_4 <= BIT_OR) || (LA3_4 >= GE && LA3_4 <= 49) || LA3_4 == 51 || LA3_4 == 53 || LA3_4 == 55) )
                {
                    alt3 = 4;
                }
                else if ( (LA3_4 == 50) )
                {
                    alt3 = 5;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d3s4 =
                        new NoViableAltException("", 3, 4, input);

                    throw nvae_d3s4;
                }
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // MathExpr.g:104:3: '(' term ')'
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	char_literal11=(IToken)Match(input,50,FOLLOW_50_in_group916); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_group919);
                    	term12 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term12.Tree);
                    	char_literal13=(IToken)Match(input,51,FOLLOW_51_in_group921); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // MathExpr.g:105:3: bool_value
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bool_value_in_group926);
                    	bool_value14 = bool_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bool_value14.Tree);

                    }
                    break;
                case 3 :
                    // MathExpr.g:106:3: num
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_num_in_group930);
                    	num15 = num();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, num15.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:107:3: ident
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_group934);
                    	ident16 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident16.Tree);

                    }
                    break;
                case 5 :
                    // MathExpr.g:108:3: call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_call_in_group938);
                    	call17 = call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call17.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, group_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "group"

    public class var_block_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "var_block"
    // MathExpr.g:111:1: var_block : VAR_BLOCK ( var_declaration )* ;
    public MathExprParser.var_block_return var_block() // throws RecognitionException [1]
    {   
        MathExprParser.var_block_return retval = new MathExprParser.var_block_return();
        retval.Start = input.LT(1);
        int var_block_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken VAR_BLOCK18 = null;
        MathExprParser.var_declaration_return var_declaration19 = default(MathExprParser.var_declaration_return);


        AstNode VAR_BLOCK18_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:111:11: ( VAR_BLOCK ( var_declaration )* )
            // MathExpr.g:111:13: VAR_BLOCK ( var_declaration )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	VAR_BLOCK18=(IToken)Match(input,VAR_BLOCK,FOLLOW_VAR_BLOCK_in_var_block947); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{VAR_BLOCK18_tree = (AstNode)adaptor.Create(VAR_BLOCK18);
            		root_0 = (AstNode)adaptor.BecomeRoot(VAR_BLOCK18_tree, root_0);
            	}
            	// MathExpr.g:111:24: ( var_declaration )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == IDENT) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // MathExpr.g:111:25: var_declaration
            			    {
            			    	PushFollow(FOLLOW_var_declaration_in_var_block951);
            			    	var_declaration19 = var_declaration();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var_declaration19.Tree);

            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, var_block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "var_block"

    public class var_declaration_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "var_declaration"
    // MathExpr.g:112:1: var_declaration : ident ( ',' ident )* ':' var_type ';' ;
    public MathExprParser.var_declaration_return var_declaration() // throws RecognitionException [1]
    {   
        MathExprParser.var_declaration_return retval = new MathExprParser.var_declaration_return();
        retval.Start = input.LT(1);
        int var_declaration_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal21 = null;
        IToken char_literal23 = null;
        IToken char_literal25 = null;
        MathExprParser.ident_return ident20 = default(MathExprParser.ident_return);

        MathExprParser.ident_return ident22 = default(MathExprParser.ident_return);

        MathExprParser.var_type_return var_type24 = default(MathExprParser.var_type_return);


        AstNode char_literal21_tree=null;
        AstNode char_literal23_tree=null;
        AstNode char_literal25_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:112:16: ( ident ( ',' ident )* ':' var_type ';' )
            // MathExpr.g:112:18: ident ( ',' ident )* ':' var_type ';'
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_ident_in_var_declaration959);
            	ident20 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident20.Tree);
            	// MathExpr.g:112:24: ( ',' ident )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == 49) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MathExpr.g:112:25: ',' ident
            			    {
            			    	char_literal21=(IToken)Match(input,49,FOLLOW_49_in_var_declaration962); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_ident_in_var_declaration965);
            			    	ident22 = ident();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident22.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements

            	char_literal23=(IToken)Match(input,52,FOLLOW_52_in_var_declaration969); if (state.failed) return retval;
            	PushFollow(FOLLOW_var_type_in_var_declaration972);
            	var_type24 = var_type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot(var_type24.Tree, root_0);
            	char_literal25=(IToken)Match(input,53,FOLLOW_53_in_var_declaration975); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, var_declaration_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "var_declaration"

    public class var_type_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "var_type"
    // MathExpr.g:113:1: var_type : ( ARRAY '[' term ',' term ']' OF ident | ident );
    public MathExprParser.var_type_return var_type() // throws RecognitionException [1]
    {   
        MathExprParser.var_type_return retval = new MathExprParser.var_type_return();
        retval.Start = input.LT(1);
        int var_type_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken ARRAY26 = null;
        IToken char_literal27 = null;
        IToken char_literal29 = null;
        IToken char_literal31 = null;
        IToken OF32 = null;
        MathExprParser.term_return term28 = default(MathExprParser.term_return);

        MathExprParser.term_return term30 = default(MathExprParser.term_return);

        MathExprParser.ident_return ident33 = default(MathExprParser.ident_return);

        MathExprParser.ident_return ident34 = default(MathExprParser.ident_return);


        AstNode ARRAY26_tree=null;
        AstNode char_literal27_tree=null;
        AstNode char_literal29_tree=null;
        AstNode char_literal31_tree=null;
        AstNode OF32_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:113:9: ( ARRAY '[' term ',' term ']' OF ident | ident )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == ARRAY) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == IDENT) )
            {
                alt6 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // MathExpr.g:113:11: ARRAY '[' term ',' term ']' OF ident
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	ARRAY26=(IToken)Match(input,ARRAY,FOLLOW_ARRAY_in_var_type983); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ARRAY26_tree = (AstNode)adaptor.Create(ARRAY26);
                    		root_0 = (AstNode)adaptor.BecomeRoot(ARRAY26_tree, root_0);
                    	}
                    	char_literal27=(IToken)Match(input,54,FOLLOW_54_in_var_type986); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_var_type989);
                    	term28 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term28.Tree);
                    	char_literal29=(IToken)Match(input,49,FOLLOW_49_in_var_type991); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_var_type994);
                    	term30 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term30.Tree);
                    	char_literal31=(IToken)Match(input,55,FOLLOW_55_in_var_type996); if (state.failed) return retval;
                    	OF32=(IToken)Match(input,OF,FOLLOW_OF_in_var_type999); if (state.failed) return retval;
                    	PushFollow(FOLLOW_ident_in_var_type1002);
                    	ident33 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident33.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:113:55: ident
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_var_type1006);
                    	ident34 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident34.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, var_type_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "var_type"

    public class not_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "not"
    // MathExpr.g:115:1: not : ( group | NOT not );
    public MathExprParser.not_return not() // throws RecognitionException [1]
    {   
        MathExprParser.not_return retval = new MathExprParser.not_return();
        retval.Start = input.LT(1);
        int not_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken NOT36 = null;
        MathExprParser.group_return group35 = default(MathExprParser.group_return);

        MathExprParser.not_return not37 = default(MathExprParser.not_return);


        AstNode NOT36_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:115:4: ( group | NOT not )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= TRUE && LA7_0 <= FALSE) || (LA7_0 >= NUMBER && LA7_0 <= IDENT) || LA7_0 == 50) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == NOT) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // MathExpr.g:115:8: group
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_group_in_not1015);
                    	group35 = group();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:115:16: NOT not
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	NOT36=(IToken)Match(input,NOT,FOLLOW_NOT_in_not1019); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NOT36_tree = (AstNode)adaptor.Create(NOT36);
                    		root_0 = (AstNode)adaptor.BecomeRoot(NOT36_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_not_in_not1022);
                    	not37 = not();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not37.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, not_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "not"

    public class mult_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "mult"
    // MathExpr.g:116:1: mult : not ( ( MUL | DIV | BIT_AND | MOD ) not )* ;
    public MathExprParser.mult_return mult() // throws RecognitionException [1]
    {   
        MathExprParser.mult_return retval = new MathExprParser.mult_return();
        retval.Start = input.LT(1);
        int mult_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set39 = null;
        MathExprParser.not_return not38 = default(MathExprParser.not_return);

        MathExprParser.not_return not40 = default(MathExprParser.not_return);


        AstNode set39_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:116:5: ( not ( ( MUL | DIV | BIT_AND | MOD ) not )* )
            // MathExpr.g:116:8: not ( ( MUL | DIV | BIT_AND | MOD ) not )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_not_in_mult1030);
            	not38 = not();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not38.Tree);
            	// MathExpr.g:116:12: ( ( MUL | DIV | BIT_AND | MOD ) not )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == MOD || (LA8_0 >= MUL && LA8_0 <= BIT_AND)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // MathExpr.g:116:14: ( MUL | DIV | BIT_AND | MOD ) not
            			    {
            			    	set39=(IToken)input.LT(1);
            			    	set39 = (IToken)input.LT(1);
            			    	if ( input.LA(1) == MOD || (input.LA(1) >= MUL && input.LA(1) <= BIT_AND) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set39), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_not_in_mult1053);
            			    	not40 = not();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, not40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, mult_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "mult"

    public class add_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "add"
    // MathExpr.g:117:1: add : mult ( ( ADD | SUB | BIT_OR ) mult )* ;
    public MathExprParser.add_return add() // throws RecognitionException [1]
    {   
        MathExprParser.add_return retval = new MathExprParser.add_return();
        retval.Start = input.LT(1);
        int add_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set42 = null;
        MathExprParser.mult_return mult41 = default(MathExprParser.mult_return);

        MathExprParser.mult_return mult43 = default(MathExprParser.mult_return);


        AstNode set42_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:117:4: ( mult ( ( ADD | SUB | BIT_OR ) mult )* )
            // MathExpr.g:117:8: mult ( ( ADD | SUB | BIT_OR ) mult )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mult_in_add1066);
            	mult41 = mult();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult41.Tree);
            	// MathExpr.g:117:14: ( ( ADD | SUB | BIT_OR ) mult )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= ADD && LA9_0 <= SUB) || LA9_0 == BIT_OR) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // MathExpr.g:117:16: ( ADD | SUB | BIT_OR ) mult
            			    {
            			    	set42=(IToken)input.LT(1);
            			    	set42 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= ADD && input.LA(1) <= SUB) || input.LA(1) == BIT_OR ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set42), root_0);
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mult_in_add1086);
            			    	mult43 = mult();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult43.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, add_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "add"

    public class compare_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "compare"
    // MathExpr.g:118:1: compare : add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? ;
    public MathExprParser.compare_return compare() // throws RecognitionException [1]
    {   
        MathExprParser.compare_return retval = new MathExprParser.compare_return();
        retval.Start = input.LT(1);
        int compare_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken set45 = null;
        MathExprParser.add_return add44 = default(MathExprParser.add_return);

        MathExprParser.add_return add46 = default(MathExprParser.add_return);


        AstNode set45_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:118:8: ( add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? )
            // MathExpr.g:118:10: add ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_add_in_compare1115);
            	add44 = add();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add44.Tree);
            	// MathExpr.g:118:14: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( ((LA10_0 >= GE && LA10_0 <= LT)) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // MathExpr.g:118:16: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
            	        {
            	        	set45=(IToken)input.LT(1);
            	        	set45 = (IToken)input.LT(1);
            	        	if ( (input.LA(1) >= GE && input.LA(1) <= LT) ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) root_0 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(set45), root_0);
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_add_in_compare1146);
            	        	add46 = add();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add46.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, compare_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "compare"

    public class and_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "and_logic"
    // MathExpr.g:119:1: and_logic : compare ( AND compare )* ;
    public MathExprParser.and_logic_return and_logic() // throws RecognitionException [1]
    {   
        MathExprParser.and_logic_return retval = new MathExprParser.and_logic_return();
        retval.Start = input.LT(1);
        int and_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken AND48 = null;
        MathExprParser.compare_return compare47 = default(MathExprParser.compare_return);

        MathExprParser.compare_return compare49 = default(MathExprParser.compare_return);


        AstNode AND48_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:119:10: ( compare ( AND compare )* )
            // MathExpr.g:119:12: compare ( AND compare )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_compare_in_and_logic1158);
            	compare47 = compare();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare47.Tree);
            	// MathExpr.g:119:20: ( AND compare )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == AND) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // MathExpr.g:119:22: AND compare
            			    {
            			    	AND48=(IToken)Match(input,AND,FOLLOW_AND_in_and_logic1162); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{AND48_tree = (AstNode)adaptor.Create(AND48);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(AND48_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_compare_in_and_logic1165);
            			    	compare49 = compare();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare49.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, and_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "and_logic"

    public class or_logic_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "or_logic"
    // MathExpr.g:120:1: or_logic : and_logic ( OR and_logic )* ;
    public MathExprParser.or_logic_return or_logic() // throws RecognitionException [1]
    {   
        MathExprParser.or_logic_return retval = new MathExprParser.or_logic_return();
        retval.Start = input.LT(1);
        int or_logic_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken OR51 = null;
        MathExprParser.and_logic_return and_logic50 = default(MathExprParser.and_logic_return);

        MathExprParser.and_logic_return and_logic52 = default(MathExprParser.and_logic_return);


        AstNode OR51_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:120:9: ( and_logic ( OR and_logic )* )
            // MathExpr.g:120:11: and_logic ( OR and_logic )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_and_logic_in_or_logic1178);
            	and_logic50 = and_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic50.Tree);
            	// MathExpr.g:120:21: ( OR and_logic )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == OR) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // MathExpr.g:120:23: OR and_logic
            			    {
            			    	OR51=(IToken)Match(input,OR,FOLLOW_OR_in_or_logic1182); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{OR51_tree = (AstNode)adaptor.Create(OR51);
            			    		root_0 = (AstNode)adaptor.BecomeRoot(OR51_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_and_logic_in_or_logic1185);
            			    	and_logic52 = and_logic();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, and_logic52.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, or_logic_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "or_logic"

    public class term_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "term"
    // MathExpr.g:121:1: term : or_logic ;
    public MathExprParser.term_return term() // throws RecognitionException [1]
    {   
        MathExprParser.term_return retval = new MathExprParser.term_return();
        retval.Start = input.LT(1);
        int term_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.or_logic_return or_logic53 = default(MathExprParser.or_logic_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:121:5: ( or_logic )
            // MathExpr.g:121:7: or_logic
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_or_logic_in_term1196);
            	or_logic53 = or_logic();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, or_logic53.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, term_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "term"

    public class param_decl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "param_decl"
    // MathExpr.g:123:1: param_decl : ( VAR_BLOCK )? ident ;
    public MathExprParser.param_decl_return param_decl() // throws RecognitionException [1]
    {   
        MathExprParser.param_decl_return retval = new MathExprParser.param_decl_return();
        retval.Start = input.LT(1);
        int param_decl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken VAR_BLOCK54 = null;
        MathExprParser.ident_return ident55 = default(MathExprParser.ident_return);


        AstNode VAR_BLOCK54_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:123:11: ( ( VAR_BLOCK )? ident )
            // MathExpr.g:123:13: ( VAR_BLOCK )? ident
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:123:22: ( VAR_BLOCK )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == VAR_BLOCK) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // MathExpr.g:0:0: VAR_BLOCK
            	        {
            	        	VAR_BLOCK54=(IToken)Match(input,VAR_BLOCK,FOLLOW_VAR_BLOCK_in_param_decl1205); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{VAR_BLOCK54_tree = (AstNode)adaptor.Create(VAR_BLOCK54);
            	        		root_0 = (AstNode)adaptor.BecomeRoot(VAR_BLOCK54_tree, root_0);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_ident_in_param_decl1209);
            	ident55 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident55.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, param_decl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "param_decl"

    public class params_decl_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "params_decl"
    // MathExpr.g:124:1: params_decl : param_decl ( ',' param_decl )* ':' ident -> ^( ident ( param_decl )* ) ;
    public MathExprParser.params_decl_return params_decl() // throws RecognitionException [1]
    {   
        MathExprParser.params_decl_return retval = new MathExprParser.params_decl_return();
        retval.Start = input.LT(1);
        int params_decl_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal57 = null;
        IToken char_literal59 = null;
        MathExprParser.param_decl_return param_decl56 = default(MathExprParser.param_decl_return);

        MathExprParser.param_decl_return param_decl58 = default(MathExprParser.param_decl_return);

        MathExprParser.ident_return ident60 = default(MathExprParser.ident_return);


        AstNode char_literal57_tree=null;
        AstNode char_literal59_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_param_decl = new RewriteRuleSubtreeStream(adaptor,"rule param_decl");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:124:12: ( param_decl ( ',' param_decl )* ':' ident -> ^( ident ( param_decl )* ) )
            // MathExpr.g:124:14: param_decl ( ',' param_decl )* ':' ident
            {
            	PushFollow(FOLLOW_param_decl_in_params_decl1216);
            	param_decl56 = param_decl();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_param_decl.Add(param_decl56.Tree);
            	// MathExpr.g:124:25: ( ',' param_decl )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 49) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // MathExpr.g:124:26: ',' param_decl
            			    {
            			    	char_literal57=(IToken)Match(input,49,FOLLOW_49_in_params_decl1219); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_49.Add(char_literal57);

            			    	PushFollow(FOLLOW_param_decl_in_params_decl1221);
            			    	param_decl58 = param_decl();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_param_decl.Add(param_decl58.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	char_literal59=(IToken)Match(input,52,FOLLOW_52_in_params_decl1225); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal59);

            	PushFollow(FOLLOW_ident_in_params_decl1227);
            	ident60 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident60.Tree);


            	// AST REWRITE
            	// elements:          param_decl, ident
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 124:53: -> ^( ident ( param_decl )* )
            	{
            	    // MathExpr.g:124:56: ^( ident ( param_decl )* )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot(stream_ident.NextNode(), root_1);

            	    // MathExpr.g:124:64: ( param_decl )*
            	    while ( stream_param_decl.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_param_decl.NextTree());

            	    }
            	    stream_param_decl.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, params_decl_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "params_decl"

    public class func_declr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "func_declr"
    // MathExpr.g:125:1: func_declr : FUNCTION ident '(' ( params_decl ( ';' params_decl )* )? ')' ':' var_type ( declr_block )* BEGIN exprList END ';' -> ^( FUNCTION ident ^( PARAMS ( params_decl )* ) var_type ( declr_block )* exprList ) ;
    public MathExprParser.func_declr_return func_declr() // throws RecognitionException [1]
    {   
        MathExprParser.func_declr_return retval = new MathExprParser.func_declr_return();
        retval.Start = input.LT(1);
        int func_declr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken FUNCTION61 = null;
        IToken char_literal63 = null;
        IToken char_literal65 = null;
        IToken char_literal67 = null;
        IToken char_literal68 = null;
        IToken BEGIN71 = null;
        IToken END73 = null;
        IToken char_literal74 = null;
        MathExprParser.ident_return ident62 = default(MathExprParser.ident_return);

        MathExprParser.params_decl_return params_decl64 = default(MathExprParser.params_decl_return);

        MathExprParser.params_decl_return params_decl66 = default(MathExprParser.params_decl_return);

        MathExprParser.var_type_return var_type69 = default(MathExprParser.var_type_return);

        MathExprParser.declr_block_return declr_block70 = default(MathExprParser.declr_block_return);

        MathExprParser.exprList_return exprList72 = default(MathExprParser.exprList_return);


        AstNode FUNCTION61_tree=null;
        AstNode char_literal63_tree=null;
        AstNode char_literal65_tree=null;
        AstNode char_literal67_tree=null;
        AstNode char_literal68_tree=null;
        AstNode BEGIN71_tree=null;
        AstNode END73_tree=null;
        AstNode char_literal74_tree=null;
        RewriteRuleTokenStream stream_FUNCTION = new RewriteRuleTokenStream(adaptor,"token FUNCTION");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_params_decl = new RewriteRuleSubtreeStream(adaptor,"rule params_decl");
        RewriteRuleSubtreeStream stream_var_type = new RewriteRuleSubtreeStream(adaptor,"rule var_type");
        RewriteRuleSubtreeStream stream_declr_block = new RewriteRuleSubtreeStream(adaptor,"rule declr_block");
        RewriteRuleSubtreeStream stream_exprList = new RewriteRuleSubtreeStream(adaptor,"rule exprList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:125:11: ( FUNCTION ident '(' ( params_decl ( ';' params_decl )* )? ')' ':' var_type ( declr_block )* BEGIN exprList END ';' -> ^( FUNCTION ident ^( PARAMS ( params_decl )* ) var_type ( declr_block )* exprList ) )
            // MathExpr.g:126:3: FUNCTION ident '(' ( params_decl ( ';' params_decl )* )? ')' ':' var_type ( declr_block )* BEGIN exprList END ';'
            {
            	FUNCTION61=(IToken)Match(input,FUNCTION,FOLLOW_FUNCTION_in_func_declr1245); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_FUNCTION.Add(FUNCTION61);

            	PushFollow(FOLLOW_ident_in_func_declr1247);
            	ident62 = ident();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ident.Add(ident62.Tree);
            	char_literal63=(IToken)Match(input,50,FOLLOW_50_in_func_declr1249); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_50.Add(char_literal63);

            	// MathExpr.g:126:22: ( params_decl ( ';' params_decl )* )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == VAR_BLOCK || LA16_0 == IDENT) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // MathExpr.g:126:25: params_decl ( ';' params_decl )*
            	        {
            	        	PushFollow(FOLLOW_params_decl_in_func_declr1254);
            	        	params_decl64 = params_decl();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_params_decl.Add(params_decl64.Tree);
            	        	// MathExpr.g:126:37: ( ';' params_decl )*
            	        	do 
            	        	{
            	        	    int alt15 = 2;
            	        	    int LA15_0 = input.LA(1);

            	        	    if ( (LA15_0 == 53) )
            	        	    {
            	        	        alt15 = 1;
            	        	    }


            	        	    switch (alt15) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:126:38: ';' params_decl
            	        			    {
            	        			    	char_literal65=(IToken)Match(input,53,FOLLOW_53_in_func_declr1257); if (state.failed) return retval; 
            	        			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal65);

            	        			    	PushFollow(FOLLOW_params_decl_in_func_declr1259);
            	        			    	params_decl66 = params_decl();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( (state.backtracking==0) ) stream_params_decl.Add(params_decl66.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop15;
            	        	    }
            	        	} while (true);

            	        	loop15:
            	        		;	// Stops C# compiler whining that label 'loop15' has no statements


            	        }
            	        break;

            	}

            	char_literal67=(IToken)Match(input,51,FOLLOW_51_in_func_declr1267); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal67);

            	char_literal68=(IToken)Match(input,52,FOLLOW_52_in_func_declr1269); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal68);

            	PushFollow(FOLLOW_var_type_in_func_declr1271);
            	var_type69 = var_type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_var_type.Add(var_type69.Tree);
            	// MathExpr.g:127:3: ( declr_block )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == VAR_BLOCK || LA17_0 == FUNCTION) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // MathExpr.g:127:4: declr_block
            			    {
            			    	PushFollow(FOLLOW_declr_block_in_func_declr1276);
            			    	declr_block70 = declr_block();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_declr_block.Add(declr_block70.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	BEGIN71=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_func_declr1282); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN71);

            	PushFollow(FOLLOW_exprList_in_func_declr1284);
            	exprList72 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_exprList.Add(exprList72.Tree);
            	END73=(IToken)Match(input,END,FOLLOW_END_in_func_declr1286); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_END.Add(END73);

            	char_literal74=(IToken)Match(input,53,FOLLOW_53_in_func_declr1288); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_53.Add(char_literal74);



            	// AST REWRITE
            	// elements:          exprList, ident, var_type, params_decl, declr_block, FUNCTION
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 129:3: -> ^( FUNCTION ident ^( PARAMS ( params_decl )* ) var_type ( declr_block )* exprList )
            	{
            	    // MathExpr.g:129:6: ^( FUNCTION ident ^( PARAMS ( params_decl )* ) var_type ( declr_block )* exprList )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot(stream_FUNCTION.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_ident.NextTree());
            	    // MathExpr.g:129:23: ^( PARAMS ( params_decl )* )
            	    {
            	    AstNode root_2 = (AstNode)adaptor.GetNilNode();
            	    root_2 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PARAMS, "PARAMS"), root_2);

            	    // MathExpr.g:129:32: ( params_decl )*
            	    while ( stream_params_decl.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_params_decl.NextTree());

            	    }
            	    stream_params_decl.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    adaptor.AddChild(root_1, stream_var_type.NextTree());
            	    // MathExpr.g:129:55: ( declr_block )*
            	    while ( stream_declr_block.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_declr_block.NextTree());

            	    }
            	    stream_declr_block.Reset();
            	    adaptor.AddChild(root_1, stream_exprList.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, func_declr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "func_declr"

    public class declr_block_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "declr_block"
    // MathExpr.g:131:1: declr_block : ( func_declr | var_block );
    public MathExprParser.declr_block_return declr_block() // throws RecognitionException [1]
    {   
        MathExprParser.declr_block_return retval = new MathExprParser.declr_block_return();
        retval.Start = input.LT(1);
        int declr_block_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.func_declr_return func_declr75 = default(MathExprParser.func_declr_return);

        MathExprParser.var_block_return var_block76 = default(MathExprParser.var_block_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:131:12: ( func_declr | var_block )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == FUNCTION) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == VAR_BLOCK) )
            {
                alt18 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // MathExpr.g:131:14: func_declr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_func_declr_in_declr_block1319);
                    	func_declr75 = func_declr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, func_declr75.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:131:27: var_block
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_var_block_in_declr_block1323);
                    	var_block76 = var_block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, var_block76.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, declr_block_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "declr_block"

    public class expr_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "expr"
    // MathExpr.g:133:1: expr : ( ident ASSIGN term | ident -> ^( CALL ident PARAMS ) | call | IF term THEN expr ( ELSE expr )? | BEGIN exprList END -> ^( BLOCK exprList ) | WHILE term DO expr | FOR ident ASSIGN num TO num DO expr | REPEAT expr UNTIL term );
    public MathExprParser.expr_return expr() // throws RecognitionException [1]
    {   
        MathExprParser.expr_return retval = new MathExprParser.expr_return();
        retval.Start = input.LT(1);
        int expr_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken ASSIGN78 = null;
        IToken IF82 = null;
        IToken THEN84 = null;
        IToken ELSE86 = null;
        IToken BEGIN88 = null;
        IToken END90 = null;
        IToken WHILE91 = null;
        IToken DO93 = null;
        IToken FOR95 = null;
        IToken ASSIGN97 = null;
        IToken TO99 = null;
        IToken DO101 = null;
        IToken REPEAT103 = null;
        IToken UNTIL105 = null;
        MathExprParser.ident_return ident77 = default(MathExprParser.ident_return);

        MathExprParser.term_return term79 = default(MathExprParser.term_return);

        MathExprParser.ident_return ident80 = default(MathExprParser.ident_return);

        MathExprParser.call_return call81 = default(MathExprParser.call_return);

        MathExprParser.term_return term83 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr85 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr87 = default(MathExprParser.expr_return);

        MathExprParser.exprList_return exprList89 = default(MathExprParser.exprList_return);

        MathExprParser.term_return term92 = default(MathExprParser.term_return);

        MathExprParser.expr_return expr94 = default(MathExprParser.expr_return);

        MathExprParser.ident_return ident96 = default(MathExprParser.ident_return);

        MathExprParser.num_return num98 = default(MathExprParser.num_return);

        MathExprParser.num_return num100 = default(MathExprParser.num_return);

        MathExprParser.expr_return expr102 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr104 = default(MathExprParser.expr_return);

        MathExprParser.term_return term106 = default(MathExprParser.term_return);


        AstNode ASSIGN78_tree=null;
        AstNode IF82_tree=null;
        AstNode THEN84_tree=null;
        AstNode ELSE86_tree=null;
        AstNode BEGIN88_tree=null;
        AstNode END90_tree=null;
        AstNode WHILE91_tree=null;
        AstNode DO93_tree=null;
        AstNode FOR95_tree=null;
        AstNode ASSIGN97_tree=null;
        AstNode TO99_tree=null;
        AstNode DO101_tree=null;
        AstNode REPEAT103_tree=null;
        AstNode UNTIL105_tree=null;
        RewriteRuleTokenStream stream_END = new RewriteRuleTokenStream(adaptor,"token END");
        RewriteRuleTokenStream stream_BEGIN = new RewriteRuleTokenStream(adaptor,"token BEGIN");
        RewriteRuleSubtreeStream stream_ident = new RewriteRuleSubtreeStream(adaptor,"rule ident");
        RewriteRuleSubtreeStream stream_exprList = new RewriteRuleSubtreeStream(adaptor,"rule exprList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:133:5: ( ident ASSIGN term | ident -> ^( CALL ident PARAMS ) | call | IF term THEN expr ( ELSE expr )? | BEGIN exprList END -> ^( BLOCK exprList ) | WHILE term DO expr | FOR ident ASSIGN num TO num DO expr | REPEAT expr UNTIL term )
            int alt20 = 8;
            alt20 = dfa20.Predict(input);
            switch (alt20) 
            {
                case 1 :
                    // MathExpr.g:134:3: ident ASSIGN term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ident_in_expr1333);
                    	ident77 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident77.Tree);
                    	ASSIGN78=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1335); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN78_tree = (AstNode)adaptor.Create(ASSIGN78);
                    		root_0 = (AstNode)adaptor.BecomeRoot(ASSIGN78_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1338);
                    	term79 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term79.Tree);

                    }
                    break;
                case 2 :
                    // MathExpr.g:135:3: ident
                    {
                    	PushFollow(FOLLOW_ident_in_expr1342);
                    	ident80 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_ident.Add(ident80.Tree);


                    	// AST REWRITE
                    	// elements:          ident
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 135:9: -> ^( CALL ident PARAMS )
                    	{
                    	    // MathExpr.g:135:12: ^( CALL ident PARAMS )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(CALL, "CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_ident.NextTree());
                    	    adaptor.AddChild(root_1, (AstNode)adaptor.Create(PARAMS, "PARAMS"));

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // MathExpr.g:136:3: call
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_call_in_expr1356);
                    	call81 = call();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, call81.Tree);

                    }
                    break;
                case 4 :
                    // MathExpr.g:137:3: IF term THEN expr ( ELSE expr )?
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	IF82=(IToken)Match(input,IF,FOLLOW_IF_in_expr1360); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IF82_tree = (AstNode)adaptor.Create(IF82);
                    		root_0 = (AstNode)adaptor.BecomeRoot(IF82_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1363);
                    	term83 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term83.Tree);
                    	THEN84=(IToken)Match(input,THEN,FOLLOW_THEN_in_expr1365); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1368);
                    	expr85 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr85.Tree);
                    	// MathExpr.g:137:23: ( ELSE expr )?
                    	int alt19 = 2;
                    	int LA19_0 = input.LA(1);

                    	if ( (LA19_0 == ELSE) )
                    	{
                    	    int LA19_1 = input.LA(2);

                    	    if ( (synpred36_MathExpr()) )
                    	    {
                    	        alt19 = 1;
                    	    }
                    	}
                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // MathExpr.g:137:24: ELSE expr
                    	        {
                    	        	ELSE86=(IToken)Match(input,ELSE,FOLLOW_ELSE_in_expr1371); if (state.failed) return retval;
                    	        	PushFollow(FOLLOW_expr_in_expr1374);
                    	        	expr87 = expr();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr87.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 5 :
                    // MathExpr.g:138:3: BEGIN exprList END
                    {
                    	BEGIN88=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_expr1380); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_BEGIN.Add(BEGIN88);

                    	PushFollow(FOLLOW_exprList_in_expr1382);
                    	exprList89 = exprList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_exprList.Add(exprList89.Tree);
                    	END90=(IToken)Match(input,END,FOLLOW_END_in_expr1384); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_END.Add(END90);



                    	// AST REWRITE
                    	// elements:          exprList
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (AstNode)adaptor.GetNilNode();
                    	// 138:22: -> ^( BLOCK exprList )
                    	{
                    	    // MathExpr.g:138:25: ^( BLOCK exprList )
                    	    {
                    	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
                    	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(BLOCK, "BLOCK"), root_1);

                    	    adaptor.AddChild(root_1, stream_exprList.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 6 :
                    // MathExpr.g:139:3: WHILE term DO expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	WHILE91=(IToken)Match(input,WHILE,FOLLOW_WHILE_in_expr1396); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WHILE91_tree = (AstNode)adaptor.Create(WHILE91);
                    		root_0 = (AstNode)adaptor.BecomeRoot(WHILE91_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_term_in_expr1399);
                    	term92 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term92.Tree);
                    	DO93=(IToken)Match(input,DO,FOLLOW_DO_in_expr1401); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1404);
                    	expr94 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr94.Tree);

                    }
                    break;
                case 7 :
                    // MathExpr.g:140:3: FOR ident ASSIGN num TO num DO expr
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	FOR95=(IToken)Match(input,FOR,FOLLOW_FOR_in_expr1408); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FOR95_tree = (AstNode)adaptor.Create(FOR95);
                    		root_0 = (AstNode)adaptor.BecomeRoot(FOR95_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_ident_in_expr1411);
                    	ident96 = ident();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ident96.Tree);
                    	ASSIGN97=(IToken)Match(input,ASSIGN,FOLLOW_ASSIGN_in_expr1413); if (state.failed) return retval;
                    	PushFollow(FOLLOW_num_in_expr1416);
                    	num98 = num();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, num98.Tree);
                    	TO99=(IToken)Match(input,TO,FOLLOW_TO_in_expr1418); if (state.failed) return retval;
                    	PushFollow(FOLLOW_num_in_expr1421);
                    	num100 = num();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, num100.Tree);
                    	DO101=(IToken)Match(input,DO,FOLLOW_DO_in_expr1423); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expr_in_expr1426);
                    	expr102 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr102.Tree);

                    }
                    break;
                case 8 :
                    // MathExpr.g:141:3: REPEAT expr UNTIL term
                    {
                    	root_0 = (AstNode)adaptor.GetNilNode();

                    	REPEAT103=(IToken)Match(input,REPEAT,FOLLOW_REPEAT_in_expr1430); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{REPEAT103_tree = (AstNode)adaptor.Create(REPEAT103);
                    		root_0 = (AstNode)adaptor.BecomeRoot(REPEAT103_tree, root_0);
                    	}
                    	PushFollow(FOLLOW_expr_in_expr1433);
                    	expr104 = expr();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr104.Tree);
                    	UNTIL105=(IToken)Match(input,UNTIL,FOLLOW_UNTIL_in_expr1435); if (state.failed) return retval;
                    	PushFollow(FOLLOW_term_in_expr1438);
                    	term106 = term();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term106.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, expr_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expr"

    public class exprList_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "exprList"
    // MathExpr.g:144:1: exprList : ( expr ( ( ';' )+ expr )* )? ( ';' )* ;
    public MathExprParser.exprList_return exprList() // throws RecognitionException [1]
    {   
        MathExprParser.exprList_return retval = new MathExprParser.exprList_return();
        retval.Start = input.LT(1);
        int exprList_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken char_literal108 = null;
        IToken char_literal110 = null;
        MathExprParser.expr_return expr107 = default(MathExprParser.expr_return);

        MathExprParser.expr_return expr109 = default(MathExprParser.expr_return);


        AstNode char_literal108_tree=null;
        AstNode char_literal110_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:144:9: ( ( expr ( ( ';' )+ expr )* )? ( ';' )* )
            // MathExpr.g:144:11: ( expr ( ( ';' )+ expr )* )? ( ';' )*
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:144:11: ( expr ( ( ';' )+ expr )* )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == IF || LA23_0 == FOR || LA23_0 == WHILE || LA23_0 == REPEAT || LA23_0 == BEGIN || LA23_0 == IDENT) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // MathExpr.g:144:13: expr ( ( ';' )+ expr )*
            	        {
            	        	PushFollow(FOLLOW_expr_in_exprList1448);
            	        	expr107 = expr();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr107.Tree);
            	        	// MathExpr.g:144:18: ( ( ';' )+ expr )*
            	        	do 
            	        	{
            	        	    int alt22 = 2;
            	        	    alt22 = dfa22.Predict(input);
            	        	    switch (alt22) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:144:20: ( ';' )+ expr
            	        			    {
            	        			    	// MathExpr.g:144:23: ( ';' )+
            	        			    	int cnt21 = 0;
            	        			    	do 
            	        			    	{
            	        			    	    int alt21 = 2;
            	        			    	    int LA21_0 = input.LA(1);

            	        			    	    if ( (LA21_0 == 53) )
            	        			    	    {
            	        			    	        alt21 = 1;
            	        			    	    }


            	        			    	    switch (alt21) 
            	        			    		{
            	        			    			case 1 :
            	        			    			    // MathExpr.g:0:0: ';'
            	        			    			    {
            	        			    			    	char_literal108=(IToken)Match(input,53,FOLLOW_53_in_exprList1452); if (state.failed) return retval;

            	        			    			    }
            	        			    			    break;

            	        			    			default:
            	        			    			    if ( cnt21 >= 1 ) goto loop21;
            	        			    			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        			    		            EarlyExitException eee21 =
            	        			    		                new EarlyExitException(21, input);
            	        			    		            throw eee21;
            	        			    	    }
            	        			    	    cnt21++;
            	        			    	} while (true);

            	        			    	loop21:
            	        			    		;	// Stops C# compiler whining that label 'loop21' has no statements

            	        			    	PushFollow(FOLLOW_expr_in_exprList1456);
            	        			    	expr109 = expr();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr109.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop22;
            	        	    }
            	        	} while (true);

            	        	loop22:
            	        		;	// Stops C# compiler whining that label 'loop22' has no statements


            	        }
            	        break;

            	}

            	// MathExpr.g:144:40: ( ';' )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 53) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // MathExpr.g:0:0: ';'
            			    {
            			    	char_literal110=(IToken)Match(input,53,FOLLOW_53_in_exprList1464); if (state.failed) return retval;

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, exprList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "exprList"

    public class program_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "program"
    // MathExpr.g:146:1: program : ( declr_block )* BEGIN exprList END '.' ;
    public MathExprParser.program_return program() // throws RecognitionException [1]
    {   
        MathExprParser.program_return retval = new MathExprParser.program_return();
        retval.Start = input.LT(1);
        int program_StartIndex = input.Index();
        AstNode root_0 = null;

        IToken BEGIN112 = null;
        IToken END114 = null;
        IToken char_literal115 = null;
        MathExprParser.declr_block_return declr_block111 = default(MathExprParser.declr_block_return);

        MathExprParser.exprList_return exprList113 = default(MathExprParser.exprList_return);


        AstNode BEGIN112_tree=null;
        AstNode END114_tree=null;
        AstNode char_literal115_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:146:8: ( ( declr_block )* BEGIN exprList END '.' )
            // MathExpr.g:146:10: ( declr_block )* BEGIN exprList END '.'
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	// MathExpr.g:146:10: ( declr_block )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == VAR_BLOCK || LA25_0 == FUNCTION) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // MathExpr.g:146:11: declr_block
            			    {
            			    	PushFollow(FOLLOW_declr_block_in_program1476);
            			    	declr_block111 = declr_block();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, declr_block111.Tree);

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements

            	BEGIN112=(IToken)Match(input,BEGIN,FOLLOW_BEGIN_in_program1480); if (state.failed) return retval;
            	PushFollow(FOLLOW_exprList_in_program1483);
            	exprList113 = exprList();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exprList113.Tree);
            	END114=(IToken)Match(input,END,FOLLOW_END_in_program1485); if (state.failed) return retval;
            	char_literal115=(IToken)Match(input,56,FOLLOW_56_in_program1488); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, program_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "program"

    public class result_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "result"
    // MathExpr.g:148:1: result : program -> ^( PROGRAM program ) ;
    public MathExprParser.result_return result() // throws RecognitionException [1]
    {   
        MathExprParser.result_return retval = new MathExprParser.result_return();
        retval.Start = input.LT(1);
        int result_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.program_return program116 = default(MathExprParser.program_return);


        RewriteRuleSubtreeStream stream_program = new RewriteRuleSubtreeStream(adaptor,"rule program");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:148:7: ( program -> ^( PROGRAM program ) )
            // MathExpr.g:148:9: program
            {
            	PushFollow(FOLLOW_program_in_result1496);
            	program116 = program();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_program.Add(program116.Tree);


            	// AST REWRITE
            	// elements:          program
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (AstNode)adaptor.GetNilNode();
            	// 148:17: -> ^( PROGRAM program )
            	{
            	    // MathExpr.g:148:20: ^( PROGRAM program )
            	    {
            	    AstNode root_1 = (AstNode)adaptor.GetNilNode();
            	    root_1 = (AstNode)adaptor.BecomeRoot((AstNode)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

            	    adaptor.AddChild(root_1, stream_program.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, result_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "result"

    public class execute_return : ParserRuleReturnScope
    {
        private AstNode tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (AstNode) value; }
        }
    };

    // $ANTLR start "execute"
    // MathExpr.g:150:1: execute : result ;
    public MathExprParser.execute_return execute() // throws RecognitionException [1]
    {   
        MathExprParser.execute_return retval = new MathExprParser.execute_return();
        retval.Start = input.LT(1);
        int execute_StartIndex = input.Index();
        AstNode root_0 = null;

        MathExprParser.result_return result117 = default(MathExprParser.result_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // MathExpr.g:150:8: ( result )
            // MathExpr.g:151:3: result
            {
            	root_0 = (AstNode)adaptor.GetNilNode();

            	PushFollow(FOLLOW_result_in_execute1513);
            	result117 = result();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result117.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (AstNode)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (AstNode)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, execute_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "execute"

    // $ANTLR start "synpred36_MathExpr"
    public void synpred36_MathExpr_fragment() {
        // MathExpr.g:137:24: ( ELSE expr )
        // MathExpr.g:137:24: ELSE expr
        {
        	Match(input,ELSE,FOLLOW_ELSE_in_synpred36_MathExpr1371); if (state.failed) return ;
        	PushFollow(FOLLOW_expr_in_synpred36_MathExpr1374);
        	expr();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred36_MathExpr"

    // Delegated rules

   	public bool synpred36_MathExpr() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_MathExpr_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA20 dfa20;
   	protected DFA22 dfa22;
	private void InitializeCyclicDFAs()
	{
    	this.dfa20 = new DFA20(this);
    	this.dfa22 = new DFA22(this);
	}

    const string DFA20_eotS =
        "\x0a\uffff";
    const string DFA20_eofS =
        "\x01\uffff\x01\x07\x08\uffff";
    const string DFA20_minS =
        "\x01\x08\x01\x0a\x08\uffff";
    const string DFA20_maxS =
        "\x01\x23\x01\x35\x08\uffff";
    const string DFA20_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x01\x06\x01\x07\x01\x08\x01\x02\x01"+
        "\x03\x01\x01";
    const string DFA20_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA20_transitionS = {
            "\x01\x02\x02\uffff\x01\x05\x01\uffff\x01\x04\x01\uffff\x01"+
            "\x06\x01\uffff\x01\x03\x11\uffff\x01\x01",
            "\x01\x07\x05\uffff\x01\x07\x01\uffff\x01\x07\x17\uffff\x01"+
            "\x09\x07\uffff\x01\x08\x02\uffff\x01\x07",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
    static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
    static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
    static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
    static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
    static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
    static readonly short[][] DFA20_transition = DFA.UnpackEncodedStringArray(DFA20_transitionS);

    protected class DFA20 : DFA
    {
        public DFA20(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 20;
            this.eot = DFA20_eot;
            this.eof = DFA20_eof;
            this.min = DFA20_min;
            this.max = DFA20_max;
            this.accept = DFA20_accept;
            this.special = DFA20_special;
            this.transition = DFA20_transition;

        }

        override public string Description
        {
            get { return "133:1: expr : ( ident ASSIGN term | ident -> ^( CALL ident PARAMS ) | call | IF term THEN expr ( ELSE expr )? | BEGIN exprList END -> ^( BLOCK exprList ) | WHILE term DO expr | FOR ident ASSIGN num TO num DO expr | REPEAT expr UNTIL term );"; }
        }

    }

    const string DFA22_eotS =
        "\x04\uffff";
    const string DFA22_eofS =
        "\x04\uffff";
    const string DFA22_minS =
        "\x01\x12\x01\x08\x02\uffff";
    const string DFA22_maxS =
        "\x02\x35\x02\uffff";
    const string DFA22_acceptS =
        "\x02\uffff\x01\x02\x01\x01";
    const string DFA22_specialS =
        "\x04\uffff}>";
    static readonly string[] DFA22_transitionS = {
            "\x01\x02\x22\uffff\x01\x01",
            "\x01\x03\x02\uffff\x01\x03\x01\uffff\x01\x03\x01\uffff\x01"+
            "\x03\x01\uffff\x01\x03\x01\x02\x10\uffff\x01\x03\x11\uffff\x01"+
            "\x01",
            "",
            ""
    };

    static readonly short[] DFA22_eot = DFA.UnpackEncodedString(DFA22_eotS);
    static readonly short[] DFA22_eof = DFA.UnpackEncodedString(DFA22_eofS);
    static readonly char[] DFA22_min = DFA.UnpackEncodedStringToUnsignedChars(DFA22_minS);
    static readonly char[] DFA22_max = DFA.UnpackEncodedStringToUnsignedChars(DFA22_maxS);
    static readonly short[] DFA22_accept = DFA.UnpackEncodedString(DFA22_acceptS);
    static readonly short[] DFA22_special = DFA.UnpackEncodedString(DFA22_specialS);
    static readonly short[][] DFA22_transition = DFA.UnpackEncodedStringArray(DFA22_transitionS);

    protected class DFA22 : DFA
    {
        public DFA22(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;

        }

        override public string Description
        {
            get { return "()* loopback of 144:18: ( ( ';' )+ expr )*"; }
        }

    }

 

    public static readonly BitSet FOLLOW_set_in_bool_value0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IDENT_in_ident837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_term_in_params_850 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_params_853 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_params_856 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_call869 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_call871 = new BitSet(new ulong[]{0x000C000D80200000UL});
    public static readonly BitSet FOLLOW_params__in_call873 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_call875 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_num898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_group916 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_group919 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_group921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bool_value_in_group926 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_num_in_group930 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_group934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_group938 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_BLOCK_in_var_block947 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_var_declaration_in_var_block951 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_ident_in_var_declaration959 = new BitSet(new ulong[]{0x0012000000000000UL});
    public static readonly BitSet FOLLOW_49_in_var_declaration962 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_var_declaration965 = new BitSet(new ulong[]{0x0012000000000000UL});
    public static readonly BitSet FOLLOW_52_in_var_declaration969 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_var_type_in_var_declaration972 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_var_declaration975 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ARRAY_in_var_type983 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_var_type986 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_var_type989 = new BitSet(new ulong[]{0x0002000000000000UL});
    public static readonly BitSet FOLLOW_49_in_var_type991 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_var_type994 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_var_type996 = new BitSet(new ulong[]{0x0000000040000000UL});
    public static readonly BitSet FOLLOW_OF_in_var_type999 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_var_type1002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_var_type1006 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_group_in_not1015 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NOT_in_not1019 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_not_in_not1022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_not_in_mult1030 = new BitSet(new ulong[]{0x000001C000800002UL});
    public static readonly BitSet FOLLOW_set_in_mult1034 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_not_in_mult1053 = new BitSet(new ulong[]{0x000001C000800002UL});
    public static readonly BitSet FOLLOW_mult_in_add1066 = new BitSet(new ulong[]{0x0000023000000002UL});
    public static readonly BitSet FOLLOW_set_in_add1071 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_mult_in_add1086 = new BitSet(new ulong[]{0x0000023000000002UL});
    public static readonly BitSet FOLLOW_add_in_compare1115 = new BitSet(new ulong[]{0x0001F80000000002UL});
    public static readonly BitSet FOLLOW_set_in_compare1119 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_add_in_compare1146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1158 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_AND_in_and_logic1162 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_compare_in_and_logic1165 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1178 = new BitSet(new ulong[]{0x0000000000100002UL});
    public static readonly BitSet FOLLOW_OR_in_or_logic1182 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_and_logic_in_or_logic1185 = new BitSet(new ulong[]{0x0000000000100002UL});
    public static readonly BitSet FOLLOW_or_logic_in_term1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VAR_BLOCK_in_param_decl1205 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_param_decl1209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_param_decl_in_params_decl1216 = new BitSet(new ulong[]{0x0012000000000000UL});
    public static readonly BitSet FOLLOW_49_in_params_decl1219 = new BitSet(new ulong[]{0x0000000802000000UL});
    public static readonly BitSet FOLLOW_param_decl_in_params_decl1221 = new BitSet(new ulong[]{0x0012000000000000UL});
    public static readonly BitSet FOLLOW_52_in_params_decl1225 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_params_decl1227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNCTION_in_func_declr1245 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_func_declr1247 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_func_declr1249 = new BitSet(new ulong[]{0x0008000802000000UL});
    public static readonly BitSet FOLLOW_params_decl_in_func_declr1254 = new BitSet(new ulong[]{0x0028000000000000UL});
    public static readonly BitSet FOLLOW_53_in_func_declr1257 = new BitSet(new ulong[]{0x0000000802000000UL});
    public static readonly BitSet FOLLOW_params_decl_in_func_declr1259 = new BitSet(new ulong[]{0x0028000000000000UL});
    public static readonly BitSet FOLLOW_51_in_func_declr1267 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_func_declr1269 = new BitSet(new ulong[]{0x0000000820000000UL});
    public static readonly BitSet FOLLOW_var_type_in_func_declr1271 = new BitSet(new ulong[]{0x000000000A020000UL});
    public static readonly BitSet FOLLOW_declr_block_in_func_declr1276 = new BitSet(new ulong[]{0x000000000A020000UL});
    public static readonly BitSet FOLLOW_BEGIN_in_func_declr1282 = new BitSet(new ulong[]{0x0024000D8006A900UL});
    public static readonly BitSet FOLLOW_exprList_in_func_declr1284 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_END_in_func_declr1286 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_func_declr1288 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_func_declr_in_declr_block1319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_var_block_in_declr_block1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_expr1333 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1335 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_expr1338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ident_in_expr1342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_call_in_expr1356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_expr1360 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_expr1363 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_THEN_in_expr1365 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_expr1368 = new BitSet(new ulong[]{0x0000000000000402UL});
    public static readonly BitSet FOLLOW_ELSE_in_expr1371 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_expr1374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BEGIN_in_expr1380 = new BitSet(new ulong[]{0x0024000D8006A900UL});
    public static readonly BitSet FOLLOW_exprList_in_expr1382 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_END_in_expr1384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WHILE_in_expr1396 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_expr1399 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DO_in_expr1401 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_expr1404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FOR_in_expr1408 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_ident_in_expr1411 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_expr1413 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_num_in_expr1416 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_TO_in_expr1418 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_num_in_expr1421 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_DO_in_expr1423 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_expr1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REPEAT_in_expr1430 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_expr1433 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_UNTIL_in_expr1435 = new BitSet(new ulong[]{0x0004000D80200000UL});
    public static readonly BitSet FOLLOW_term_in_expr1438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expr_in_exprList1448 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_exprList1452 = new BitSet(new ulong[]{0x0024000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_exprList1456 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_exprList1464 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_declr_block_in_program1476 = new BitSet(new ulong[]{0x000000000A020000UL});
    public static readonly BitSet FOLLOW_BEGIN_in_program1480 = new BitSet(new ulong[]{0x0024000D8006A900UL});
    public static readonly BitSet FOLLOW_exprList_in_program1483 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_END_in_program1485 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_program1488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_program_in_result1496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_result_in_execute1513 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ELSE_in_synpred36_MathExpr1371 = new BitSet(new ulong[]{0x0004000D8002A900UL});
    public static readonly BitSet FOLLOW_expr_in_synpred36_MathExpr1374 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}