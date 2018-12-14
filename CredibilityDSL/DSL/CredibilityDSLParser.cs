// $ANTLR 3.1.2 D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g 2018-06-10 19:29:33

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

public partial class CredibilityDSLParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"AND", 
		"CONDITION", 
		"DIVIDE", 
		"EQUALS", 
		"GREATER", 
		"GREATEROREQUALS", 
		"ID", 
		"LESS", 
		"LESSOREQUALS", 
		"MINUS", 
		"MODULO", 
		"MONEY", 
		"MULTIPLY", 
		"NOTEQUALS", 
		"OR", 
		"PLUS", 
		"WS", 
		"'('", 
		"')'", 
		"'='", 
		"'to'"
    };

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



        public CredibilityDSLParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public CredibilityDSLParser(ITokenStream input, RecognizerSharedState state)
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
		get { return CredibilityDSLParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g"; }
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
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:8:0: start : ( 'Jesli' conditionalOrExpression 'to' )? expression ;
    public CredibilityDSLParser.start_return start() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.start_return retval = new CredibilityDSLParser.start_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal1 = null;
        IToken string_literal3 = null;
        CredibilityDSLParser.conditionalOrExpression_return conditionalOrExpression2 = default(CredibilityDSLParser.conditionalOrExpression_return);

        CredibilityDSLParser.expression_return expression4 = default(CredibilityDSLParser.expression_return);


        CommonTree string_literal1_tree=null;
        CommonTree string_literal3_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:2: ( ( 'Jesli' conditionalOrExpression 'to' )? expression )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:2: ( 'Jesli' conditionalOrExpression 'to' )? expression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:2: ( 'Jesli' conditionalOrExpression 'to' )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == CONDITION) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:9:3: 'Jesli' conditionalOrExpression 'to'
            	        {
            	        	string_literal1=(IToken)Match(input,CONDITION,FOLLOW_CONDITION_in_start44); 
            	        		string_literal1_tree = (CommonTree)adaptor.Create(string_literal1);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal1_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalOrExpression_in_start47);
            	        	conditionalOrExpression2 = conditionalOrExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalOrExpression2.Tree);
            	        	string_literal3=(IToken)Match(input,24,FOLLOW_24_in_start49); 

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_expression_in_start54);
            	expression4 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression4.Tree);

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

    public class conditionalOrExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalOrExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:11:0: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public CredibilityDSLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.conditionalOrExpression_return retval = new CredibilityDSLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal6 = null;
        CredibilityDSLParser.conditionalAndExpression_return conditionalAndExpression5 = default(CredibilityDSLParser.conditionalAndExpression_return);

        CredibilityDSLParser.conditionalAndExpression_return conditionalAndExpression7 = default(CredibilityDSLParser.conditionalAndExpression_return);


        CommonTree string_literal6_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:12:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:12:5: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression65);
            	conditionalAndExpression5 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression5.Tree);
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:12:30: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == OR) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:12:32: '||' conditionalAndExpression
            			    {
            			    	string_literal6=(IToken)Match(input,OR,FOLLOW_OR_in_conditionalOrExpression69); 
            			    		string_literal6_tree = (CommonTree)adaptor.Create(string_literal6);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal6_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression72);
            			    	conditionalAndExpression7 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression7.Tree);

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
    // $ANTLR end "conditionalOrExpression"

    public class conditionalAndExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "conditionalAndExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:14:0: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public CredibilityDSLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.conditionalAndExpression_return retval = new CredibilityDSLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal9 = null;
        CredibilityDSLParser.equalityExpression_return equalityExpression8 = default(CredibilityDSLParser.equalityExpression_return);

        CredibilityDSLParser.equalityExpression_return equalityExpression10 = default(CredibilityDSLParser.equalityExpression_return);


        CommonTree string_literal9_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:15:5: ( equalityExpression ( '&&' equalityExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:15:5: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression86);
            	equalityExpression8 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression8.Tree);
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:15:24: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == AND) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:15:26: '&&' equalityExpression
            			    {
            			    	string_literal9=(IToken)Match(input,AND,FOLLOW_AND_in_conditionalAndExpression90); 
            			    		string_literal9_tree = (CommonTree)adaptor.Create(string_literal9);
            			    		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal9_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression93);
            			    	equalityExpression10 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression10.Tree);

            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
    // $ANTLR end "conditionalAndExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:17:0: equalityExpression : relationalExpression ( ( '=' | '!=' ) relationalExpression )* ;
    public CredibilityDSLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.equalityExpression_return retval = new CredibilityDSLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal12 = null;
        IToken string_literal13 = null;
        CredibilityDSLParser.relationalExpression_return relationalExpression11 = default(CredibilityDSLParser.relationalExpression_return);

        CredibilityDSLParser.relationalExpression_return relationalExpression14 = default(CredibilityDSLParser.relationalExpression_return);


        CommonTree char_literal12_tree=null;
        CommonTree string_literal13_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:5: ( relationalExpression ( ( '=' | '!=' ) relationalExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:5: relationalExpression ( ( '=' | '!=' ) relationalExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression107);
            	relationalExpression11 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression11.Tree);
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:26: ( ( '=' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == NOTEQUALS || LA5_0 == 23) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:28: ( '=' | '!=' ) relationalExpression
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:28: ( '=' | '!=' )
            			    	int alt4 = 2;
            			    	int LA4_0 = input.LA(1);

            			    	if ( (LA4_0 == 23) )
            			    	{
            			    	    alt4 = 1;
            			    	}
            			    	else if ( (LA4_0 == NOTEQUALS) )
            			    	{
            			    	    alt4 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d4s0 =
            			    	        new NoViableAltException("", 4, 0, input);

            			    	    throw nvae_d4s0;
            			    	}
            			    	switch (alt4) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:29: '='
            			    	        {
            			    	        	char_literal12=(IToken)Match(input,23,FOLLOW_23_in_equalityExpression112); 
            			    	        		char_literal12_tree = (CommonTree)adaptor.Create(char_literal12);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal12_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:18:36: '!='
            			    	        {
            			    	        	string_literal13=(IToken)Match(input,NOTEQUALS,FOLLOW_NOTEQUALS_in_equalityExpression117); 
            			    	        		string_literal13_tree = (CommonTree)adaptor.Create(string_literal13);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal13_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression121);
            			    	relationalExpression14 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression14.Tree);

            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


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
    // $ANTLR end "equalityExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:20:0: relationalExpression : additiveExpression ( ( '<=' | '>=' | '<' | '>' ) additiveExpression )* ;
    public CredibilityDSLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.relationalExpression_return retval = new CredibilityDSLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal16 = null;
        IToken string_literal17 = null;
        IToken char_literal18 = null;
        IToken char_literal19 = null;
        CredibilityDSLParser.additiveExpression_return additiveExpression15 = default(CredibilityDSLParser.additiveExpression_return);

        CredibilityDSLParser.additiveExpression_return additiveExpression20 = default(CredibilityDSLParser.additiveExpression_return);


        CommonTree string_literal16_tree=null;
        CommonTree string_literal17_tree=null;
        CommonTree char_literal18_tree=null;
        CommonTree char_literal19_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:5: ( additiveExpression ( ( '<=' | '>=' | '<' | '>' ) additiveExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:5: additiveExpression ( ( '<=' | '>=' | '<' | '>' ) additiveExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression135);
            	additiveExpression15 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression15.Tree);
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:24: ( ( '<=' | '>=' | '<' | '>' ) additiveExpression )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= GREATER && LA7_0 <= GREATEROREQUALS) || (LA7_0 >= LESS && LA7_0 <= LESSOREQUALS)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:26: ( '<=' | '>=' | '<' | '>' ) additiveExpression
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:26: ( '<=' | '>=' | '<' | '>' )
            			    	int alt6 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case LESSOREQUALS:
            			    		{
            			    	    alt6 = 1;
            			    	    }
            			    	    break;
            			    	case GREATEROREQUALS:
            			    		{
            			    	    alt6 = 2;
            			    	    }
            			    	    break;
            			    	case LESS:
            			    		{
            			    	    alt6 = 3;
            			    	    }
            			    	    break;
            			    	case GREATER:
            			    		{
            			    	    alt6 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d6s0 =
            			    		        new NoViableAltException("", 6, 0, input);

            			    		    throw nvae_d6s0;
            			    	}

            			    	switch (alt6) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:27: '<='
            			    	        {
            			    	        	string_literal16=(IToken)Match(input,LESSOREQUALS,FOLLOW_LESSOREQUALS_in_relationalExpression140); 
            			    	        		string_literal16_tree = (CommonTree)adaptor.Create(string_literal16);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal16_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:35: '>='
            			    	        {
            			    	        	string_literal17=(IToken)Match(input,GREATEROREQUALS,FOLLOW_GREATEROREQUALS_in_relationalExpression145); 
            			    	        		string_literal17_tree = (CommonTree)adaptor.Create(string_literal17);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(string_literal17_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:43: '<'
            			    	        {
            			    	        	char_literal18=(IToken)Match(input,LESS,FOLLOW_LESS_in_relationalExpression150); 
            			    	        		char_literal18_tree = (CommonTree)adaptor.Create(char_literal18);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal18_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:21:50: '>'
            			    	        {
            			    	        	char_literal19=(IToken)Match(input,GREATER,FOLLOW_GREATER_in_relationalExpression155); 
            			    	        		char_literal19_tree = (CommonTree)adaptor.Create(char_literal19);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal19_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression159);
            			    	additiveExpression20 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression20.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
    // $ANTLR end "relationalExpression"

    public class expression_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "expression"
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:23:0: expression : ( '+' | '-' | '*' | '/' ) additiveExpression ;
    public CredibilityDSLParser.expression_return expression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.expression_return retval = new CredibilityDSLParser.expression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal21 = null;
        IToken char_literal22 = null;
        IToken char_literal23 = null;
        IToken char_literal24 = null;
        CredibilityDSLParser.additiveExpression_return additiveExpression25 = default(CredibilityDSLParser.additiveExpression_return);


        CommonTree char_literal21_tree=null;
        CommonTree char_literal22_tree=null;
        CommonTree char_literal23_tree=null;
        CommonTree char_literal24_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:2: ( ( '+' | '-' | '*' | '/' ) additiveExpression )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:2: ( '+' | '-' | '*' | '/' ) additiveExpression
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:2: ( '+' | '-' | '*' | '/' )
            	int alt8 = 4;
            	switch ( input.LA(1) ) 
            	{
            	case PLUS:
            		{
            	    alt8 = 1;
            	    }
            	    break;
            	case MINUS:
            		{
            	    alt8 = 2;
            	    }
            	    break;
            	case MULTIPLY:
            		{
            	    alt8 = 3;
            	    }
            	    break;
            	case DIVIDE:
            		{
            	    alt8 = 4;
            	    }
            	    break;
            		default:
            		    NoViableAltException nvae_d8s0 =
            		        new NoViableAltException("", 8, 0, input);

            		    throw nvae_d8s0;
            	}

            	switch (alt8) 
            	{
            	    case 1 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:3: '+'
            	        {
            	        	char_literal21=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_expression171); 
            	        		char_literal21_tree = (CommonTree)adaptor.Create(char_literal21);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal21_tree, root_0);


            	        }
            	        break;
            	    case 2 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:10: '-'
            	        {
            	        	char_literal22=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_expression176); 
            	        		char_literal22_tree = (CommonTree)adaptor.Create(char_literal22);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal22_tree, root_0);


            	        }
            	        break;
            	    case 3 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:16: '*'
            	        {
            	        	char_literal23=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_expression180); 
            	        		char_literal23_tree = (CommonTree)adaptor.Create(char_literal23);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal23_tree, root_0);


            	        }
            	        break;
            	    case 4 :
            	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:24:22: '/'
            	        {
            	        	char_literal24=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_expression184); 
            	        		char_literal24_tree = (CommonTree)adaptor.Create(char_literal24);
            	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal24_tree, root_0);


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_additiveExpression_in_expression188);
            	additiveExpression25 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression25.Tree);

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
    // $ANTLR end "expression"

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
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:26:0: additiveExpression : ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )* ;
    public CredibilityDSLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.additiveExpression_return retval = new CredibilityDSLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal27 = null;
        IToken char_literal28 = null;
        CredibilityDSLParser.multiplicativeExpression_return multiplicativeExpression26 = default(CredibilityDSLParser.multiplicativeExpression_return);

        CredibilityDSLParser.multiplicativeExpression_return multiplicativeExpression29 = default(CredibilityDSLParser.multiplicativeExpression_return);


        CommonTree char_literal27_tree=null;
        CommonTree char_literal28_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:2: ( ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:2: ( multiplicativeExpression ) ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:2: ( multiplicativeExpression )
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:3: multiplicativeExpression
            	{
            		PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression197);
            		multiplicativeExpression26 = multiplicativeExpression();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, multiplicativeExpression26.Tree);

            	}

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:29: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == MINUS || LA10_0 == PLUS) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:30: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:30: ( '+' | '-' )
            			    	int alt9 = 2;
            			    	int LA9_0 = input.LA(1);

            			    	if ( (LA9_0 == PLUS) )
            			    	{
            			    	    alt9 = 1;
            			    	}
            			    	else if ( (LA9_0 == MINUS) )
            			    	{
            			    	    alt9 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d9s0 =
            			    	        new NoViableAltException("", 9, 0, input);

            			    	    throw nvae_d9s0;
            			    	}
            			    	switch (alt9) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:31: '+'
            			    	        {
            			    	        	char_literal27=(IToken)Match(input,PLUS,FOLLOW_PLUS_in_additiveExpression202); 
            			    	        		char_literal27_tree = (CommonTree)adaptor.Create(char_literal27);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal27_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:27:36: '-'
            			    	        {
            			    	        	char_literal28=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_additiveExpression205); 
            			    	        		char_literal28_tree = (CommonTree)adaptor.Create(char_literal28);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal28_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression209);
            			    	multiplicativeExpression29 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression29.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


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
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:28:0: multiplicativeExpression : ( term ) ( ( '*' | '/' | '%' ) term )* ;
    public CredibilityDSLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.multiplicativeExpression_return retval = new CredibilityDSLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal31 = null;
        IToken char_literal32 = null;
        IToken char_literal33 = null;
        CredibilityDSLParser.term_return term30 = default(CredibilityDSLParser.term_return);

        CredibilityDSLParser.term_return term34 = default(CredibilityDSLParser.term_return);


        CommonTree char_literal31_tree=null;
        CommonTree char_literal32_tree=null;
        CommonTree char_literal33_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:2: ( ( term ) ( ( '*' | '/' | '%' ) term )* )
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:2: ( term ) ( ( '*' | '/' | '%' ) term )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:2: ( term )
            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:3: term
            	{
            		PushFollow(FOLLOW_term_in_multiplicativeExpression219);
            		term30 = term();
            		state.followingStackPointer--;

            		adaptor.AddChild(root_0, term30.Tree);

            	}

            	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:9: ( ( '*' | '/' | '%' ) term )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == DIVIDE || LA12_0 == MODULO || LA12_0 == MULTIPLY) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:10: ( '*' | '/' | '%' ) term
            			    {
            			    	// D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:10: ( '*' | '/' | '%' )
            			    	int alt11 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case MULTIPLY:
            			    		{
            			    	    alt11 = 1;
            			    	    }
            			    	    break;
            			    	case DIVIDE:
            			    		{
            			    	    alt11 = 2;
            			    	    }
            			    	    break;
            			    	case MODULO:
            			    		{
            			    	    alt11 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d11s0 =
            			    		        new NoViableAltException("", 11, 0, input);

            			    		    throw nvae_d11s0;
            			    	}

            			    	switch (alt11) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:11: '*'
            			    	        {
            			    	        	char_literal31=(IToken)Match(input,MULTIPLY,FOLLOW_MULTIPLY_in_multiplicativeExpression224); 
            			    	        		char_literal31_tree = (CommonTree)adaptor.Create(char_literal31);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal31_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:16: '/'
            			    	        {
            			    	        	char_literal32=(IToken)Match(input,DIVIDE,FOLLOW_DIVIDE_in_multiplicativeExpression227); 
            			    	        		char_literal32_tree = (CommonTree)adaptor.Create(char_literal32);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal32_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:29:21: '%'
            			    	        {
            			    	        	char_literal33=(IToken)Match(input,MODULO,FOLLOW_MODULO_in_multiplicativeExpression230); 
            			    	        		char_literal33_tree = (CommonTree)adaptor.Create(char_literal33);
            			    	        		root_0 = (CommonTree)adaptor.BecomeRoot(char_literal33_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_term_in_multiplicativeExpression234);
            			    	term34 = term();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, term34.Tree);

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
    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:31:0: term : ( MONEY | ID | '(' additiveExpression ')' );
    public CredibilityDSLParser.term_return term() // throws RecognitionException [1]
    {   
        CredibilityDSLParser.term_return retval = new CredibilityDSLParser.term_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MONEY35 = null;
        IToken ID36 = null;
        IToken char_literal37 = null;
        IToken char_literal39 = null;
        CredibilityDSLParser.additiveExpression_return additiveExpression38 = default(CredibilityDSLParser.additiveExpression_return);


        CommonTree MONEY35_tree=null;
        CommonTree ID36_tree=null;
        CommonTree char_literal37_tree=null;
        CommonTree char_literal39_tree=null;

        try 
    	{
            // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:32:2: ( MONEY | ID | '(' additiveExpression ')' )
            int alt13 = 3;
            switch ( input.LA(1) ) 
            {
            case MONEY:
            	{
                alt13 = 1;
                }
                break;
            case ID:
            	{
                alt13 = 2;
                }
                break;
            case 21:
            	{
                alt13 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            }

            switch (alt13) 
            {
                case 1 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:32:2: MONEY
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	MONEY35=(IToken)Match(input,MONEY,FOLLOW_MONEY_in_term245); 
                    		MONEY35_tree = (CommonTree)adaptor.Create(MONEY35);
                    		adaptor.AddChild(root_0, MONEY35_tree);


                    }
                    break;
                case 2 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:33:2: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID36=(IToken)Match(input,ID,FOLLOW_ID_in_term251); 
                    		ID36_tree = (CommonTree)adaptor.Create(ID36);
                    		adaptor.AddChild(root_0, ID36_tree);


                    }
                    break;
                case 3 :
                    // D:\\Szkolenia\\Artykuł ProgramistaMag - DSL\\Code\\DSLSamples\\CredibilityDSL\\DSL\\CredibilityDSL.g:34:2: '(' additiveExpression ')'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	char_literal37=(IToken)Match(input,21,FOLLOW_21_in_term256); 
                    	PushFollow(FOLLOW_additiveExpression_in_term259);
                    	additiveExpression38 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression38.Tree);
                    	char_literal39=(IToken)Match(input,22,FOLLOW_22_in_term261); 

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

 

    public static readonly BitSet FOLLOW_CONDITION_in_start44 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_start47 = new BitSet(new ulong[]{0x0000000001000000UL});
    public static readonly BitSet FOLLOW_24_in_start49 = new BitSet(new ulong[]{0x0000000000092040UL});
    public static readonly BitSet FOLLOW_expression_in_start54 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression65 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_OR_in_conditionalOrExpression69 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression72 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression86 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_AND_in_conditionalAndExpression90 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression93 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression107 = new BitSet(new ulong[]{0x0000000000820002UL});
    public static readonly BitSet FOLLOW_23_in_equalityExpression112 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_NOTEQUALS_in_equalityExpression117 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression121 = new BitSet(new ulong[]{0x0000000000820002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression135 = new BitSet(new ulong[]{0x0000000000001B02UL});
    public static readonly BitSet FOLLOW_LESSOREQUALS_in_relationalExpression140 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_GREATEROREQUALS_in_relationalExpression145 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_LESS_in_relationalExpression150 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_GREATER_in_relationalExpression155 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression159 = new BitSet(new ulong[]{0x0000000000001B02UL});
    public static readonly BitSet FOLLOW_PLUS_in_expression171 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_MINUS_in_expression176 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_expression180 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_expression184 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_expression188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression197 = new BitSet(new ulong[]{0x0000000000082002UL});
    public static readonly BitSet FOLLOW_PLUS_in_additiveExpression202 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_MINUS_in_additiveExpression205 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression209 = new BitSet(new ulong[]{0x0000000000082002UL});
    public static readonly BitSet FOLLOW_term_in_multiplicativeExpression219 = new BitSet(new ulong[]{0x0000000000014042UL});
    public static readonly BitSet FOLLOW_MULTIPLY_in_multiplicativeExpression224 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_DIVIDE_in_multiplicativeExpression227 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_MODULO_in_multiplicativeExpression230 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_term_in_multiplicativeExpression234 = new BitSet(new ulong[]{0x0000000000014042UL});
    public static readonly BitSet FOLLOW_MONEY_in_term245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_term251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_term256 = new BitSet(new ulong[]{0x0000000000208400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_term259 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_22_in_term261 = new BitSet(new ulong[]{0x0000000000000002UL});

}
