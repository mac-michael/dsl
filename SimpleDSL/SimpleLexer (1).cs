// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g 2017-09-04 13:07:16

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class SimpleLexer : Lexer {
    public const int EOF = -1;
    public const int T__7 = 7;
    public const int T__8 = 8;
    public const int T__9 = 9;
    public const int T__10 = 10;
    public const int T__11 = 11;
    public const int T__12 = 12;
    public const int T__13 = 13;
    public const int ID = 4;
    public const int IntegerLiteral = 5;
    public const int WS = 6;

    // delegates
    // delegators

    public SimpleLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SimpleLexer(ICharStream input)
		: this(input, null) {
    }
    public SimpleLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g";} 
    }

    // $ANTLR start "T__7"
    public void mT__7() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__7;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:7:8: ( '-' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:7:8: '-'
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
    // $ANTLR end "T__7"

    // $ANTLR start "T__8"
    public void mT__8() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__8;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:8:8: ( '%' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:8:8: '%'
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
    // $ANTLR end "T__8"

    // $ANTLR start "T__9"
    public void mT__9() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__9;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:9:8: ( '(' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:9:8: '('
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
    // $ANTLR end "T__9"

    // $ANTLR start "T__10"
    public void mT__10() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__10;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:10:9: ( ')' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:10:9: ')'
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
    // $ANTLR end "T__10"

    // $ANTLR start "T__11"
    public void mT__11() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__11;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:9: ( '*' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:9: '*'
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
    // $ANTLR end "T__11"

    // $ANTLR start "T__12"
    public void mT__12() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__12;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:12:9: ( '/' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:12:9: '/'
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
    // $ANTLR end "T__12"

    // $ANTLR start "T__13"
    public void mT__13() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__13;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:9: ( '+' )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:9: '+'
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
    // $ANTLR end "T__13"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:19:5: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:19:5: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:19:24: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:
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

    // $ANTLR start "IntegerLiteral"
    public void mIntegerLiteral() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntegerLiteral;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:18: ( ( '0' | '1' .. '9' ( '0' .. '9' )* ) )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:18: ( '0' | '1' .. '9' ( '0' .. '9' )* )
            {
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:18: ( '0' | '1' .. '9' ( '0' .. '9' )* )
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
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:19: '0'
            	        {
            	        	Match('0'); 

            	        }
            	        break;
            	    case 2 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:25: '1' .. '9' ( '0' .. '9' )*
            	        {
            	        	MatchRange('1','9'); 
            	        	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:20:34: ( '0' .. '9' )*
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
            	        			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:
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

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntegerLiteral"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:22:5: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:22:5: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:22:5: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt4 = 0;
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '\t' && LA4_0 <= '\n') || LA4_0 == '\r' || LA4_0 == ' ') )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:
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
            			    if ( cnt4 >= 1 ) goto loop4;
            		            EarlyExitException eee4 =
            		                new EarlyExitException(4, input);
            		            throw eee4;
            	    }
            	    cnt4++;
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

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
        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:10: ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | ID | IntegerLiteral | WS )
        int alt5 = 10;
        switch ( input.LA(1) ) 
        {
        case '-':
        	{
            alt5 = 1;
            }
            break;
        case '%':
        	{
            alt5 = 2;
            }
            break;
        case '(':
        	{
            alt5 = 3;
            }
            break;
        case ')':
        	{
            alt5 = 4;
            }
            break;
        case '*':
        	{
            alt5 = 5;
            }
            break;
        case '/':
        	{
            alt5 = 6;
            }
            break;
        case '+':
        	{
            alt5 = 7;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'i':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
        	{
            alt5 = 8;
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        	{
            alt5 = 9;
            }
            break;
        case '\t':
        case '\n':
        case '\r':
        case ' ':
        	{
            alt5 = 10;
            }
            break;
        	default:
        	    NoViableAltException nvae_d5s0 =
        	        new NoViableAltException("", 5, 0, input);

        	    throw nvae_d5s0;
        }

        switch (alt5) 
        {
            case 1 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:10: T__7
                {
                	mT__7(); 

                }
                break;
            case 2 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:15: T__8
                {
                	mT__8(); 

                }
                break;
            case 3 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:20: T__9
                {
                	mT__9(); 

                }
                break;
            case 4 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:25: T__10
                {
                	mT__10(); 

                }
                break;
            case 5 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:31: T__11
                {
                	mT__11(); 

                }
                break;
            case 6 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:37: T__12
                {
                	mT__12(); 

                }
                break;
            case 7 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:43: T__13
                {
                	mT__13(); 

                }
                break;
            case 8 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:49: ID
                {
                	mID(); 

                }
                break;
            case 9 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:52: IntegerLiteral
                {
                	mIntegerLiteral(); 

                }
                break;
            case 10 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:1:67: WS
                {
                	mWS(); 

                }
                break;

        }

    }


	private void InitializeCyclicDFAs()
	{
	}

 
    
}
