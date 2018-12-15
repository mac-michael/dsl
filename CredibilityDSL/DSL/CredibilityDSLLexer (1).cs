// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g 2017-09-04 13:18:22

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class CredibilityDSLLexer : Lexer {
    public const int EOF = -1;
    public const int T__21 = 21;
    public const int T__22 = 22;
    public const int T__23 = 23;
    public const int T__24 = 24;
    public const int AND = 4;
    public const int CONDITION = 5;
    public const int DIVIDE = 6;
    public const int EQUALS = 7;
    public const int GREATER = 8;
    public const int GREATEROREQUALS = 9;
    public const int ID = 10;
    public const int LESS = 11;
    public const int LESSOREQUALS = 12;
    public const int MINUS = 13;
    public const int MODULO = 14;
    public const int MONEY = 15;
    public const int MULTIPLY = 16;
    public const int NOTEQUALS = 17;
    public const int OR = 18;
    public const int PLUS = 19;
    public const int WS = 20;

    // delegates
    // delegators

    public CredibilityDSLLexer() 
    {
		InitializeCyclicDFAs();
    }
    public CredibilityDSLLexer(ICharStream input)
		: this(input, null) {
    }
    public CredibilityDSLLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g";} 
    }

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:7:9: ( '(' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:7:9: '('
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
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public void mT__22() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__22;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:8:9: ( ')' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:8:9: ')'
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
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public void mT__23() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__23;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:9: ( '=' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:9: '='
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
    // $ANTLR end "T__23"

    // $ANTLR start "T__24"
    public void mT__24() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__24;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:10:9: ( 'to' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:10:9: 'to'
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
    // $ANTLR end "T__24"

    // $ANTLR start "CONDITION"
    public void mCONDITION() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = CONDITION;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:36:12: ( 'Jesli' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:36:12: 'Jesli'
            {
            	Match("Jesli"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "CONDITION"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:38:5: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:38:5: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:38:24: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9') || (LA1_0 >= 'A' && LA1_0 <= 'Z') || (LA1_0 >= 'a' && LA1_0 <= 'z')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || (input.LA(1) >= 'a' && input.LA(1) <= 'z') ) 
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
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "MONEY"
    public void mMONEY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MONEY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:9: ( ( '0' | '1' .. '9' ( '0' .. '9' )* ) | ( '0' .. '9' )+ '.' ( '0' .. '9' )* )
            int alt6 = 2;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:9: ( '0' | '1' .. '9' ( '0' .. '9' )* )
                    {
                    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:9: ( '0' | '1' .. '9' ( '0' .. '9' )* )
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == '0') )
                    	{
                    	    alt3 = 1;
                    	}
                    	else if ( ((LA3_0 >= '1' && LA3_0 <= '9')) )
                    	{
                    	    alt3 = 2;
                    	}
                    	else 
                    	{
                    	    NoViableAltException nvae_d3s0 =
                    	        new NoViableAltException("", 3, 0, input);

                    	    throw nvae_d3s0;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:10: '0'
                    	        {
                    	        	Match('0'); 

                    	        }
                    	        break;
                    	    case 2 :
                    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:16: '1' .. '9' ( '0' .. '9' )*
                    	        {
                    	        	MatchRange('1','9'); 
                    	        	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:25: ( '0' .. '9' )*
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
                    	        			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:
                    	        			    {
                    	        			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
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
                    	        			    goto loop2;
                    	        	    }
                    	        	} while (true);

                    	        	loop2:
                    	        		;	// Stops C# compiler whining that label 'loop2' has no statements


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:39: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:39: ( '0' .. '9' )+
                    	int cnt4 = 0;
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:
                    			    {
                    			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
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
                    			    if ( cnt4 >= 1 ) goto loop4;
                    		            EarlyExitException eee4 =
                    		                new EarlyExitException(4, input);
                    		            throw eee4;
                    	    }
                    	    cnt4++;
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements

                    	Match('.'); 
                    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:39:55: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:
                    			    {
                    			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) 
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
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MONEY"

    // $ANTLR start "PLUS"
    public void mPLUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = PLUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:41:9: ( '+' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:41:9: '+'
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
    // $ANTLR end "PLUS"

    // $ANTLR start "MINUS"
    public void mMINUS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MINUS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:42:10: ( '-' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:42:10: '-'
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
    // $ANTLR end "MINUS"

    // $ANTLR start "MULTIPLY"
    public void mMULTIPLY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MULTIPLY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:43:12: ( '*' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:43:12: '*'
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
    // $ANTLR end "MULTIPLY"

    // $ANTLR start "DIVIDE"
    public void mDIVIDE() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = DIVIDE;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:44:10: ( '/' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:44:10: '/'
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
    // $ANTLR end "DIVIDE"

    // $ANTLR start "MODULO"
    public void mMODULO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = MODULO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:45:10: ( '%' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:45:10: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "MODULO"

    // $ANTLR start "EQUALS"
    public void mEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:46:11: ( '==' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:46:11: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EQUALS"

    // $ANTLR start "NOTEQUALS"
    public void mNOTEQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = NOTEQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:47:13: ( '!=' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:47:13: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "NOTEQUALS"

    // $ANTLR start "OR"
    public void mOR() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OR;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:48:6: ( '||' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:48:6: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OR"

    // $ANTLR start "AND"
    public void mAND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = AND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:49:7: ( '&&' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:49:7: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "AND"

    // $ANTLR start "LESS"
    public void mLESS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:50:9: ( '<' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:50:9: '<'
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
    // $ANTLR end "LESS"

    // $ANTLR start "LESSOREQUALS"
    public void mLESSOREQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LESSOREQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:51:16: ( '<=' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:51:16: '<='
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
    // $ANTLR end "LESSOREQUALS"

    // $ANTLR start "GREATER"
    public void mGREATER() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATER;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:52:12: ( '>' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:52:12: '>'
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
    // $ANTLR end "GREATER"

    // $ANTLR start "GREATEROREQUALS"
    public void mGREATEROREQUALS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = GREATEROREQUALS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:53:18: ( '>=' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:53:18: '>='
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
    // $ANTLR end "GREATEROREQUALS"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:55:5: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:55:5: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:55:5: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= '\t' && LA7_0 <= '\n') || LA7_0 == '\r' || LA7_0 == ' ') )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:
            			    {
            			    	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
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
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

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

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:10: ( T__21 | T__22 | T__23 | T__24 | CONDITION | ID | MONEY | PLUS | MINUS | MULTIPLY | DIVIDE | MODULO | EQUALS | NOTEQUALS | OR | AND | LESS | LESSOREQUALS | GREATER | GREATEROREQUALS | WS )
        int alt8 = 21;
        alt8 = dfa8.Predict(input);
        switch (alt8) 
        {
            case 1 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:10: T__21
                {
                	mT__21(); 

                }
                break;
            case 2 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:16: T__22
                {
                	mT__22(); 

                }
                break;
            case 3 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:22: T__23
                {
                	mT__23(); 

                }
                break;
            case 4 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:28: T__24
                {
                	mT__24(); 

                }
                break;
            case 5 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:34: CONDITION
                {
                	mCONDITION(); 

                }
                break;
            case 6 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:44: ID
                {
                	mID(); 

                }
                break;
            case 7 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:47: MONEY
                {
                	mMONEY(); 

                }
                break;
            case 8 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:53: PLUS
                {
                	mPLUS(); 

                }
                break;
            case 9 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:58: MINUS
                {
                	mMINUS(); 

                }
                break;
            case 10 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:64: MULTIPLY
                {
                	mMULTIPLY(); 

                }
                break;
            case 11 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:73: DIVIDE
                {
                	mDIVIDE(); 

                }
                break;
            case 12 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:80: MODULO
                {
                	mMODULO(); 

                }
                break;
            case 13 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:87: EQUALS
                {
                	mEQUALS(); 

                }
                break;
            case 14 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:94: NOTEQUALS
                {
                	mNOTEQUALS(); 

                }
                break;
            case 15 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:104: OR
                {
                	mOR(); 

                }
                break;
            case 16 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:107: AND
                {
                	mAND(); 

                }
                break;
            case 17 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:111: LESS
                {
                	mLESS(); 

                }
                break;
            case 18 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:116: LESSOREQUALS
                {
                	mLESSOREQUALS(); 

                }
                break;
            case 19 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:129: GREATER
                {
                	mGREATER(); 

                }
                break;
            case 20 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:137: GREATEROREQUALS
                {
                	mGREATEROREQUALS(); 

                }
                break;
            case 21 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:1:153: WS
                {
                	mWS(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
    protected DFA8 dfa8;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	    this.dfa8 = new DFA8(this);


	}

    const string DFA6_eotS =
        "\x1\xFFFF\x2\x3\x2\xFFFF\x1\x3";
    const string DFA6_eofS =
        "\x6\xFFFF";
    const string DFA6_minS =
        "\x1\x30\x2\x2E\x2\xFFFF\x1\x2E";
    const string DFA6_maxS =
        "\x3\x39\x2\xFFFF\x1\x39";
    const string DFA6_acceptS =
        "\x3\xFFFF\x1\x1\x1\x2\x1\xFFFF";
    const string DFA6_specialS =
        "\x6\xFFFF}>";
    static readonly string[] DFA6_transitionS = {
            "\x1\x1\x9\x2",
            "\x1\x4\x1\xFFFF\xA\x4",
            "\x1\x4\x1\xFFFF\xA\x5",
            "",
            "",
            "\x1\x4\x1\xFFFF\xA\x5"
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
            get { return "39:0: MONEY : ( ( '0' | '1' .. '9' ( '0' .. '9' )* ) | ( '0' .. '9' )+ '.' ( '0' .. '9' )* );"; }
        }

    }

    const string DFA8_eotS =
        "\x3\xFFFF\x1\x14\x2\x6\xA\xFFFF\x1\x18\x1\x1A\x3\xFFFF\x1\x1B\x1"+
        "\x6\x5\xFFFF\x2\x6\x1\x1F\x1\xFFFF";
    const string DFA8_eofS =
        "\x20\xFFFF";
    const string DFA8_minS =
        "\x1\x9\x2\xFFFF\x1\x3D\x1\x6F\x1\x65\xA\xFFFF\x2\x3D\x3\xFFFF\x1"+
        "\x30\x1\x73\x5\xFFFF\x1\x6C\x1\x69\x1\x30\x1\xFFFF";
    const string DFA8_maxS =
        "\x1\x7C\x2\xFFFF\x1\x3D\x1\x6F\x1\x65\xA\xFFFF\x2\x3D\x3\xFFFF\x1"+
        "\x7A\x1\x73\x5\xFFFF\x1\x6C\x1\x69\x1\x7A\x1\xFFFF";
    const string DFA8_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x3\xFFFF\x1\x6\x1\x7\x1\x8\x1\x9\x1\xA\x1"+
        "\xB\x1\xC\x1\xE\x1\xF\x1\x10\x2\xFFFF\x1\x15\x1\xD\x1\x3\x2\xFFFF"+
        "\x1\x12\x1\x11\x1\x14\x1\x13\x1\x4\x3\xFFFF\x1\x5";
    const string DFA8_specialS =
        "\x20\xFFFF}>";
    static readonly string[] DFA8_transitionS = {
            "\x2\x12\x2\xFFFF\x1\x12\x12\xFFFF\x1\x12\x1\xD\x3\xFFFF\x1\xC"+
            "\x1\xF\x1\xFFFF\x1\x1\x1\x2\x1\xA\x1\x8\x1\xFFFF\x1\x9\x1\xFFFF"+
            "\x1\xB\xA\x7\x2\xFFFF\x1\x10\x1\x3\x1\x11\x2\xFFFF\x9\x6\x1"+
            "\x5\x10\x6\x6\xFFFF\x13\x6\x1\x4\x6\x6\x1\xFFFF\x1\xE",
            "",
            "",
            "\x1\x13",
            "\x1\x15",
            "\x1\x16",
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
            "\x1\x17",
            "\x1\x19",
            "",
            "",
            "",
            "\xA\x6\x7\xFFFF\x1A\x6\x6\xFFFF\x1A\x6",
            "\x1\x1C",
            "",
            "",
            "",
            "",
            "",
            "\x1\x1D",
            "\x1\x1E",
            "\xA\x6\x7\xFFFF\x1A\x6\x6\xFFFF\x1A\x6",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "1:0: Tokens : ( T__21 | T__22 | T__23 | T__24 | CONDITION | ID | MONEY | PLUS | MINUS | MULTIPLY | DIVIDE | MODULO | EQUALS | NOTEQUALS | OR | AND | LESS | LESSOREQUALS | GREATER | GREATEROREQUALS | WS );"; }
        }

    }

 
    
}
