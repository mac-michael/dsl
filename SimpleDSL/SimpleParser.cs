// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g 2018-06-10 19:29:32

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class SimpleParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ID", 
		"IntegerLiteral", 
		"WS", 
		"'-'", 
		"'%'", 
		"'('", 
		"')'", 
		"'*'", 
		"'/'", 
		"'+'"
    };

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



        public SimpleParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SimpleParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
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
		get { return SimpleParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g"; }
    }


    public class start_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "start"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:8:0: start : additiveExpression ;
    public SimpleParser.start_return start() // throws RecognitionException [1]
    {   
        SimpleParser.start_return retval = new SimpleParser.start_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SimpleParser.additiveExpression_return additiveExpression1 = default(SimpleParser.additiveExpression_return);



        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:9:2: ( additiveExpression )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:9:2: additiveExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_start43);
            	additiveExpression1 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression1.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "start"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:10:0: additiveExpression : ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SimpleParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SimpleParser.additiveExpression_return retval = new SimpleParser.additiveExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal3 = null;
        IToken char_literal4 = null;
        SimpleParser.multiplicativeExpression_return multiplicativeExpression2 = default(SimpleParser.multiplicativeExpression_return);

        SimpleParser.multiplicativeExpression_return multiplicativeExpression5 = default(SimpleParser.multiplicativeExpression_return);


        CommonTree char_literal3_tree=null;
        CommonTree char_literal4_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:2: ( ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:2: ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:2: ( multiplicativeExpression )
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:3: multiplicativeExpression
            	{
            		PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression52);
            		multiplicativeExpression2 = multiplicativeExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, multiplicativeExpression2.Tree);

            	}

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:29: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 7 || LA2_0 == 13) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:30: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:30: ( '+' | '-' )
            			    	int alt1 = 2;
            			    	int LA1_0 = input.LA(1);

            			    	if ( (LA1_0 == 13) )
            			    	{
            			    	    alt1 = 1;
            			    	}
            			    	else if ( (LA1_0 == 7) )
            			    	{
            			    	    alt1 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d1s0 =
            			    	        new NoViableAltException("", 1, 0, input);

            			    	    throw nvae_d1s0;
            			    	}
            			    	switch (alt1) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:31: '+'
            			    	        {
            			    	        	char_literal3=(IToken)Match(input,13,FOLLOW_13_in_additiveExpression57); 
            			    	        		char_literal3_tree = (CommonTree)adaptor.Create(char_literal3);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal3_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:11:36: '-'
            			    	        {
            			    	        	char_literal4=(IToken)Match(input,7,FOLLOW_7_in_additiveExpression60); 
            			    	        		char_literal4_tree = (CommonTree)adaptor.Create(char_literal4);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal4_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression64);
            			    	multiplicativeExpression5 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression5.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:12:0: multiplicativeExpression : ( term ) ( ( '*' | '/' | '%' ) term )* ;
    public SimpleParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SimpleParser.multiplicativeExpression_return retval = new SimpleParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal7 = null;
        IToken char_literal8 = null;
        IToken char_literal9 = null;
        SimpleParser.term_return term6 = default(SimpleParser.term_return);

        SimpleParser.term_return term10 = default(SimpleParser.term_return);


        CommonTree char_literal7_tree=null;
        CommonTree char_literal8_tree=null;
        CommonTree char_literal9_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:2: ( ( term ) ( ( '*' | '/' | '%' ) term )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:2: ( term ) ( ( '*' | '/' | '%' ) term )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:2: ( term )
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:3: term
            	{
            		PushFollow(FOLLOW_term_in_multiplicativeExpression76);
            		term6 = term();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, term6.Tree);

            	}

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:9: ( ( '*' | '/' | '%' ) term )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 8 || (LA4_0 >= 11 && LA4_0 <= 12)) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:10: ( '*' | '/' | '%' ) term
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:10: ( '*' | '/' | '%' )
            			    	int alt3 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 11:
            			    		{
            			    	    alt3 = 1;
            			    	    }
            			    	    break;
            			    	case 12:
            			    		{
            			    	    alt3 = 2;
            			    	    }
            			    	    break;
            			    	case 8:
            			    		{
            			    	    alt3 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d3s0 =
            			    		        new NoViableAltException("", 3, 0, input);

            			    		    throw nvae_d3s0;
            			    	}

            			    	switch (alt3) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:11: '*'
            			    	        {
            			    	        	char_literal7=(IToken)Match(input,11,FOLLOW_11_in_multiplicativeExpression81); 
            			    	        		char_literal7_tree = (CommonTree)adaptor.Create(char_literal7);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal7_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:16: '/'
            			    	        {
            			    	        	char_literal8=(IToken)Match(input,12,FOLLOW_12_in_multiplicativeExpression84); 
            			    	        		char_literal8_tree = (CommonTree)adaptor.Create(char_literal8);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal8_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:13:21: '%'
            			    	        {
            			    	        	char_literal9=(IToken)Match(input,8,FOLLOW_8_in_multiplicativeExpression87); 
            			    	        		char_literal9_tree = (CommonTree)adaptor.Create(char_literal9);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal9_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_term_in_multiplicativeExpression91);
            			    	term10 = term();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, term10.Tree);

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

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class term_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "term"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:14:0: term : ( IntegerLiteral | ID | '(' additiveExpression ')' );
    public SimpleParser.term_return term() // throws RecognitionException [1]
    {   
        SimpleParser.term_return retval = new SimpleParser.term_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IntegerLiteral11 = null;
        IToken ID12 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        SimpleParser.additiveExpression_return additiveExpression14 = default(SimpleParser.additiveExpression_return);


        CommonTree IntegerLiteral11_tree=null;
        CommonTree ID12_tree=null;
        CommonTree char_literal13_tree=null;
        CommonTree char_literal15_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:15:2: ( IntegerLiteral | ID | '(' additiveExpression ')' )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case IntegerLiteral:
            	{
                alt5 = 1;
                }
                break;
            case ID:
            	{
                alt5 = 2;
                }
                break;
            case 9:
            	{
                alt5 = 3;
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
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:15:2: IntegerLiteral
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	IntegerLiteral11=(IToken)Match(input,IntegerLiteral,FOLLOW_IntegerLiteral_in_term101); 
                    		IntegerLiteral11_tree = (CommonTree)adaptor.Create(IntegerLiteral11);
                    		adaptor.AddChild(root_0, IntegerLiteral11_tree);


                    }
                    break;
                case 2 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:16:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID12=(IToken)Match(input,ID,FOLLOW_ID_in_term107); 
                    		ID12_tree = (CommonTree)adaptor.Create(ID12);
                    		adaptor.AddChild(root_0, ID12_tree);


                    }
                    break;
                case 3 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\SimpleDSL\\Simple.g:17:2: '(' additiveExpression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal13=(IToken)Match(input,9,FOLLOW_9_in_term113); 
                    	PushFollow(FOLLOW_additiveExpression_in_term116);
                    	additiveExpression14 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression14.Tree);
                    	char_literal15=(IToken)Match(input,10,FOLLOW_10_in_term118); 

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "term"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_additiveExpression_in_start43 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression52 = new BitSet(new ulong[]{0x0000000000002082UL});
    public static readonly BitSet FOLLOW_13_in_additiveExpression57 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_7_in_additiveExpression60 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression64 = new BitSet(new ulong[]{0x0000000000002082UL});
    public static readonly BitSet FOLLOW_term_in_multiplicativeExpression76 = new BitSet(new ulong[]{0x0000000000001902UL});
    public static readonly BitSet FOLLOW_11_in_multiplicativeExpression81 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_12_in_multiplicativeExpression84 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_8_in_multiplicativeExpression87 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_term_in_multiplicativeExpression91 = new BitSet(new ulong[]{0x0000000000001902UL});
    public static readonly BitSet FOLLOW_IntegerLiteral_in_term101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_term107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_9_in_term113 = new BitSet(new ulong[]{0x0000000000000230UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_term116 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_10_in_term118 = new BitSet(new ulong[]{0x0000000000000002UL});

}
