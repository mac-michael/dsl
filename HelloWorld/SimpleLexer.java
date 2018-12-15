// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g 2012-11-27 13:04:43

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class SimpleLexer extends Lexer {
    public static final int EOF=-1;
    public static final int ID=4;
    public static final int START=5;
    public static final int WS=6;
    public static final int XXX=7;

    // delegates
    // delegators

    public SimpleLexer() {;} 
    public SimpleLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public SimpleLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g"; }

    // $ANTLR start "ID"
    private final void mID() throws RecognitionException {
        try {
            int _type = ID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:11:7: ( ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:11:7: ( 'a' .. 'z' | 'A' .. 'Z' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            {
            if ( (input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:11:26: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' )*
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>='0' && LA1_0<='9')||(LA1_0>='A' && LA1_0<='Z')||(LA1_0>='a' && LA1_0<='z')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:
            	    {
            	    if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||(input.LA(1)>='a' && input.LA(1)<='z') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "WS"
    private final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:13:9: ( ( ' ' | '\\t' | '\\n' | '\\r' )+ )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:13:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
            {
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:13:9: ( ' ' | '\\t' | '\\n' | '\\r' )+
            int cnt2=0;
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0>='\t' && LA2_0<='\n')||LA2_0=='\r'||LA2_0==' ') ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:
            	    {
            	    if ( (input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ' ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    if ( cnt2 >= 1 ) break loop2;
                        EarlyExitException eee =
                            new EarlyExitException(2, input);
                        throw eee;
                }
                cnt2++;
            } while (true);

            _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "WS"

    public void mTokens() throws RecognitionException {
        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:1:10: ( ID | WS )
        int alt3=2;
        int LA3_0 = input.LA(1);

        if ( ((LA3_0>='A' && LA3_0<='Z')||(LA3_0>='a' && LA3_0<='z')) ) {
            alt3=1;
        }
        else if ( ((LA3_0>='\t' && LA3_0<='\n')||LA3_0=='\r'||LA3_0==' ') ) {
            alt3=2;
        }
        else {
            NoViableAltException nvae =
                new NoViableAltException("", 3, 0, input);

            throw nvae;
        }
        switch (alt3) {
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


 

}