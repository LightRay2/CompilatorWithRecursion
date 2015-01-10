// $ANTLR 3.2 Sep 23, 2009 12:02:23 MathExpr.g 2015-01-08 11:45:56

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  MathExpr 
{
public partial class MathExprLexer : Lexer {
    public const int FUNCTION = 27;
    public const int LT = 48;
    public const int WHILE = 13;
    public const int BIT_AND = 40;
    public const int MOD = 23;
    public const int DO = 14;
    public const int FOR = 11;
    public const int SUB = 37;
    public const int EQUALS = 46;
    public const int NOT = 21;
    public const int VAR_BLOCK = 25;
    public const int AND = 19;
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

    public MathExprLexer() 
    {
		InitializeCyclicDFAs();
    }
    public MathExprLexer(ICharStream input)
		: this(input, null) {
    }
    public MathExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "MathExpr.g";} 
    }

    // $ANTLR start "IF"
    public void mIF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:9:4: ( 'if' )
            // MathExpr.g:9:6: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IF"

    // $ANTLR start "THEN"
    public void mTHEN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = THEN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:10:6: ( 'then' )
            // MathExpr.g:10:8: 'then'
            {
            	Match("then"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "THEN"

    // $ANTLR start "ELSE"
    public void mELSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ELSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:11:6: ( 'else' )
            // MathExpr.g:11:8: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ELSE"

    // $ANTLR start "FOR"
    public void mFOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:12:5: ( 'for' )
            // MathExpr.g:12:7: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FOR"

    // $ANTLR start "TO"
    public void mTO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:13:4: ( 'to' )
            // MathExpr.g:13:6: 'to'
            {
            	Match("to"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TO"

    // $ANTLR start "WHILE"
    public void mWHILE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WHILE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:14:7: ( 'while' )
            // MathExpr.g:14:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WHILE"

    // $ANTLR start "DO"
    public void mDO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:15:4: ( 'do' )
            // MathExpr.g:15:6: 'do'
            {
            	Match("do"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DO"

    // $ANTLR start "REPEAT"
    public void mREPEAT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = REPEAT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:16:8: ( 'repeat' )
            // MathExpr.g:16:10: 'repeat'
            {
            	Match("repeat"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "REPEAT"

    // $ANTLR start "UNTIL"
    public void mUNTIL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = UNTIL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:17:7: ( 'until' )
            // MathExpr.g:17:9: 'until'
            {
            	Match("until"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "UNTIL"

    // $ANTLR start "BEGIN"
    public void mBEGIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BEGIN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:18:7: ( 'begin' )
            // MathExpr.g:18:9: 'begin'
            {
            	Match("begin"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BEGIN"

    // $ANTLR start "END"
    public void mEND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = END;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:19:5: ( 'end' )
            // MathExpr.g:19:7: 'end'
            {
            	Match("end"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "END"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:20:5: ( 'and' )
            // MathExpr.g:20:7: 'and'
            {
            	Match("and"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:21:4: ( 'or' )
            // MathExpr.g:21:6: 'or'
            {
            	Match("or"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "NOT"
    public void mNOT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:22:5: ( 'not' )
            // MathExpr.g:22:7: 'not'
            {
            	Match("not"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOT"

    // $ANTLR start "XOR"
    public void mXOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = XOR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:23:5: ( 'xor' )
            // MathExpr.g:23:7: 'xor'
            {
            	Match("xor"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "XOR"

    // $ANTLR start "MOD"
    public void mMOD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MOD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:24:5: ( 'mod' )
            // MathExpr.g:24:7: 'mod'
            {
            	Match("mod"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MOD"

    // $ANTLR start "IN"
    public void mIN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:25:4: ( 'in' )
            // MathExpr.g:25:6: 'in'
            {
            	Match("in"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IN"

    // $ANTLR start "VAR_BLOCK"
    public void mVAR_BLOCK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VAR_BLOCK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:26:11: ( 'var' )
            // MathExpr.g:26:13: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VAR_BLOCK"

    // $ANTLR start "PROCEDURE"
    public void mPROCEDURE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROCEDURE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:27:11: ( 'procedure' )
            // MathExpr.g:27:13: 'procedure'
            {
            	Match("procedure"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROCEDURE"

    // $ANTLR start "FUNCTION"
    public void mFUNCTION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FUNCTION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:28:10: ( 'function' )
            // MathExpr.g:28:12: 'function'
            {
            	Match("function"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FUNCTION"

    // $ANTLR start "PROGRAM"
    public void mPROGRAM() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PROGRAM;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:29:9: ( 'program' )
            // MathExpr.g:29:11: 'program'
            {
            	Match("program"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "PROGRAM"

    // $ANTLR start "ARRAY"
    public void mARRAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ARRAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:30:7: ( 'array' )
            // MathExpr.g:30:9: 'array'
            {
            	Match("array"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ARRAY"

    // $ANTLR start "OF"
    public void mOF() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OF;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:31:4: ( 'of' )
            // MathExpr.g:31:6: 'of'
            {
            	Match("of"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OF"

    // $ANTLR start "TRUE"
    public void mTRUE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = TRUE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:32:6: ( 'true' )
            // MathExpr.g:32:8: 'true'
            {
            	Match("true"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "TRUE"

    // $ANTLR start "FALSE"
    public void mFALSE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FALSE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:33:7: ( 'false' )
            // MathExpr.g:33:9: 'false'
            {
            	Match("false"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FALSE"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:34:7: ( ',' )
            // MathExpr.g:34:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:35:7: ( '(' )
            // MathExpr.g:35:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:36:7: ( ')' )
            // MathExpr.g:36:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:37:7: ( ':' )
            // MathExpr.g:37:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:38:7: ( ';' )
            // MathExpr.g:38:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:39:7: ( '[' )
            // MathExpr.g:39:9: '['
            {
            	Match('['); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:40:7: ( ']' )
            // MathExpr.g:40:9: ']'
            {
            	Match(']'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:41:7: ( '.' )
            // MathExpr.g:41:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:63:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
            // MathExpr.g:64:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            {
            	// MathExpr.g:64:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '\t' && LA1_0 <= '\n') || (LA1_0 >= '\f' && LA1_0 <= '\r') || LA1_0 == ' ') )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            	    _channel=HIDDEN;
            	  

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "NUMBER"
    public void mNUMBER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NUMBER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:70:7: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
            // MathExpr.g:70:9: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
            {
            	// MathExpr.g:70:9: ( '0' .. '9' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // MathExpr.g:70:10: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

            	// MathExpr.g:70:21: ( '.' ( '0' .. '9' )+ )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == '.') )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // MathExpr.g:70:22: '.' ( '0' .. '9' )+
            	        {
            	        	Match('.'); 
            	        	// MathExpr.g:70:26: ( '0' .. '9' )+
            	        	int cnt3 = 0;
            	        	do 
            	        	{
            	        	    int alt3 = 2;
            	        	    int LA3_0 = input.LA(1);

            	        	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
            	        	    {
            	        	        alt3 = 1;
            	        	    }


            	        	    switch (alt3) 
            	        		{
            	        			case 1 :
            	        			    // MathExpr.g:70:27: '0' .. '9'
            	        			    {
            	        			    	MatchRange('0','9'); 

            	        			    }
            	        			    break;

            	        			default:
            	        			    if ( cnt3 >= 1 ) goto loop3;
            	        		            EarlyExitException eee3 =
            	        		                new EarlyExitException(3, input);
            	        		            throw eee3;
            	        	    }
            	        	    cnt3++;
            	        	} while (true);

            	        	loop3:
            	        		;	// Stops C# compiler whining that label 'loop3' has no statements


            	        }
            	        break;

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "IDENT"
    public void mIDENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IDENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:74:6: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )* )
            // MathExpr.g:74:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// MathExpr.g:75:9: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= '0' && LA5_0 <= '9') || (LA5_0 >= 'A' && LA5_0 <= 'Z') || LA5_0 == '_' || (LA5_0 >= 'a' && LA5_0 <= 'z')) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // MathExpr.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "ADD"
    public void mADD() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ADD;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:78:4: ( '+' )
            // MathExpr.g:78:10: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ADD"

    // $ANTLR start "SUB"
    public void mSUB() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SUB;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:79:4: ( '-' )
            // MathExpr.g:79:10: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SUB"

    // $ANTLR start "MUL"
    public void mMUL() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MUL;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:80:4: ( '*' )
            // MathExpr.g:80:10: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "DIV"
    public void mDIV() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIV;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:81:4: ( '/' )
            // MathExpr.g:81:10: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "BIT_AND"
    public void mBIT_AND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIT_AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:82:8: ( '&' )
            // MathExpr.g:82:10: '&'
            {
            	Match('&'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIT_AND"

    // $ANTLR start "BIT_OR"
    public void mBIT_OR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIT_OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:83:7: ( '|' )
            // MathExpr.g:83:10: '|'
            {
            	Match('|'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIT_OR"

    // $ANTLR start "ASSIGN"
    public void mASSIGN() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ASSIGN;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:84:7: ( ':=' )
            // MathExpr.g:84:9: ':='
            {
            	Match(":="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ASSIGN"

    // $ANTLR start "GE"
    public void mGE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:85:3: ( '>=' )
            // MathExpr.g:85:11: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GE"

    // $ANTLR start "LE"
    public void mLE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:86:3: ( '<=' )
            // MathExpr.g:86:11: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LE"

    // $ANTLR start "NEQUALS"
    public void mNEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NEQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:87:8: ( '<>' )
            // MathExpr.g:87:11: '<>'
            {
            	Match("<>"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NEQUALS"

    // $ANTLR start "EQUALS"
    public void mEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:88:7: ( '=' )
            // MathExpr.g:88:11: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALS"

    // $ANTLR start "GT"
    public void mGT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:89:3: ( '>' )
            // MathExpr.g:89:11: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "GT"

    // $ANTLR start "LT"
    public void mLT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // MathExpr.g:90:3: ( '<' )
            // MathExpr.g:90:11: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LT"

    override public void mTokens() // throws RecognitionException 
    {
        // MathExpr.g:1:8: ( IF | THEN | ELSE | FOR | TO | WHILE | DO | REPEAT | UNTIL | BEGIN | END | AND | OR | NOT | XOR | MOD | IN | VAR_BLOCK | PROCEDURE | FUNCTION | PROGRAM | ARRAY | OF | TRUE | FALSE | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | WS | NUMBER | IDENT | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT )
        int alt6 = 49;
        alt6 = dfa6.Predict(input);
        switch (alt6) 
        {
            case 1 :
                // MathExpr.g:1:10: IF
                {
                	mIF(); 

                }
                break;
            case 2 :
                // MathExpr.g:1:13: THEN
                {
                	mTHEN(); 

                }
                break;
            case 3 :
                // MathExpr.g:1:18: ELSE
                {
                	mELSE(); 

                }
                break;
            case 4 :
                // MathExpr.g:1:23: FOR
                {
                	mFOR(); 

                }
                break;
            case 5 :
                // MathExpr.g:1:27: TO
                {
                	mTO(); 

                }
                break;
            case 6 :
                // MathExpr.g:1:30: WHILE
                {
                	mWHILE(); 

                }
                break;
            case 7 :
                // MathExpr.g:1:36: DO
                {
                	mDO(); 

                }
                break;
            case 8 :
                // MathExpr.g:1:39: REPEAT
                {
                	mREPEAT(); 

                }
                break;
            case 9 :
                // MathExpr.g:1:46: UNTIL
                {
                	mUNTIL(); 

                }
                break;
            case 10 :
                // MathExpr.g:1:52: BEGIN
                {
                	mBEGIN(); 

                }
                break;
            case 11 :
                // MathExpr.g:1:58: END
                {
                	mEND(); 

                }
                break;
            case 12 :
                // MathExpr.g:1:62: AND
                {
                	mAND(); 

                }
                break;
            case 13 :
                // MathExpr.g:1:66: OR
                {
                	mOR(); 

                }
                break;
            case 14 :
                // MathExpr.g:1:69: NOT
                {
                	mNOT(); 

                }
                break;
            case 15 :
                // MathExpr.g:1:73: XOR
                {
                	mXOR(); 

                }
                break;
            case 16 :
                // MathExpr.g:1:77: MOD
                {
                	mMOD(); 

                }
                break;
            case 17 :
                // MathExpr.g:1:81: IN
                {
                	mIN(); 

                }
                break;
            case 18 :
                // MathExpr.g:1:84: VAR_BLOCK
                {
                	mVAR_BLOCK(); 

                }
                break;
            case 19 :
                // MathExpr.g:1:94: PROCEDURE
                {
                	mPROCEDURE(); 

                }
                break;
            case 20 :
                // MathExpr.g:1:104: FUNCTION
                {
                	mFUNCTION(); 

                }
                break;
            case 21 :
                // MathExpr.g:1:113: PROGRAM
                {
                	mPROGRAM(); 

                }
                break;
            case 22 :
                // MathExpr.g:1:121: ARRAY
                {
                	mARRAY(); 

                }
                break;
            case 23 :
                // MathExpr.g:1:127: OF
                {
                	mOF(); 

                }
                break;
            case 24 :
                // MathExpr.g:1:130: TRUE
                {
                	mTRUE(); 

                }
                break;
            case 25 :
                // MathExpr.g:1:135: FALSE
                {
                	mFALSE(); 

                }
                break;
            case 26 :
                // MathExpr.g:1:141: T__49
                {
                	mT__49(); 

                }
                break;
            case 27 :
                // MathExpr.g:1:147: T__50
                {
                	mT__50(); 

                }
                break;
            case 28 :
                // MathExpr.g:1:153: T__51
                {
                	mT__51(); 

                }
                break;
            case 29 :
                // MathExpr.g:1:159: T__52
                {
                	mT__52(); 

                }
                break;
            case 30 :
                // MathExpr.g:1:165: T__53
                {
                	mT__53(); 

                }
                break;
            case 31 :
                // MathExpr.g:1:171: T__54
                {
                	mT__54(); 

                }
                break;
            case 32 :
                // MathExpr.g:1:177: T__55
                {
                	mT__55(); 

                }
                break;
            case 33 :
                // MathExpr.g:1:183: T__56
                {
                	mT__56(); 

                }
                break;
            case 34 :
                // MathExpr.g:1:189: WS
                {
                	mWS(); 

                }
                break;
            case 35 :
                // MathExpr.g:1:192: NUMBER
                {
                	mNUMBER(); 

                }
                break;
            case 36 :
                // MathExpr.g:1:199: IDENT
                {
                	mIDENT(); 

                }
                break;
            case 37 :
                // MathExpr.g:1:205: ADD
                {
                	mADD(); 

                }
                break;
            case 38 :
                // MathExpr.g:1:209: SUB
                {
                	mSUB(); 

                }
                break;
            case 39 :
                // MathExpr.g:1:213: MUL
                {
                	mMUL(); 

                }
                break;
            case 40 :
                // MathExpr.g:1:217: DIV
                {
                	mDIV(); 

                }
                break;
            case 41 :
                // MathExpr.g:1:221: BIT_AND
                {
                	mBIT_AND(); 

                }
                break;
            case 42 :
                // MathExpr.g:1:229: BIT_OR
                {
                	mBIT_OR(); 

                }
                break;
            case 43 :
                // MathExpr.g:1:236: ASSIGN
                {
                	mASSIGN(); 

                }
                break;
            case 44 :
                // MathExpr.g:1:243: GE
                {
                	mGE(); 

                }
                break;
            case 45 :
                // MathExpr.g:1:246: LE
                {
                	mLE(); 

                }
                break;
            case 46 :
                // MathExpr.g:1:249: NEQUALS
                {
                	mNEQUALS(); 

                }
                break;
            case 47 :
                // MathExpr.g:1:257: EQUALS
                {
                	mEQUALS(); 

                }
                break;
            case 48 :
                // MathExpr.g:1:264: GT
                {
                	mGT(); 

                }
                break;
            case 49 :
                // MathExpr.g:1:267: LT
                {
                	mLT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	}

    const string DFA6_eotS =
        "\x01\uffff\x10\x1b\x03\uffff\x01\x3e\x0d\uffff\x01\x40\x01\x43"+
        "\x01\uffff\x01\x44\x01\x45\x01\x1b\x01\x47\x07\x1b\x01\x4f\x05\x1b"+
        "\x01\x55\x01\x56\x05\x1b\x09\uffff\x01\x1b\x01\uffff\x02\x1b\x01"+
        "\x5f\x01\x60\x03\x1b\x01\uffff\x03\x1b\x01\x67\x01\x1b\x02\uffff"+
        "\x01\x69\x01\x6a\x01\x6b\x01\x6c\x01\x1b\x01\x6f\x01\x70\x01\x71"+
        "\x02\uffff\x06\x1b\x01\uffff\x01\x1b\x04\uffff\x02\x1b\x03\uffff"+
        "\x01\x1b\x01\x7c\x01\x7d\x01\x1b\x01\x7f\x01\u0080\x01\u0081\x03"+
        "\x1b\x02\uffff\x01\u0085\x03\uffff\x03\x1b\x01\uffff\x01\x1b\x01"+
        "\u008a\x01\u008b\x01\x1b\x02\uffff\x01\u008d\x01\uffff";
    const string DFA6_eofS =
        "\u008e\uffff";
    const string DFA6_minS =
        "\x01\x09\x01\x66\x01\x68\x01\x6c\x01\x61\x01\x68\x01\x6f\x01\x65"+
        "\x01\x6e\x01\x65\x01\x6e\x01\x66\x03\x6f\x01\x61\x01\x72\x03\uffff"+
        "\x01\x3d\x0d\uffff\x02\x3d\x01\uffff\x02\x30\x01\x65\x01\x30\x01"+
        "\x75\x01\x73\x01\x64\x01\x72\x01\x6e\x01\x6c\x01\x69\x01\x30\x01"+
        "\x70\x01\x74\x01\x67\x01\x64\x01\x72\x02\x30\x01\x74\x01\x72\x01"+
        "\x64\x01\x72\x01\x6f\x09\uffff\x01\x6e\x01\uffff\x02\x65\x02\x30"+
        "\x01\x63\x01\x73\x01\x6c\x01\uffff\x01\x65\x02\x69\x01\x30\x01\x61"+
        "\x02\uffff\x04\x30\x01\x63\x03\x30\x02\uffff\x01\x74\x02\x65\x01"+
        "\x61\x01\x6c\x01\x6e\x01\uffff\x01\x79\x04\uffff\x01\x65\x01\x72"+
        "\x03\uffff\x01\x69\x02\x30\x01\x74\x03\x30\x01\x64\x01\x61\x01\x6f"+
        "\x02\uffff\x01\x30\x03\uffff\x01\x75\x01\x6d\x01\x6e\x01\uffff\x01"+
        "\x72\x02\x30\x01\x65\x02\uffff\x01\x30\x01\uffff";
    const string DFA6_maxS =
        "\x01\x7c\x01\x6e\x01\x72\x01\x6e\x01\x75\x01\x68\x01\x6f\x01\x65"+
        "\x01\x6e\x01\x65\x02\x72\x03\x6f\x01\x61\x01\x72\x03\uffff\x01\x3d"+
        "\x0d\uffff\x01\x3d\x01\x3e\x01\uffff\x02\x7a\x01\x65\x01\x7a\x01"+
        "\x75\x01\x73\x01\x64\x01\x72\x01\x6e\x01\x6c\x01\x69\x01\x7a\x01"+
        "\x70\x01\x74\x01\x67\x01\x64\x01\x72\x02\x7a\x01\x74\x01\x72\x01"+
        "\x64\x01\x72\x01\x6f\x09\uffff\x01\x6e\x01\uffff\x02\x65\x02\x7a"+
        "\x01\x63\x01\x73\x01\x6c\x01\uffff\x01\x65\x02\x69\x01\x7a\x01\x61"+
        "\x02\uffff\x04\x7a\x01\x67\x03\x7a\x02\uffff\x01\x74\x02\x65\x01"+
        "\x61\x01\x6c\x01\x6e\x01\uffff\x01\x79\x04\uffff\x01\x65\x01\x72"+
        "\x03\uffff\x01\x69\x02\x7a\x01\x74\x03\x7a\x01\x64\x01\x61\x01\x6f"+
        "\x02\uffff\x01\x7a\x03\uffff\x01\x75\x01\x6d\x01\x6e\x01\uffff\x01"+
        "\x72\x02\x7a\x01\x65\x02\uffff\x01\x7a\x01\uffff";
    const string DFA6_acceptS =
        "\x11\uffff\x01\x1a\x01\x1b\x01\x1c\x01\uffff\x01\x1e\x01\x1f\x01"+
        "\x20\x01\x21\x01\x22\x01\x23\x01\x24\x01\x25\x01\x26\x01\x27\x01"+
        "\x28\x01\x29\x01\x2a\x02\uffff\x01\x2f\x18\uffff\x01\x2b\x01\x1d"+
        "\x01\x2c\x01\x30\x01\x2d\x01\x2e\x01\x31\x01\x01\x01\x11\x01\uffff"+
        "\x01\x05\x07\uffff\x01\x07\x05\uffff\x01\x0d\x01\x17\x08\uffff\x01"+
        "\x0b\x01\x04\x06\uffff\x01\x0c\x01\uffff\x01\x0e\x01\x0f\x01\x10"+
        "\x01\x12\x02\uffff\x01\x02\x01\x18\x01\x03\x0a\uffff\x01\x19\x01"+
        "\x06\x01\uffff\x01\x09\x01\x0a\x01\x16\x03\uffff\x01\x08\x04\uffff"+
        "\x01\x15\x01\x14\x01\uffff\x01\x13";
    const string DFA6_specialS =
        "\u008e\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x02\x19\x01\uffff\x02\x19\x12\uffff\x01\x19\x05\uffff\x01"+
            "\x20\x01\uffff\x01\x12\x01\x13\x01\x1e\x01\x1c\x01\x11\x01\x1d"+
            "\x01\x18\x01\x1f\x0a\x1a\x01\x14\x01\x15\x01\x23\x01\x24\x01"+
            "\x22\x02\uffff\x1a\x1b\x01\x16\x01\uffff\x01\x17\x01\uffff\x01"+
            "\x1b\x01\uffff\x01\x0a\x01\x09\x01\x1b\x01\x06\x01\x03\x01\x04"+
            "\x02\x1b\x01\x01\x03\x1b\x01\x0e\x01\x0c\x01\x0b\x01\x10\x01"+
            "\x1b\x01\x07\x01\x1b\x01\x02\x01\x08\x01\x0f\x01\x05\x01\x0d"+
            "\x02\x1b\x01\uffff\x01\x21",
            "\x01\x25\x07\uffff\x01\x26",
            "\x01\x27\x06\uffff\x01\x28\x02\uffff\x01\x29",
            "\x01\x2a\x01\uffff\x01\x2b",
            "\x01\x2e\x0d\uffff\x01\x2c\x05\uffff\x01\x2d",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34\x03\uffff\x01\x35",
            "\x01\x37\x0b\uffff\x01\x36",
            "\x01\x38",
            "\x01\x39",
            "\x01\x3a",
            "\x01\x3b",
            "\x01\x3c",
            "",
            "",
            "",
            "\x01\x3d",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x3f",
            "\x01\x41\x01\x42",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x46",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x5c",
            "",
            "\x01\x5d",
            "\x01\x5e",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x68",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x6d\x03\uffff\x01\x6e",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "",
            "\x01\x78",
            "",
            "",
            "",
            "",
            "\x01\x79",
            "\x01\x7a",
            "",
            "",
            "",
            "\x01\x7b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\x7e",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\u0082",
            "\x01\u0083",
            "\x01\u0084",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "",
            "",
            "",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "",
            "\x01\u0089",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            "\x01\u008c",
            "",
            "",
            "\x0a\x1b\x07\uffff\x1a\x1b\x04\uffff\x01\x1b\x01\uffff\x1a"+
            "\x1b",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( IF | THEN | ELSE | FOR | TO | WHILE | DO | REPEAT | UNTIL | BEGIN | END | AND | OR | NOT | XOR | MOD | IN | VAR_BLOCK | PROCEDURE | FUNCTION | PROGRAM | ARRAY | OF | TRUE | FALSE | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | WS | NUMBER | IDENT | ADD | SUB | MUL | DIV | BIT_AND | BIT_OR | ASSIGN | GE | LE | NEQUALS | EQUALS | GT | LT );"; }
        }

    }

 
    
}
}