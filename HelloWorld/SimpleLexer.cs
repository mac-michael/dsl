// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g 2018-06-10 19:29:33

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
    public const int ID = 4;
    public const int START = 5;
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
    	get { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g";} 
    }

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:15:7: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:15:7: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:15:26: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
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
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:
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

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:17:9: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:17:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:17:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '\t' && LA2_0 <= '\n') || LA2_0 == '\r' || LA2_0 == ' ') )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:
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
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements

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
        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:1:10: ( ID | WS )
        int alt3 = 2;
        int LA3_0 = input.LA(1);

        if ( ((LA3_0 >= 'A' && LA3_0 <= 'Z') || (LA3_0 >= 'a' && LA3_0 <= 'z')) )
        {
            alt3 = 1;
        }
        else if ( ((LA3_0 >= '\t' && LA3_0 <= '\n') || LA3_0 == '\r' || LA3_0 == ' ') )
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
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:1:10: ID
                {
                	mID(); 

                }
                break;
            case 2 :
                // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:1:13: WS
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
