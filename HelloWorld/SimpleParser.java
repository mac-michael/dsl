// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g 2012-11-27 13:04:42

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class SimpleParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "ID", "START", "WS", "XXX"
    };
    public static final int EOF=-1;
    public static final int ID=4;
    public static final int START=5;
    public static final int WS=6;
    public static final int XXX=7;

    // delegates
    // delegators


        public SimpleParser(TokenStream input) {
            this(input, new RecognizerSharedState());
        }
        public SimpleParser(TokenStream input, RecognizerSharedState state) {
            super(input, state);
             
        }
        

    public String[] getTokenNames() { return SimpleParser.tokenNames; }
    public String getGrammarFileName() { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g"; }



    // $ANTLR start "start"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:9:0: start : ID ;
    private final void start() throws RecognitionException {
        try {
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:9:8: ( ID )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:9:8: ID
            {
            match(input,ID,FOLLOW_ID_in_start22); 

            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end "start"


    // $ANTLR start "term"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:10:0: term : ID ;
    private final void term() throws RecognitionException {
        try {
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:10:7: ( ID )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\HelloWorld\\Simple.g:10:7: ID
            {
            match(input,ID,FOLLOW_ID_in_term28); 

            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }
        finally {
        }
        return ;
    }
    // $ANTLR end "term"

    // Delegated rules


 

    public static final BitSet FOLLOW_ID_in_start22 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_term28 = new BitSet(new long[]{0x0000000000000002L});

}