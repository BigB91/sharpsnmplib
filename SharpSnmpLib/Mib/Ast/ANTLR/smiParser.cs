// $ANTLR 3.1.2 Smi.g 2009-11-07 08:33:15

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


#pragma warning disable 3001, 3003, 3005, 3009, 1591 


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  Lextm.SharpSnmpLib.Mib.Ast.ANTLR 
{
public partial class SmiParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ABSENT_KW", 
		"ABSTRACT_SYNTAX_KW", 
		"ALL_KW", 
		"ANY_KW", 
		"APPLICATION_KW", 
		"ARGUMENT_KW", 
		"ASSIGN_OP", 
		"AUTOMATIC_KW", 
		"B_OR_H_STRING", 
		"B_STRING", 
		"BAR", 
		"BASED_NUM_KW", 
		"BDIG", 
		"BEGIN_KW", 
		"BIT_KW", 
		"BMP_STR_KW", 
		"BOOLEAN_KW", 
		"BY_KW", 
		"C_STRING", 
		"CHARACTER_KW", 
		"CHARB", 
		"CHARH", 
		"CHOICE_KW", 
		"CLASS_KW", 
		"COLON", 
		"COMMA", 
		"COMMENT", 
		"COMPONENT_KW", 
		"COMPONENTS_KW", 
		"CONSTRAINED_KW", 
		"DEFAULT_KW", 
		"DEFINED_KW", 
		"DEFINITIONS_KW", 
		"DOT", 
		"DOTDOT", 
		"DOTDOTDOT", 
		"EMBEDDED_KW", 
		"END_KW", 
		"ENUMERATED_KW", 
		"ERROR_KW", 
		"ERRORS_KW", 
		"EXCEPT_KW", 
		"EXCLAMATION", 
		"EXPLICIT_KW", 
		"EXPORTS_KW", 
		"EXTENSIBILITY_KW", 
		"EXTERNAL_KW", 
		"FALSE_KW", 
		"FROM_KW", 
		"GENERAL_STR_KW", 
		"GENERALIZED_TIME_KW", 
		"GRAPHIC_STR_KW", 
		"H_STRING", 
		"HDIG", 
		"IA5_STRING_KW", 
		"IDENTIFIER_KW", 
		"IMPLICIT_KW", 
		"IMPLIED_KW", 
		"IMPORTS_KW", 
		"INCLUDES_KW", 
		"INSTANCE_KW", 
		"INTEGER_KW", 
		"INTERSECTION", 
		"INTERSECTION_KW", 
		"ISO646_STR_KW", 
		"L_BRACE", 
		"L_BRACKET", 
		"L_PAREN", 
		"LESS", 
		"LINKED_KW", 
		"LOWER", 
		"MAX_KW", 
		"MIN_KW", 
		"MINUS", 
		"MINUS_INFINITY_KW", 
		"NULL_KW", 
		"NUMBER", 
		"NUMERIC_STR_KW", 
		"OBJECT_DESCRIPTOR_KW", 
		"OBJECT_KW", 
		"OCTET_KW", 
		"OF_KW", 
		"OID_KW", 
		"OPERATION_KW", 
		"OPTIONAL_KW", 
		"PARAMETER_KW", 
		"PATTERN_KW", 
		"PDV_KW", 
		"PLUS", 
		"PLUS_INFINITY_KW", 
		"PRESENT_KW", 
		"PRINTABLE_STR_KW", 
		"PRIVATE_KW", 
		"R_BRACE", 
		"R_BRACKET", 
		"R_PAREN", 
		"REAL_KW", 
		"RELATIVE_KW", 
		"RESULT_KW", 
		"SEMI", 
		"SEQUENCE_KW", 
		"SET_KW", 
		"SINGLE_QUOTE", 
		"SIZE_KW", 
		"SL_COMMENT", 
		"STRING_KW", 
		"T61_STR_KW", 
		"TAGS_KW", 
		"TELETEX_STR_KW", 
		"TRUE_KW", 
		"TYPE_IDENTIFIER_KW", 
		"UNION_KW", 
		"UNIQUE_KW", 
		"UNIVERSAL_KW", 
		"UNIVERSAL_STR_KW", 
		"UPPER", 
		"UTC_TIME_KW", 
		"UTF8_STR_KW", 
		"VIDEOTEX_STR_KW", 
		"VISIBLE_STR_KW", 
		"WITH_KW", 
		"WS", 
		"'ABSTRACT-BIND'", 
		"'ABSTRACT-ERROR'", 
		"'ABSTRACT-OPERATION'", 
		"'ABSTRACT-UNBIND'", 
		"'ACCESS'", 
		"'AGENT-CAPABILITIES'", 
		"'ALGORITHM'", 
		"'APPLICATION-CONTEXT'", 
		"'APPLICATION-SERVICE-ELEMENT'", 
		"'AUGMENTS'", 
		"'BIND'", 
		"'BITS'", 
		"'CONTACT-INFO'", 
		"'CREATION-REQUIRES'", 
		"'DEFVAL'", 
		"'DESCRIPTION'", 
		"'DISPLAY-HINT'", 
		"'ENCRYPTED'", 
		"'ENTERPRISE'", 
		"'EXTENDS'", 
		"'EXTENSION'", 
		"'EXTENSION-ATTRIBUTE'", 
		"'EXTENSIONS'", 
		"'GROUP'", 
		"'INDEX'", 
		"'INSTALL-ERRORS'", 
		"'LAST-UPDATED'", 
		"'MACRO'", 
		"'MANDATORY-GROUPS'", 
		"'MAX-ACCESS'", 
		"'MIN-ACCESS'", 
		"'MODULE'", 
		"'MODULE-COMPLIANCE'", 
		"'MODULE-IDENTITY'", 
		"'NOTIFICATION-GROUP'", 
		"'NOTIFICATIONS'", 
		"'NOTIFICATION-TYPE'", 
		"'OBJECT-GROUP'", 
		"'OBJECT-IDENTITY'", 
		"'OBJECTS'", 
		"'OBJECT-TYPE'", 
		"'ORGANIZATION'", 
		"'PIB-ACCESS'", 
		"'PIB-DEFINITIONS'", 
		"'PIB-INDEX'", 
		"'PIB-MIN-ACCESS'", 
		"'PIB-REFERENCES'", 
		"'PIB-TAG'", 
		"'PORT'", 
		"'PRODUCT-RELEASE'", 
		"'PROTECTED'", 
		"'REFERENCE'", 
		"'REFINE'", 
		"'RELATIVE-OID'", 
		"'REVISION'", 
		"'SECURITY-CATEGORY'", 
		"'SIGNATURE'", 
		"'SIGNED'", 
		"'STATUS'", 
		"'SUBJECT-CATEGORIES'", 
		"'SUPPORTS'", 
		"'SYNTAX'", 
		"'TEXTUAL-CONVENTION'", 
		"'TOKEN'", 
		"'TOKEN-DATA'", 
		"'TRAP-TYPE'", 
		"'UNBIND'", 
		"'UNIQUENESS'", 
		"'UNITS'", 
		"'VARIABLES'", 
		"'VARIATION'", 
		"'WRITE-SYNTAX'"
    };

    public const int EOF = -1;
    public const int T__126 = 126;
    public const int T__127 = 127;
    public const int T__128 = 128;
    public const int T__129 = 129;
    public const int T__130 = 130;
    public const int T__131 = 131;
    public const int T__132 = 132;
    public const int T__133 = 133;
    public const int T__134 = 134;
    public const int T__135 = 135;
    public const int T__136 = 136;
    public const int T__137 = 137;
    public const int T__138 = 138;
    public const int T__139 = 139;
    public const int T__140 = 140;
    public const int T__141 = 141;
    public const int T__142 = 142;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int T__147 = 147;
    public const int T__148 = 148;
    public const int T__149 = 149;
    public const int T__150 = 150;
    public const int T__151 = 151;
    public const int T__152 = 152;
    public const int T__153 = 153;
    public const int T__154 = 154;
    public const int T__155 = 155;
    public const int T__156 = 156;
    public const int T__157 = 157;
    public const int T__158 = 158;
    public const int T__159 = 159;
    public const int T__160 = 160;
    public const int T__161 = 161;
    public const int T__162 = 162;
    public const int T__163 = 163;
    public const int T__164 = 164;
    public const int T__165 = 165;
    public const int T__166 = 166;
    public const int T__167 = 167;
    public const int T__168 = 168;
    public const int T__169 = 169;
    public const int T__170 = 170;
    public const int T__171 = 171;
    public const int T__172 = 172;
    public const int T__173 = 173;
    public const int T__174 = 174;
    public const int T__175 = 175;
    public const int T__176 = 176;
    public const int T__177 = 177;
    public const int T__178 = 178;
    public const int T__179 = 179;
    public const int T__180 = 180;
    public const int T__181 = 181;
    public const int T__182 = 182;
    public const int T__183 = 183;
    public const int T__184 = 184;
    public const int T__185 = 185;
    public const int T__186 = 186;
    public const int T__187 = 187;
    public const int T__188 = 188;
    public const int T__189 = 189;
    public const int T__190 = 190;
    public const int T__191 = 191;
    public const int T__192 = 192;
    public const int T__193 = 193;
    public const int T__194 = 194;
    public const int T__195 = 195;
    public const int T__196 = 196;
    public const int T__197 = 197;
    public const int ABSENT_KW = 4;
    public const int ABSTRACT_SYNTAX_KW = 5;
    public const int ALL_KW = 6;
    public const int ANY_KW = 7;
    public const int APPLICATION_KW = 8;
    public const int ARGUMENT_KW = 9;
    public const int ASSIGN_OP = 10;
    public const int AUTOMATIC_KW = 11;
    public const int B_OR_H_STRING = 12;
    public const int B_STRING = 13;
    public const int BAR = 14;
    public const int BASED_NUM_KW = 15;
    public const int BDIG = 16;
    public const int BEGIN_KW = 17;
    public const int BIT_KW = 18;
    public const int BMP_STR_KW = 19;
    public const int BOOLEAN_KW = 20;
    public const int BY_KW = 21;
    public const int C_STRING = 22;
    public const int CHARACTER_KW = 23;
    public const int CHARB = 24;
    public const int CHARH = 25;
    public const int CHOICE_KW = 26;
    public const int CLASS_KW = 27;
    public const int COLON = 28;
    public const int COMMA = 29;
    public const int COMMENT = 30;
    public const int COMPONENT_KW = 31;
    public const int COMPONENTS_KW = 32;
    public const int CONSTRAINED_KW = 33;
    public const int DEFAULT_KW = 34;
    public const int DEFINED_KW = 35;
    public const int DEFINITIONS_KW = 36;
    public const int DOT = 37;
    public const int DOTDOT = 38;
    public const int DOTDOTDOT = 39;
    public const int EMBEDDED_KW = 40;
    public const int END_KW = 41;
    public const int ENUMERATED_KW = 42;
    public const int ERROR_KW = 43;
    public const int ERRORS_KW = 44;
    public const int EXCEPT_KW = 45;
    public const int EXCLAMATION = 46;
    public const int EXPLICIT_KW = 47;
    public const int EXPORTS_KW = 48;
    public const int EXTENSIBILITY_KW = 49;
    public const int EXTERNAL_KW = 50;
    public const int FALSE_KW = 51;
    public const int FROM_KW = 52;
    public const int GENERAL_STR_KW = 53;
    public const int GENERALIZED_TIME_KW = 54;
    public const int GRAPHIC_STR_KW = 55;
    public const int H_STRING = 56;
    public const int HDIG = 57;
    public const int IA5_STRING_KW = 58;
    public const int IDENTIFIER_KW = 59;
    public const int IMPLICIT_KW = 60;
    public const int IMPLIED_KW = 61;
    public const int IMPORTS_KW = 62;
    public const int INCLUDES_KW = 63;
    public const int INSTANCE_KW = 64;
    public const int INTEGER_KW = 65;
    public const int INTERSECTION = 66;
    public const int INTERSECTION_KW = 67;
    public const int ISO646_STR_KW = 68;
    public const int L_BRACE = 69;
    public const int L_BRACKET = 70;
    public const int L_PAREN = 71;
    public const int LESS = 72;
    public const int LINKED_KW = 73;
    public const int LOWER = 74;
    public const int MAX_KW = 75;
    public const int MIN_KW = 76;
    public const int MINUS = 77;
    public const int MINUS_INFINITY_KW = 78;
    public const int NULL_KW = 79;
    public const int NUMBER = 80;
    public const int NUMERIC_STR_KW = 81;
    public const int OBJECT_DESCRIPTOR_KW = 82;
    public const int OBJECT_KW = 83;
    public const int OCTET_KW = 84;
    public const int OF_KW = 85;
    public const int OID_KW = 86;
    public const int OPERATION_KW = 87;
    public const int OPTIONAL_KW = 88;
    public const int PARAMETER_KW = 89;
    public const int PATTERN_KW = 90;
    public const int PDV_KW = 91;
    public const int PLUS = 92;
    public const int PLUS_INFINITY_KW = 93;
    public const int PRESENT_KW = 94;
    public const int PRINTABLE_STR_KW = 95;
    public const int PRIVATE_KW = 96;
    public const int R_BRACE = 97;
    public const int R_BRACKET = 98;
    public const int R_PAREN = 99;
    public const int REAL_KW = 100;
    public const int RELATIVE_KW = 101;
    public const int RESULT_KW = 102;
    public const int SEMI = 103;
    public const int SEQUENCE_KW = 104;
    public const int SET_KW = 105;
    public const int SINGLE_QUOTE = 106;
    public const int SIZE_KW = 107;
    public const int SL_COMMENT = 108;
    public const int STRING_KW = 109;
    public const int T61_STR_KW = 110;
    public const int TAGS_KW = 111;
    public const int TELETEX_STR_KW = 112;
    public const int TRUE_KW = 113;
    public const int TYPE_IDENTIFIER_KW = 114;
    public const int UNION_KW = 115;
    public const int UNIQUE_KW = 116;
    public const int UNIVERSAL_KW = 117;
    public const int UNIVERSAL_STR_KW = 118;
    public const int UPPER = 119;
    public const int UTC_TIME_KW = 120;
    public const int UTF8_STR_KW = 121;
    public const int VIDEOTEX_STR_KW = 122;
    public const int VISIBLE_STR_KW = 123;
    public const int WITH_KW = 124;
    public const int WS = 125;

    // delegates
    // delegators



        public SmiParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SmiParser(ITokenStream input, RecognizerSharedState state)
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
		get { return SmiParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Smi.g"; }
    }


    public class module_definition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "module_definition"
    // Smi.g:596:0: module_definition : module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW ;
    public SmiParser.module_definition_return module_definition() // throws RecognitionException [1]
    {   
        SmiParser.module_definition_return retval = new SmiParser.module_definition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set2 = null;
        IToken set3 = null;
        IToken TAGS_KW4 = null;
        IToken EXTENSIBILITY_KW5 = null;
        IToken IMPLIED_KW6 = null;
        IToken ASSIGN_OP7 = null;
        IToken BEGIN_KW8 = null;
        IToken END_KW10 = null;
        SmiParser.module_identifier_return module_identifier1 = default(SmiParser.module_identifier_return);

        SmiParser.module_body_return module_body9 = default(SmiParser.module_body_return);


        object set2_tree=null;
        object set3_tree=null;
        object TAGS_KW4_tree=null;
        object EXTENSIBILITY_KW5_tree=null;
        object IMPLIED_KW6_tree=null;
        object ASSIGN_OP7_tree=null;
        object BEGIN_KW8_tree=null;
        object END_KW10_tree=null;

        try 
    	{
            // Smi.g:596:20: ( module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW )
            // Smi.g:596:20: module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_module_identifier_in_module_definition1855);
            	module_identifier1 = module_identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_identifier1.Tree);
            	set2 = (IToken)input.LT(1);
            	if ( input.LA(1) == DEFINITIONS_KW || input.LA(1) == 169 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set2));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// Smi.g:597:3: ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )?
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == AUTOMATIC_KW || LA1_0 == EXPLICIT_KW || LA1_0 == IMPLICIT_KW) )
            	{
            	    alt1 = 1;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // Smi.g:597:5: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW
            	        {
            	        	set3 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set3));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	TAGS_KW4=(IToken)Match(input,TAGS_KW,FOLLOW_TAGS_KW_in_module_definition1882); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{TAGS_KW4_tree = (object)adaptor.Create(TAGS_KW4);
            	        		adaptor.AddChild(root_0, TAGS_KW4_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:598:3: ( EXTENSIBILITY_KW IMPLIED_KW )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == EXTENSIBILITY_KW) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // Smi.g:598:4: EXTENSIBILITY_KW IMPLIED_KW
            	        {
            	        	EXTENSIBILITY_KW5=(IToken)Match(input,EXTENSIBILITY_KW,FOLLOW_EXTENSIBILITY_KW_in_module_definition1891); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXTENSIBILITY_KW5_tree = (object)adaptor.Create(EXTENSIBILITY_KW5);
            	        		adaptor.AddChild(root_0, EXTENSIBILITY_KW5_tree);
            	        	}
            	        	IMPLIED_KW6=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_module_definition1893); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{IMPLIED_KW6_tree = (object)adaptor.Create(IMPLIED_KW6);
            	        		adaptor.AddChild(root_0, IMPLIED_KW6_tree);
            	        	}

            	        }
            	        break;

            	}

            	ASSIGN_OP7=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_module_definition1899); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ASSIGN_OP7_tree = (object)adaptor.Create(ASSIGN_OP7);
            		adaptor.AddChild(root_0, ASSIGN_OP7_tree);
            	}
            	BEGIN_KW8=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_module_definition1901); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BEGIN_KW8_tree = (object)adaptor.Create(BEGIN_KW8);
            		adaptor.AddChild(root_0, BEGIN_KW8_tree);
            	}
            	PushFollow(FOLLOW_module_body_in_module_definition1903);
            	module_body9 = module_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_body9.Tree);
            	END_KW10=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_module_definition1905); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{END_KW10_tree = (object)adaptor.Create(END_KW10);
            		adaptor.AddChild(root_0, END_KW10_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_definition"

    public class module_identifier_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "module_identifier"
    // Smi.g:601:0: module_identifier : UPPER ( obj_id_comp_lst )? ;
    public SmiParser.module_identifier_return module_identifier() // throws RecognitionException [1]
    {   
        SmiParser.module_identifier_return retval = new SmiParser.module_identifier_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UPPER11 = null;
        SmiParser.obj_id_comp_lst_return obj_id_comp_lst12 = default(SmiParser.obj_id_comp_lst_return);


        object UPPER11_tree=null;

        try 
    	{
            // Smi.g:601:20: ( UPPER ( obj_id_comp_lst )? )
            // Smi.g:601:20: UPPER ( obj_id_comp_lst )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	UPPER11=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_module_identifier1912); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER11_tree = (object)adaptor.Create(UPPER11);
            		adaptor.AddChild(root_0, UPPER11_tree);
            	}
            	// Smi.g:601:26: ( obj_id_comp_lst )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == L_BRACE) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Smi.g:601:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_module_identifier1915);
            	        	obj_id_comp_lst12 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst12.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_identifier"

    public class module_body_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "module_body"
    // Smi.g:603:0: module_body : ( exports )? ( imports )? ( assignment )* ;
    public SmiParser.module_body_return module_body() // throws RecognitionException [1]
    {   
        SmiParser.module_body_return retval = new SmiParser.module_body_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SmiParser.exports_return exports13 = default(SmiParser.exports_return);

        SmiParser.imports_return imports14 = default(SmiParser.imports_return);

        SmiParser.assignment_return assignment15 = default(SmiParser.assignment_return);



        try 
    	{
            // Smi.g:603:14: ( ( exports )? ( imports )? ( assignment )* )
            // Smi.g:603:14: ( exports )? ( imports )? ( assignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:603:14: ( exports )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXPORTS_KW) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Smi.g:603:15: exports
            	        {
            	        	PushFollow(FOLLOW_exports_in_module_body1926);
            	        	exports13 = exports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exports13.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:603:25: ( imports )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == IMPORTS_KW) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Smi.g:603:26: imports
            	        {
            	        	PushFollow(FOLLOW_imports_in_module_body1931);
            	        	imports14 = imports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, imports14.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:603:36: ( assignment )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == ERROR_KW || LA6_0 == LOWER || LA6_0 == OBJECT_KW || LA6_0 == OPERATION_KW || LA6_0 == UPPER || (LA6_0 >= 126 && LA6_0 <= 129) || (LA6_0 >= 131 && LA6_0 <= 134) || LA6_0 == 136 || LA6_0 == 143 || (LA6_0 >= 146 && LA6_0 <= 148) || (LA6_0 >= 158 && LA6_0 <= 160) || (LA6_0 >= 162 && LA6_0 <= 164) || LA6_0 == 166 || LA6_0 == 174 || LA6_0 == 176 || LA6_0 == 178 || (LA6_0 >= 181 && LA6_0 <= 183) || (LA6_0 >= 188 && LA6_0 <= 192)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // Smi.g:603:37: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_module_body1936);
            			    	assignment15 = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment15.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_body"

    public class obj_id_comp_lst_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "obj_id_comp_lst"
    // Smi.g:606:0: obj_id_comp_lst : L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE ;
    public SmiParser.obj_id_comp_lst_return obj_id_comp_lst() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_comp_lst_return retval = new SmiParser.obj_id_comp_lst_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE16 = null;
        IToken R_BRACE19 = null;
        SmiParser.defined_value_return defined_value17 = default(SmiParser.defined_value_return);

        SmiParser.obj_id_component_return obj_id_component18 = default(SmiParser.obj_id_component_return);


        object L_BRACE16_tree=null;
        object R_BRACE19_tree=null;

        try 
    	{
            // Smi.g:606:18: ( L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE )
            // Smi.g:606:18: L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE16=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_obj_id_comp_lst1948); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE16_tree = (object)adaptor.Create(L_BRACE16);
            		adaptor.AddChild(root_0, L_BRACE16_tree);
            	}
            	// Smi.g:606:26: (=> defined_value )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == UPPER) && (synpred1_Smi()) )
            	{
            	    alt7 = 1;
            	}
            	else if ( (LA7_0 == LOWER) )
            	{
            	    int LA7_2 = input.LA(2);

            	    if ( (synpred1_Smi()) )
            	    {
            	        alt7 = 1;
            	    }
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // Smi.g:606:27: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_obj_id_comp_lst1963);
            	        	defined_value17 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value17.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:606:69: ( obj_id_component )+
            	int cnt8 = 0;
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == LOWER || LA8_0 == NUMBER) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // Smi.g:606:70: obj_id_component
            			    {
            			    	PushFollow(FOLLOW_obj_id_component_in_obj_id_comp_lst1968);
            			    	obj_id_component18 = obj_id_component();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_component18.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt8 >= 1 ) goto loop8;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee8 =
            		                new EarlyExitException(8, input);
            		            throw eee8;
            	    }
            	    cnt8++;
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	R_BRACE19=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_obj_id_comp_lst1972); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE19_tree = (object)adaptor.Create(R_BRACE19);
            		adaptor.AddChild(root_0, R_BRACE19_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_comp_lst"

    public class defined_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "defined_value"
    // Smi.g:609:0: protected defined_value : ( UPPER DOT )? LOWER ;
    public SmiParser.defined_value_return defined_value() // throws RecognitionException [1]
    {   
        SmiParser.defined_value_return retval = new SmiParser.defined_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UPPER20 = null;
        IToken DOT21 = null;
        IToken LOWER22 = null;

        object UPPER20_tree=null;
        object DOT21_tree=null;
        object LOWER22_tree=null;

        try 
    	{
            // Smi.g:609:26: ( ( UPPER DOT )? LOWER )
            // Smi.g:609:26: ( UPPER DOT )? LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:609:26: ( UPPER DOT )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == UPPER) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // Smi.g:609:27: UPPER DOT
            	        {
            	        	UPPER20=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_value1983); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER20_tree = (object)adaptor.Create(UPPER20);
            	        		adaptor.AddChild(root_0, UPPER20_tree);
            	        	}
            	        	DOT21=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_value1985); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT21_tree = (object)adaptor.Create(DOT21);
            	        		adaptor.AddChild(root_0, DOT21_tree);
            	        	}

            	        }
            	        break;

            	}

            	LOWER22=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_defined_value1989); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER22_tree = (object)adaptor.Create(LOWER22);
            		adaptor.AddChild(root_0, LOWER22_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_value"

    public class obj_id_component_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "obj_id_component"
    // Smi.g:612:0: obj_id_component : ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? );
    public SmiParser.obj_id_component_return obj_id_component() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_component_return retval = new SmiParser.obj_id_component_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NUMBER23 = null;
        IToken LOWER24 = null;
        IToken L_PAREN25 = null;
        IToken NUMBER26 = null;
        IToken R_PAREN27 = null;

        object NUMBER23_tree=null;
        object LOWER24_tree=null;
        object L_PAREN25_tree=null;
        object NUMBER26_tree=null;
        object R_PAREN27_tree=null;

        try 
    	{
            // Smi.g:612:19: ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == NUMBER) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == LOWER) )
            {
                alt11 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // Smi.g:612:19: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER23=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component1999); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER23_tree = (object)adaptor.Create(NUMBER23);
                    		adaptor.AddChild(root_0, NUMBER23_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:613:19: LOWER ( L_PAREN NUMBER R_PAREN )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LOWER24=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_obj_id_component2020); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER24_tree = (object)adaptor.Create(LOWER24);
                    		adaptor.AddChild(root_0, LOWER24_tree);
                    	}
                    	// Smi.g:613:25: ( L_PAREN NUMBER R_PAREN )?
                    	int alt10 = 2;
                    	int LA10_0 = input.LA(1);

                    	if ( (LA10_0 == L_PAREN) )
                    	{
                    	    alt10 = 1;
                    	}
                    	switch (alt10) 
                    	{
                    	    case 1 :
                    	        // Smi.g:613:26: L_PAREN NUMBER R_PAREN
                    	        {
                    	        	L_PAREN25=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_obj_id_component2023); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_PAREN25_tree = (object)adaptor.Create(L_PAREN25);
                    	        		adaptor.AddChild(root_0, L_PAREN25_tree);
                    	        	}
                    	        	NUMBER26=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component2025); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{NUMBER26_tree = (object)adaptor.Create(NUMBER26);
                    	        		adaptor.AddChild(root_0, NUMBER26_tree);
                    	        	}
                    	        	R_PAREN27=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_obj_id_component2027); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_PAREN27_tree = (object)adaptor.Create(R_PAREN27);
                    	        		adaptor.AddChild(root_0, R_PAREN27_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_component"

    public class tag_default_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tag_default"
    // Smi.g:619:0: tag_default : ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW );
    public SmiParser.tag_default_return tag_default() // throws RecognitionException [1]
    {   
        SmiParser.tag_default_return retval = new SmiParser.tag_default_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set28 = null;

        object set28_tree=null;

        try 
    	{
            // Smi.g:619:14: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW )
            // Smi.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set28 = (IToken)input.LT(1);
            	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set28));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag_default"

    public class exports_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "exports"
    // Smi.g:621:0: exports : EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI ;
    public SmiParser.exports_return exports() // throws RecognitionException [1]
    {   
        SmiParser.exports_return retval = new SmiParser.exports_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EXPORTS_KW29 = null;
        IToken ALL_KW31 = null;
        IToken SEMI32 = null;
        SmiParser.symbol_list_return symbol_list30 = default(SmiParser.symbol_list_return);


        object EXPORTS_KW29_tree=null;
        object ALL_KW31_tree=null;
        object SEMI32_tree=null;

        try 
    	{
            // Smi.g:621:10: ( EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI )
            // Smi.g:621:10: EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	EXPORTS_KW29=(IToken)Match(input,EXPORTS_KW,FOLLOW_EXPORTS_KW_in_exports2055); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXPORTS_KW29_tree = (object)adaptor.Create(EXPORTS_KW29);
            		adaptor.AddChild(root_0, EXPORTS_KW29_tree);
            	}
            	// Smi.g:621:21: ( ( symbol_list )? | ALL_KW )
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == ERROR_KW || LA13_0 == LOWER || LA13_0 == OBJECT_KW || LA13_0 == OPERATION_KW || LA13_0 == SEMI || LA13_0 == UPPER || (LA13_0 >= 126 && LA13_0 <= 129) || (LA13_0 >= 131 && LA13_0 <= 134) || LA13_0 == 136 || LA13_0 == 143 || (LA13_0 >= 146 && LA13_0 <= 148) || (LA13_0 >= 158 && LA13_0 <= 160) || (LA13_0 >= 162 && LA13_0 <= 164) || LA13_0 == 166 || LA13_0 == 174 || LA13_0 == 176 || LA13_0 == 178 || (LA13_0 >= 181 && LA13_0 <= 183) || (LA13_0 >= 188 && LA13_0 <= 192)) )
            	{
            	    alt13 = 1;
            	}
            	else if ( (LA13_0 == ALL_KW) )
            	{
            	    alt13 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // Smi.g:621:23: ( symbol_list )?
            	        {
            	        	// Smi.g:621:23: ( symbol_list )?
            	        	int alt12 = 2;
            	        	int LA12_0 = input.LA(1);

            	        	if ( (LA12_0 == ERROR_KW || LA12_0 == LOWER || LA12_0 == OBJECT_KW || LA12_0 == OPERATION_KW || LA12_0 == UPPER || (LA12_0 >= 126 && LA12_0 <= 129) || (LA12_0 >= 131 && LA12_0 <= 134) || LA12_0 == 136 || LA12_0 == 143 || (LA12_0 >= 146 && LA12_0 <= 148) || (LA12_0 >= 158 && LA12_0 <= 160) || (LA12_0 >= 162 && LA12_0 <= 164) || LA12_0 == 166 || LA12_0 == 174 || LA12_0 == 176 || LA12_0 == 178 || (LA12_0 >= 181 && LA12_0 <= 183) || (LA12_0 >= 188 && LA12_0 <= 192)) )
            	        	{
            	        	    alt12 = 1;
            	        	}
            	        	switch (alt12) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:621:24: symbol_list
            	        	        {
            	        	        	PushFollow(FOLLOW_symbol_list_in_exports2060);
            	        	        	symbol_list30 = symbol_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list30.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:621:40: ALL_KW
            	        {
            	        	ALL_KW31=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_exports2066); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ALL_KW31_tree = (object)adaptor.Create(ALL_KW31);
            	        		adaptor.AddChild(root_0, ALL_KW31_tree);
            	        	}

            	        }
            	        break;

            	}

            	SEMI32=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_exports2070); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI32_tree = (object)adaptor.Create(SEMI32);
            		adaptor.AddChild(root_0, SEMI32_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exports"

    public class imports_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "imports"
    // Smi.g:623:0: imports : IMPORTS_KW ( symbols_from_module )* SEMI ;
    public SmiParser.imports_return imports() // throws RecognitionException [1]
    {   
        SmiParser.imports_return retval = new SmiParser.imports_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken IMPORTS_KW33 = null;
        IToken SEMI35 = null;
        SmiParser.symbols_from_module_return symbols_from_module34 = default(SmiParser.symbols_from_module_return);


        object IMPORTS_KW33_tree=null;
        object SEMI35_tree=null;

        try 
    	{
            // Smi.g:623:10: ( IMPORTS_KW ( symbols_from_module )* SEMI )
            // Smi.g:623:10: IMPORTS_KW ( symbols_from_module )* SEMI
            {
            	root_0 = (object)adaptor.GetNilNode();

            	IMPORTS_KW33=(IToken)Match(input,IMPORTS_KW,FOLLOW_IMPORTS_KW_in_imports2077); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IMPORTS_KW33_tree = (object)adaptor.Create(IMPORTS_KW33);
            		adaptor.AddChild(root_0, IMPORTS_KW33_tree);
            	}
            	// Smi.g:623:21: ( symbols_from_module )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == ERROR_KW || LA14_0 == LOWER || LA14_0 == OBJECT_KW || LA14_0 == OPERATION_KW || LA14_0 == UPPER || (LA14_0 >= 126 && LA14_0 <= 129) || (LA14_0 >= 131 && LA14_0 <= 134) || LA14_0 == 136 || LA14_0 == 143 || (LA14_0 >= 146 && LA14_0 <= 148) || (LA14_0 >= 158 && LA14_0 <= 160) || (LA14_0 >= 162 && LA14_0 <= 164) || LA14_0 == 166 || LA14_0 == 174 || LA14_0 == 176 || LA14_0 == 178 || (LA14_0 >= 181 && LA14_0 <= 183) || (LA14_0 >= 188 && LA14_0 <= 192)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // Smi.g:623:22: symbols_from_module
            			    {
            			    	PushFollow(FOLLOW_symbols_from_module_in_imports2080);
            			    	symbols_from_module34 = symbols_from_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbols_from_module34.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	SEMI35=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_imports2084); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI35_tree = (object)adaptor.Create(SEMI35);
            		adaptor.AddChild(root_0, SEMI35_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "imports"

    public class assignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // Smi.g:626:0: assignment : ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW );
    public SmiParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SmiParser.assignment_return retval = new SmiParser.assignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UPPER36 = null;
        IToken ASSIGN_OP37 = null;
        IToken LOWER39 = null;
        IToken ASSIGN_OP41 = null;
        IToken UPPER43 = null;
        IToken string_literal45 = null;
        IToken ASSIGN_OP46 = null;
        IToken BEGIN_KW47 = null;
        IToken set48 = null;
        IToken END_KW49 = null;
        SmiParser.type_return type38 = default(SmiParser.type_return);

        SmiParser.type_return type40 = default(SmiParser.type_return);

        SmiParser.value_return value42 = default(SmiParser.value_return);

        SmiParser.macroName_return macroName44 = default(SmiParser.macroName_return);


        object UPPER36_tree=null;
        object ASSIGN_OP37_tree=null;
        object LOWER39_tree=null;
        object ASSIGN_OP41_tree=null;
        object UPPER43_tree=null;
        object string_literal45_tree=null;
        object ASSIGN_OP46_tree=null;
        object BEGIN_KW47_tree=null;
        object set48_tree=null;
        object END_KW49_tree=null;

        try 
    	{
            // Smi.g:626:13: ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                int LA17_1 = input.LA(2);

                if ( (LA17_1 == ASSIGN_OP) )
                {
                    alt17 = 1;
                }
                else if ( (LA17_1 == 153) )
                {
                    alt17 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d17s1 =
                        new NoViableAltException("", 17, 1, input);

                    throw nvae_d17s1;
                }
                }
                break;
            case LOWER:
            	{
                alt17 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt17 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // Smi.g:626:13: UPPER ASSIGN_OP type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	UPPER36=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2094); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER36_tree = (object)adaptor.Create(UPPER36);
                    		adaptor.AddChild(root_0, UPPER36_tree);
                    	}
                    	ASSIGN_OP37=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2096); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP37_tree = (object)adaptor.Create(ASSIGN_OP37);
                    		adaptor.AddChild(root_0, ASSIGN_OP37_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2098);
                    	type38 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type38.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:627:13: LOWER type ASSIGN_OP value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LOWER39=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_assignment2113); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER39_tree = (object)adaptor.Create(LOWER39);
                    		adaptor.AddChild(root_0, LOWER39_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2115);
                    	type40 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type40.Tree);
                    	ASSIGN_OP41=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2117); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP41_tree = (object)adaptor.Create(ASSIGN_OP41);
                    		adaptor.AddChild(root_0, ASSIGN_OP41_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_assignment2119);
                    	value42 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value42.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:628:13: ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// Smi.g:628:13: ( UPPER | macroName )
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == UPPER) )
                    	{
                    	    alt15 = 1;
                    	}
                    	else if ( (LA15_0 == ERROR_KW || LA15_0 == OBJECT_KW || LA15_0 == OPERATION_KW || (LA15_0 >= 126 && LA15_0 <= 129) || (LA15_0 >= 131 && LA15_0 <= 134) || LA15_0 == 136 || LA15_0 == 143 || (LA15_0 >= 146 && LA15_0 <= 148) || (LA15_0 >= 158 && LA15_0 <= 160) || (LA15_0 >= 162 && LA15_0 <= 164) || LA15_0 == 166 || LA15_0 == 174 || LA15_0 == 176 || LA15_0 == 178 || (LA15_0 >= 181 && LA15_0 <= 183) || (LA15_0 >= 188 && LA15_0 <= 192)) )
                    	{
                    	    alt15 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d15s0 =
                    	        new NoViableAltException("", 15, 0, input);

                    	    throw nvae_d15s0;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // Smi.g:628:14: UPPER
                    	        {
                    	        	UPPER43=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2135); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{UPPER43_tree = (object)adaptor.Create(UPPER43);
                    	        		adaptor.AddChild(root_0, UPPER43_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:628:22: macroName
                    	        {
                    	        	PushFollow(FOLLOW_macroName_in_assignment2139);
                    	        	macroName44 = macroName();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName44.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal45=(IToken)Match(input,153,FOLLOW_153_in_assignment2142); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal45_tree = (object)adaptor.Create(string_literal45);
                    		adaptor.AddChild(root_0, string_literal45_tree);
                    	}
                    	ASSIGN_OP46=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2144); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP46_tree = (object)adaptor.Create(ASSIGN_OP46);
                    		adaptor.AddChild(root_0, ASSIGN_OP46_tree);
                    	}
                    	BEGIN_KW47=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_assignment2146); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BEGIN_KW47_tree = (object)adaptor.Create(BEGIN_KW47);
                    		adaptor.AddChild(root_0, BEGIN_KW47_tree);
                    	}
                    	// Smi.g:628:60: (~ ( END_KW ) )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( ((LA16_0 >= ABSENT_KW && LA16_0 <= EMBEDDED_KW) || (LA16_0 >= ENUMERATED_KW && LA16_0 <= 197)) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // Smi.g:
                    			    {
                    			    	set48 = (IToken)input.LT(1);
                    			    	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= EMBEDDED_KW) || (input.LA(1) >= ENUMERATED_KW && input.LA(1) <= 197) ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set48));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements

                    	END_KW49=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_assignment2156); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{END_KW49_tree = (object)adaptor.Create(END_KW49);
                    		adaptor.AddChild(root_0, END_KW49_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class symbol_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "symbol_list"
    // Smi.g:636:0: symbol_list : symbol ( COMMA symbol )* ;
    public SmiParser.symbol_list_return symbol_list() // throws RecognitionException [1]
    {   
        SmiParser.symbol_list_return retval = new SmiParser.symbol_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA51 = null;
        SmiParser.symbol_return symbol50 = default(SmiParser.symbol_return);

        SmiParser.symbol_return symbol52 = default(SmiParser.symbol_return);


        object COMMA51_tree=null;

        try 
    	{
            // Smi.g:636:14: ( symbol ( COMMA symbol )* )
            // Smi.g:636:14: symbol ( COMMA symbol )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_in_symbol_list2170);
            	symbol50 = symbol();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol50.Tree);
            	// Smi.g:636:21: ( COMMA symbol )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == COMMA) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // Smi.g:636:22: COMMA symbol
            			    {
            			    	COMMA51=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_symbol_list2173); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA51_tree = (object)adaptor.Create(COMMA51);
            			    		adaptor.AddChild(root_0, COMMA51_tree);
            			    	}
            			    	PushFollow(FOLLOW_symbol_in_symbol_list2175);
            			    	symbol52 = symbol();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol52.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol_list"

    public class symbols_from_module_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "symbols_from_module"
    // Smi.g:638:0: symbols_from_module : symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? ;
    public SmiParser.symbols_from_module_return symbols_from_module() // throws RecognitionException [1]
    {   
        SmiParser.symbols_from_module_return retval = new SmiParser.symbols_from_module_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken FROM_KW54 = null;
        IToken UPPER55 = null;
        SmiParser.symbol_list_return symbol_list53 = default(SmiParser.symbol_list_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst56 = default(SmiParser.obj_id_comp_lst_return);

        SmiParser.defined_value_return defined_value57 = default(SmiParser.defined_value_return);


        object FROM_KW54_tree=null;
        object UPPER55_tree=null;

        try 
    	{
            // Smi.g:638:22: ( symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? )
            // Smi.g:638:22: symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_list_in_symbols_from_module2185);
            	symbol_list53 = symbol_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list53.Tree);
            	FROM_KW54=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_symbols_from_module2187); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{FROM_KW54_tree = (object)adaptor.Create(FROM_KW54);
            		adaptor.AddChild(root_0, FROM_KW54_tree);
            	}
            	UPPER55=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbols_from_module2189); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER55_tree = (object)adaptor.Create(UPPER55);
            		adaptor.AddChild(root_0, UPPER55_tree);
            	}
            	// Smi.g:639:25: ( obj_id_comp_lst |=> defined_value )?
            	int alt19 = 3;
            	alt19 = dfa19.Predict(input);
            	switch (alt19) 
            	{
            	    case 1 :
            	        // Smi.g:639:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_symbols_from_module2218);
            	        	obj_id_comp_lst56 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst56.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:640:29: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_symbols_from_module2255);
            	        	defined_value57 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value57.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbols_from_module"

    public class symbol_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "symbol"
    // Smi.g:643:0: symbol : ( UPPER | LOWER | macroName );
    public SmiParser.symbol_return symbol() // throws RecognitionException [1]
    {   
        SmiParser.symbol_return retval = new SmiParser.symbol_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UPPER58 = null;
        IToken LOWER59 = null;
        SmiParser.macroName_return macroName60 = default(SmiParser.macroName_return);


        object UPPER58_tree=null;
        object LOWER59_tree=null;

        try 
    	{
            // Smi.g:643:9: ( UPPER | LOWER | macroName )
            int alt20 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                alt20 = 1;
                }
                break;
            case LOWER:
            	{
                alt20 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt20 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            }

            switch (alt20) 
            {
                case 1 :
                    // Smi.g:643:9: UPPER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	UPPER58=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbol2291); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER58_tree = (object)adaptor.Create(UPPER58);
                    		adaptor.AddChild(root_0, UPPER58_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:643:17: LOWER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LOWER59=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_symbol2295); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER59_tree = (object)adaptor.Create(LOWER59);
                    		adaptor.AddChild(root_0, LOWER59_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:643:25: macroName
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macroName_in_symbol2299);
                    	macroName60 = macroName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName60.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol"

    public class macroName_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "macroName"
    // Smi.g:645:0: macroName : ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros );
    public SmiParser.macroName_return macroName() // throws RecognitionException [1]
    {   
        SmiParser.macroName_return retval = new SmiParser.macroName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OPERATION_KW61 = null;
        IToken ERROR_KW62 = null;
        IToken string_literal63 = null;
        IToken string_literal64 = null;
        IToken string_literal65 = null;
        IToken string_literal66 = null;
        IToken string_literal67 = null;
        IToken string_literal68 = null;
        IToken string_literal69 = null;
        IToken string_literal70 = null;
        IToken string_literal71 = null;
        IToken string_literal72 = null;
        IToken string_literal73 = null;
        IToken string_literal74 = null;
        IToken string_literal75 = null;
        IToken string_literal76 = null;
        IToken string_literal77 = null;
        IToken string_literal78 = null;
        IToken string_literal79 = null;
        IToken string_literal80 = null;
        IToken string_literal81 = null;
        IToken string_literal82 = null;
        IToken string_literal83 = null;
        IToken string_literal84 = null;
        SmiParser.smi_macros_return smi_macros85 = default(SmiParser.smi_macros_return);


        object OPERATION_KW61_tree=null;
        object ERROR_KW62_tree=null;
        object string_literal63_tree=null;
        object string_literal64_tree=null;
        object string_literal65_tree=null;
        object string_literal66_tree=null;
        object string_literal67_tree=null;
        object string_literal68_tree=null;
        object string_literal69_tree=null;
        object string_literal70_tree=null;
        object string_literal71_tree=null;
        object string_literal72_tree=null;
        object string_literal73_tree=null;
        object string_literal74_tree=null;
        object string_literal75_tree=null;
        object string_literal76_tree=null;
        object string_literal77_tree=null;
        object string_literal78_tree=null;
        object string_literal79_tree=null;
        object string_literal80_tree=null;
        object string_literal81_tree=null;
        object string_literal82_tree=null;
        object string_literal83_tree=null;
        object string_literal84_tree=null;

        try 
    	{
            // Smi.g:645:12: ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros )
            int alt21 = 25;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt21 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt21 = 2;
                }
                break;
            case 136:
            	{
                alt21 = 3;
                }
                break;
            case 192:
            	{
                alt21 = 4;
                }
                break;
            case 134:
            	{
                alt21 = 5;
                }
                break;
            case 133:
            	{
                alt21 = 6;
                }
                break;
            case 146:
            	{
                alt21 = 7;
                }
                break;
            case 148:
            	{
                alt21 = 8;
                }
                break;
            case 147:
            	{
                alt21 = 9;
                }
                break;
            case 189:
            	{
                alt21 = 10;
                }
                break;
            case 190:
            	{
                alt21 = 11;
                }
                break;
            case 181:
            	{
                alt21 = 12;
                }
                break;
            case OBJECT_KW:
            	{
                alt21 = 13;
                }
                break;
            case 174:
            	{
                alt21 = 14;
                }
                break;
            case 178:
            	{
                alt21 = 15;
                }
                break;
            case 126:
            	{
                alt21 = 16;
                }
                break;
            case 129:
            	{
                alt21 = 17;
                }
                break;
            case 128:
            	{
                alt21 = 18;
                }
                break;
            case 127:
            	{
                alt21 = 19;
                }
                break;
            case 132:
            	{
                alt21 = 20;
                }
                break;
            case 143:
            	{
                alt21 = 21;
                }
                break;
            case 183:
            	{
                alt21 = 22;
                }
                break;
            case 182:
            	{
                alt21 = 23;
                }
                break;
            case 176:
            	{
                alt21 = 24;
                }
                break;
            case 131:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 188:
            case 191:
            	{
                alt21 = 25;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // Smi.g:645:12: OPERATION_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OPERATION_KW61=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_macroName2306); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OPERATION_KW61_tree = (object)adaptor.Create(OPERATION_KW61);
                    		adaptor.AddChild(root_0, OPERATION_KW61_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:645:27: ERROR_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ERROR_KW62=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_macroName2310); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ERROR_KW62_tree = (object)adaptor.Create(ERROR_KW62);
                    		adaptor.AddChild(root_0, ERROR_KW62_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:645:39: 'BIND'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal63=(IToken)Match(input,136,FOLLOW_136_in_macroName2315); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal63_tree = (object)adaptor.Create(string_literal63);
                    		adaptor.AddChild(root_0, string_literal63_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:645:48: 'UNBIND'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal64=(IToken)Match(input,192,FOLLOW_192_in_macroName2319); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal64_tree = (object)adaptor.Create(string_literal64);
                    		adaptor.AddChild(root_0, string_literal64_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:646:12: 'APPLICATION-SERVICE-ELEMENT'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal65=(IToken)Match(input,134,FOLLOW_134_in_macroName2333); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal65_tree = (object)adaptor.Create(string_literal65);
                    		adaptor.AddChild(root_0, string_literal65_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:646:44: 'APPLICATION-CONTEXT'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal66=(IToken)Match(input,133,FOLLOW_133_in_macroName2337); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal66_tree = (object)adaptor.Create(string_literal66);
                    		adaptor.AddChild(root_0, string_literal66_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:646:68: 'EXTENSION'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal67=(IToken)Match(input,146,FOLLOW_146_in_macroName2341); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal67_tree = (object)adaptor.Create(string_literal67);
                    		adaptor.AddChild(root_0, string_literal67_tree);
                    	}

                    }
                    break;
                case 8 :
                    // Smi.g:647:12: 'EXTENSIONS'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal68=(IToken)Match(input,148,FOLLOW_148_in_macroName2355); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal68_tree = (object)adaptor.Create(string_literal68);
                    		adaptor.AddChild(root_0, string_literal68_tree);
                    	}

                    }
                    break;
                case 9 :
                    // Smi.g:647:27: 'EXTENSION-ATTRIBUTE'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal69=(IToken)Match(input,147,FOLLOW_147_in_macroName2359); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal69_tree = (object)adaptor.Create(string_literal69);
                    		adaptor.AddChild(root_0, string_literal69_tree);
                    	}

                    }
                    break;
                case 10 :
                    // Smi.g:647:51: 'TOKEN'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal70=(IToken)Match(input,189,FOLLOW_189_in_macroName2363); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal70_tree = (object)adaptor.Create(string_literal70);
                    		adaptor.AddChild(root_0, string_literal70_tree);
                    	}

                    }
                    break;
                case 11 :
                    // Smi.g:647:61: 'TOKEN-DATA'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal71=(IToken)Match(input,190,FOLLOW_190_in_macroName2367); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal71_tree = (object)adaptor.Create(string_literal71);
                    		adaptor.AddChild(root_0, string_literal71_tree);
                    	}

                    }
                    break;
                case 12 :
                    // Smi.g:648:5: 'SECURITY-CATEGORY'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal72=(IToken)Match(input,181,FOLLOW_181_in_macroName2374); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal72_tree = (object)adaptor.Create(string_literal72);
                    		adaptor.AddChild(root_0, string_literal72_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:648:27: 'OBJECT'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal73=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_macroName2378); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal73_tree = (object)adaptor.Create(string_literal73);
                    		adaptor.AddChild(root_0, string_literal73_tree);
                    	}

                    }
                    break;
                case 14 :
                    // Smi.g:648:38: 'PORT'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal74=(IToken)Match(input,174,FOLLOW_174_in_macroName2382); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal74_tree = (object)adaptor.Create(string_literal74);
                    		adaptor.AddChild(root_0, string_literal74_tree);
                    	}

                    }
                    break;
                case 15 :
                    // Smi.g:648:47: 'REFINE'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal75=(IToken)Match(input,178,FOLLOW_178_in_macroName2386); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal75_tree = (object)adaptor.Create(string_literal75);
                    		adaptor.AddChild(root_0, string_literal75_tree);
                    	}

                    }
                    break;
                case 16 :
                    // Smi.g:648:58: 'ABSTRACT-BIND'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal76=(IToken)Match(input,126,FOLLOW_126_in_macroName2390); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal76_tree = (object)adaptor.Create(string_literal76);
                    		adaptor.AddChild(root_0, string_literal76_tree);
                    	}

                    }
                    break;
                case 17 :
                    // Smi.g:649:5: 'ABSTRACT-UNBIND'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal77=(IToken)Match(input,129,FOLLOW_129_in_macroName2397); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal77_tree = (object)adaptor.Create(string_literal77);
                    		adaptor.AddChild(root_0, string_literal77_tree);
                    	}

                    }
                    break;
                case 18 :
                    // Smi.g:649:25: 'ABSTRACT-OPERATION'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal78=(IToken)Match(input,128,FOLLOW_128_in_macroName2401); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal78_tree = (object)adaptor.Create(string_literal78);
                    		adaptor.AddChild(root_0, string_literal78_tree);
                    	}

                    }
                    break;
                case 19 :
                    // Smi.g:649:48: 'ABSTRACT-ERROR'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal79=(IToken)Match(input,127,FOLLOW_127_in_macroName2405); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal79_tree = (object)adaptor.Create(string_literal79);
                    		adaptor.AddChild(root_0, string_literal79_tree);
                    	}

                    }
                    break;
                case 20 :
                    // Smi.g:650:5: 'ALGORITHM'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal80=(IToken)Match(input,132,FOLLOW_132_in_macroName2412); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal80_tree = (object)adaptor.Create(string_literal80);
                    		adaptor.AddChild(root_0, string_literal80_tree);
                    	}

                    }
                    break;
                case 21 :
                    // Smi.g:650:19: 'ENCRYPTED'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal81=(IToken)Match(input,143,FOLLOW_143_in_macroName2416); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal81_tree = (object)adaptor.Create(string_literal81);
                    		adaptor.AddChild(root_0, string_literal81_tree);
                    	}

                    }
                    break;
                case 22 :
                    // Smi.g:650:33: 'SIGNED'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal82=(IToken)Match(input,183,FOLLOW_183_in_macroName2420); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal82_tree = (object)adaptor.Create(string_literal82);
                    		adaptor.AddChild(root_0, string_literal82_tree);
                    	}

                    }
                    break;
                case 23 :
                    // Smi.g:650:44: 'SIGNATURE'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal83=(IToken)Match(input,182,FOLLOW_182_in_macroName2424); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal83_tree = (object)adaptor.Create(string_literal83);
                    		adaptor.AddChild(root_0, string_literal83_tree);
                    	}

                    }
                    break;
                case 24 :
                    // Smi.g:650:58: 'PROTECTED'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal84=(IToken)Match(input,176,FOLLOW_176_in_macroName2428); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal84_tree = (object)adaptor.Create(string_literal84);
                    		adaptor.AddChild(root_0, string_literal84_tree);
                    	}

                    }
                    break;
                case 25 :
                    // Smi.g:651:5: smi_macros
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_macros_in_macroName2435);
                    	smi_macros85 = smi_macros();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_macros85.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macroName"

    public class type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type"
    // Smi.g:653:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );
    public SmiParser.type_return type() // throws RecognitionException [1]
    {   
        SmiParser.type_return retval = new SmiParser.type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SmiParser.built_in_type_return built_in_type86 = default(SmiParser.built_in_type_return);

        SmiParser.defined_type_return defined_type87 = default(SmiParser.defined_type_return);

        SmiParser.selection_type_return selection_type88 = default(SmiParser.selection_type_return);

        SmiParser.macros_type_return macros_type89 = default(SmiParser.macros_type_return);

        SmiParser.smi_type_return smi_type90 = default(SmiParser.smi_type_return);



        try 
    	{
            // Smi.g:653:7: ( built_in_type | defined_type | selection_type | macros_type | smi_type )
            int alt22 = 5;
            alt22 = dfa22.Predict(input);
            switch (alt22) 
            {
                case 1 :
                    // Smi.g:653:7: built_in_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_built_in_type_in_type2442);
                    	built_in_type86 = built_in_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, built_in_type86.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:653:23: defined_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_type_in_type2446);
                    	defined_type87 = defined_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_type87.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:653:38: selection_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selection_type_in_type2450);
                    	selection_type88 = selection_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selection_type88.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:653:55: macros_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macros_type_in_type2454);
                    	macros_type89 = macros_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macros_type89.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:653:69: smi_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_type_in_type2458);
                    	smi_type90 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type90.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "value"
    // Smi.g:655:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );
    public SmiParser.value_return value() // throws RecognitionException [1]
    {   
        SmiParser.value_return retval = new SmiParser.value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken TRUE_KW91 = null;
        IToken FALSE_KW92 = null;
        IToken NULL_KW93 = null;
        IToken C_STRING94 = null;
        IToken PLUS_INFINITY_KW102 = null;
        IToken MINUS_INFINITY_KW103 = null;
        SmiParser.defined_value_return defined_value95 = default(SmiParser.defined_value_return);

        SmiParser.signed_number_return signed_number96 = default(SmiParser.signed_number_return);

        SmiParser.choice_value_return choice_value97 = default(SmiParser.choice_value_return);

        SmiParser.sequence_value_return sequence_value98 = default(SmiParser.sequence_value_return);

        SmiParser.sequenceof_value_return sequenceof_value99 = default(SmiParser.sequenceof_value_return);

        SmiParser.cstr_value_return cstr_value100 = default(SmiParser.cstr_value_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst101 = default(SmiParser.obj_id_comp_lst_return);


        object TRUE_KW91_tree=null;
        object FALSE_KW92_tree=null;
        object NULL_KW93_tree=null;
        object C_STRING94_tree=null;
        object PLUS_INFINITY_KW102_tree=null;
        object MINUS_INFINITY_KW103_tree=null;

        try 
    	{
            // Smi.g:655:8: (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW )
            int alt23 = 13;
            alt23 = dfa23.Predict(input);
            switch (alt23) 
            {
                case 1 :
                    // Smi.g:655:8: => TRUE_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	TRUE_KW91=(IToken)Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_value2471); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE_KW91_tree = (object)adaptor.Create(TRUE_KW91);
                    		adaptor.AddChild(root_0, TRUE_KW91_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:656:8: => FALSE_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	FALSE_KW92=(IToken)Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_value2487); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE_KW92_tree = (object)adaptor.Create(FALSE_KW92);
                    		adaptor.AddChild(root_0, FALSE_KW92_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:657:8: => NULL_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	NULL_KW93=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_value2503); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NULL_KW93_tree = (object)adaptor.Create(NULL_KW93);
                    		adaptor.AddChild(root_0, NULL_KW93_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:658:8: => C_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	C_STRING94=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_value2520); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING94_tree = (object)adaptor.Create(C_STRING94);
                    		adaptor.AddChild(root_0, C_STRING94_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:659:8: => defined_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_defined_value_in_value2536);
                    	defined_value95 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value95.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:660:8: => signed_number
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_signed_number_in_value2552);
                    	signed_number96 = signed_number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number96.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:661:8: => choice_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_choice_value_in_value2567);
                    	choice_value97 = choice_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_value97.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:662:8: => sequence_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequence_value_in_value2583);
                    	sequence_value98 = sequence_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_value98.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:663:8: => sequenceof_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequenceof_value_in_value2599);
                    	sequenceof_value99 = sequenceof_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_value99.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:664:8: => cstr_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_cstr_value_in_value2615);
                    	cstr_value100 = cstr_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cstr_value100.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:665:8: => obj_id_comp_lst
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_obj_id_comp_lst_in_value2631);
                    	obj_id_comp_lst101 = obj_id_comp_lst();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst101.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:666:8: => PLUS_INFINITY_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PLUS_INFINITY_KW102=(IToken)Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_value2647); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PLUS_INFINITY_KW102_tree = (object)adaptor.Create(PLUS_INFINITY_KW102);
                    		adaptor.AddChild(root_0, PLUS_INFINITY_KW102_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:667:8: => MINUS_INFINITY_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	MINUS_INFINITY_KW103=(IToken)Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_value2663); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{MINUS_INFINITY_KW103_tree = (object)adaptor.Create(MINUS_INFINITY_KW103);
                    		adaptor.AddChild(root_0, MINUS_INFINITY_KW103_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    public class built_in_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "built_in_type"
    // Smi.g:669:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );
    public SmiParser.built_in_type_return built_in_type() // throws RecognitionException [1]
    {   
        SmiParser.built_in_type_return retval = new SmiParser.built_in_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EMBEDDED_KW110 = null;
        IToken PDV_KW111 = null;
        SmiParser.any_type_return any_type104 = default(SmiParser.any_type_return);

        SmiParser.bit_string_type_return bit_string_type105 = default(SmiParser.bit_string_type_return);

        SmiParser.boolean_type_return boolean_type106 = default(SmiParser.boolean_type_return);

        SmiParser.character_str_type_return character_str_type107 = default(SmiParser.character_str_type_return);

        SmiParser.choice_type_return choice_type108 = default(SmiParser.choice_type_return);

        SmiParser.embedded_type_return embedded_type109 = default(SmiParser.embedded_type_return);

        SmiParser.enum_type_return enum_type112 = default(SmiParser.enum_type_return);

        SmiParser.external_type_return external_type113 = default(SmiParser.external_type_return);

        SmiParser.integer_type_return integer_type114 = default(SmiParser.integer_type_return);

        SmiParser.null_type_return null_type115 = default(SmiParser.null_type_return);

        SmiParser.object_identifier_type_return object_identifier_type116 = default(SmiParser.object_identifier_type_return);

        SmiParser.octetString_type_return octetString_type117 = default(SmiParser.octetString_type_return);

        SmiParser.real_type_return real_type118 = default(SmiParser.real_type_return);

        SmiParser.relativeOid_type_return relativeOid_type119 = default(SmiParser.relativeOid_type_return);

        SmiParser.sequence_type_return sequence_type120 = default(SmiParser.sequence_type_return);

        SmiParser.sequenceof_type_return sequenceof_type121 = default(SmiParser.sequenceof_type_return);

        SmiParser.set_type_return set_type122 = default(SmiParser.set_type_return);

        SmiParser.setof_type_return setof_type123 = default(SmiParser.setof_type_return);

        SmiParser.tagged_type_return tagged_type124 = default(SmiParser.tagged_type_return);


        object EMBEDDED_KW110_tree=null;
        object PDV_KW111_tree=null;

        try 
    	{
            // Smi.g:669:16: ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type )
            int alt24 = 19;
            alt24 = dfa24.Predict(input);
            switch (alt24) 
            {
                case 1 :
                    // Smi.g:669:16: any_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_any_type_in_built_in_type2670);
                    	any_type104 = any_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, any_type104.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:670:16: bit_string_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bit_string_type_in_built_in_type2688);
                    	bit_string_type105 = bit_string_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bit_string_type105.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:671:16: boolean_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_type_in_built_in_type2706);
                    	boolean_type106 = boolean_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolean_type106.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:672:16: character_str_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_str_type_in_built_in_type2724);
                    	character_str_type107 = character_str_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_str_type107.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:673:16: choice_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_choice_type_in_built_in_type2742);
                    	choice_type108 = choice_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_type108.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:674:16: embedded_type EMBEDDED_KW PDV_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_embedded_type_in_built_in_type2759);
                    	embedded_type109 = embedded_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, embedded_type109.Tree);
                    	EMBEDDED_KW110=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_built_in_type2761); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EMBEDDED_KW110_tree = (object)adaptor.Create(EMBEDDED_KW110);
                    		adaptor.AddChild(root_0, EMBEDDED_KW110_tree);
                    	}
                    	PDV_KW111=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_built_in_type2763); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDV_KW111_tree = (object)adaptor.Create(PDV_KW111);
                    		adaptor.AddChild(root_0, PDV_KW111_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:675:16: enum_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enum_type_in_built_in_type2781);
                    	enum_type112 = enum_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, enum_type112.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:676:16: external_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_external_type_in_built_in_type2798);
                    	external_type113 = external_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, external_type113.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:677:9: integer_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_type_in_built_in_type2808);
                    	integer_type114 = integer_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, integer_type114.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:678:9: null_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_type_in_built_in_type2818);
                    	null_type115 = null_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, null_type115.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:679:9: object_identifier_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_object_identifier_type_in_built_in_type2828);
                    	object_identifier_type116 = object_identifier_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_identifier_type116.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:680:9: octetString_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_octetString_type_in_built_in_type2838);
                    	octetString_type117 = octetString_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, octetString_type117.Tree);

                    }
                    break;
                case 13 :
                    // Smi.g:681:9: real_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_real_type_in_built_in_type2848);
                    	real_type118 = real_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, real_type118.Tree);

                    }
                    break;
                case 14 :
                    // Smi.g:682:9: relativeOid_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_relativeOid_type_in_built_in_type2858);
                    	relativeOid_type119 = relativeOid_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relativeOid_type119.Tree);

                    }
                    break;
                case 15 :
                    // Smi.g:683:9: sequence_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequence_type_in_built_in_type2868);
                    	sequence_type120 = sequence_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_type120.Tree);

                    }
                    break;
                case 16 :
                    // Smi.g:684:9: sequenceof_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequenceof_type_in_built_in_type2878);
                    	sequenceof_type121 = sequenceof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_type121.Tree);

                    }
                    break;
                case 17 :
                    // Smi.g:685:9: set_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_type_in_built_in_type2888);
                    	set_type122 = set_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, set_type122.Tree);

                    }
                    break;
                case 18 :
                    // Smi.g:686:9: setof_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setof_type_in_built_in_type2898);
                    	setof_type123 = setof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, setof_type123.Tree);

                    }
                    break;
                case 19 :
                    // Smi.g:687:9: tagged_type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tagged_type_in_built_in_type2908);
                    	tagged_type124 = tagged_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tagged_type124.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "built_in_type"

    public class defined_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "defined_type"
    // Smi.g:689:0: defined_type : ( UPPER DOT )? UPPER ( constraint )? ;
    public SmiParser.defined_type_return defined_type() // throws RecognitionException [1]
    {   
        SmiParser.defined_type_return retval = new SmiParser.defined_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken UPPER125 = null;
        IToken DOT126 = null;
        IToken UPPER127 = null;
        SmiParser.constraint_return constraint128 = default(SmiParser.constraint_return);


        object UPPER125_tree=null;
        object DOT126_tree=null;
        object UPPER127_tree=null;

        try 
    	{
            // Smi.g:689:15: ( ( UPPER DOT )? UPPER ( constraint )? )
            // Smi.g:689:15: ( UPPER DOT )? UPPER ( constraint )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:689:15: ( UPPER DOT )?
            	int alt25 = 2;
            	int LA25_0 = input.LA(1);

            	if ( (LA25_0 == UPPER) )
            	{
            	    int LA25_1 = input.LA(2);

            	    if ( (LA25_1 == DOT) )
            	    {
            	        alt25 = 1;
            	    }
            	}
            	switch (alt25) 
            	{
            	    case 1 :
            	        // Smi.g:689:16: UPPER DOT
            	        {
            	        	UPPER125=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2916); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER125_tree = (object)adaptor.Create(UPPER125);
            	        		adaptor.AddChild(root_0, UPPER125_tree);
            	        	}
            	        	DOT126=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_type2918); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT126_tree = (object)adaptor.Create(DOT126);
            	        		adaptor.AddChild(root_0, DOT126_tree);
            	        	}

            	        }
            	        break;

            	}

            	UPPER127=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2922); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER127_tree = (object)adaptor.Create(UPPER127);
            		adaptor.AddChild(root_0, UPPER127_tree);
            	}
            	// Smi.g:689:34: ( constraint )?
            	int alt26 = 2;
            	int LA26_0 = input.LA(1);

            	if ( (LA26_0 == L_PAREN) )
            	{
            	    alt26 = 1;
            	}
            	switch (alt26) 
            	{
            	    case 1 :
            	        // Smi.g:689:35: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_defined_type2925);
            	        	constraint128 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint128.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_type"

    public class selection_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "selection_type"
    // Smi.g:691:0: selection_type : LOWER LESS type ;
    public SmiParser.selection_type_return selection_type() // throws RecognitionException [1]
    {   
        SmiParser.selection_type_return retval = new SmiParser.selection_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER129 = null;
        IToken LESS130 = null;
        SmiParser.type_return type131 = default(SmiParser.type_return);


        object LOWER129_tree=null;
        object LESS130_tree=null;

        try 
    	{
            // Smi.g:691:17: ( LOWER LESS type )
            // Smi.g:691:17: LOWER LESS type
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER129=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_selection_type2935); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER129_tree = (object)adaptor.Create(LOWER129);
            		adaptor.AddChild(root_0, LOWER129_tree);
            	}
            	LESS130=(IToken)Match(input,LESS,FOLLOW_LESS_in_selection_type2937); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LESS130_tree = (object)adaptor.Create(LESS130);
            		adaptor.AddChild(root_0, LESS130_tree);
            	}
            	PushFollow(FOLLOW_type_in_selection_type2939);
            	type131 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type131.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selection_type"

    public class any_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "any_type"
    // Smi.g:693:0: any_type : ANY_KW ( DEFINED_KW BY_KW LOWER )? ;
    public SmiParser.any_type_return any_type() // throws RecognitionException [1]
    {   
        SmiParser.any_type_return retval = new SmiParser.any_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ANY_KW132 = null;
        IToken DEFINED_KW133 = null;
        IToken BY_KW134 = null;
        IToken LOWER135 = null;

        object ANY_KW132_tree=null;
        object DEFINED_KW133_tree=null;
        object BY_KW134_tree=null;
        object LOWER135_tree=null;

        try 
    	{
            // Smi.g:693:11: ( ANY_KW ( DEFINED_KW BY_KW LOWER )? )
            // Smi.g:693:11: ANY_KW ( DEFINED_KW BY_KW LOWER )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ANY_KW132=(IToken)Match(input,ANY_KW,FOLLOW_ANY_KW_in_any_type2946); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ANY_KW132_tree = (object)adaptor.Create(ANY_KW132);
            		adaptor.AddChild(root_0, ANY_KW132_tree);
            	}
            	// Smi.g:693:18: ( DEFINED_KW BY_KW LOWER )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == DEFINED_KW) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // Smi.g:693:19: DEFINED_KW BY_KW LOWER
            	        {
            	        	DEFINED_KW133=(IToken)Match(input,DEFINED_KW,FOLLOW_DEFINED_KW_in_any_type2949); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DEFINED_KW133_tree = (object)adaptor.Create(DEFINED_KW133);
            	        		adaptor.AddChild(root_0, DEFINED_KW133_tree);
            	        	}
            	        	BY_KW134=(IToken)Match(input,BY_KW,FOLLOW_BY_KW_in_any_type2951); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{BY_KW134_tree = (object)adaptor.Create(BY_KW134);
            	        		adaptor.AddChild(root_0, BY_KW134_tree);
            	        	}
            	        	LOWER135=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_any_type2953); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LOWER135_tree = (object)adaptor.Create(LOWER135);
            	        		adaptor.AddChild(root_0, LOWER135_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "any_type"

    public class bit_string_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "bit_string_type"
    // Smi.g:696:0: bit_string_type : BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? ;
    public SmiParser.bit_string_type_return bit_string_type() // throws RecognitionException [1]
    {   
        SmiParser.bit_string_type_return retval = new SmiParser.bit_string_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BIT_KW136 = null;
        IToken STRING_KW137 = null;
        SmiParser.namedNumber_list_return namedNumber_list138 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint139 = default(SmiParser.constraint_return);


        object BIT_KW136_tree=null;
        object STRING_KW137_tree=null;

        try 
    	{
            // Smi.g:696:18: ( BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? )
            // Smi.g:696:18: BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BIT_KW136=(IToken)Match(input,BIT_KW,FOLLOW_BIT_KW_in_bit_string_type2965); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BIT_KW136_tree = (object)adaptor.Create(BIT_KW136);
            		adaptor.AddChild(root_0, BIT_KW136_tree);
            	}
            	STRING_KW137=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_bit_string_type2967); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW137_tree = (object)adaptor.Create(STRING_KW137);
            		adaptor.AddChild(root_0, STRING_KW137_tree);
            	}
            	// Smi.g:696:35: (=> namedNumber_list )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == L_BRACE) && (synpred16_Smi()) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // Smi.g:696:36: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_bit_string_type2978);
            	        	namedNumber_list138 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list138.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:696:80: ( constraint )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == L_PAREN) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // Smi.g:696:81: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_bit_string_type2983);
            	        	constraint139 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint139.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bit_string_type"

    public class boolean_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "boolean_type"
    // Smi.g:699:0: boolean_type : BOOLEAN_KW ;
    public SmiParser.boolean_type_return boolean_type() // throws RecognitionException [1]
    {   
        SmiParser.boolean_type_return retval = new SmiParser.boolean_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken BOOLEAN_KW140 = null;

        object BOOLEAN_KW140_tree=null;

        try 
    	{
            // Smi.g:699:15: ( BOOLEAN_KW )
            // Smi.g:699:15: BOOLEAN_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	BOOLEAN_KW140=(IToken)Match(input,BOOLEAN_KW,FOLLOW_BOOLEAN_KW_in_boolean_type2994); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BOOLEAN_KW140_tree = (object)adaptor.Create(BOOLEAN_KW140);
            		adaptor.AddChild(root_0, BOOLEAN_KW140_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolean_type"

    public class character_str_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "character_str_type"
    // Smi.g:701:0: character_str_type : ( CHARACTER_KW STRING_KW | character_set ( constraint )? );
    public SmiParser.character_str_type_return character_str_type() // throws RecognitionException [1]
    {   
        SmiParser.character_str_type_return retval = new SmiParser.character_str_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CHARACTER_KW141 = null;
        IToken STRING_KW142 = null;
        SmiParser.character_set_return character_set143 = default(SmiParser.character_set_return);

        SmiParser.constraint_return constraint144 = default(SmiParser.constraint_return);


        object CHARACTER_KW141_tree=null;
        object STRING_KW142_tree=null;

        try 
    	{
            // Smi.g:701:21: ( CHARACTER_KW STRING_KW | character_set ( constraint )? )
            int alt31 = 2;
            int LA31_0 = input.LA(1);

            if ( (LA31_0 == CHARACTER_KW) )
            {
                alt31 = 1;
            }
            else if ( (LA31_0 == BMP_STR_KW || (LA31_0 >= GENERAL_STR_KW && LA31_0 <= GRAPHIC_STR_KW) || LA31_0 == IA5_STRING_KW || LA31_0 == ISO646_STR_KW || LA31_0 == NUMERIC_STR_KW || LA31_0 == PRINTABLE_STR_KW || LA31_0 == T61_STR_KW || LA31_0 == TELETEX_STR_KW || LA31_0 == UNIVERSAL_STR_KW || (LA31_0 >= UTC_TIME_KW && LA31_0 <= VISIBLE_STR_KW)) )
            {
                alt31 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d31s0 =
                    new NoViableAltException("", 31, 0, input);

                throw nvae_d31s0;
            }
            switch (alt31) 
            {
                case 1 :
                    // Smi.g:701:21: CHARACTER_KW STRING_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	CHARACTER_KW141=(IToken)Match(input,CHARACTER_KW,FOLLOW_CHARACTER_KW_in_character_str_type3001); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHARACTER_KW141_tree = (object)adaptor.Create(CHARACTER_KW141);
                    		adaptor.AddChild(root_0, CHARACTER_KW141_tree);
                    	}
                    	STRING_KW142=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_character_str_type3003); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW142_tree = (object)adaptor.Create(STRING_KW142);
                    		adaptor.AddChild(root_0, STRING_KW142_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:701:46: character_set ( constraint )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_set_in_character_str_type3007);
                    	character_set143 = character_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_set143.Tree);
                    	// Smi.g:701:60: ( constraint )?
                    	int alt30 = 2;
                    	int LA30_0 = input.LA(1);

                    	if ( (LA30_0 == L_PAREN) )
                    	{
                    	    alt30 = 1;
                    	}
                    	switch (alt30) 
                    	{
                    	    case 1 :
                    	        // Smi.g:701:61: constraint
                    	        {
                    	        	PushFollow(FOLLOW_constraint_in_character_str_type3010);
                    	        	constraint144 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint144.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_str_type"

    public class choice_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "choice_type"
    // Smi.g:703:0: choice_type : CHOICE_KW L_BRACE elementType_list R_BRACE ;
    public SmiParser.choice_type_return choice_type() // throws RecognitionException [1]
    {   
        SmiParser.choice_type_return retval = new SmiParser.choice_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken CHOICE_KW145 = null;
        IToken L_BRACE146 = null;
        IToken R_BRACE148 = null;
        SmiParser.elementType_list_return elementType_list147 = default(SmiParser.elementType_list_return);


        object CHOICE_KW145_tree=null;
        object L_BRACE146_tree=null;
        object R_BRACE148_tree=null;

        try 
    	{
            // Smi.g:703:14: ( CHOICE_KW L_BRACE elementType_list R_BRACE )
            // Smi.g:703:14: CHOICE_KW L_BRACE elementType_list R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	CHOICE_KW145=(IToken)Match(input,CHOICE_KW,FOLLOW_CHOICE_KW_in_choice_type3020); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{CHOICE_KW145_tree = (object)adaptor.Create(CHOICE_KW145);
            		adaptor.AddChild(root_0, CHOICE_KW145_tree);
            	}
            	L_BRACE146=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_choice_type3022); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE146_tree = (object)adaptor.Create(L_BRACE146);
            		adaptor.AddChild(root_0, L_BRACE146_tree);
            	}
            	PushFollow(FOLLOW_elementType_list_in_choice_type3024);
            	elementType_list147 = elementType_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list147.Tree);
            	R_BRACE148=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_choice_type3026); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE148_tree = (object)adaptor.Create(R_BRACE148);
            		adaptor.AddChild(root_0, R_BRACE148_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_type"

    public class embedded_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "embedded_type"
    // Smi.g:705:0: embedded_type : EMBEDDED_KW PDV_KW ;
    public SmiParser.embedded_type_return embedded_type() // throws RecognitionException [1]
    {   
        SmiParser.embedded_type_return retval = new SmiParser.embedded_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EMBEDDED_KW149 = null;
        IToken PDV_KW150 = null;

        object EMBEDDED_KW149_tree=null;
        object PDV_KW150_tree=null;

        try 
    	{
            // Smi.g:705:16: ( EMBEDDED_KW PDV_KW )
            // Smi.g:705:16: EMBEDDED_KW PDV_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	EMBEDDED_KW149=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_embedded_type3033); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EMBEDDED_KW149_tree = (object)adaptor.Create(EMBEDDED_KW149);
            		adaptor.AddChild(root_0, EMBEDDED_KW149_tree);
            	}
            	PDV_KW150=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_embedded_type3035); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{PDV_KW150_tree = (object)adaptor.Create(PDV_KW150);
            		adaptor.AddChild(root_0, PDV_KW150_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "embedded_type"

    public class enum_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "enum_type"
    // Smi.g:707:0: enum_type : ENUMERATED_KW namedNumber_list ;
    public SmiParser.enum_type_return enum_type() // throws RecognitionException [1]
    {   
        SmiParser.enum_type_return retval = new SmiParser.enum_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ENUMERATED_KW151 = null;
        SmiParser.namedNumber_list_return namedNumber_list152 = default(SmiParser.namedNumber_list_return);


        object ENUMERATED_KW151_tree=null;

        try 
    	{
            // Smi.g:707:12: ( ENUMERATED_KW namedNumber_list )
            // Smi.g:707:12: ENUMERATED_KW namedNumber_list
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ENUMERATED_KW151=(IToken)Match(input,ENUMERATED_KW,FOLLOW_ENUMERATED_KW_in_enum_type3042); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ENUMERATED_KW151_tree = (object)adaptor.Create(ENUMERATED_KW151);
            		adaptor.AddChild(root_0, ENUMERATED_KW151_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_list_in_enum_type3044);
            	namedNumber_list152 = namedNumber_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list152.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_type"

    public class external_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "external_type"
    // Smi.g:709:0: external_type : EXTERNAL_KW ;
    public SmiParser.external_type_return external_type() // throws RecognitionException [1]
    {   
        SmiParser.external_type_return retval = new SmiParser.external_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EXTERNAL_KW153 = null;

        object EXTERNAL_KW153_tree=null;

        try 
    	{
            // Smi.g:709:16: ( EXTERNAL_KW )
            // Smi.g:709:16: EXTERNAL_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	EXTERNAL_KW153=(IToken)Match(input,EXTERNAL_KW,FOLLOW_EXTERNAL_KW_in_external_type3051); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXTERNAL_KW153_tree = (object)adaptor.Create(EXTERNAL_KW153);
            		adaptor.AddChild(root_0, EXTERNAL_KW153_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "external_type"

    public class integer_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "integer_type"
    // Smi.g:712:0: integer_type : INTEGER_KW (=> namedNumber_list | constraint )? ;
    public SmiParser.integer_type_return integer_type() // throws RecognitionException [1]
    {   
        SmiParser.integer_type_return retval = new SmiParser.integer_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken INTEGER_KW154 = null;
        SmiParser.namedNumber_list_return namedNumber_list155 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint156 = default(SmiParser.constraint_return);


        object INTEGER_KW154_tree=null;

        try 
    	{
            // Smi.g:712:15: ( INTEGER_KW (=> namedNumber_list | constraint )? )
            // Smi.g:712:15: INTEGER_KW (=> namedNumber_list | constraint )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	INTEGER_KW154=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_integer_type3060); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INTEGER_KW154_tree = (object)adaptor.Create(INTEGER_KW154);
            		adaptor.AddChild(root_0, INTEGER_KW154_tree);
            	}
            	// Smi.g:712:26: (=> namedNumber_list | constraint )?
            	int alt32 = 3;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == L_BRACE) && (synpred17_Smi()) )
            	{
            	    alt32 = 1;
            	}
            	else if ( (LA32_0 == L_PAREN) )
            	{
            	    alt32 = 2;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // Smi.g:712:27: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_integer_type3071);
            	        	namedNumber_list155 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list155.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:712:71: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_integer_type3075);
            	        	constraint156 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint156.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "integer_type"

    public class null_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "null_type"
    // Smi.g:715:0: null_type : NULL_KW ;
    public SmiParser.null_type_return null_type() // throws RecognitionException [1]
    {   
        SmiParser.null_type_return retval = new SmiParser.null_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NULL_KW157 = null;

        object NULL_KW157_tree=null;

        try 
    	{
            // Smi.g:715:12: ( NULL_KW )
            // Smi.g:715:12: NULL_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	NULL_KW157=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_null_type3086); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NULL_KW157_tree = (object)adaptor.Create(NULL_KW157);
            		adaptor.AddChild(root_0, NULL_KW157_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "null_type"

    public class object_identifier_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "object_identifier_type"
    // Smi.g:717:0: object_identifier_type : OBJECT_KW IDENTIFIER_KW ;
    public SmiParser.object_identifier_type_return object_identifier_type() // throws RecognitionException [1]
    {   
        SmiParser.object_identifier_type_return retval = new SmiParser.object_identifier_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OBJECT_KW158 = null;
        IToken IDENTIFIER_KW159 = null;

        object OBJECT_KW158_tree=null;
        object IDENTIFIER_KW159_tree=null;

        try 
    	{
            // Smi.g:717:25: ( OBJECT_KW IDENTIFIER_KW )
            // Smi.g:717:25: OBJECT_KW IDENTIFIER_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	OBJECT_KW158=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_object_identifier_type3093); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OBJECT_KW158_tree = (object)adaptor.Create(OBJECT_KW158);
            		adaptor.AddChild(root_0, OBJECT_KW158_tree);
            	}
            	IDENTIFIER_KW159=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_object_identifier_type3095); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENTIFIER_KW159_tree = (object)adaptor.Create(IDENTIFIER_KW159);
            		adaptor.AddChild(root_0, IDENTIFIER_KW159_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "object_identifier_type"

    public class octetString_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "octetString_type"
    // Smi.g:719:0: octetString_type : OCTET_KW STRING_KW ( constraint )? ;
    public SmiParser.octetString_type_return octetString_type() // throws RecognitionException [1]
    {   
        SmiParser.octetString_type_return retval = new SmiParser.octetString_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken OCTET_KW160 = null;
        IToken STRING_KW161 = null;
        SmiParser.constraint_return constraint162 = default(SmiParser.constraint_return);


        object OCTET_KW160_tree=null;
        object STRING_KW161_tree=null;

        try 
    	{
            // Smi.g:719:19: ( OCTET_KW STRING_KW ( constraint )? )
            // Smi.g:719:19: OCTET_KW STRING_KW ( constraint )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	OCTET_KW160=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_octetString_type3102); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OCTET_KW160_tree = (object)adaptor.Create(OCTET_KW160);
            		adaptor.AddChild(root_0, OCTET_KW160_tree);
            	}
            	STRING_KW161=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_octetString_type3104); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW161_tree = (object)adaptor.Create(STRING_KW161);
            		adaptor.AddChild(root_0, STRING_KW161_tree);
            	}
            	// Smi.g:719:38: ( constraint )?
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == L_PAREN) )
            	{
            	    alt33 = 1;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // Smi.g:719:39: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_octetString_type3107);
            	        	constraint162 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint162.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "octetString_type"

    public class real_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "real_type"
    // Smi.g:721:0: real_type : REAL_KW ;
    public SmiParser.real_type_return real_type() // throws RecognitionException [1]
    {   
        SmiParser.real_type_return retval = new SmiParser.real_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken REAL_KW163 = null;

        object REAL_KW163_tree=null;

        try 
    	{
            // Smi.g:721:12: ( REAL_KW )
            // Smi.g:721:12: REAL_KW
            {
            	root_0 = (object)adaptor.GetNilNode();

            	REAL_KW163=(IToken)Match(input,REAL_KW,FOLLOW_REAL_KW_in_real_type3117); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{REAL_KW163_tree = (object)adaptor.Create(REAL_KW163);
            		adaptor.AddChild(root_0, REAL_KW163_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "real_type"

    public class relativeOid_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relativeOid_type"
    // Smi.g:724:0: relativeOid_type : 'RELATIVE-OID' ;
    public SmiParser.relativeOid_type_return relativeOid_type() // throws RecognitionException [1]
    {   
        SmiParser.relativeOid_type_return retval = new SmiParser.relativeOid_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal164 = null;

        object string_literal164_tree=null;

        try 
    	{
            // Smi.g:724:19: ( 'RELATIVE-OID' )
            // Smi.g:724:19: 'RELATIVE-OID'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal164=(IToken)Match(input,179,FOLLOW_179_in_relativeOid_type3126); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal164_tree = (object)adaptor.Create(string_literal164);
            		adaptor.AddChild(root_0, string_literal164_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relativeOid_type"

    public class sequence_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sequence_type"
    // Smi.g:727:0: sequence_type : SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.sequence_type_return sequence_type() // throws RecognitionException [1]
    {   
        SmiParser.sequence_type_return retval = new SmiParser.sequence_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEQUENCE_KW165 = null;
        IToken L_BRACE166 = null;
        IToken R_BRACE168 = null;
        SmiParser.elementType_list_return elementType_list167 = default(SmiParser.elementType_list_return);


        object SEQUENCE_KW165_tree=null;
        object L_BRACE166_tree=null;
        object R_BRACE168_tree=null;

        try 
    	{
            // Smi.g:727:16: ( SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:727:16: SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SEQUENCE_KW165=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequence_type3134); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW165_tree = (object)adaptor.Create(SEQUENCE_KW165);
            		adaptor.AddChild(root_0, SEQUENCE_KW165_tree);
            	}
            	L_BRACE166=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_type3136); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE166_tree = (object)adaptor.Create(L_BRACE166);
            		adaptor.AddChild(root_0, L_BRACE166_tree);
            	}
            	// Smi.g:727:36: ( elementType_list )?
            	int alt34 = 2;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == COMPONENTS_KW || LA34_0 == LOWER) )
            	{
            	    alt34 = 1;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // Smi.g:727:37: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_sequence_type3139);
            	        	elementType_list167 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list167.Tree);

            	        }
            	        break;

            	}

            	R_BRACE168=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_type3143); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE168_tree = (object)adaptor.Create(R_BRACE168);
            		adaptor.AddChild(root_0, R_BRACE168_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_type"

    public class sequenceof_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sequenceof_type"
    // Smi.g:729:0: sequenceof_type : SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.sequenceof_type_return sequenceof_type() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_type_return retval = new SmiParser.sequenceof_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SEQUENCE_KW169 = null;
        IToken SIZE_KW170 = null;
        IToken OF_KW172 = null;
        SmiParser.constraint_return constraint171 = default(SmiParser.constraint_return);

        SmiParser.type_return type173 = default(SmiParser.type_return);


        object SEQUENCE_KW169_tree=null;
        object SIZE_KW170_tree=null;
        object OF_KW172_tree=null;

        try 
    	{
            // Smi.g:729:18: ( SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:729:18: SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SEQUENCE_KW169=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequenceof_type3151); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW169_tree = (object)adaptor.Create(SEQUENCE_KW169);
            		adaptor.AddChild(root_0, SEQUENCE_KW169_tree);
            	}
            	// Smi.g:729:30: ( SIZE_KW constraint )?
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == SIZE_KW) )
            	{
            	    alt35 = 1;
            	}
            	switch (alt35) 
            	{
            	    case 1 :
            	        // Smi.g:729:31: SIZE_KW constraint
            	        {
            	        	SIZE_KW170=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_sequenceof_type3154); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW170_tree = (object)adaptor.Create(SIZE_KW170);
            	        		adaptor.AddChild(root_0, SIZE_KW170_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_sequenceof_type3156);
            	        	constraint171 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint171.Tree);

            	        }
            	        break;

            	}

            	OF_KW172=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_sequenceof_type3160); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW172_tree = (object)adaptor.Create(OF_KW172);
            		adaptor.AddChild(root_0, OF_KW172_tree);
            	}
            	PushFollow(FOLLOW_type_in_sequenceof_type3162);
            	type173 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type173.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_type"

    public class set_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "set_type"
    // Smi.g:731:0: set_type : SET_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.set_type_return set_type() // throws RecognitionException [1]
    {   
        SmiParser.set_type_return retval = new SmiParser.set_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SET_KW174 = null;
        IToken L_BRACE175 = null;
        IToken R_BRACE177 = null;
        SmiParser.elementType_list_return elementType_list176 = default(SmiParser.elementType_list_return);


        object SET_KW174_tree=null;
        object L_BRACE175_tree=null;
        object R_BRACE177_tree=null;

        try 
    	{
            // Smi.g:731:11: ( SET_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:731:11: SET_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SET_KW174=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_set_type3169); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW174_tree = (object)adaptor.Create(SET_KW174);
            		adaptor.AddChild(root_0, SET_KW174_tree);
            	}
            	L_BRACE175=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_set_type3171); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE175_tree = (object)adaptor.Create(L_BRACE175);
            		adaptor.AddChild(root_0, L_BRACE175_tree);
            	}
            	// Smi.g:731:26: ( elementType_list )?
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == COMPONENTS_KW || LA36_0 == LOWER) )
            	{
            	    alt36 = 1;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // Smi.g:731:27: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_set_type3174);
            	        	elementType_list176 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list176.Tree);

            	        }
            	        break;

            	}

            	R_BRACE177=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_set_type3178); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE177_tree = (object)adaptor.Create(R_BRACE177);
            		adaptor.AddChild(root_0, R_BRACE177_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "set_type"

    public class setof_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "setof_type"
    // Smi.g:733:0: setof_type : SET_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.setof_type_return setof_type() // throws RecognitionException [1]
    {   
        SmiParser.setof_type_return retval = new SmiParser.setof_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SET_KW178 = null;
        IToken SIZE_KW179 = null;
        IToken OF_KW181 = null;
        SmiParser.constraint_return constraint180 = default(SmiParser.constraint_return);

        SmiParser.type_return type182 = default(SmiParser.type_return);


        object SET_KW178_tree=null;
        object SIZE_KW179_tree=null;
        object OF_KW181_tree=null;

        try 
    	{
            // Smi.g:733:13: ( SET_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:733:13: SET_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (object)adaptor.GetNilNode();

            	SET_KW178=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_setof_type3185); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW178_tree = (object)adaptor.Create(SET_KW178);
            		adaptor.AddChild(root_0, SET_KW178_tree);
            	}
            	// Smi.g:733:20: ( SIZE_KW constraint )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == SIZE_KW) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // Smi.g:733:21: SIZE_KW constraint
            	        {
            	        	SIZE_KW179=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_setof_type3188); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW179_tree = (object)adaptor.Create(SIZE_KW179);
            	        		adaptor.AddChild(root_0, SIZE_KW179_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_setof_type3190);
            	        	constraint180 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint180.Tree);

            	        }
            	        break;

            	}

            	OF_KW181=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_setof_type3194); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW181_tree = (object)adaptor.Create(OF_KW181);
            		adaptor.AddChild(root_0, OF_KW181_tree);
            	}
            	PushFollow(FOLLOW_type_in_setof_type3196);
            	type182 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type182.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setof_type"

    public class tagged_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tagged_type"
    // Smi.g:735:0: tagged_type : tag ( tag_default )? type ;
    public SmiParser.tagged_type_return tagged_type() // throws RecognitionException [1]
    {   
        SmiParser.tagged_type_return retval = new SmiParser.tagged_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SmiParser.tag_return tag183 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default184 = default(SmiParser.tag_default_return);

        SmiParser.type_return type185 = default(SmiParser.type_return);



        try 
    	{
            // Smi.g:735:14: ( tag ( tag_default )? type )
            // Smi.g:735:14: tag ( tag_default )? type
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tag_in_tagged_type3203);
            	tag183 = tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag183.Tree);
            	// Smi.g:735:18: ( tag_default )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == AUTOMATIC_KW || LA38_0 == EXPLICIT_KW || LA38_0 == IMPLICIT_KW) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // Smi.g:735:19: tag_default
            	        {
            	        	PushFollow(FOLLOW_tag_default_in_tagged_type3206);
            	        	tag_default184 = tag_default();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default184.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_type_in_tagged_type3210);
            	type185 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type185.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tagged_type"

    public class namedNumber_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "namedNumber_list"
    // Smi.g:737:0: namedNumber_list : L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE ;
    public SmiParser.namedNumber_list_return namedNumber_list() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_list_return retval = new SmiParser.namedNumber_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE186 = null;
        IToken COMMA188 = null;
        IToken R_BRACE190 = null;
        SmiParser.namedNumber_return namedNumber187 = default(SmiParser.namedNumber_return);

        SmiParser.namedNumber_return namedNumber189 = default(SmiParser.namedNumber_return);


        object L_BRACE186_tree=null;
        object COMMA188_tree=null;
        object R_BRACE190_tree=null;

        try 
    	{
            // Smi.g:737:19: ( L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE )
            // Smi.g:737:19: L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE186=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_namedNumber_list3217); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE186_tree = (object)adaptor.Create(L_BRACE186);
            		adaptor.AddChild(root_0, L_BRACE186_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3219);
            	namedNumber187 = namedNumber();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber187.Tree);
            	// Smi.g:737:39: ( COMMA namedNumber )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == COMMA) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // Smi.g:737:40: COMMA namedNumber
            			    {
            			    	COMMA188=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_namedNumber_list3222); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA188_tree = (object)adaptor.Create(COMMA188);
            			    		adaptor.AddChild(root_0, COMMA188_tree);
            			    	}
            			    	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3224);
            			    	namedNumber189 = namedNumber();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber189.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements

            	R_BRACE190=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_namedNumber_list3228); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE190_tree = (object)adaptor.Create(R_BRACE190);
            		adaptor.AddChild(root_0, R_BRACE190_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber_list"

    public class constraint_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "constraint"
    // Smi.g:739:0: constraint : L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN ;
    public SmiParser.constraint_return constraint() // throws RecognitionException [1]
    {   
        SmiParser.constraint_return retval = new SmiParser.constraint_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_PAREN191 = null;
        IToken R_PAREN194 = null;
        SmiParser.element_set_specs_return element_set_specs192 = default(SmiParser.element_set_specs_return);

        SmiParser.exception_spec_return exception_spec193 = default(SmiParser.exception_spec_return);


        object L_PAREN191_tree=null;
        object R_PAREN194_tree=null;

        try 
    	{
            // Smi.g:739:13: ( L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN )
            // Smi.g:739:13: L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_PAREN191=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint3235); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN191_tree = (object)adaptor.Create(L_PAREN191);
            		adaptor.AddChild(root_0, L_PAREN191_tree);
            	}
            	// Smi.g:739:21: ( element_set_specs )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( ((LA40_0 >= ALL_KW && LA40_0 <= ANY_KW) || LA40_0 == B_STRING || (LA40_0 >= BIT_KW && LA40_0 <= BOOLEAN_KW) || (LA40_0 >= C_STRING && LA40_0 <= CHARACTER_KW) || LA40_0 == CHOICE_KW || LA40_0 == EMBEDDED_KW || (LA40_0 >= ENUMERATED_KW && LA40_0 <= ERROR_KW) || (LA40_0 >= EXTERNAL_KW && LA40_0 <= H_STRING) || LA40_0 == IA5_STRING_KW || LA40_0 == INCLUDES_KW || LA40_0 == INTEGER_KW || (LA40_0 >= ISO646_STR_KW && LA40_0 <= L_PAREN) || LA40_0 == LOWER || (LA40_0 >= MIN_KW && LA40_0 <= NUMERIC_STR_KW) || (LA40_0 >= OBJECT_KW && LA40_0 <= OCTET_KW) || LA40_0 == OPERATION_KW || LA40_0 == PATTERN_KW || LA40_0 == PLUS_INFINITY_KW || LA40_0 == PRINTABLE_STR_KW || LA40_0 == REAL_KW || (LA40_0 >= SEQUENCE_KW && LA40_0 <= SET_KW) || LA40_0 == SIZE_KW || LA40_0 == T61_STR_KW || (LA40_0 >= TELETEX_STR_KW && LA40_0 <= TRUE_KW) || (LA40_0 >= UNIVERSAL_STR_KW && LA40_0 <= WITH_KW) || LA40_0 == 131 || LA40_0 == 137 || (LA40_0 >= 158 && LA40_0 <= 160) || (LA40_0 >= 162 && LA40_0 <= 164) || LA40_0 == 166 || LA40_0 == 179 || LA40_0 == 188 || LA40_0 == 191) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // Smi.g:739:22: element_set_specs
            	        {
            	        	PushFollow(FOLLOW_element_set_specs_in_constraint3238);
            	        	element_set_specs192 = element_set_specs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_specs192.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:739:42: ( exception_spec )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( (LA41_0 == EXCLAMATION) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // Smi.g:739:43: exception_spec
            	        {
            	        	PushFollow(FOLLOW_exception_spec_in_constraint3243);
            	        	exception_spec193 = exception_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exception_spec193.Tree);

            	        }
            	        break;

            	}

            	R_PAREN194=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint3247); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN194_tree = (object)adaptor.Create(R_PAREN194);
            		adaptor.AddChild(root_0, R_PAREN194_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint"

    public class character_set_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "character_set"
    // Smi.g:741:0: character_set : ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW );
    public SmiParser.character_set_return character_set() // throws RecognitionException [1]
    {   
        SmiParser.character_set_return retval = new SmiParser.character_set_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set195 = null;

        object set195_tree=null;

        try 
    	{
            // Smi.g:741:16: ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW )
            // Smi.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set195 = (IToken)input.LT(1);
            	if ( input.LA(1) == BMP_STR_KW || (input.LA(1) >= GENERAL_STR_KW && input.LA(1) <= GRAPHIC_STR_KW) || input.LA(1) == IA5_STRING_KW || input.LA(1) == ISO646_STR_KW || input.LA(1) == NUMERIC_STR_KW || input.LA(1) == PRINTABLE_STR_KW || input.LA(1) == T61_STR_KW || input.LA(1) == TELETEX_STR_KW || input.LA(1) == UNIVERSAL_STR_KW || (input.LA(1) >= UTC_TIME_KW && input.LA(1) <= VISIBLE_STR_KW) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set195));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_set"

    public class elementType_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elementType_list"
    // Smi.g:746:0: elementType_list : elementType ( COMMA elementType )* ;
    public SmiParser.elementType_list_return elementType_list() // throws RecognitionException [1]
    {   
        SmiParser.elementType_list_return retval = new SmiParser.elementType_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA197 = null;
        SmiParser.elementType_return elementType196 = default(SmiParser.elementType_return);

        SmiParser.elementType_return elementType198 = default(SmiParser.elementType_return);


        object COMMA197_tree=null;

        try 
    	{
            // Smi.g:746:19: ( elementType ( COMMA elementType )* )
            // Smi.g:746:19: elementType ( COMMA elementType )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_elementType_in_elementType_list3356);
            	elementType196 = elementType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType196.Tree);
            	// Smi.g:746:31: ( COMMA elementType )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == COMMA) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // Smi.g:746:32: COMMA elementType
            			    {
            			    	COMMA197=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_elementType_list3359); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA197_tree = (object)adaptor.Create(COMMA197);
            			    		adaptor.AddChild(root_0, COMMA197_tree);
            			    	}
            			    	PushFollow(FOLLOW_elementType_in_elementType_list3361);
            			    	elementType198 = elementType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType198.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType_list"

    public class tag_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tag"
    // Smi.g:748:0: tag : L_BRACKET ( clazz )? class_NUMBER R_BRACKET ;
    public SmiParser.tag_return tag() // throws RecognitionException [1]
    {   
        SmiParser.tag_return retval = new SmiParser.tag_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACKET199 = null;
        IToken R_BRACKET202 = null;
        SmiParser.clazz_return clazz200 = default(SmiParser.clazz_return);

        SmiParser.class_NUMBER_return class_NUMBER201 = default(SmiParser.class_NUMBER_return);


        object L_BRACKET199_tree=null;
        object R_BRACKET202_tree=null;

        try 
    	{
            // Smi.g:748:6: ( L_BRACKET ( clazz )? class_NUMBER R_BRACKET )
            // Smi.g:748:6: L_BRACKET ( clazz )? class_NUMBER R_BRACKET
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACKET199=(IToken)Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_tag3371); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACKET199_tree = (object)adaptor.Create(L_BRACKET199);
            		adaptor.AddChild(root_0, L_BRACKET199_tree);
            	}
            	// Smi.g:748:16: ( clazz )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == APPLICATION_KW || LA43_0 == PRIVATE_KW || LA43_0 == UNIVERSAL_KW) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // Smi.g:748:17: clazz
            	        {
            	        	PushFollow(FOLLOW_clazz_in_tag3374);
            	        	clazz200 = clazz();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, clazz200.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_class_NUMBER_in_tag3378);
            	class_NUMBER201 = class_NUMBER();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_NUMBER201.Tree);
            	R_BRACKET202=(IToken)Match(input,R_BRACKET,FOLLOW_R_BRACKET_in_tag3380); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACKET202_tree = (object)adaptor.Create(R_BRACKET202);
            		adaptor.AddChild(root_0, R_BRACKET202_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag"

    public class clazz_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "clazz"
    // Smi.g:750:0: clazz : ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW );
    public SmiParser.clazz_return clazz() // throws RecognitionException [1]
    {   
        SmiParser.clazz_return retval = new SmiParser.clazz_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set203 = null;

        object set203_tree=null;

        try 
    	{
            // Smi.g:750:8: ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW )
            // Smi.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set203 = (IToken)input.LT(1);
            	if ( input.LA(1) == APPLICATION_KW || input.LA(1) == PRIVATE_KW || input.LA(1) == UNIVERSAL_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set203));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "clazz"

    public class class_NUMBER_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "class_NUMBER"
    // Smi.g:753:0: class_NUMBER : ( NUMBER | defined_value );
    public SmiParser.class_NUMBER_return class_NUMBER() // throws RecognitionException [1]
    {   
        SmiParser.class_NUMBER_return retval = new SmiParser.class_NUMBER_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken NUMBER204 = null;
        SmiParser.defined_value_return defined_value205 = default(SmiParser.defined_value_return);


        object NUMBER204_tree=null;

        try 
    	{
            // Smi.g:753:15: ( NUMBER | defined_value )
            int alt44 = 2;
            int LA44_0 = input.LA(1);

            if ( (LA44_0 == NUMBER) )
            {
                alt44 = 1;
            }
            else if ( (LA44_0 == LOWER || LA44_0 == UPPER) )
            {
                alt44 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d44s0 =
                    new NoViableAltException("", 44, 0, input);

                throw nvae_d44s0;
            }
            switch (alt44) 
            {
                case 1 :
                    // Smi.g:753:15: NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	NUMBER204=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_class_NUMBER3404); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER204_tree = (object)adaptor.Create(NUMBER204);
                    		adaptor.AddChild(root_0, NUMBER204_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:753:24: defined_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_class_NUMBER3408);
                    	defined_value205 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value205.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_NUMBER"

    public class operation_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "operation_macro"
    // Smi.g:756:0: operation_macro : 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? ;
    public SmiParser.operation_macro_return operation_macro() // throws RecognitionException [1]
    {   
        SmiParser.operation_macro_return retval = new SmiParser.operation_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal206 = null;
        IToken ARGUMENT_KW207 = null;
        IToken LOWER208 = null;
        IToken RESULT_KW210 = null;
        IToken LOWER211 = null;
        IToken ERRORS_KW213 = null;
        IToken L_BRACE214 = null;
        IToken R_BRACE216 = null;
        IToken LINKED_KW217 = null;
        IToken L_BRACE218 = null;
        IToken R_BRACE220 = null;
        SmiParser.type_return type209 = default(SmiParser.type_return);

        SmiParser.type_return type212 = default(SmiParser.type_return);

        SmiParser.operation_errorlist_return operation_errorlist215 = default(SmiParser.operation_errorlist_return);

        SmiParser.linkedOp_list_return linkedOp_list219 = default(SmiParser.linkedOp_list_return);


        object string_literal206_tree=null;
        object ARGUMENT_KW207_tree=null;
        object LOWER208_tree=null;
        object RESULT_KW210_tree=null;
        object LOWER211_tree=null;
        object ERRORS_KW213_tree=null;
        object L_BRACE214_tree=null;
        object R_BRACE216_tree=null;
        object LINKED_KW217_tree=null;
        object L_BRACE218_tree=null;
        object R_BRACE220_tree=null;

        try 
    	{
            // Smi.g:756:18: ( 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? )
            // Smi.g:756:18: 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal206=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_operation_macro3417); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal206_tree = (object)adaptor.Create(string_literal206);
            		adaptor.AddChild(root_0, string_literal206_tree);
            	}
            	// Smi.g:756:30: ( ARGUMENT_KW (=> LOWER )? type )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == ARGUMENT_KW) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // Smi.g:756:31: ARGUMENT_KW (=> LOWER )? type
            	        {
            	        	ARGUMENT_KW207=(IToken)Match(input,ARGUMENT_KW,FOLLOW_ARGUMENT_KW_in_operation_macro3420); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ARGUMENT_KW207_tree = (object)adaptor.Create(ARGUMENT_KW207);
            	        		adaptor.AddChild(root_0, ARGUMENT_KW207_tree);
            	        	}
            	        	// Smi.g:756:43: (=> LOWER )?
            	        	int alt45 = 2;
            	        	alt45 = dfa45.Predict(input);
            	        	switch (alt45) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:756:44: => LOWER
            	        	        {

            	        	        	LOWER208=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3429); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER208_tree = (object)adaptor.Create(LOWER208);
            	        	        		adaptor.AddChild(root_0, LOWER208_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_operation_macro3433);
            	        	type209 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type209.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:757:21: (=> RESULT_KW (=> (=> LOWER )? type )? )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == RESULT_KW) )
            	{
            	    int LA49_1 = input.LA(2);

            	    if ( (synpred19_Smi()) )
            	    {
            	        alt49 = 1;
            	    }
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // Smi.g:757:23: => RESULT_KW (=> (=> LOWER )? type )?
            	        {

            	        	RESULT_KW210=(IToken)Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_operation_macro3467); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{RESULT_KW210_tree = (object)adaptor.Create(RESULT_KW210);
            	        		adaptor.AddChild(root_0, RESULT_KW210_tree);
            	        	}
            	        	// Smi.g:758:25: (=> (=> LOWER )? type )?
            	        	int alt48 = 2;
            	        	alt48 = dfa48.Predict(input);
            	        	switch (alt48) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:758:26: => (=> LOWER )? type
            	        	        {

            	        	        	// Smi.g:758:37: (=> LOWER )?
            	        	        	int alt47 = 2;
            	        	        	alt47 = dfa47.Predict(input);
            	        	        	switch (alt47) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:758:38: => LOWER
            	        	        	        {

            	        	        	        	LOWER211=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3508); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER211_tree = (object)adaptor.Create(LOWER211);
            	        	        	        		adaptor.AddChild(root_0, LOWER211_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	PushFollow(FOLLOW_type_in_operation_macro3512);
            	        	        	type212 = type();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type212.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:760:21: (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == ERRORS_KW) )
            	{
            	    int LA51_1 = input.LA(2);

            	    if ( (synpred22_Smi()) )
            	    {
            	        alt51 = 1;
            	    }
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // Smi.g:760:23: => ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE
            	        {

            	        	ERRORS_KW213=(IToken)Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_operation_macro3554); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ERRORS_KW213_tree = (object)adaptor.Create(ERRORS_KW213);
            	        		adaptor.AddChild(root_0, ERRORS_KW213_tree);
            	        	}
            	        	L_BRACE214=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3556); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE214_tree = (object)adaptor.Create(L_BRACE214);
            	        		adaptor.AddChild(root_0, L_BRACE214_tree);
            	        	}
            	        	// Smi.g:760:56: ( operation_errorlist )?
            	        	int alt50 = 2;
            	        	int LA50_0 = input.LA(1);

            	        	if ( (LA50_0 == ANY_KW || LA50_0 == B_STRING || (LA50_0 >= BIT_KW && LA50_0 <= BOOLEAN_KW) || (LA50_0 >= C_STRING && LA50_0 <= CHARACTER_KW) || LA50_0 == CHOICE_KW || LA50_0 == EMBEDDED_KW || (LA50_0 >= ENUMERATED_KW && LA50_0 <= ERROR_KW) || (LA50_0 >= EXTERNAL_KW && LA50_0 <= FALSE_KW) || (LA50_0 >= GENERAL_STR_KW && LA50_0 <= H_STRING) || LA50_0 == IA5_STRING_KW || LA50_0 == INTEGER_KW || (LA50_0 >= ISO646_STR_KW && LA50_0 <= L_BRACKET) || LA50_0 == LOWER || (LA50_0 >= MINUS && LA50_0 <= NUMERIC_STR_KW) || (LA50_0 >= OBJECT_KW && LA50_0 <= OCTET_KW) || LA50_0 == OPERATION_KW || LA50_0 == PLUS_INFINITY_KW || LA50_0 == PRINTABLE_STR_KW || LA50_0 == REAL_KW || (LA50_0 >= SEQUENCE_KW && LA50_0 <= SET_KW) || LA50_0 == T61_STR_KW || (LA50_0 >= TELETEX_STR_KW && LA50_0 <= TRUE_KW) || (LA50_0 >= UNIVERSAL_STR_KW && LA50_0 <= VISIBLE_STR_KW) || LA50_0 == 131 || LA50_0 == 137 || (LA50_0 >= 158 && LA50_0 <= 160) || (LA50_0 >= 162 && LA50_0 <= 164) || LA50_0 == 166 || LA50_0 == 179 || LA50_0 == 188 || LA50_0 == 191) )
            	        	{
            	        	    alt50 = 1;
            	        	}
            	        	switch (alt50) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:760:57: operation_errorlist
            	        	        {
            	        	        	PushFollow(FOLLOW_operation_errorlist_in_operation_macro3559);
            	        	        	operation_errorlist215 = operation_errorlist();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_errorlist215.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE216=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3563); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE216_tree = (object)adaptor.Create(R_BRACE216);
            	        		adaptor.AddChild(root_0, R_BRACE216_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:761:21: (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( (LA53_0 == LINKED_KW) )
            	{
            	    int LA53_1 = input.LA(2);

            	    if ( (synpred23_Smi()) )
            	    {
            	        alt53 = 1;
            	    }
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // Smi.g:761:23: => LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE
            	        {

            	        	LINKED_KW217=(IToken)Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_operation_macro3597); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LINKED_KW217_tree = (object)adaptor.Create(LINKED_KW217);
            	        		adaptor.AddChild(root_0, LINKED_KW217_tree);
            	        	}
            	        	L_BRACE218=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3599); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE218_tree = (object)adaptor.Create(L_BRACE218);
            	        		adaptor.AddChild(root_0, L_BRACE218_tree);
            	        	}
            	        	// Smi.g:761:56: ( linkedOp_list )?
            	        	int alt52 = 2;
            	        	int LA52_0 = input.LA(1);

            	        	if ( (LA52_0 == ANY_KW || LA52_0 == B_STRING || (LA52_0 >= BIT_KW && LA52_0 <= BOOLEAN_KW) || (LA52_0 >= C_STRING && LA52_0 <= CHARACTER_KW) || LA52_0 == CHOICE_KW || LA52_0 == EMBEDDED_KW || (LA52_0 >= ENUMERATED_KW && LA52_0 <= ERROR_KW) || (LA52_0 >= EXTERNAL_KW && LA52_0 <= FALSE_KW) || (LA52_0 >= GENERAL_STR_KW && LA52_0 <= H_STRING) || LA52_0 == IA5_STRING_KW || LA52_0 == INTEGER_KW || (LA52_0 >= ISO646_STR_KW && LA52_0 <= L_BRACKET) || LA52_0 == LOWER || (LA52_0 >= MINUS && LA52_0 <= NUMERIC_STR_KW) || (LA52_0 >= OBJECT_KW && LA52_0 <= OCTET_KW) || LA52_0 == OPERATION_KW || LA52_0 == PLUS_INFINITY_KW || LA52_0 == PRINTABLE_STR_KW || LA52_0 == REAL_KW || (LA52_0 >= SEQUENCE_KW && LA52_0 <= SET_KW) || LA52_0 == T61_STR_KW || (LA52_0 >= TELETEX_STR_KW && LA52_0 <= TRUE_KW) || (LA52_0 >= UNIVERSAL_STR_KW && LA52_0 <= VISIBLE_STR_KW) || LA52_0 == 131 || LA52_0 == 137 || (LA52_0 >= 158 && LA52_0 <= 160) || (LA52_0 >= 162 && LA52_0 <= 164) || LA52_0 == 166 || LA52_0 == 179 || LA52_0 == 188 || LA52_0 == 191) )
            	        	{
            	        	    alt52 = 1;
            	        	}
            	        	switch (alt52) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:761:57: linkedOp_list
            	        	        {
            	        	        	PushFollow(FOLLOW_linkedOp_list_in_operation_macro3602);
            	        	        	linkedOp_list219 = linkedOp_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, linkedOp_list219.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE220=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3606); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE220_tree = (object)adaptor.Create(R_BRACE220);
            	        		adaptor.AddChild(root_0, R_BRACE220_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_macro"

    public class error_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "error_macro"
    // Smi.g:771:0: error_macro : ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? ;
    public SmiParser.error_macro_return error_macro() // throws RecognitionException [1]
    {   
        SmiParser.error_macro_return retval = new SmiParser.error_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken ERROR_KW221 = null;
        IToken PARAMETER_KW222 = null;
        IToken LOWER223 = null;
        SmiParser.type_return type224 = default(SmiParser.type_return);


        object ERROR_KW221_tree=null;
        object PARAMETER_KW222_tree=null;
        object LOWER223_tree=null;

        try 
    	{
            // Smi.g:771:14: ( ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? )
            // Smi.g:771:14: ERROR_KW ( PARAMETER_KW (=> LOWER )? type )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	ERROR_KW221=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_error_macro3626); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ERROR_KW221_tree = (object)adaptor.Create(ERROR_KW221);
            		adaptor.AddChild(root_0, ERROR_KW221_tree);
            	}
            	// Smi.g:771:23: ( PARAMETER_KW (=> LOWER )? type )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == PARAMETER_KW) )
            	{
            	    alt55 = 1;
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // Smi.g:771:25: PARAMETER_KW (=> LOWER )? type
            	        {
            	        	PARAMETER_KW222=(IToken)Match(input,PARAMETER_KW,FOLLOW_PARAMETER_KW_in_error_macro3630); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{PARAMETER_KW222_tree = (object)adaptor.Create(PARAMETER_KW222);
            	        		adaptor.AddChild(root_0, PARAMETER_KW222_tree);
            	        	}
            	        	// Smi.g:771:38: (=> LOWER )?
            	        	int alt54 = 2;
            	        	alt54 = dfa54.Predict(input);
            	        	switch (alt54) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:771:39: => LOWER
            	        	        {

            	        	        	LOWER223=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_error_macro3639); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER223_tree = (object)adaptor.Create(LOWER223);
            	        	        		adaptor.AddChild(root_0, LOWER223_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_error_macro3643);
            	        	type224 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type224.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "error_macro"

    public class macros_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "macros_type"
    // Smi.g:778:0: macros_type : ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro );
    public SmiParser.macros_type_return macros_type() // throws RecognitionException [1]
    {   
        SmiParser.macros_type_return retval = new SmiParser.macros_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SmiParser.operation_macro_return operation_macro225 = default(SmiParser.operation_macro_return);

        SmiParser.error_macro_return error_macro226 = default(SmiParser.error_macro_return);

        SmiParser.objecttype_macro_return objecttype_macro227 = default(SmiParser.objecttype_macro_return);

        SmiParser.moduleidentity_macro_return moduleidentity_macro228 = default(SmiParser.moduleidentity_macro_return);

        SmiParser.objectidentity_macro_return objectidentity_macro229 = default(SmiParser.objectidentity_macro_return);

        SmiParser.notificationtype_macro_return notificationtype_macro230 = default(SmiParser.notificationtype_macro_return);

        SmiParser.textualconvention_macro_return textualconvention_macro231 = default(SmiParser.textualconvention_macro_return);

        SmiParser.objectgroup_macro_return objectgroup_macro232 = default(SmiParser.objectgroup_macro_return);

        SmiParser.notificationgroup_macro_return notificationgroup_macro233 = default(SmiParser.notificationgroup_macro_return);

        SmiParser.modulecompliance_macro_return modulecompliance_macro234 = default(SmiParser.modulecompliance_macro_return);

        SmiParser.agentcapabilities_macro_return agentcapabilities_macro235 = default(SmiParser.agentcapabilities_macro_return);

        SmiParser.traptype_macro_return traptype_macro236 = default(SmiParser.traptype_macro_return);



        try 
    	{
            // Smi.g:778:14: ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro )
            int alt56 = 12;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt56 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt56 = 2;
                }
                break;
            case 166:
            	{
                alt56 = 3;
                }
                break;
            case 159:
            	{
                alt56 = 4;
                }
                break;
            case 164:
            	{
                alt56 = 5;
                }
                break;
            case 162:
            	{
                alt56 = 6;
                }
                break;
            case 188:
            	{
                alt56 = 7;
                }
                break;
            case 163:
            	{
                alt56 = 8;
                }
                break;
            case 160:
            	{
                alt56 = 9;
                }
                break;
            case 158:
            	{
                alt56 = 10;
                }
                break;
            case 131:
            	{
                alt56 = 11;
                }
                break;
            case 191:
            	{
                alt56 = 12;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d56s0 =
            	        new NoViableAltException("", 56, 0, input);

            	    throw nvae_d56s0;
            }

            switch (alt56) 
            {
                case 1 :
                    // Smi.g:778:14: operation_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_operation_macro_in_macros_type3661);
                    	operation_macro225 = operation_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_macro225.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:778:32: error_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_error_macro_in_macros_type3665);
                    	error_macro226 = error_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, error_macro226.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:778:46: objecttype_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objecttype_macro_in_macros_type3669);
                    	objecttype_macro227 = objecttype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro227.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:778:65: moduleidentity_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_in_macros_type3673);
                    	moduleidentity_macro228 = moduleidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro228.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:779:14: objectidentity_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectidentity_macro_in_macros_type3689);
                    	objectidentity_macro229 = objectidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro229.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:779:37: notificationtype_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationtype_macro_in_macros_type3693);
                    	notificationtype_macro230 = notificationtype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro230.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:779:62: textualconvention_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_textualconvention_macro_in_macros_type3697);
                    	textualconvention_macro231 = textualconvention_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro231.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:780:14: objectgroup_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectgroup_macro_in_macros_type3713);
                    	objectgroup_macro232 = objectgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro232.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:780:34: notificationgroup_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationgroup_macro_in_macros_type3717);
                    	notificationgroup_macro233 = notificationgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro233.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:780:60: modulecompliance_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_modulecompliance_macro_in_macros_type3721);
                    	modulecompliance_macro234 = modulecompliance_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro234.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:781:14: agentcapabilities_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_agentcapabilities_macro_in_macros_type3737);
                    	agentcapabilities_macro235 = agentcapabilities_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro235.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:781:40: traptype_macro
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_traptype_macro_in_macros_type3741);
                    	traptype_macro236 = traptype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, traptype_macro236.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macros_type"

    public class smi_macros_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "smi_macros"
    // Smi.g:783:0: smi_macros : ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' );
    public SmiParser.smi_macros_return smi_macros() // throws RecognitionException [1]
    {   
        SmiParser.smi_macros_return retval = new SmiParser.smi_macros_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set237 = null;

        object set237_tree=null;

        try 
    	{
            // Smi.g:783:13: ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' )
            // Smi.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set237 = (IToken)input.LT(1);
            	if ( input.LA(1) == 131 || (input.LA(1) >= 158 && input.LA(1) <= 160) || (input.LA(1) >= 162 && input.LA(1) <= 164) || input.LA(1) == 166 || input.LA(1) == 188 || input.LA(1) == 191 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set237));
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
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_macros"

    public class smi_type_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "smi_type"
    // Smi.g:789:0: smi_type : ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER );
    public SmiParser.smi_type_return smi_type() // throws RecognitionException [1]
    {   
        SmiParser.smi_type_return retval = new SmiParser.smi_type_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal238 = null;
        IToken INTEGER_KW239 = null;
        IToken OCTET_KW240 = null;
        IToken STRING_KW241 = null;
        IToken OBJECT_KW242 = null;
        IToken IDENTIFIER_KW243 = null;
        IToken UPPER244 = null;

        object string_literal238_tree=null;
        object INTEGER_KW239_tree=null;
        object OCTET_KW240_tree=null;
        object STRING_KW241_tree=null;
        object OBJECT_KW242_tree=null;
        object IDENTIFIER_KW243_tree=null;
        object UPPER244_tree=null;

        try 
    	{
            // Smi.g:789:11: ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER )
            int alt57 = 5;
            switch ( input.LA(1) ) 
            {
            case 137:
            	{
                alt57 = 1;
                }
                break;
            case INTEGER_KW:
            	{
                alt57 = 2;
                }
                break;
            case OCTET_KW:
            	{
                alt57 = 3;
                }
                break;
            case OBJECT_KW:
            	{
                alt57 = 4;
                }
                break;
            case UPPER:
            	{
                alt57 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d57s0 =
            	        new NoViableAltException("", 57, 0, input);

            	    throw nvae_d57s0;
            }

            switch (alt57) 
            {
                case 1 :
                    // Smi.g:789:11: 'BITS'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal238=(IToken)Match(input,137,FOLLOW_137_in_smi_type3815); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal238_tree = (object)adaptor.Create(string_literal238);
                    		adaptor.AddChild(root_0, string_literal238_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:789:20: INTEGER_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	INTEGER_KW239=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_smi_type3819); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INTEGER_KW239_tree = (object)adaptor.Create(INTEGER_KW239);
                    		adaptor.AddChild(root_0, INTEGER_KW239_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:789:33: OCTET_KW STRING_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OCTET_KW240=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_smi_type3823); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OCTET_KW240_tree = (object)adaptor.Create(OCTET_KW240);
                    		adaptor.AddChild(root_0, OCTET_KW240_tree);
                    	}
                    	STRING_KW241=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_smi_type3825); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW241_tree = (object)adaptor.Create(STRING_KW241);
                    		adaptor.AddChild(root_0, STRING_KW241_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:789:54: OBJECT_KW IDENTIFIER_KW
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OBJECT_KW242=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_smi_type3829); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OBJECT_KW242_tree = (object)adaptor.Create(OBJECT_KW242);
                    		adaptor.AddChild(root_0, OBJECT_KW242_tree);
                    	}
                    	IDENTIFIER_KW243=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_smi_type3831); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENTIFIER_KW243_tree = (object)adaptor.Create(IDENTIFIER_KW243);
                    		adaptor.AddChild(root_0, IDENTIFIER_KW243_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:789:80: UPPER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	UPPER244=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_smi_type3835); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER244_tree = (object)adaptor.Create(UPPER244);
                    		adaptor.AddChild(root_0, UPPER244_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_type"

    public class smi_subtyping_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "smi_subtyping"
    // Smi.g:795:0: smi_subtyping : ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN );
    public SmiParser.smi_subtyping_return smi_subtyping() // throws RecognitionException [1]
    {   
        SmiParser.smi_subtyping_return retval = new SmiParser.smi_subtyping_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_PAREN245 = null;
        IToken BAR247 = null;
        IToken R_PAREN249 = null;
        IToken L_PAREN250 = null;
        IToken string_literal251 = null;
        IToken L_PAREN252 = null;
        IToken BAR254 = null;
        IToken R_PAREN256 = null;
        IToken R_PAREN257 = null;
        SmiParser.subtype_range_return subtype_range246 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range248 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range253 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range255 = default(SmiParser.subtype_range_return);


        object L_PAREN245_tree=null;
        object BAR247_tree=null;
        object R_PAREN249_tree=null;
        object L_PAREN250_tree=null;
        object string_literal251_tree=null;
        object L_PAREN252_tree=null;
        object BAR254_tree=null;
        object R_PAREN256_tree=null;
        object R_PAREN257_tree=null;

        try 
    	{
            // Smi.g:795:16: ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN )
            int alt60 = 2;
            int LA60_0 = input.LA(1);

            if ( (LA60_0 == L_PAREN) )
            {
                int LA60_1 = input.LA(2);

                if ( (LA60_1 == SIZE_KW) )
                {
                    alt60 = 2;
                }
                else if ( (LA60_1 == B_STRING || LA60_1 == H_STRING || LA60_1 == MINUS || LA60_1 == NUMBER) )
                {
                    alt60 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d60s1 =
                        new NoViableAltException("", 60, 1, input);

                    throw nvae_d60s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d60s0 =
                    new NoViableAltException("", 60, 0, input);

                throw nvae_d60s0;
            }
            switch (alt60) 
            {
                case 1 :
                    // Smi.g:795:16: L_PAREN subtype_range ( BAR subtype_range )* R_PAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	L_PAREN245=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3849); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN245_tree = (object)adaptor.Create(L_PAREN245);
                    		adaptor.AddChild(root_0, L_PAREN245_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3851);
                    	subtype_range246 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range246.Tree);
                    	// Smi.g:795:38: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt58 = 2;
                    	    int LA58_0 = input.LA(1);

                    	    if ( (LA58_0 == BAR) )
                    	    {
                    	        alt58 = 1;
                    	    }


                    	    switch (alt58) 
                    		{
                    			case 1 :
                    			    // Smi.g:795:39: BAR subtype_range
                    			    {
                    			    	BAR247=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3854); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR247_tree = (object)adaptor.Create(BAR247);
                    			    		adaptor.AddChild(root_0, BAR247_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3856);
                    			    	subtype_range248 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range248.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop58;
                    	    }
                    	} while (true);

                    	loop58:
                    		;	// Stops C# compiler whining that label 'loop58' has no statements

                    	R_PAREN249=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3860); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN249_tree = (object)adaptor.Create(R_PAREN249);
                    		adaptor.AddChild(root_0, R_PAREN249_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:796:16: L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	L_PAREN250=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3877); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN250_tree = (object)adaptor.Create(L_PAREN250);
                    		adaptor.AddChild(root_0, L_PAREN250_tree);
                    	}
                    	string_literal251=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_smi_subtyping3879); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal251_tree = (object)adaptor.Create(string_literal251);
                    		adaptor.AddChild(root_0, string_literal251_tree);
                    	}
                    	L_PAREN252=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3881); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN252_tree = (object)adaptor.Create(L_PAREN252);
                    		adaptor.AddChild(root_0, L_PAREN252_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3883);
                    	subtype_range253 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range253.Tree);
                    	// Smi.g:796:53: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt59 = 2;
                    	    int LA59_0 = input.LA(1);

                    	    if ( (LA59_0 == BAR) )
                    	    {
                    	        alt59 = 1;
                    	    }


                    	    switch (alt59) 
                    		{
                    			case 1 :
                    			    // Smi.g:796:54: BAR subtype_range
                    			    {
                    			    	BAR254=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3886); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR254_tree = (object)adaptor.Create(BAR254);
                    			    		adaptor.AddChild(root_0, BAR254_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3888);
                    			    	subtype_range255 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range255.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop59;
                    	    }
                    	} while (true);

                    	loop59:
                    		;	// Stops C# compiler whining that label 'loop59' has no statements

                    	R_PAREN256=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3892); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN256_tree = (object)adaptor.Create(R_PAREN256);
                    		adaptor.AddChild(root_0, R_PAREN256_tree);
                    	}
                    	R_PAREN257=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3894); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN257_tree = (object)adaptor.Create(R_PAREN257);
                    		adaptor.AddChild(root_0, R_PAREN257_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_subtyping"

    public class subtype_range_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "subtype_range"
    // Smi.g:797:0: subtype_range : subtype_value ( DOTDOT subtype_value )? ;
    public SmiParser.subtype_range_return subtype_range() // throws RecognitionException [1]
    {   
        SmiParser.subtype_range_return retval = new SmiParser.subtype_range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken DOTDOT259 = null;
        SmiParser.subtype_value_return subtype_value258 = default(SmiParser.subtype_value_return);

        SmiParser.subtype_value_return subtype_value260 = default(SmiParser.subtype_value_return);


        object DOTDOT259_tree=null;

        try 
    	{
            // Smi.g:797:16: ( subtype_value ( DOTDOT subtype_value )? )
            // Smi.g:797:16: subtype_value ( DOTDOT subtype_value )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_subtype_value_in_subtype_range3900);
            	subtype_value258 = subtype_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value258.Tree);
            	// Smi.g:797:30: ( DOTDOT subtype_value )?
            	int alt61 = 2;
            	int LA61_0 = input.LA(1);

            	if ( (LA61_0 == DOTDOT) )
            	{
            	    alt61 = 1;
            	}
            	switch (alt61) 
            	{
            	    case 1 :
            	        // Smi.g:797:31: DOTDOT subtype_value
            	        {
            	        	DOTDOT259=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_subtype_range3903); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOT259_tree = (object)adaptor.Create(DOTDOT259);
            	        		adaptor.AddChild(root_0, DOTDOT259_tree);
            	        	}
            	        	PushFollow(FOLLOW_subtype_value_in_subtype_range3905);
            	        	subtype_value260 = subtype_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value260.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_range"

    public class subtype_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "subtype_value"
    // Smi.g:798:0: subtype_value : ( ( MINUS )? NUMBER | B_STRING | H_STRING );
    public SmiParser.subtype_value_return subtype_value() // throws RecognitionException [1]
    {   
        SmiParser.subtype_value_return retval = new SmiParser.subtype_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MINUS261 = null;
        IToken NUMBER262 = null;
        IToken B_STRING263 = null;
        IToken H_STRING264 = null;

        object MINUS261_tree=null;
        object NUMBER262_tree=null;
        object B_STRING263_tree=null;
        object H_STRING264_tree=null;

        try 
    	{
            // Smi.g:798:16: ( ( MINUS )? NUMBER | B_STRING | H_STRING )
            int alt63 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS:
            case NUMBER:
            	{
                alt63 = 1;
                }
                break;
            case B_STRING:
            	{
                alt63 = 2;
                }
                break;
            case H_STRING:
            	{
                alt63 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d63s0 =
            	        new NoViableAltException("", 63, 0, input);

            	    throw nvae_d63s0;
            }

            switch (alt63) 
            {
                case 1 :
                    // Smi.g:798:16: ( MINUS )? NUMBER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// Smi.g:798:16: ( MINUS )?
                    	int alt62 = 2;
                    	int LA62_0 = input.LA(1);

                    	if ( (LA62_0 == MINUS) )
                    	{
                    	    alt62 = 1;
                    	}
                    	switch (alt62) 
                    	{
                    	    case 1 :
                    	        // Smi.g:798:17: MINUS
                    	        {
                    	        	MINUS261=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_subtype_value3915); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{MINUS261_tree = (object)adaptor.Create(MINUS261);
                    	        		adaptor.AddChild(root_0, MINUS261_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	NUMBER262=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_subtype_value3919); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER262_tree = (object)adaptor.Create(NUMBER262);
                    		adaptor.AddChild(root_0, NUMBER262_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:798:34: B_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	B_STRING263=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_subtype_value3923); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING263_tree = (object)adaptor.Create(B_STRING263);
                    		adaptor.AddChild(root_0, B_STRING263_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:798:45: H_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	H_STRING264=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_subtype_value3927); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING264_tree = (object)adaptor.Create(H_STRING264);
                    		adaptor.AddChild(root_0, H_STRING264_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_value"

    public class objecttype_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro"
    // Smi.g:801:0: objecttype_macro : 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? ;
    public SmiParser.objecttype_macro_return objecttype_macro() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_return retval = new SmiParser.objecttype_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal265 = null;
        IToken string_literal266 = null;
        IToken string_literal272 = null;
        IToken C_STRING273 = null;
        IToken set274 = null;
        IToken string_literal276 = null;
        IToken string_literal278 = null;
        IToken L_BRACE279 = null;
        IToken R_BRACE281 = null;
        IToken string_literal282 = null;
        IToken L_BRACE283 = null;
        IToken R_BRACE285 = null;
        IToken string_literal286 = null;
        IToken string_literal288 = null;
        IToken C_STRING289 = null;
        IToken string_literal290 = null;
        IToken L_BRACE291 = null;
        IToken COMMA293 = null;
        IToken R_BRACE295 = null;
        IToken string_literal296 = null;
        IToken C_STRING297 = null;
        IToken string_literal298 = null;
        IToken string_literal300 = null;
        IToken string_literal302 = null;
        IToken L_BRACE303 = null;
        IToken R_BRACE305 = null;
        IToken string_literal306 = null;
        IToken L_BRACE307 = null;
        IToken R_BRACE309 = null;
        IToken string_literal310 = null;
        IToken string_literal312 = null;
        IToken L_BRACE313 = null;
        IToken COMMA315 = null;
        IToken R_BRACE317 = null;
        IToken string_literal318 = null;
        IToken L_BRACE319 = null;
        IToken R_BRACE322 = null;
        SmiParser.smi_type_return smi_type267 = default(SmiParser.smi_type_return);

        SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits268 = default(SmiParser.objecttype_macro_namedbits_return);

        SmiParser.smi_type_return smi_type269 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping270 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type271 = default(SmiParser.type_return);

        SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes275 = default(SmiParser.objecttype_macro_accesstypes_return);

        SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess277 = default(SmiParser.objecttype_macro_pibaccess_return);

        SmiParser.value_return value280 = default(SmiParser.value_return);

        SmiParser.value_return value284 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes287 = default(SmiParser.objecttype_macro_statustypes_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error292 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error294 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index299 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.objecttype_macro_augments_return objecttype_macro_augments301 = default(SmiParser.objecttype_macro_augments_return);

        SmiParser.value_return value304 = default(SmiParser.value_return);

        SmiParser.value_return value308 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index311 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.value_return value314 = default(SmiParser.value_return);

        SmiParser.value_return value316 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue320 = default(SmiParser.objecttype_macro_bitsvalue_return);

        SmiParser.value_return value321 = default(SmiParser.value_return);


        object string_literal265_tree=null;
        object string_literal266_tree=null;
        object string_literal272_tree=null;
        object C_STRING273_tree=null;
        object set274_tree=null;
        object string_literal276_tree=null;
        object string_literal278_tree=null;
        object L_BRACE279_tree=null;
        object R_BRACE281_tree=null;
        object string_literal282_tree=null;
        object L_BRACE283_tree=null;
        object R_BRACE285_tree=null;
        object string_literal286_tree=null;
        object string_literal288_tree=null;
        object C_STRING289_tree=null;
        object string_literal290_tree=null;
        object L_BRACE291_tree=null;
        object COMMA293_tree=null;
        object R_BRACE295_tree=null;
        object string_literal296_tree=null;
        object C_STRING297_tree=null;
        object string_literal298_tree=null;
        object string_literal300_tree=null;
        object string_literal302_tree=null;
        object L_BRACE303_tree=null;
        object R_BRACE305_tree=null;
        object string_literal306_tree=null;
        object L_BRACE307_tree=null;
        object R_BRACE309_tree=null;
        object string_literal310_tree=null;
        object string_literal312_tree=null;
        object L_BRACE313_tree=null;
        object COMMA315_tree=null;
        object R_BRACE317_tree=null;
        object string_literal318_tree=null;
        object L_BRACE319_tree=null;
        object R_BRACE322_tree=null;

        try 
    	{
            // Smi.g:801:19: ( 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? )
            // Smi.g:801:19: 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal265=(IToken)Match(input,166,FOLLOW_166_in_objecttype_macro3936); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal265_tree = (object)adaptor.Create(string_literal265);
            		adaptor.AddChild(root_0, string_literal265_tree);
            	}
            	string_literal266=(IToken)Match(input,187,FOLLOW_187_in_objecttype_macro3938); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal266_tree = (object)adaptor.Create(string_literal266);
            		adaptor.AddChild(root_0, string_literal266_tree);
            	}
            	// Smi.g:802:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )
            	int alt65 = 3;
            	alt65 = dfa65.Predict(input);
            	switch (alt65) 
            	{
            	    case 1 :
            	        // Smi.g:802:23: => smi_type objecttype_macro_namedbits
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro3971);
            	        	smi_type267 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type267.Tree);
            	        	PushFollow(FOLLOW_objecttype_macro_namedbits_in_objecttype_macro3973);
            	        	objecttype_macro_namedbits268 = objecttype_macro_namedbits();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_namedbits268.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:803:24: => smi_type ( smi_subtyping )?
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro4005);
            	        	smi_type269 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type269.Tree);
            	        	// Smi.g:803:47: ( smi_subtyping )?
            	        	int alt64 = 2;
            	        	int LA64_0 = input.LA(1);

            	        	if ( (LA64_0 == L_PAREN) )
            	        	{
            	        	    alt64 = 1;
            	        	}
            	        	switch (alt64) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:803:48: smi_subtyping
            	        	        {
            	        	        	PushFollow(FOLLOW_smi_subtyping_in_objecttype_macro4008);
            	        	        	smi_subtyping270 = smi_subtyping();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping270.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:804:24: type
            	        {
            	        	PushFollow(FOLLOW_type_in_objecttype_macro4035);
            	        	type271 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type271.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:806:19: ( 'UNITS' C_STRING )?
            	int alt66 = 2;
            	int LA66_0 = input.LA(1);

            	if ( (LA66_0 == 194) )
            	{
            	    alt66 = 1;
            	}
            	switch (alt66) 
            	{
            	    case 1 :
            	        // Smi.g:806:20: 'UNITS' C_STRING
            	        {
            	        	string_literal272=(IToken)Match(input,194,FOLLOW_194_in_objecttype_macro4079); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal272_tree = (object)adaptor.Create(string_literal272);
            	        		adaptor.AddChild(root_0, string_literal272_tree);
            	        	}
            	        	C_STRING273=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4081); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING273_tree = (object)adaptor.Create(C_STRING273);
            	        		adaptor.AddChild(root_0, C_STRING273_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:807:19: ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )?
            	int alt67 = 3;
            	int LA67_0 = input.LA(1);

            	if ( (LA67_0 == 130 || LA67_0 == 155) )
            	{
            	    alt67 = 1;
            	}
            	else if ( (LA67_0 == 168) )
            	{
            	    alt67 = 2;
            	}
            	switch (alt67) 
            	{
            	    case 1 :
            	        // Smi.g:807:21: ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes
            	        {
            	        	set274 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == 130 || input.LA(1) == 155 ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set274));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4114);
            	        	objecttype_macro_accesstypes275 = objecttype_macro_accesstypes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_accesstypes275.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:808:22: 'PIB-ACCESS' objecttype_macro_pibaccess
            	        {
            	        	string_literal276=(IToken)Match(input,168,FOLLOW_168_in_objecttype_macro4138); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal276_tree = (object)adaptor.Create(string_literal276);
            	        		adaptor.AddChild(root_0, string_literal276_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4140);
            	        	objecttype_macro_pibaccess277 = objecttype_macro_pibaccess();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_pibaccess277.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:809:19: ( 'PIB-REFERENCES' L_BRACE value R_BRACE )?
            	int alt68 = 2;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == 172) )
            	{
            	    alt68 = 1;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // Smi.g:809:20: 'PIB-REFERENCES' L_BRACE value R_BRACE
            	        {
            	        	string_literal278=(IToken)Match(input,172,FOLLOW_172_in_objecttype_macro4178); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal278_tree = (object)adaptor.Create(string_literal278);
            	        		adaptor.AddChild(root_0, string_literal278_tree);
            	        	}
            	        	L_BRACE279=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4180); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE279_tree = (object)adaptor.Create(L_BRACE279);
            	        		adaptor.AddChild(root_0, L_BRACE279_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4182);
            	        	value280 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value280.Tree);
            	        	R_BRACE281=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4184); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE281_tree = (object)adaptor.Create(R_BRACE281);
            	        		adaptor.AddChild(root_0, R_BRACE281_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:810:19: ( 'PIB-TAG' L_BRACE value R_BRACE )?
            	int alt69 = 2;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 173) )
            	{
            	    alt69 = 1;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // Smi.g:810:20: 'PIB-TAG' L_BRACE value R_BRACE
            	        {
            	        	string_literal282=(IToken)Match(input,173,FOLLOW_173_in_objecttype_macro4225); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal282_tree = (object)adaptor.Create(string_literal282);
            	        		adaptor.AddChild(root_0, string_literal282_tree);
            	        	}
            	        	L_BRACE283=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4227); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE283_tree = (object)adaptor.Create(L_BRACE283);
            	        		adaptor.AddChild(root_0, L_BRACE283_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4229);
            	        	value284 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value284.Tree);
            	        	R_BRACE285=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4231); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE285_tree = (object)adaptor.Create(R_BRACE285);
            	        		adaptor.AddChild(root_0, R_BRACE285_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal286=(IToken)Match(input,184,FOLLOW_184_in_objecttype_macro4278); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal286_tree = (object)adaptor.Create(string_literal286);
            		adaptor.AddChild(root_0, string_literal286_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4280);
            	objecttype_macro_statustypes287 = objecttype_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_statustypes287.Tree);
            	// Smi.g:812:19: (=> 'DESCRIPTION' C_STRING )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 141) )
            	{
            	    int LA70_1 = input.LA(2);

            	    if ( (LA70_1 == C_STRING) )
            	    {
            	        int LA70_3 = input.LA(3);

            	        if ( (synpred27_Smi()) )
            	        {
            	            alt70 = 1;
            	        }
            	    }
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // Smi.g:812:21: => 'DESCRIPTION' C_STRING
            	        {

            	        	string_literal288=(IToken)Match(input,141,FOLLOW_141_in_objecttype_macro4309); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal288_tree = (object)adaptor.Create(string_literal288);
            	        		adaptor.AddChild(root_0, string_literal288_tree);
            	        	}
            	        	C_STRING289=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4311); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING289_tree = (object)adaptor.Create(C_STRING289);
            	        		adaptor.AddChild(root_0, C_STRING289_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:813:19: ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )?
            	int alt72 = 2;
            	int LA72_0 = input.LA(1);

            	if ( (LA72_0 == 151) )
            	{
            	    alt72 = 1;
            	}
            	switch (alt72) 
            	{
            	    case 1 :
            	        // Smi.g:813:20: 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE
            	        {
            	        	string_literal290=(IToken)Match(input,151,FOLLOW_151_in_objecttype_macro4367); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal290_tree = (object)adaptor.Create(string_literal290);
            	        		adaptor.AddChild(root_0, string_literal290_tree);
            	        	}
            	        	L_BRACE291=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4369); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE291_tree = (object)adaptor.Create(L_BRACE291);
            	        		adaptor.AddChild(root_0, L_BRACE291_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4371);
            	        	objecttype_macro_error292 = objecttype_macro_error();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error292.Tree);
            	        	// Smi.g:813:68: ( COMMA objecttype_macro_error )*
            	        	do 
            	        	{
            	        	    int alt71 = 2;
            	        	    int LA71_0 = input.LA(1);

            	        	    if ( (LA71_0 == COMMA) )
            	        	    {
            	        	        alt71 = 1;
            	        	    }


            	        	    switch (alt71) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:813:69: COMMA objecttype_macro_error
            	        			    {
            	        			    	COMMA293=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4374); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA293_tree = (object)adaptor.Create(COMMA293);
            	        			    		adaptor.AddChild(root_0, COMMA293_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4376);
            	        			    	objecttype_macro_error294 = objecttype_macro_error();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error294.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop71;
            	        	    }
            	        	} while (true);

            	        	loop71:
            	        		;	// Stops C# compiler whining that label 'loop71' has no statements

            	        	R_BRACE295=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4380); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE295_tree = (object)adaptor.Create(R_BRACE295);
            	        		adaptor.AddChild(root_0, R_BRACE295_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:814:5: ( 'REFERENCE' C_STRING )?
            	int alt73 = 2;
            	int LA73_0 = input.LA(1);

            	if ( (LA73_0 == 177) )
            	{
            	    alt73 = 1;
            	}
            	switch (alt73) 
            	{
            	    case 1 :
            	        // Smi.g:814:7: 'REFERENCE' C_STRING
            	        {
            	        	string_literal296=(IToken)Match(input,177,FOLLOW_177_in_objecttype_macro4395); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal296_tree = (object)adaptor.Create(string_literal296);
            	        		adaptor.AddChild(root_0, string_literal296_tree);
            	        	}
            	        	C_STRING297=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4397); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING297_tree = (object)adaptor.Create(C_STRING297);
            	        		adaptor.AddChild(root_0, C_STRING297_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:815:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?
            	int alt74 = 5;
            	alt74 = dfa74.Predict(input);
            	switch (alt74) 
            	{
            	    case 1 :
            	        // Smi.g:815:7: => 'INDEX' objecttype_macro_index
            	        {

            	        	string_literal298=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4418); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal298_tree = (object)adaptor.Create(string_literal298);
            	        		adaptor.AddChild(root_0, string_literal298_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4420);
            	        	objecttype_macro_index299 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index299.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:816:23: 'AUGMENTS' objecttype_macro_augments
            	        {
            	        	string_literal300=(IToken)Match(input,135,FOLLOW_135_in_objecttype_macro4445); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal300_tree = (object)adaptor.Create(string_literal300);
            	        		adaptor.AddChild(root_0, string_literal300_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_augments_in_objecttype_macro4447);
            	        	objecttype_macro_augments301 = objecttype_macro_augments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_augments301.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:817:23: 'PIB-INDEX' L_BRACE value R_BRACE
            	        {
            	        	string_literal302=(IToken)Match(input,170,FOLLOW_170_in_objecttype_macro4472); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal302_tree = (object)adaptor.Create(string_literal302);
            	        		adaptor.AddChild(root_0, string_literal302_tree);
            	        	}
            	        	L_BRACE303=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4474); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE303_tree = (object)adaptor.Create(L_BRACE303);
            	        		adaptor.AddChild(root_0, L_BRACE303_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4476);
            	        	value304 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value304.Tree);
            	        	R_BRACE305=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4478); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE305_tree = (object)adaptor.Create(R_BRACE305);
            	        		adaptor.AddChild(root_0, R_BRACE305_tree);
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // Smi.g:818:23: 'EXTENDS' L_BRACE value R_BRACE
            	        {
            	        	string_literal306=(IToken)Match(input,145,FOLLOW_145_in_objecttype_macro4524); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal306_tree = (object)adaptor.Create(string_literal306);
            	        		adaptor.AddChild(root_0, string_literal306_tree);
            	        	}
            	        	L_BRACE307=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4526); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE307_tree = (object)adaptor.Create(L_BRACE307);
            	        		adaptor.AddChild(root_0, L_BRACE307_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4528);
            	        	value308 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value308.Tree);
            	        	R_BRACE309=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4530); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE309_tree = (object)adaptor.Create(R_BRACE309);
            	        		adaptor.AddChild(root_0, R_BRACE309_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:820:19: ( 'INDEX' objecttype_macro_index )?
            	int alt75 = 2;
            	int LA75_0 = input.LA(1);

            	if ( (LA75_0 == 150) )
            	{
            	    alt75 = 1;
            	}
            	switch (alt75) 
            	{
            	    case 1 :
            	        // Smi.g:820:21: 'INDEX' objecttype_macro_index
            	        {
            	        	string_literal310=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4598); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal310_tree = (object)adaptor.Create(string_literal310);
            	        		adaptor.AddChild(root_0, string_literal310_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4600);
            	        	objecttype_macro_index311 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index311.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:821:19: ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )?
            	int alt78 = 2;
            	int LA78_0 = input.LA(1);

            	if ( (LA78_0 == 193) )
            	{
            	    alt78 = 1;
            	}
            	switch (alt78) 
            	{
            	    case 1 :
            	        // Smi.g:821:21: 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE
            	        {
            	        	string_literal312=(IToken)Match(input,193,FOLLOW_193_in_objecttype_macro4649); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal312_tree = (object)adaptor.Create(string_literal312);
            	        		adaptor.AddChild(root_0, string_literal312_tree);
            	        	}
            	        	L_BRACE313=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4651); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE313_tree = (object)adaptor.Create(L_BRACE313);
            	        		adaptor.AddChild(root_0, L_BRACE313_tree);
            	        	}
            	        	// Smi.g:821:42: ( value ( COMMA value )* )?
            	        	int alt77 = 2;
            	        	int LA77_0 = input.LA(1);

            	        	if ( (LA77_0 == B_STRING || LA77_0 == C_STRING || LA77_0 == FALSE_KW || LA77_0 == H_STRING || LA77_0 == L_BRACE || LA77_0 == LOWER || (LA77_0 >= MINUS && LA77_0 <= NUMBER) || LA77_0 == PLUS_INFINITY_KW || LA77_0 == TRUE_KW || LA77_0 == UPPER) )
            	        	{
            	        	    alt77 = 1;
            	        	}
            	        	switch (alt77) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:821:43: value ( COMMA value )*
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4654);
            	        	        	value314 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value314.Tree);
            	        	        	// Smi.g:821:49: ( COMMA value )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt76 = 2;
            	        	        	    int LA76_0 = input.LA(1);

            	        	        	    if ( (LA76_0 == COMMA) )
            	        	        	    {
            	        	        	        alt76 = 1;
            	        	        	    }


            	        	        	    switch (alt76) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:821:50: COMMA value
            	        	        			    {
            	        	        			    	COMMA315=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4657); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA315_tree = (object)adaptor.Create(COMMA315);
            	        	        			    		adaptor.AddChild(root_0, COMMA315_tree);
            	        	        			    	}
            	        	        			    	PushFollow(FOLLOW_value_in_objecttype_macro4659);
            	        	        			    	value316 = value();
            	        	        			    	state.followingStackPointer--;
            	        	        			    	if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value316.Tree);

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop76;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop76:
            	        	        		;	// Stops C# compiler whining that label 'loop76' has no statements


            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE317=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4666); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE317_tree = (object)adaptor.Create(R_BRACE317);
            	        		adaptor.AddChild(root_0, R_BRACE317_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:822:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            	int alt80 = 2;
            	alt80 = dfa80.Predict(input);
            	switch (alt80) 
            	{
            	    case 1 :
            	        // Smi.g:822:7: => 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE
            	        {

            	        	string_literal318=(IToken)Match(input,140,FOLLOW_140_in_objecttype_macro4705); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal318_tree = (object)adaptor.Create(string_literal318);
            	        		adaptor.AddChild(root_0, string_literal318_tree);
            	        	}
            	        	L_BRACE319=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4707); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE319_tree = (object)adaptor.Create(L_BRACE319);
            	        		adaptor.AddChild(root_0, L_BRACE319_tree);
            	        	}
            	        	// Smi.g:823:21: (=> objecttype_macro_bitsvalue | value )
            	        	int alt79 = 2;
            	        	alt79 = dfa79.Predict(input);
            	        	switch (alt79) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:823:23: => objecttype_macro_bitsvalue
            	        	        {

            	        	        	PushFollow(FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4748);
            	        	        	objecttype_macro_bitsvalue320 = objecttype_macro_bitsvalue();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_bitsvalue320.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:824:26: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4775);
            	        	        	value321 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value321.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE322=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4799); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE322_tree = (object)adaptor.Create(R_BRACE322);
            	        		adaptor.AddChild(root_0, R_BRACE322_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro"

    public class objecttype_macro_accesstypes_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_accesstypes"
    // Smi.g:826:0: protected objecttype_macro_accesstypes : l= LOWER ;
    public SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_accesstypes_return retval = new SmiParser.objecttype_macro_accesstypes_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:826:41: (l= LOWER )
            // Smi.g:826:41: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_accesstypes4813); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("read-only") || l.Text == ("read-write") 
            	                                              || l.Text == ("write-only") || l.Text == ("read-create") 
            	                                              || l.Text == ("not-accessible") || l.Text == ("accessible-for-notify"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_accesstypes"

    public class objecttype_macro_pibaccess_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_pibaccess"
    // Smi.g:831:0: protected objecttype_macro_pibaccess : l= LOWER ;
    public SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_pibaccess_return retval = new SmiParser.objecttype_macro_pibaccess_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:831:39: (l= LOWER )
            // Smi.g:831:39: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_pibaccess4866); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("install") 
            	                                              || l.Text == ("notify") 
            	                                              || l.Text == ("install-notify") 
            	                                              || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_pibaccess"

    public class objecttype_macro_statustypes_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_statustypes"
    // Smi.g:837:0: protected objecttype_macro_statustypes : l= LOWER ;
    public SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_statustypes_return retval = new SmiParser.objecttype_macro_statustypes_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:837:41: (l= LOWER )
            // Smi.g:837:41: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_statustypes4919); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("mandatory") 
            	                                              || l.Text == ("optional") 
            	                                              || l.Text == ("obsolete") 
            	                                              || l.Text == ("current") 
            	                                              || l.Text == ("deprecated"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_statustypes"

    public class objecttype_macro_index_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_index"
    // Smi.g:846:0: objecttype_macro_index : L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE ;
    public SmiParser.objecttype_macro_index_return objecttype_macro_index() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_index_return retval = new SmiParser.objecttype_macro_index_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE323 = null;
        IToken COMMA325 = null;
        IToken R_BRACE327 = null;
        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype324 = default(SmiParser.objecttype_macro_indextype_return);

        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype326 = default(SmiParser.objecttype_macro_indextype_return);


        object L_BRACE323_tree=null;
        object COMMA325_tree=null;
        object R_BRACE327_tree=null;

        try 
    	{
            // Smi.g:846:25: ( L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE )
            // Smi.g:846:25: L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE323=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_index4969); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE323_tree = (object)adaptor.Create(L_BRACE323);
            		adaptor.AddChild(root_0, L_BRACE323_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4971);
            	objecttype_macro_indextype324 = objecttype_macro_indextype();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype324.Tree);
            	// Smi.g:846:60: ( COMMA objecttype_macro_indextype )*
            	do 
            	{
            	    int alt81 = 2;
            	    int LA81_0 = input.LA(1);

            	    if ( (LA81_0 == COMMA) )
            	    {
            	        alt81 = 1;
            	    }


            	    switch (alt81) 
            		{
            			case 1 :
            			    // Smi.g:846:61: COMMA objecttype_macro_indextype
            			    {
            			    	COMMA325=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_index4974); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA325_tree = (object)adaptor.Create(COMMA325);
            			    		adaptor.AddChild(root_0, COMMA325_tree);
            			    	}
            			    	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4976);
            			    	objecttype_macro_indextype326 = objecttype_macro_indextype();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype326.Tree);

            			    }
            			    break;

            			default:
            			    goto loop81;
            	    }
            	} while (true);

            	loop81:
            		;	// Stops C# compiler whining that label 'loop81' has no statements

            	R_BRACE327=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_index4980); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE327_tree = (object)adaptor.Create(R_BRACE327);
            		adaptor.AddChild(root_0, R_BRACE327_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_index"

    public class objecttype_macro_indextype_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_indextype"
    // Smi.g:847:0: objecttype_macro_indextype : ( 'IMPLIED' )? value ;
    public SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_indextype_return retval = new SmiParser.objecttype_macro_indextype_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal328 = null;
        SmiParser.value_return value329 = default(SmiParser.value_return);


        object string_literal328_tree=null;

        try 
    	{
            // Smi.g:847:29: ( ( 'IMPLIED' )? value )
            // Smi.g:847:29: ( 'IMPLIED' )? value
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:847:29: ( 'IMPLIED' )?
            	int alt82 = 2;
            	int LA82_0 = input.LA(1);

            	if ( (LA82_0 == IMPLIED_KW) )
            	{
            	    alt82 = 1;
            	}
            	switch (alt82) 
            	{
            	    case 1 :
            	        // Smi.g:847:30: 'IMPLIED'
            	        {
            	        	string_literal328=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype4994); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal328_tree = (object)adaptor.Create(string_literal328);
            	        		adaptor.AddChild(root_0, string_literal328_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_objecttype_macro_indextype4998);
            	value329 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value329.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_indextype"

    public class objecttype_macro_augments_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_augments"
    // Smi.g:848:0: objecttype_macro_augments : L_BRACE value R_BRACE ;
    public SmiParser.objecttype_macro_augments_return objecttype_macro_augments() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_augments_return retval = new SmiParser.objecttype_macro_augments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE330 = null;
        IToken R_BRACE332 = null;
        SmiParser.value_return value331 = default(SmiParser.value_return);


        object L_BRACE330_tree=null;
        object R_BRACE332_tree=null;

        try 
    	{
            // Smi.g:848:28: ( L_BRACE value R_BRACE )
            // Smi.g:848:28: L_BRACE value R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE330=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_augments5004); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE330_tree = (object)adaptor.Create(L_BRACE330);
            		adaptor.AddChild(root_0, L_BRACE330_tree);
            	}
            	PushFollow(FOLLOW_value_in_objecttype_macro_augments5006);
            	value331 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value331.Tree);
            	R_BRACE332=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_augments5008); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE332_tree = (object)adaptor.Create(R_BRACE332);
            		adaptor.AddChild(root_0, R_BRACE332_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_augments"

    public class objecttype_macro_namedbits_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_namedbits"
    // Smi.g:850:0: objecttype_macro_namedbits : L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE ;
    public SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_namedbits_return retval = new SmiParser.objecttype_macro_namedbits_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE333 = null;
        IToken LOWER334 = null;
        IToken L_PAREN335 = null;
        IToken NUMBER336 = null;
        IToken R_PAREN337 = null;
        IToken COMMA338 = null;
        IToken LOWER339 = null;
        IToken L_PAREN340 = null;
        IToken NUMBER341 = null;
        IToken R_PAREN342 = null;
        IToken R_BRACE343 = null;

        object L_BRACE333_tree=null;
        object LOWER334_tree=null;
        object L_PAREN335_tree=null;
        object NUMBER336_tree=null;
        object R_PAREN337_tree=null;
        object COMMA338_tree=null;
        object LOWER339_tree=null;
        object L_PAREN340_tree=null;
        object NUMBER341_tree=null;
        object R_PAREN342_tree=null;
        object R_BRACE343_tree=null;

        try 
    	{
            // Smi.g:850:29: ( L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE )
            // Smi.g:850:29: L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE333=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_namedbits5018); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE333_tree = (object)adaptor.Create(L_BRACE333);
            		adaptor.AddChild(root_0, L_BRACE333_tree);
            	}
            	// Smi.g:850:37: ( LOWER )
            	// Smi.g:850:38: LOWER
            	{
            		LOWER334=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5021); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{LOWER334_tree = (object)adaptor.Create(LOWER334);
            			adaptor.AddChild(root_0, LOWER334_tree);
            		}

            	}

            	L_PAREN335=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5024); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN335_tree = (object)adaptor.Create(L_PAREN335);
            		adaptor.AddChild(root_0, L_PAREN335_tree);
            	}
            	NUMBER336=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5026); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER336_tree = (object)adaptor.Create(NUMBER336);
            		adaptor.AddChild(root_0, NUMBER336_tree);
            	}
            	R_PAREN337=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5028); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN337_tree = (object)adaptor.Create(R_PAREN337);
            		adaptor.AddChild(root_0, R_PAREN337_tree);
            	}
            	// Smi.g:850:68: ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )*
            	do 
            	{
            	    int alt83 = 2;
            	    int LA83_0 = input.LA(1);

            	    if ( (LA83_0 == COMMA) )
            	    {
            	        alt83 = 1;
            	    }


            	    switch (alt83) 
            		{
            			case 1 :
            			    // Smi.g:850:69: COMMA ( LOWER ) L_PAREN NUMBER R_PAREN
            			    {
            			    	COMMA338=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_namedbits5031); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA338_tree = (object)adaptor.Create(COMMA338);
            			    		adaptor.AddChild(root_0, COMMA338_tree);
            			    	}
            			    	// Smi.g:850:75: ( LOWER )
            			    	// Smi.g:850:76: LOWER
            			    	{
            			    		LOWER339=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5034); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{LOWER339_tree = (object)adaptor.Create(LOWER339);
            			    			adaptor.AddChild(root_0, LOWER339_tree);
            			    		}

            			    	}

            			    	L_PAREN340=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5037); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{L_PAREN340_tree = (object)adaptor.Create(L_PAREN340);
            			    		adaptor.AddChild(root_0, L_PAREN340_tree);
            			    	}
            			    	NUMBER341=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5039); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{NUMBER341_tree = (object)adaptor.Create(NUMBER341);
            			    		adaptor.AddChild(root_0, NUMBER341_tree);
            			    	}
            			    	R_PAREN342=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5041); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{R_PAREN342_tree = (object)adaptor.Create(R_PAREN342);
            			    		adaptor.AddChild(root_0, R_PAREN342_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop83;
            	    }
            	} while (true);

            	loop83:
            		;	// Stops C# compiler whining that label 'loop83' has no statements

            	R_BRACE343=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_namedbits5045); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE343_tree = (object)adaptor.Create(R_BRACE343);
            		adaptor.AddChild(root_0, R_BRACE343_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_namedbits"

    public class objecttype_macro_bitsvalue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_bitsvalue"
    // Smi.g:851:0: objecttype_macro_bitsvalue : L_BRACE LOWER ( COMMA LOWER )* R_BRACE ;
    public SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_bitsvalue_return retval = new SmiParser.objecttype_macro_bitsvalue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE344 = null;
        IToken LOWER345 = null;
        IToken COMMA346 = null;
        IToken LOWER347 = null;
        IToken R_BRACE348 = null;

        object L_BRACE344_tree=null;
        object LOWER345_tree=null;
        object COMMA346_tree=null;
        object LOWER347_tree=null;
        object R_BRACE348_tree=null;

        try 
    	{
            // Smi.g:851:29: ( L_BRACE LOWER ( COMMA LOWER )* R_BRACE )
            // Smi.g:851:29: L_BRACE LOWER ( COMMA LOWER )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE344=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5056); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE344_tree = (object)adaptor.Create(L_BRACE344);
            		adaptor.AddChild(root_0, L_BRACE344_tree);
            	}
            	LOWER345=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5058); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER345_tree = (object)adaptor.Create(LOWER345);
            		adaptor.AddChild(root_0, LOWER345_tree);
            	}
            	// Smi.g:851:43: ( COMMA LOWER )*
            	do 
            	{
            	    int alt84 = 2;
            	    int LA84_0 = input.LA(1);

            	    if ( (LA84_0 == COMMA) )
            	    {
            	        alt84 = 1;
            	    }


            	    switch (alt84) 
            		{
            			case 1 :
            			    // Smi.g:851:44: COMMA LOWER
            			    {
            			    	COMMA346=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_bitsvalue5061); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA346_tree = (object)adaptor.Create(COMMA346);
            			    		adaptor.AddChild(root_0, COMMA346_tree);
            			    	}
            			    	LOWER347=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5063); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER347_tree = (object)adaptor.Create(LOWER347);
            			    		adaptor.AddChild(root_0, LOWER347_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop84;
            	    }
            	} while (true);

            	loop84:
            		;	// Stops C# compiler whining that label 'loop84' has no statements

            	R_BRACE348=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5067); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE348_tree = (object)adaptor.Create(R_BRACE348);
            		adaptor.AddChild(root_0, R_BRACE348_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_bitsvalue"

    public class objecttype_macro_error_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objecttype_macro_error"
    // Smi.g:852:0: objecttype_macro_error : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.objecttype_macro_error_return objecttype_macro_error() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_error_return retval = new SmiParser.objecttype_macro_error_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER349 = null;
        IToken L_PAREN350 = null;
        IToken NUMBER351 = null;
        IToken R_PAREN352 = null;

        object LOWER349_tree=null;
        object L_PAREN350_tree=null;
        object NUMBER351_tree=null;
        object R_PAREN352_tree=null;

        try 
    	{
            // Smi.g:852:25: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:852:25: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER349=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_error5078); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER349_tree = (object)adaptor.Create(LOWER349);
            		adaptor.AddChild(root_0, LOWER349_tree);
            	}
            	L_PAREN350=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_error5080); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN350_tree = (object)adaptor.Create(L_PAREN350);
            		adaptor.AddChild(root_0, L_PAREN350_tree);
            	}
            	NUMBER351=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_error5082); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER351_tree = (object)adaptor.Create(NUMBER351);
            		adaptor.AddChild(root_0, NUMBER351_tree);
            	}
            	R_PAREN352=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_error5084); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN352_tree = (object)adaptor.Create(R_PAREN352);
            		adaptor.AddChild(root_0, R_PAREN352_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_error"

    public class moduleidentity_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro"
    // Smi.g:855:0: moduleidentity_macro : 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* ;
    public SmiParser.moduleidentity_macro_return moduleidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_return retval = new SmiParser.moduleidentity_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal353 = null;
        IToken string_literal354 = null;
        IToken L_BRACE355 = null;
        IToken R_BRACE357 = null;
        IToken string_literal358 = null;
        IToken C_STRING359 = null;
        IToken string_literal360 = null;
        IToken C_STRING361 = null;
        IToken string_literal362 = null;
        IToken C_STRING363 = null;
        IToken string_literal364 = null;
        IToken C_STRING365 = null;
        SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories356 = default(SmiParser.moduleidentity_macro_categories_return);

        SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision366 = default(SmiParser.moduleidentity_macro_revision_return);


        object string_literal353_tree=null;
        object string_literal354_tree=null;
        object L_BRACE355_tree=null;
        object R_BRACE357_tree=null;
        object string_literal358_tree=null;
        object C_STRING359_tree=null;
        object string_literal360_tree=null;
        object C_STRING361_tree=null;
        object string_literal362_tree=null;
        object C_STRING363_tree=null;
        object string_literal364_tree=null;
        object C_STRING365_tree=null;

        try 
    	{
            // Smi.g:855:23: ( 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* )
            // Smi.g:855:23: 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal353=(IToken)Match(input,159,FOLLOW_159_in_moduleidentity_macro5093); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal353_tree = (object)adaptor.Create(string_literal353);
            		adaptor.AddChild(root_0, string_literal353_tree);
            	}
            	// Smi.g:856:25: ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )?
            	int alt85 = 2;
            	int LA85_0 = input.LA(1);

            	if ( (LA85_0 == 185) )
            	{
            	    alt85 = 1;
            	}
            	switch (alt85) 
            	{
            	    case 1 :
            	        // Smi.g:856:26: 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE
            	        {
            	        	string_literal354=(IToken)Match(input,185,FOLLOW_185_in_moduleidentity_macro5121); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal354_tree = (object)adaptor.Create(string_literal354);
            	        		adaptor.AddChild(root_0, string_literal354_tree);
            	        	}
            	        	L_BRACE355=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_moduleidentity_macro5123); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE355_tree = (object)adaptor.Create(L_BRACE355);
            	        		adaptor.AddChild(root_0, L_BRACE355_tree);
            	        	}
            	        	PushFollow(FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5125);
            	        	moduleidentity_macro_categories356 = moduleidentity_macro_categories();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categories356.Tree);
            	        	R_BRACE357=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_moduleidentity_macro5127); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE357_tree = (object)adaptor.Create(R_BRACE357);
            	        		adaptor.AddChild(root_0, R_BRACE357_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal358=(IToken)Match(input,152,FOLLOW_152_in_moduleidentity_macro5157); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal358_tree = (object)adaptor.Create(string_literal358);
            		adaptor.AddChild(root_0, string_literal358_tree);
            	}
            	C_STRING359=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5159); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING359_tree = (object)adaptor.Create(C_STRING359);
            		adaptor.AddChild(root_0, C_STRING359_tree);
            	}
            	string_literal360=(IToken)Match(input,167,FOLLOW_167_in_moduleidentity_macro5161); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal360_tree = (object)adaptor.Create(string_literal360);
            		adaptor.AddChild(root_0, string_literal360_tree);
            	}
            	C_STRING361=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5163); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING361_tree = (object)adaptor.Create(C_STRING361);
            		adaptor.AddChild(root_0, C_STRING361_tree);
            	}
            	string_literal362=(IToken)Match(input,138,FOLLOW_138_in_moduleidentity_macro5165); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal362_tree = (object)adaptor.Create(string_literal362);
            		adaptor.AddChild(root_0, string_literal362_tree);
            	}
            	C_STRING363=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5167); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING363_tree = (object)adaptor.Create(C_STRING363);
            		adaptor.AddChild(root_0, C_STRING363_tree);
            	}
            	string_literal364=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro5194); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal364_tree = (object)adaptor.Create(string_literal364);
            		adaptor.AddChild(root_0, string_literal364_tree);
            	}
            	C_STRING365=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5196); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING365_tree = (object)adaptor.Create(C_STRING365);
            		adaptor.AddChild(root_0, C_STRING365_tree);
            	}
            	// Smi.g:858:48: ( moduleidentity_macro_revision )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( (LA86_0 == 180) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // Smi.g:858:49: moduleidentity_macro_revision
            			    {
            			    	PushFollow(FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5199);
            			    	moduleidentity_macro_revision366 = moduleidentity_macro_revision();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_revision366.Tree);

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro"

    public class moduleidentity_macro_revision_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_revision"
    // Smi.g:859:0: moduleidentity_macro_revision : 'REVISION' C_STRING 'DESCRIPTION' C_STRING ;
    public SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_revision_return retval = new SmiParser.moduleidentity_macro_revision_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal367 = null;
        IToken C_STRING368 = null;
        IToken string_literal369 = null;
        IToken C_STRING370 = null;

        object string_literal367_tree=null;
        object C_STRING368_tree=null;
        object string_literal369_tree=null;
        object C_STRING370_tree=null;

        try 
    	{
            // Smi.g:859:32: ( 'REVISION' C_STRING 'DESCRIPTION' C_STRING )
            // Smi.g:859:32: 'REVISION' C_STRING 'DESCRIPTION' C_STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal367=(IToken)Match(input,180,FOLLOW_180_in_moduleidentity_macro_revision5208); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal367_tree = (object)adaptor.Create(string_literal367);
            		adaptor.AddChild(root_0, string_literal367_tree);
            	}
            	C_STRING368=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5210); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING368_tree = (object)adaptor.Create(C_STRING368);
            		adaptor.AddChild(root_0, C_STRING368_tree);
            	}
            	string_literal369=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro_revision5212); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal369_tree = (object)adaptor.Create(string_literal369);
            		adaptor.AddChild(root_0, string_literal369_tree);
            	}
            	C_STRING370=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5214); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING370_tree = (object)adaptor.Create(C_STRING370);
            		adaptor.AddChild(root_0, C_STRING370_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_revision"

    public class moduleidentity_macro_categories_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categories"
    // Smi.g:860:0: moduleidentity_macro_categories : (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* );
    public SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categories_return retval = new SmiParser.moduleidentity_macro_categories_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;
        IToken COMMA372 = null;
        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid371 = default(SmiParser.moduleidentity_macro_categoryid_return);

        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid373 = default(SmiParser.moduleidentity_macro_categoryid_return);


        object l_tree=null;
        object COMMA372_tree=null;

        try 
    	{
            // Smi.g:860:34: (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* )
            int alt88 = 2;
            int LA88_0 = input.LA(1);

            if ( (LA88_0 == LOWER) )
            {
                int LA88_1 = input.LA(2);

                if ( (LA88_1 == L_PAREN) )
                {
                    alt88 = 2;
                }
                else if ( (LA88_1 == R_BRACE) )
                {
                    alt88 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d88s1 =
                        new NoViableAltException("", 88, 1, input);

                    throw nvae_d88s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d88s0 =
                    new NoViableAltException("", 88, 0, input);

                throw nvae_d88s0;
            }
            switch (alt88) 
            {
                case 1 :
                    // Smi.g:860:34: l= LOWER
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categories5223); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{l_tree = (object)adaptor.Create(l);
                    		adaptor.AddChild(root_0, l_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	  if (l.Text !=  ("all")) {throw new SemanticException ("(invalid)");}
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:861:34: moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5261);
                    	moduleidentity_macro_categoryid371 = moduleidentity_macro_categoryid();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid371.Tree);
                    	// Smi.g:861:66: ( COMMA moduleidentity_macro_categoryid )*
                    	do 
                    	{
                    	    int alt87 = 2;
                    	    int LA87_0 = input.LA(1);

                    	    if ( (LA87_0 == COMMA) )
                    	    {
                    	        alt87 = 1;
                    	    }


                    	    switch (alt87) 
                    		{
                    			case 1 :
                    			    // Smi.g:861:67: COMMA moduleidentity_macro_categoryid
                    			    {
                    			    	COMMA372=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_moduleidentity_macro_categories5264); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA372_tree = (object)adaptor.Create(COMMA372);
                    			    		adaptor.AddChild(root_0, COMMA372_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5266);
                    			    	moduleidentity_macro_categoryid373 = moduleidentity_macro_categoryid();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid373.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop87;
                    	    }
                    	} while (true);

                    	loop87:
                    		;	// Stops C# compiler whining that label 'loop87' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categories"

    public class moduleidentity_macro_categoryid_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categoryid"
    // Smi.g:862:0: moduleidentity_macro_categoryid : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categoryid_return retval = new SmiParser.moduleidentity_macro_categoryid_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER374 = null;
        IToken L_PAREN375 = null;
        IToken NUMBER376 = null;
        IToken R_PAREN377 = null;

        object LOWER374_tree=null;
        object L_PAREN375_tree=null;
        object NUMBER376_tree=null;
        object R_PAREN377_tree=null;

        try 
    	{
            // Smi.g:862:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:862:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER374=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categoryid5274); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER374_tree = (object)adaptor.Create(LOWER374);
            		adaptor.AddChild(root_0, LOWER374_tree);
            	}
            	L_PAREN375=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5276); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN375_tree = (object)adaptor.Create(L_PAREN375);
            		adaptor.AddChild(root_0, L_PAREN375_tree);
            	}
            	NUMBER376=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5278); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER376_tree = (object)adaptor.Create(NUMBER376);
            		adaptor.AddChild(root_0, NUMBER376_tree);
            	}
            	R_PAREN377=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5280); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN377_tree = (object)adaptor.Create(R_PAREN377);
            		adaptor.AddChild(root_0, R_PAREN377_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categoryid"

    public class objectidentity_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectidentity_macro"
    // Smi.g:865:0: objectidentity_macro : 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectidentity_macro_return objectidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_return retval = new SmiParser.objectidentity_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal378 = null;
        IToken string_literal379 = null;
        IToken string_literal381 = null;
        IToken C_STRING382 = null;
        IToken string_literal383 = null;
        IToken C_STRING384 = null;
        SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes380 = default(SmiParser.objectidentity_macro_statustypes_return);


        object string_literal378_tree=null;
        object string_literal379_tree=null;
        object string_literal381_tree=null;
        object C_STRING382_tree=null;
        object string_literal383_tree=null;
        object C_STRING384_tree=null;

        try 
    	{
            // Smi.g:865:23: ( 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:865:23: 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal378=(IToken)Match(input,164,FOLLOW_164_in_objectidentity_macro5290); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal378_tree = (object)adaptor.Create(string_literal378);
            		adaptor.AddChild(root_0, string_literal378_tree);
            	}
            	string_literal379=(IToken)Match(input,184,FOLLOW_184_in_objectidentity_macro5292); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal379_tree = (object)adaptor.Create(string_literal379);
            		adaptor.AddChild(root_0, string_literal379_tree);
            	}
            	PushFollow(FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5294);
            	objectidentity_macro_statustypes380 = objectidentity_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro_statustypes380.Tree);
            	string_literal381=(IToken)Match(input,141,FOLLOW_141_in_objectidentity_macro5296); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal381_tree = (object)adaptor.Create(string_literal381);
            		adaptor.AddChild(root_0, string_literal381_tree);
            	}
            	C_STRING382=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5298); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING382_tree = (object)adaptor.Create(C_STRING382);
            		adaptor.AddChild(root_0, C_STRING382_tree);
            	}
            	// Smi.g:865:106: ( 'REFERENCE' C_STRING )?
            	int alt89 = 2;
            	int LA89_0 = input.LA(1);

            	if ( (LA89_0 == 177) )
            	{
            	    alt89 = 1;
            	}
            	switch (alt89) 
            	{
            	    case 1 :
            	        // Smi.g:865:107: 'REFERENCE' C_STRING
            	        {
            	        	string_literal383=(IToken)Match(input,177,FOLLOW_177_in_objectidentity_macro5301); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal383_tree = (object)adaptor.Create(string_literal383);
            	        		adaptor.AddChild(root_0, string_literal383_tree);
            	        	}
            	        	C_STRING384=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5303); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING384_tree = (object)adaptor.Create(C_STRING384);
            	        		adaptor.AddChild(root_0, C_STRING384_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro"

    public class objectidentity_macro_statustypes_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectidentity_macro_statustypes"
    // Smi.g:866:0: protected objectidentity_macro_statustypes : l= LOWER ;
    public SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_statustypes_return retval = new SmiParser.objectidentity_macro_statustypes_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:866:45: (l= LOWER )
            // Smi.g:866:45: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectidentity_macro_statustypes5316); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro_statustypes"

    public class notificationtype_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "notificationtype_macro"
    // Smi.g:874:0: notificationtype_macro : 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationtype_macro_return notificationtype_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_return retval = new SmiParser.notificationtype_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal385 = null;
        IToken string_literal386 = null;
        IToken L_BRACE387 = null;
        IToken COMMA389 = null;
        IToken R_BRACE391 = null;
        IToken string_literal392 = null;
        IToken string_literal394 = null;
        IToken C_STRING395 = null;
        IToken string_literal396 = null;
        IToken C_STRING397 = null;
        SmiParser.value_return value388 = default(SmiParser.value_return);

        SmiParser.value_return value390 = default(SmiParser.value_return);

        SmiParser.notificationtype_macro_status_return notificationtype_macro_status393 = default(SmiParser.notificationtype_macro_status_return);


        object string_literal385_tree=null;
        object string_literal386_tree=null;
        object L_BRACE387_tree=null;
        object COMMA389_tree=null;
        object R_BRACE391_tree=null;
        object string_literal392_tree=null;
        object string_literal394_tree=null;
        object C_STRING395_tree=null;
        object string_literal396_tree=null;
        object C_STRING397_tree=null;

        try 
    	{
            // Smi.g:874:25: ( 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:874:25: 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal385=(IToken)Match(input,162,FOLLOW_162_in_notificationtype_macro5369); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal385_tree = (object)adaptor.Create(string_literal385);
            		adaptor.AddChild(root_0, string_literal385_tree);
            	}
            	// Smi.g:874:45: ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt91 = 2;
            	int LA91_0 = input.LA(1);

            	if ( (LA91_0 == 165) )
            	{
            	    alt91 = 1;
            	}
            	switch (alt91) 
            	{
            	    case 1 :
            	        // Smi.g:874:46: 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal386=(IToken)Match(input,165,FOLLOW_165_in_notificationtype_macro5372); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal386_tree = (object)adaptor.Create(string_literal386);
            	        		adaptor.AddChild(root_0, string_literal386_tree);
            	        	}
            	        	L_BRACE387=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationtype_macro5374); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE387_tree = (object)adaptor.Create(L_BRACE387);
            	        		adaptor.AddChild(root_0, L_BRACE387_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_notificationtype_macro5376);
            	        	value388 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value388.Tree);
            	        	// Smi.g:874:70: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt90 = 2;
            	        	    int LA90_0 = input.LA(1);

            	        	    if ( (LA90_0 == COMMA) )
            	        	    {
            	        	        alt90 = 1;
            	        	    }


            	        	    switch (alt90) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:874:71: COMMA value
            	        			    {
            	        			    	COMMA389=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationtype_macro5379); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA389_tree = (object)adaptor.Create(COMMA389);
            	        			    		adaptor.AddChild(root_0, COMMA389_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_notificationtype_macro5381);
            	        			    	value390 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value390.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop90;
            	        	    }
            	        	} while (true);

            	        	loop90:
            	        		;	// Stops C# compiler whining that label 'loop90' has no statements

            	        	R_BRACE391=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationtype_macro5385); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE391_tree = (object)adaptor.Create(R_BRACE391);
            	        		adaptor.AddChild(root_0, R_BRACE391_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal392=(IToken)Match(input,184,FOLLOW_184_in_notificationtype_macro5434); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal392_tree = (object)adaptor.Create(string_literal392);
            		adaptor.AddChild(root_0, string_literal392_tree);
            	}
            	PushFollow(FOLLOW_notificationtype_macro_status_in_notificationtype_macro5436);
            	notificationtype_macro_status393 = notificationtype_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro_status393.Tree);
            	string_literal394=(IToken)Match(input,141,FOLLOW_141_in_notificationtype_macro5438); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal394_tree = (object)adaptor.Create(string_literal394);
            		adaptor.AddChild(root_0, string_literal394_tree);
            	}
            	C_STRING395=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5440); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING395_tree = (object)adaptor.Create(C_STRING395);
            		adaptor.AddChild(root_0, C_STRING395_tree);
            	}
            	// Smi.g:875:107: ( 'REFERENCE' C_STRING )?
            	int alt92 = 2;
            	int LA92_0 = input.LA(1);

            	if ( (LA92_0 == 177) )
            	{
            	    alt92 = 1;
            	}
            	switch (alt92) 
            	{
            	    case 1 :
            	        // Smi.g:875:108: 'REFERENCE' C_STRING
            	        {
            	        	string_literal396=(IToken)Match(input,177,FOLLOW_177_in_notificationtype_macro5443); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal396_tree = (object)adaptor.Create(string_literal396);
            	        		adaptor.AddChild(root_0, string_literal396_tree);
            	        	}
            	        	C_STRING397=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5445); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING397_tree = (object)adaptor.Create(C_STRING397);
            	        		adaptor.AddChild(root_0, C_STRING397_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro"

    public class notificationtype_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "notificationtype_macro_status"
    // Smi.g:876:0: protected notificationtype_macro_status : l= LOWER ;
    public SmiParser.notificationtype_macro_status_return notificationtype_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_status_return retval = new SmiParser.notificationtype_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:876:42: (l= LOWER )
            // Smi.g:876:42: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationtype_macro_status5458); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro_status"

    public class textualconvention_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "textualconvention_macro"
    // Smi.g:883:0: textualconvention_macro : 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) ;
    public SmiParser.textualconvention_macro_return textualconvention_macro() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_return retval = new SmiParser.textualconvention_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal398 = null;
        IToken string_literal399 = null;
        IToken C_STRING400 = null;
        IToken string_literal401 = null;
        IToken string_literal403 = null;
        IToken C_STRING404 = null;
        IToken string_literal405 = null;
        IToken C_STRING406 = null;
        IToken string_literal407 = null;
        IToken L_BRACE409 = null;
        IToken COMMA411 = null;
        IToken R_BRACE413 = null;
        SmiParser.textualconvention_macro_status_return textualconvention_macro_status402 = default(SmiParser.textualconvention_macro_status_return);

        SmiParser.smi_type_return smi_type408 = default(SmiParser.smi_type_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit410 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit412 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.type_return type414 = default(SmiParser.type_return);


        object string_literal398_tree=null;
        object string_literal399_tree=null;
        object C_STRING400_tree=null;
        object string_literal401_tree=null;
        object string_literal403_tree=null;
        object C_STRING404_tree=null;
        object string_literal405_tree=null;
        object C_STRING406_tree=null;
        object string_literal407_tree=null;
        object L_BRACE409_tree=null;
        object COMMA411_tree=null;
        object R_BRACE413_tree=null;

        try 
    	{
            // Smi.g:883:26: ( 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) )
            // Smi.g:883:26: 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal398=(IToken)Match(input,188,FOLLOW_188_in_textualconvention_macro5510); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal398_tree = (object)adaptor.Create(string_literal398);
            		adaptor.AddChild(root_0, string_literal398_tree);
            	}
            	// Smi.g:883:47: ( 'DISPLAY-HINT' C_STRING )?
            	int alt93 = 2;
            	int LA93_0 = input.LA(1);

            	if ( (LA93_0 == 142) )
            	{
            	    alt93 = 1;
            	}
            	switch (alt93) 
            	{
            	    case 1 :
            	        // Smi.g:883:48: 'DISPLAY-HINT' C_STRING
            	        {
            	        	string_literal399=(IToken)Match(input,142,FOLLOW_142_in_textualconvention_macro5513); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal399_tree = (object)adaptor.Create(string_literal399);
            	        		adaptor.AddChild(root_0, string_literal399_tree);
            	        	}
            	        	C_STRING400=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5515); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING400_tree = (object)adaptor.Create(C_STRING400);
            	        		adaptor.AddChild(root_0, C_STRING400_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal401=(IToken)Match(input,184,FOLLOW_184_in_textualconvention_macro5548); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal401_tree = (object)adaptor.Create(string_literal401);
            		adaptor.AddChild(root_0, string_literal401_tree);
            	}
            	PushFollow(FOLLOW_textualconvention_macro_status_in_textualconvention_macro5550);
            	textualconvention_macro_status402 = textualconvention_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_status402.Tree);
            	string_literal403=(IToken)Match(input,141,FOLLOW_141_in_textualconvention_macro5581); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal403_tree = (object)adaptor.Create(string_literal403);
            		adaptor.AddChild(root_0, string_literal403_tree);
            	}
            	C_STRING404=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5583); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING404_tree = (object)adaptor.Create(C_STRING404);
            		adaptor.AddChild(root_0, C_STRING404_tree);
            	}
            	// Smi.g:886:29: ( 'REFERENCE' C_STRING )?
            	int alt94 = 2;
            	int LA94_0 = input.LA(1);

            	if ( (LA94_0 == 177) )
            	{
            	    alt94 = 1;
            	}
            	switch (alt94) 
            	{
            	    case 1 :
            	        // Smi.g:886:30: 'REFERENCE' C_STRING
            	        {
            	        	string_literal405=(IToken)Match(input,177,FOLLOW_177_in_textualconvention_macro5615); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal405_tree = (object)adaptor.Create(string_literal405);
            	        		adaptor.AddChild(root_0, string_literal405_tree);
            	        	}
            	        	C_STRING406=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5617); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING406_tree = (object)adaptor.Create(C_STRING406);
            	        		adaptor.AddChild(root_0, C_STRING406_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal407=(IToken)Match(input,187,FOLLOW_187_in_textualconvention_macro5650); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal407_tree = (object)adaptor.Create(string_literal407);
            		adaptor.AddChild(root_0, string_literal407_tree);
            	}
            	// Smi.g:887:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            	int alt96 = 2;
            	alt96 = dfa96.Predict(input);
            	switch (alt96) 
            	{
            	    case 1 :
            	        // Smi.g:887:40: => smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_textualconvention_macro5662);
            	        	smi_type408 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type408.Tree);
            	        	L_BRACE409=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_textualconvention_macro5664); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE409_tree = (object)adaptor.Create(L_BRACE409);
            	        		adaptor.AddChild(root_0, L_BRACE409_tree);
            	        	}
            	        	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5666);
            	        	textualconvention_macro_namedbit410 = textualconvention_macro_namedbit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit410.Tree);
            	        	// Smi.g:888:37: ( COMMA textualconvention_macro_namedbit )*
            	        	do 
            	        	{
            	        	    int alt95 = 2;
            	        	    int LA95_0 = input.LA(1);

            	        	    if ( (LA95_0 == COMMA) )
            	        	    {
            	        	        alt95 = 1;
            	        	    }


            	        	    switch (alt95) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:888:38: COMMA textualconvention_macro_namedbit
            	        			    {
            	        			    	COMMA411=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_textualconvention_macro5706); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA411_tree = (object)adaptor.Create(COMMA411);
            	        			    		adaptor.AddChild(root_0, COMMA411_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5708);
            	        			    	textualconvention_macro_namedbit412 = textualconvention_macro_namedbit();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit412.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop95;
            	        	    }
            	        	} while (true);

            	        	loop95:
            	        		;	// Stops C# compiler whining that label 'loop95' has no statements

            	        	R_BRACE413=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_textualconvention_macro5712); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE413_tree = (object)adaptor.Create(R_BRACE413);
            	        		adaptor.AddChild(root_0, R_BRACE413_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:888:89: type
            	        {
            	        	PushFollow(FOLLOW_type_in_textualconvention_macro5716);
            	        	type414 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type414.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro"

    public class textualconvention_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_status"
    // Smi.g:889:0: protected textualconvention_macro_status : l= LOWER ;
    public SmiParser.textualconvention_macro_status_return textualconvention_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_status_return retval = new SmiParser.textualconvention_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:889:43: (l= LOWER )
            // Smi.g:889:43: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_status5727); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_status"

    public class textualconvention_macro_namedbit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_namedbit"
    // Smi.g:894:0: textualconvention_macro_namedbit : LOWER L_PAREN ( MINUS )? NUMBER R_PAREN ;
    public SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_namedbit_return retval = new SmiParser.textualconvention_macro_namedbit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER415 = null;
        IToken L_PAREN416 = null;
        IToken MINUS417 = null;
        IToken NUMBER418 = null;
        IToken R_PAREN419 = null;

        object LOWER415_tree=null;
        object L_PAREN416_tree=null;
        object MINUS417_tree=null;
        object NUMBER418_tree=null;
        object R_PAREN419_tree=null;

        try 
    	{
            // Smi.g:894:35: ( LOWER L_PAREN ( MINUS )? NUMBER R_PAREN )
            // Smi.g:894:35: LOWER L_PAREN ( MINUS )? NUMBER R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER415=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_namedbit5776); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER415_tree = (object)adaptor.Create(LOWER415);
            		adaptor.AddChild(root_0, LOWER415_tree);
            	}
            	L_PAREN416=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5778); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN416_tree = (object)adaptor.Create(L_PAREN416);
            		adaptor.AddChild(root_0, L_PAREN416_tree);
            	}
            	// Smi.g:894:49: ( MINUS )?
            	int alt97 = 2;
            	int LA97_0 = input.LA(1);

            	if ( (LA97_0 == MINUS) )
            	{
            	    alt97 = 1;
            	}
            	switch (alt97) 
            	{
            	    case 1 :
            	        // Smi.g:894:50: MINUS
            	        {
            	        	MINUS417=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_textualconvention_macro_namedbit5781); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS417_tree = (object)adaptor.Create(MINUS417);
            	        		adaptor.AddChild(root_0, MINUS417_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER418=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_textualconvention_macro_namedbit5785); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER418_tree = (object)adaptor.Create(NUMBER418);
            		adaptor.AddChild(root_0, NUMBER418_tree);
            	}
            	R_PAREN419=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5787); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN419_tree = (object)adaptor.Create(R_PAREN419);
            		adaptor.AddChild(root_0, R_PAREN419_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_namedbit"

    public class objectgroup_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectgroup_macro"
    // Smi.g:897:0: objectgroup_macro : 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectgroup_macro_return objectgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_return retval = new SmiParser.objectgroup_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal420 = null;
        IToken string_literal421 = null;
        IToken L_BRACE422 = null;
        IToken COMMA424 = null;
        IToken R_BRACE426 = null;
        IToken string_literal427 = null;
        IToken string_literal429 = null;
        IToken C_STRING430 = null;
        IToken string_literal431 = null;
        IToken C_STRING432 = null;
        SmiParser.value_return value423 = default(SmiParser.value_return);

        SmiParser.value_return value425 = default(SmiParser.value_return);

        SmiParser.objectgroup_macro_status_return objectgroup_macro_status428 = default(SmiParser.objectgroup_macro_status_return);


        object string_literal420_tree=null;
        object string_literal421_tree=null;
        object L_BRACE422_tree=null;
        object COMMA424_tree=null;
        object R_BRACE426_tree=null;
        object string_literal427_tree=null;
        object string_literal429_tree=null;
        object C_STRING430_tree=null;
        object string_literal431_tree=null;
        object C_STRING432_tree=null;

        try 
    	{
            // Smi.g:897:20: ( 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:897:20: 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal420=(IToken)Match(input,163,FOLLOW_163_in_objectgroup_macro5796); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal420_tree = (object)adaptor.Create(string_literal420);
            		adaptor.AddChild(root_0, string_literal420_tree);
            	}
            	string_literal421=(IToken)Match(input,165,FOLLOW_165_in_objectgroup_macro5798); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal421_tree = (object)adaptor.Create(string_literal421);
            		adaptor.AddChild(root_0, string_literal421_tree);
            	}
            	L_BRACE422=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objectgroup_macro5800); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE422_tree = (object)adaptor.Create(L_BRACE422);
            		adaptor.AddChild(root_0, L_BRACE422_tree);
            	}
            	PushFollow(FOLLOW_value_in_objectgroup_macro5802);
            	value423 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value423.Tree);
            	// Smi.g:897:59: ( COMMA value )*
            	do 
            	{
            	    int alt98 = 2;
            	    int LA98_0 = input.LA(1);

            	    if ( (LA98_0 == COMMA) )
            	    {
            	        alt98 = 1;
            	    }


            	    switch (alt98) 
            		{
            			case 1 :
            			    // Smi.g:897:60: COMMA value
            			    {
            			    	COMMA424=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objectgroup_macro5805); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA424_tree = (object)adaptor.Create(COMMA424);
            			    		adaptor.AddChild(root_0, COMMA424_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_objectgroup_macro5807);
            			    	value425 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value425.Tree);

            			    }
            			    break;

            			default:
            			    goto loop98;
            	    }
            	} while (true);

            	loop98:
            		;	// Stops C# compiler whining that label 'loop98' has no statements

            	R_BRACE426=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objectgroup_macro5811); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE426_tree = (object)adaptor.Create(R_BRACE426);
            		adaptor.AddChild(root_0, R_BRACE426_tree);
            	}
            	string_literal427=(IToken)Match(input,184,FOLLOW_184_in_objectgroup_macro5838); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal427_tree = (object)adaptor.Create(string_literal427);
            		adaptor.AddChild(root_0, string_literal427_tree);
            	}
            	PushFollow(FOLLOW_objectgroup_macro_status_in_objectgroup_macro5840);
            	objectgroup_macro_status428 = objectgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro_status428.Tree);
            	string_literal429=(IToken)Match(input,141,FOLLOW_141_in_objectgroup_macro5842); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal429_tree = (object)adaptor.Create(string_literal429);
            		adaptor.AddChild(root_0, string_literal429_tree);
            	}
            	C_STRING430=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5844); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING430_tree = (object)adaptor.Create(C_STRING430);
            		adaptor.AddChild(root_0, C_STRING430_tree);
            	}
            	// Smi.g:898:82: ( 'REFERENCE' C_STRING )?
            	int alt99 = 2;
            	int LA99_0 = input.LA(1);

            	if ( (LA99_0 == 177) )
            	{
            	    alt99 = 1;
            	}
            	switch (alt99) 
            	{
            	    case 1 :
            	        // Smi.g:898:83: 'REFERENCE' C_STRING
            	        {
            	        	string_literal431=(IToken)Match(input,177,FOLLOW_177_in_objectgroup_macro5847); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal431_tree = (object)adaptor.Create(string_literal431);
            	        		adaptor.AddChild(root_0, string_literal431_tree);
            	        	}
            	        	C_STRING432=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5849); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING432_tree = (object)adaptor.Create(C_STRING432);
            	        		adaptor.AddChild(root_0, C_STRING432_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro"

    public class objectgroup_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectgroup_macro_status"
    // Smi.g:899:0: objectgroup_macro_status : l= LOWER ;
    public SmiParser.objectgroup_macro_status_return objectgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_status_return retval = new SmiParser.objectgroup_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:899:27: (l= LOWER )
            // Smi.g:899:27: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectgroup_macro_status5860); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro_status"

    public class notificationgroup_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro"
    // Smi.g:906:0: notificationgroup_macro : 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationgroup_macro_return notificationgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_return retval = new SmiParser.notificationgroup_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal433 = null;
        IToken string_literal434 = null;
        IToken L_BRACE435 = null;
        IToken COMMA437 = null;
        IToken R_BRACE439 = null;
        IToken string_literal440 = null;
        IToken string_literal442 = null;
        IToken C_STRING443 = null;
        IToken string_literal444 = null;
        IToken C_STRING445 = null;
        SmiParser.value_return value436 = default(SmiParser.value_return);

        SmiParser.value_return value438 = default(SmiParser.value_return);

        SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status441 = default(SmiParser.notificationgroup_macro_status_return);


        object string_literal433_tree=null;
        object string_literal434_tree=null;
        object L_BRACE435_tree=null;
        object COMMA437_tree=null;
        object R_BRACE439_tree=null;
        object string_literal440_tree=null;
        object string_literal442_tree=null;
        object C_STRING443_tree=null;
        object string_literal444_tree=null;
        object C_STRING445_tree=null;

        try 
    	{
            // Smi.g:906:26: ( 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:906:26: 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal433=(IToken)Match(input,160,FOLLOW_160_in_notificationgroup_macro5912); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal433_tree = (object)adaptor.Create(string_literal433);
            		adaptor.AddChild(root_0, string_literal433_tree);
            	}
            	string_literal434=(IToken)Match(input,161,FOLLOW_161_in_notificationgroup_macro5914); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal434_tree = (object)adaptor.Create(string_literal434);
            		adaptor.AddChild(root_0, string_literal434_tree);
            	}
            	L_BRACE435=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationgroup_macro5916); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE435_tree = (object)adaptor.Create(L_BRACE435);
            		adaptor.AddChild(root_0, L_BRACE435_tree);
            	}
            	PushFollow(FOLLOW_value_in_notificationgroup_macro5918);
            	value436 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value436.Tree);
            	// Smi.g:906:77: ( COMMA value )*
            	do 
            	{
            	    int alt100 = 2;
            	    int LA100_0 = input.LA(1);

            	    if ( (LA100_0 == COMMA) )
            	    {
            	        alt100 = 1;
            	    }


            	    switch (alt100) 
            		{
            			case 1 :
            			    // Smi.g:906:78: COMMA value
            			    {
            			    	COMMA437=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationgroup_macro5921); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA437_tree = (object)adaptor.Create(COMMA437);
            			    		adaptor.AddChild(root_0, COMMA437_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_notificationgroup_macro5923);
            			    	value438 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value438.Tree);

            			    }
            			    break;

            			default:
            			    goto loop100;
            	    }
            	} while (true);

            	loop100:
            		;	// Stops C# compiler whining that label 'loop100' has no statements

            	R_BRACE439=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationgroup_macro5927); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE439_tree = (object)adaptor.Create(R_BRACE439);
            		adaptor.AddChild(root_0, R_BRACE439_tree);
            	}
            	string_literal440=(IToken)Match(input,184,FOLLOW_184_in_notificationgroup_macro5954); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal440_tree = (object)adaptor.Create(string_literal440);
            		adaptor.AddChild(root_0, string_literal440_tree);
            	}
            	PushFollow(FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5956);
            	notificationgroup_macro_status441 = notificationgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro_status441.Tree);
            	string_literal442=(IToken)Match(input,141,FOLLOW_141_in_notificationgroup_macro5958); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal442_tree = (object)adaptor.Create(string_literal442);
            		adaptor.AddChild(root_0, string_literal442_tree);
            	}
            	C_STRING443=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5960); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING443_tree = (object)adaptor.Create(C_STRING443);
            		adaptor.AddChild(root_0, C_STRING443_tree);
            	}
            	// Smi.g:907:88: ( 'REFERENCE' C_STRING )?
            	int alt101 = 2;
            	int LA101_0 = input.LA(1);

            	if ( (LA101_0 == 177) )
            	{
            	    alt101 = 1;
            	}
            	switch (alt101) 
            	{
            	    case 1 :
            	        // Smi.g:907:89: 'REFERENCE' C_STRING
            	        {
            	        	string_literal444=(IToken)Match(input,177,FOLLOW_177_in_notificationgroup_macro5963); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal444_tree = (object)adaptor.Create(string_literal444);
            	        		adaptor.AddChild(root_0, string_literal444_tree);
            	        	}
            	        	C_STRING445=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5965); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING445_tree = (object)adaptor.Create(C_STRING445);
            	        		adaptor.AddChild(root_0, C_STRING445_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro"

    public class notificationgroup_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro_status"
    // Smi.g:908:0: notificationgroup_macro_status : l= LOWER ;
    public SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_status_return retval = new SmiParser.notificationgroup_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:908:33: (l= LOWER )
            // Smi.g:908:33: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationgroup_macro_status5976); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro_status"

    public class modulecompliance_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro"
    // Smi.g:915:0: modulecompliance_macro : 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ ;
    public SmiParser.modulecompliance_macro_return modulecompliance_macro() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_return retval = new SmiParser.modulecompliance_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal446 = null;
        IToken string_literal447 = null;
        IToken string_literal449 = null;
        IToken C_STRING450 = null;
        IToken string_literal451 = null;
        IToken C_STRING452 = null;
        SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status448 = default(SmiParser.modulecompliance_macro_status_return);

        SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module453 = default(SmiParser.modulecompliance_macro_module_return);


        object string_literal446_tree=null;
        object string_literal447_tree=null;
        object string_literal449_tree=null;
        object C_STRING450_tree=null;
        object string_literal451_tree=null;
        object C_STRING452_tree=null;

        try 
    	{
            // Smi.g:915:25: ( 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ )
            // Smi.g:915:25: 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal446=(IToken)Match(input,158,FOLLOW_158_in_modulecompliance_macro6028); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal446_tree = (object)adaptor.Create(string_literal446);
            		adaptor.AddChild(root_0, string_literal446_tree);
            	}
            	string_literal447=(IToken)Match(input,184,FOLLOW_184_in_modulecompliance_macro6030); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal447_tree = (object)adaptor.Create(string_literal447);
            		adaptor.AddChild(root_0, string_literal447_tree);
            	}
            	PushFollow(FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6032);
            	modulecompliance_macro_status448 = modulecompliance_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_status448.Tree);
            	string_literal449=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro6058); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal449_tree = (object)adaptor.Create(string_literal449);
            		adaptor.AddChild(root_0, string_literal449_tree);
            	}
            	C_STRING450=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6060); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING450_tree = (object)adaptor.Create(C_STRING450);
            		adaptor.AddChild(root_0, C_STRING450_tree);
            	}
            	// Smi.g:916:48: ( 'REFERENCE' C_STRING )?
            	int alt102 = 2;
            	int LA102_0 = input.LA(1);

            	if ( (LA102_0 == 177) )
            	{
            	    alt102 = 1;
            	}
            	switch (alt102) 
            	{
            	    case 1 :
            	        // Smi.g:916:49: 'REFERENCE' C_STRING
            	        {
            	        	string_literal451=(IToken)Match(input,177,FOLLOW_177_in_modulecompliance_macro6063); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal451_tree = (object)adaptor.Create(string_literal451);
            	        		adaptor.AddChild(root_0, string_literal451_tree);
            	        	}
            	        	C_STRING452=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6065); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING452_tree = (object)adaptor.Create(C_STRING452);
            	        		adaptor.AddChild(root_0, C_STRING452_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:916:72: ( modulecompliance_macro_module )+
            	int cnt103 = 0;
            	do 
            	{
            	    int alt103 = 2;
            	    int LA103_0 = input.LA(1);

            	    if ( (LA103_0 == 157) )
            	    {
            	        alt103 = 1;
            	    }


            	    switch (alt103) 
            		{
            			case 1 :
            			    // Smi.g:916:73: modulecompliance_macro_module
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6070);
            			    	modulecompliance_macro_module453 = modulecompliance_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_module453.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt103 >= 1 ) goto loop103;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee103 =
            		                new EarlyExitException(103, input);
            		            throw eee103;
            	    }
            	    cnt103++;
            	} while (true);

            	loop103:
            		;	// Stops C# compiler whining that label 'loop103' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro"

    public class modulecompliance_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_status"
    // Smi.g:917:0: modulecompliance_macro_status : l= LOWER ;
    public SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_status_return retval = new SmiParser.modulecompliance_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:917:32: (l= LOWER )
            // Smi.g:917:32: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_status6081); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_status"

    public class modulecompliance_macro_module_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_module"
    // Smi.g:922:0: modulecompliance_macro_module : 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* ;
    public SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_module_return retval = new SmiParser.modulecompliance_macro_module_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal454 = null;
        IToken UPPER455 = null;
        IToken string_literal457 = null;
        IToken L_BRACE458 = null;
        IToken COMMA460 = null;
        IToken R_BRACE462 = null;
        SmiParser.value_return value456 = default(SmiParser.value_return);

        SmiParser.value_return value459 = default(SmiParser.value_return);

        SmiParser.value_return value461 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance463 = default(SmiParser.modulecompliance_macro_compliance_return);


        object string_literal454_tree=null;
        object UPPER455_tree=null;
        object string_literal457_tree=null;
        object L_BRACE458_tree=null;
        object COMMA460_tree=null;
        object R_BRACE462_tree=null;

        try 
    	{
            // Smi.g:922:32: ( 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* )
            // Smi.g:922:32: 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal454=(IToken)Match(input,157,FOLLOW_157_in_modulecompliance_macro_module6129); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal454_tree = (object)adaptor.Create(string_literal454);
            		adaptor.AddChild(root_0, string_literal454_tree);
            	}
            	// Smi.g:922:41: (=> UPPER (=> value )? )?
            	int alt105 = 2;
            	alt105 = dfa105.Predict(input);
            	switch (alt105) 
            	{
            	    case 1 :
            	        // Smi.g:922:42: => UPPER (=> value )?
            	        {

            	        	UPPER455=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_modulecompliance_macro_module6138); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER455_tree = (object)adaptor.Create(UPPER455);
            	        		adaptor.AddChild(root_0, UPPER455_tree);
            	        	}
            	        	// Smi.g:922:59: (=> value )?
            	        	int alt104 = 2;
            	        	alt104 = dfa104.Predict(input);
            	        	switch (alt104) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:922:60: => value
            	        	        {

            	        	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6147);
            	        	        	value456 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value456.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:923:33: ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt107 = 2;
            	int LA107_0 = input.LA(1);

            	if ( (LA107_0 == 154) )
            	{
            	    alt107 = 1;
            	}
            	switch (alt107) 
            	{
            	    case 1 :
            	        // Smi.g:923:34: 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal457=(IToken)Match(input,154,FOLLOW_154_in_modulecompliance_macro_module6188); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal457_tree = (object)adaptor.Create(string_literal457);
            	        		adaptor.AddChild(root_0, string_literal457_tree);
            	        	}
            	        	L_BRACE458=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_module6190); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE458_tree = (object)adaptor.Create(L_BRACE458);
            	        		adaptor.AddChild(root_0, L_BRACE458_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6192);
            	        	value459 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value459.Tree);
            	        	// Smi.g:923:67: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt106 = 2;
            	        	    int LA106_0 = input.LA(1);

            	        	    if ( (LA106_0 == COMMA) )
            	        	    {
            	        	        alt106 = 1;
            	        	    }


            	        	    switch (alt106) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:923:68: COMMA value
            	        			    {
            	        			    	COMMA460=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_module6195); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA460_tree = (object)adaptor.Create(COMMA460);
            	        			    		adaptor.AddChild(root_0, COMMA460_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6197);
            	        			    	value461 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value461.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop106;
            	        	    }
            	        	} while (true);

            	        	loop106:
            	        		;	// Stops C# compiler whining that label 'loop106' has no statements

            	        	R_BRACE462=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_module6201); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE462_tree = (object)adaptor.Create(R_BRACE462);
            	        		adaptor.AddChild(root_0, R_BRACE462_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:924:33: ( modulecompliance_macro_compliance )*
            	do 
            	{
            	    int alt108 = 2;
            	    int LA108_0 = input.LA(1);

            	    if ( (LA108_0 == OBJECT_KW) )
            	    {
            	        int LA108_2 = input.LA(2);

            	        if ( (LA108_2 == B_STRING || LA108_2 == C_STRING || LA108_2 == FALSE_KW || LA108_2 == H_STRING || LA108_2 == L_BRACE || LA108_2 == LOWER || (LA108_2 >= MINUS && LA108_2 <= NUMBER) || LA108_2 == PLUS_INFINITY_KW || LA108_2 == TRUE_KW || LA108_2 == UPPER) )
            	        {
            	            alt108 = 1;
            	        }


            	    }
            	    else if ( (LA108_0 == 149) )
            	    {
            	        alt108 = 1;
            	    }


            	    switch (alt108) 
            		{
            			case 1 :
            			    // Smi.g:924:34: modulecompliance_macro_compliance
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6238);
            			    	modulecompliance_macro_compliance463 = modulecompliance_macro_compliance();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_compliance463.Tree);

            			    }
            			    break;

            			default:
            			    goto loop108;
            	    }
            	} while (true);

            	loop108:
            		;	// Stops C# compiler whining that label 'loop108' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_module"

    public class modulecompliance_macro_compliance_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_compliance"
    // Smi.g:925:0: modulecompliance_macro_compliance : ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING );
    public SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_compliance_return retval = new SmiParser.modulecompliance_macro_compliance_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal464 = null;
        IToken string_literal466 = null;
        IToken C_STRING467 = null;
        IToken string_literal468 = null;
        IToken string_literal470 = null;
        IToken string_literal472 = null;
        IToken string_literal474 = null;
        IToken string_literal476 = null;
        IToken string_literal478 = null;
        IToken C_STRING479 = null;
        SmiParser.value_return value465 = default(SmiParser.value_return);

        SmiParser.value_return value469 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax471 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax473 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access475 = default(SmiParser.modulecompliance_macro_access_return);

        SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess477 = default(SmiParser.modulecompliance_macro_pibaccess_return);


        object string_literal464_tree=null;
        object string_literal466_tree=null;
        object C_STRING467_tree=null;
        object string_literal468_tree=null;
        object string_literal470_tree=null;
        object string_literal472_tree=null;
        object string_literal474_tree=null;
        object string_literal476_tree=null;
        object string_literal478_tree=null;
        object C_STRING479_tree=null;

        try 
    	{
            // Smi.g:925:36: ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING )
            int alt113 = 2;
            int LA113_0 = input.LA(1);

            if ( (LA113_0 == 149) )
            {
                alt113 = 1;
            }
            else if ( (LA113_0 == OBJECT_KW) )
            {
                alt113 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d113s0 =
                    new NoViableAltException("", 113, 0, input);

                throw nvae_d113s0;
            }
            switch (alt113) 
            {
                case 1 :
                    // Smi.g:925:36: 'GROUP' value 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal464=(IToken)Match(input,149,FOLLOW_149_in_modulecompliance_macro_compliance6247); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal464_tree = (object)adaptor.Create(string_literal464);
                    		adaptor.AddChild(root_0, string_literal464_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6249);
                    	value465 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value465.Tree);
                    	string_literal466=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6251); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal466_tree = (object)adaptor.Create(string_literal466);
                    		adaptor.AddChild(root_0, string_literal466_tree);
                    	}
                    	C_STRING467=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6253); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING467_tree = (object)adaptor.Create(C_STRING467);
                    		adaptor.AddChild(root_0, C_STRING467_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:926:36: 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal468=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6290); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal468_tree = (object)adaptor.Create(string_literal468);
                    		adaptor.AddChild(root_0, string_literal468_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6292);
                    	value469 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value469.Tree);
                    	// Smi.g:927:37: ( 'SYNTAX' modulecompliance_macro_syntax )?
                    	int alt109 = 2;
                    	int LA109_0 = input.LA(1);

                    	if ( (LA109_0 == 187) )
                    	{
                    	    alt109 = 1;
                    	}
                    	switch (alt109) 
                    	{
                    	    case 1 :
                    	        // Smi.g:927:38: 'SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal470=(IToken)Match(input,187,FOLLOW_187_in_modulecompliance_macro_compliance6332); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal470_tree = (object)adaptor.Create(string_literal470);
                    	        		adaptor.AddChild(root_0, string_literal470_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6334);
                    	        	modulecompliance_macro_syntax471 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax471.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:928:37: ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )?
                    	int alt110 = 2;
                    	int LA110_0 = input.LA(1);

                    	if ( (LA110_0 == 197) )
                    	{
                    	    alt110 = 1;
                    	}
                    	switch (alt110) 
                    	{
                    	    case 1 :
                    	        // Smi.g:928:38: 'WRITE-SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal472=(IToken)Match(input,197,FOLLOW_197_in_modulecompliance_macro_compliance6376); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal472_tree = (object)adaptor.Create(string_literal472);
                    	        		adaptor.AddChild(root_0, string_literal472_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6378);
                    	        	modulecompliance_macro_syntax473 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax473.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:929:37: ( 'MIN-ACCESS' modulecompliance_macro_access )?
                    	int alt111 = 2;
                    	int LA111_0 = input.LA(1);

                    	if ( (LA111_0 == 156) )
                    	{
                    	    alt111 = 1;
                    	}
                    	switch (alt111) 
                    	{
                    	    case 1 :
                    	        // Smi.g:929:38: 'MIN-ACCESS' modulecompliance_macro_access
                    	        {
                    	        	string_literal474=(IToken)Match(input,156,FOLLOW_156_in_modulecompliance_macro_compliance6425); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal474_tree = (object)adaptor.Create(string_literal474);
                    	        		adaptor.AddChild(root_0, string_literal474_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6427);
                    	        	modulecompliance_macro_access475 = modulecompliance_macro_access();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_access475.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:930:37: ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )?
                    	int alt112 = 2;
                    	int LA112_0 = input.LA(1);

                    	if ( (LA112_0 == 171) )
                    	{
                    	    alt112 = 1;
                    	}
                    	switch (alt112) 
                    	{
                    	    case 1 :
                    	        // Smi.g:930:38: 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess
                    	        {
                    	        	string_literal476=(IToken)Match(input,171,FOLLOW_171_in_modulecompliance_macro_compliance6469); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal476_tree = (object)adaptor.Create(string_literal476);
                    	        		adaptor.AddChild(root_0, string_literal476_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6471);
                    	        	modulecompliance_macro_pibaccess477 = modulecompliance_macro_pibaccess();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_pibaccess477.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal478=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6516); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal478_tree = (object)adaptor.Create(string_literal478);
                    		adaptor.AddChild(root_0, string_literal478_tree);
                    	}
                    	C_STRING479=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6518); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING479_tree = (object)adaptor.Create(C_STRING479);
                    		adaptor.AddChild(root_0, C_STRING479_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_compliance"

    public class modulecompliance_macro_syntax_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_syntax"
    // Smi.g:932:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_syntax_return retval = new SmiParser.modulecompliance_macro_syntax_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE481 = null;
        IToken COMMA483 = null;
        IToken R_BRACE485 = null;
        SmiParser.smi_type_return smi_type480 = default(SmiParser.smi_type_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit482 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit484 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.smi_type_return smi_type486 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping487 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type488 = default(SmiParser.type_return);


        object L_BRACE481_tree=null;
        object COMMA483_tree=null;
        object R_BRACE485_tree=null;

        try 
    	{
            // Smi.g:932:32: (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt116 = 3;
            alt116 = dfa116.Predict(input);
            switch (alt116) 
            {
                case 1 :
                    // Smi.g:932:32: => smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6532);
                    	smi_type480 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type480.Tree);
                    	L_BRACE481=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6534); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE481_tree = (object)adaptor.Create(L_BRACE481);
                    		adaptor.AddChild(root_0, L_BRACE481_tree);
                    	}
                    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6536);
                    	modulecompliance_macro_namedbit482 = modulecompliance_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit482.Tree);
                    	// Smi.g:932:103: ( COMMA modulecompliance_macro_namedbit )*
                    	do 
                    	{
                    	    int alt114 = 2;
                    	    int LA114_0 = input.LA(1);

                    	    if ( (LA114_0 == COMMA) )
                    	    {
                    	        alt114 = 1;
                    	    }


                    	    switch (alt114) 
                    		{
                    			case 1 :
                    			    // Smi.g:932:104: COMMA modulecompliance_macro_namedbit
                    			    {
                    			    	COMMA483=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_syntax6539); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA483_tree = (object)adaptor.Create(COMMA483);
                    			    		adaptor.AddChild(root_0, COMMA483_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6541);
                    			    	modulecompliance_macro_namedbit484 = modulecompliance_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit484.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop114;
                    	    }
                    	} while (true);

                    	loop114:
                    		;	// Stops C# compiler whining that label 'loop114' has no statements

                    	R_BRACE485=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6545); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE485_tree = (object)adaptor.Create(R_BRACE485);
                    		adaptor.AddChild(root_0, R_BRACE485_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:933:32: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6584);
                    	smi_type486 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type486.Tree);
                    	// Smi.g:933:55: ( smi_subtyping )?
                    	int alt115 = 2;
                    	int LA115_0 = input.LA(1);

                    	if ( (LA115_0 == L_PAREN) )
                    	{
                    	    alt115 = 1;
                    	}
                    	switch (alt115) 
                    	{
                    	    case 1 :
                    	        // Smi.g:933:56: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6587);
                    	        	smi_subtyping487 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping487.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:934:32: type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_modulecompliance_macro_syntax6622);
                    	type488 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type488.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_syntax"

    public class modulecompliance_macro_namedbit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_namedbit"
    // Smi.g:935:0: modulecompliance_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_namedbit_return retval = new SmiParser.modulecompliance_macro_namedbit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER489 = null;
        IToken L_PAREN490 = null;
        IToken NUMBER491 = null;
        IToken R_PAREN492 = null;

        object LOWER489_tree=null;
        object L_PAREN490_tree=null;
        object NUMBER491_tree=null;
        object R_PAREN492_tree=null;

        try 
    	{
            // Smi.g:935:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:935:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER489=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_namedbit6628); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER489_tree = (object)adaptor.Create(LOWER489);
            		adaptor.AddChild(root_0, LOWER489_tree);
            	}
            	L_PAREN490=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6630); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN490_tree = (object)adaptor.Create(L_PAREN490);
            		adaptor.AddChild(root_0, L_PAREN490_tree);
            	}
            	NUMBER491=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6632); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER491_tree = (object)adaptor.Create(NUMBER491);
            		adaptor.AddChild(root_0, NUMBER491_tree);
            	}
            	R_PAREN492=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6634); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN492_tree = (object)adaptor.Create(R_PAREN492);
            		adaptor.AddChild(root_0, R_PAREN492_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_namedbit"

    public class modulecompliance_macro_access_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_access"
    // Smi.g:936:0: modulecompliance_macro_access : l= LOWER ;
    public SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_access_return retval = new SmiParser.modulecompliance_macro_access_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:936:32: (l= LOWER )
            // Smi.g:936:32: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_access6642); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_access"

    public class modulecompliance_macro_pibaccess_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_pibaccess"
    // Smi.g:943:0: modulecompliance_macro_pibaccess : l= LOWER ;
    public SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_pibaccess_return retval = new SmiParser.modulecompliance_macro_pibaccess_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:943:35: (l= LOWER )
            // Smi.g:943:35: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6692); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("install") 
            	                                                  || l.Text == ("notify")
            	                                                  || l.Text == ("install-notify")
            	                                                  || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_pibaccess"

    public class agentcapabilities_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro"
    // Smi.g:952:0: agentcapabilities_macro : 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* ;
    public SmiParser.agentcapabilities_macro_return agentcapabilities_macro() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_return retval = new SmiParser.agentcapabilities_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal493 = null;
        IToken string_literal494 = null;
        IToken C_STRING495 = null;
        IToken string_literal496 = null;
        IToken string_literal498 = null;
        IToken C_STRING499 = null;
        IToken string_literal500 = null;
        IToken C_STRING501 = null;
        SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status497 = default(SmiParser.agentcapabilities_macro_status_return);

        SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module502 = default(SmiParser.agentcapabilities_macro_module_return);


        object string_literal493_tree=null;
        object string_literal494_tree=null;
        object C_STRING495_tree=null;
        object string_literal496_tree=null;
        object string_literal498_tree=null;
        object C_STRING499_tree=null;
        object string_literal500_tree=null;
        object C_STRING501_tree=null;

        try 
    	{
            // Smi.g:952:26: ( 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* )
            // Smi.g:952:26: 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal493=(IToken)Match(input,131,FOLLOW_131_in_agentcapabilities_macro6743); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal493_tree = (object)adaptor.Create(string_literal493);
            		adaptor.AddChild(root_0, string_literal493_tree);
            	}
            	string_literal494=(IToken)Match(input,175,FOLLOW_175_in_agentcapabilities_macro6745); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal494_tree = (object)adaptor.Create(string_literal494);
            		adaptor.AddChild(root_0, string_literal494_tree);
            	}
            	C_STRING495=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6747); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING495_tree = (object)adaptor.Create(C_STRING495);
            		adaptor.AddChild(root_0, C_STRING495_tree);
            	}
            	string_literal496=(IToken)Match(input,184,FOLLOW_184_in_agentcapabilities_macro6749); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal496_tree = (object)adaptor.Create(string_literal496);
            		adaptor.AddChild(root_0, string_literal496_tree);
            	}
            	PushFollow(FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6751);
            	agentcapabilities_macro_status497 = agentcapabilities_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_status497.Tree);
            	string_literal498=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro6778); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal498_tree = (object)adaptor.Create(string_literal498);
            		adaptor.AddChild(root_0, string_literal498_tree);
            	}
            	C_STRING499=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6780); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING499_tree = (object)adaptor.Create(C_STRING499);
            		adaptor.AddChild(root_0, C_STRING499_tree);
            	}
            	// Smi.g:953:49: ( 'REFERENCE' C_STRING )?
            	int alt117 = 2;
            	int LA117_0 = input.LA(1);

            	if ( (LA117_0 == 177) )
            	{
            	    alt117 = 1;
            	}
            	switch (alt117) 
            	{
            	    case 1 :
            	        // Smi.g:953:50: 'REFERENCE' C_STRING
            	        {
            	        	string_literal500=(IToken)Match(input,177,FOLLOW_177_in_agentcapabilities_macro6783); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal500_tree = (object)adaptor.Create(string_literal500);
            	        		adaptor.AddChild(root_0, string_literal500_tree);
            	        	}
            	        	C_STRING501=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6785); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING501_tree = (object)adaptor.Create(C_STRING501);
            	        		adaptor.AddChild(root_0, C_STRING501_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:953:73: ( agentcapabilities_macro_module )*
            	do 
            	{
            	    int alt118 = 2;
            	    int LA118_0 = input.LA(1);

            	    if ( (LA118_0 == 186) )
            	    {
            	        alt118 = 1;
            	    }


            	    switch (alt118) 
            		{
            			case 1 :
            			    // Smi.g:953:74: agentcapabilities_macro_module
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6790);
            			    	agentcapabilities_macro_module502 = agentcapabilities_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_module502.Tree);

            			    }
            			    break;

            			default:
            			    goto loop118;
            	    }
            	} while (true);

            	loop118:
            		;	// Stops C# compiler whining that label 'loop118' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro"

    public class agentcapabilities_macro_status_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_status"
    // Smi.g:954:0: agentcapabilities_macro_status : l= LOWER ;
    public SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_status_return retval = new SmiParser.agentcapabilities_macro_status_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:954:33: (l= LOWER )
            // Smi.g:954:33: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_status6800); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_status"

    public class agentcapabilities_macro_module_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_module"
    // Smi.g:958:0: agentcapabilities_macro_module : 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* ;
    public SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_module_return retval = new SmiParser.agentcapabilities_macro_module_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal503 = null;
        IToken LOWER504 = null;
        IToken string_literal506 = null;
        IToken L_BRACE507 = null;
        IToken COMMA509 = null;
        IToken R_BRACE511 = null;
        SmiParser.value_return value505 = default(SmiParser.value_return);

        SmiParser.value_return value508 = default(SmiParser.value_return);

        SmiParser.value_return value510 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation512 = default(SmiParser.agentcapabilities_macro_variation_return);


        object string_literal503_tree=null;
        object LOWER504_tree=null;
        object string_literal506_tree=null;
        object L_BRACE507_tree=null;
        object COMMA509_tree=null;
        object R_BRACE511_tree=null;

        try 
    	{
            // Smi.g:958:33: ( 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* )
            // Smi.g:958:33: 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal503=(IToken)Match(input,186,FOLLOW_186_in_agentcapabilities_macro_module6848); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal503_tree = (object)adaptor.Create(string_literal503);
            		adaptor.AddChild(root_0, string_literal503_tree);
            	}
            	LOWER504=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_module6850); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER504_tree = (object)adaptor.Create(LOWER504);
            		adaptor.AddChild(root_0, LOWER504_tree);
            	}
            	// Smi.g:958:50: ( value )?
            	int alt119 = 2;
            	int LA119_0 = input.LA(1);

            	if ( (LA119_0 == B_STRING || LA119_0 == C_STRING || LA119_0 == FALSE_KW || LA119_0 == H_STRING || LA119_0 == L_BRACE || LA119_0 == LOWER || (LA119_0 >= MINUS && LA119_0 <= NUMBER) || LA119_0 == PLUS_INFINITY_KW || LA119_0 == TRUE_KW || LA119_0 == UPPER) )
            	{
            	    alt119 = 1;
            	}
            	switch (alt119) 
            	{
            	    case 1 :
            	        // Smi.g:958:51: value
            	        {
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6853);
            	        	value505 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value505.Tree);

            	        }
            	        break;

            	}

            	string_literal506=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6890); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal506_tree = (object)adaptor.Create(string_literal506);
            		adaptor.AddChild(root_0, string_literal506_tree);
            	}
            	L_BRACE507=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_module6892); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE507_tree = (object)adaptor.Create(L_BRACE507);
            		adaptor.AddChild(root_0, L_BRACE507_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6894);
            	value508 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value508.Tree);
            	// Smi.g:959:58: ( COMMA value )*
            	do 
            	{
            	    int alt120 = 2;
            	    int LA120_0 = input.LA(1);

            	    if ( (LA120_0 == COMMA) )
            	    {
            	        alt120 = 1;
            	    }


            	    switch (alt120) 
            		{
            			case 1 :
            			    // Smi.g:959:59: COMMA value
            			    {
            			    	COMMA509=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_module6897); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA509_tree = (object)adaptor.Create(COMMA509);
            			    		adaptor.AddChild(root_0, COMMA509_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6899);
            			    	value510 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value510.Tree);

            			    }
            			    break;

            			default:
            			    goto loop120;
            	    }
            	} while (true);

            	loop120:
            		;	// Stops C# compiler whining that label 'loop120' has no statements

            	R_BRACE511=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_module6903); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE511_tree = (object)adaptor.Create(R_BRACE511);
            		adaptor.AddChild(root_0, R_BRACE511_tree);
            	}
            	// Smi.g:960:33: ( agentcapabilities_macro_variation )*
            	do 
            	{
            	    int alt121 = 2;
            	    int LA121_0 = input.LA(1);

            	    if ( (LA121_0 == 196) )
            	    {
            	        alt121 = 1;
            	    }


            	    switch (alt121) 
            		{
            			case 1 :
            			    // Smi.g:960:34: agentcapabilities_macro_variation
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6939);
            			    	agentcapabilities_macro_variation512 = agentcapabilities_macro_variation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_variation512.Tree);

            			    }
            			    break;

            			default:
            			    goto loop121;
            	    }
            	} while (true);

            	loop121:
            		;	// Stops C# compiler whining that label 'loop121' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_module"

    public class agentcapabilities_macro_variation_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_variation"
    // Smi.g:961:0: agentcapabilities_macro_variation : 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING ;
    public SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_variation_return retval = new SmiParser.agentcapabilities_macro_variation_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal513 = null;
        IToken string_literal515 = null;
        IToken string_literal517 = null;
        IToken string_literal519 = null;
        IToken string_literal521 = null;
        IToken L_BRACE522 = null;
        IToken COMMA524 = null;
        IToken R_BRACE526 = null;
        IToken string_literal527 = null;
        IToken L_BRACE528 = null;
        IToken L_BRACE529 = null;
        IToken LOWER530 = null;
        IToken COMMA531 = null;
        IToken LOWER532 = null;
        IToken R_BRACE533 = null;
        IToken string_literal535 = null;
        IToken C_STRING536 = null;
        SmiParser.value_return value514 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax516 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax518 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access520 = default(SmiParser.agentcapabilities_macro_access_return);

        SmiParser.value_return value523 = default(SmiParser.value_return);

        SmiParser.value_return value525 = default(SmiParser.value_return);

        SmiParser.value_return value534 = default(SmiParser.value_return);


        object string_literal513_tree=null;
        object string_literal515_tree=null;
        object string_literal517_tree=null;
        object string_literal519_tree=null;
        object string_literal521_tree=null;
        object L_BRACE522_tree=null;
        object COMMA524_tree=null;
        object R_BRACE526_tree=null;
        object string_literal527_tree=null;
        object L_BRACE528_tree=null;
        object L_BRACE529_tree=null;
        object LOWER530_tree=null;
        object COMMA531_tree=null;
        object LOWER532_tree=null;
        object R_BRACE533_tree=null;
        object string_literal535_tree=null;
        object C_STRING536_tree=null;

        try 
    	{
            // Smi.g:961:36: ( 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING )
            // Smi.g:961:36: 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal513=(IToken)Match(input,196,FOLLOW_196_in_agentcapabilities_macro_variation6947); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal513_tree = (object)adaptor.Create(string_literal513);
            		adaptor.AddChild(root_0, string_literal513_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation6949);
            	value514 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value514.Tree);
            	// Smi.g:961:54: ( 'SYNTAX' agentcapabilities_macro_syntax )?
            	int alt122 = 2;
            	int LA122_0 = input.LA(1);

            	if ( (LA122_0 == 187) )
            	{
            	    alt122 = 1;
            	}
            	switch (alt122) 
            	{
            	    case 1 :
            	        // Smi.g:961:55: 'SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal515=(IToken)Match(input,187,FOLLOW_187_in_agentcapabilities_macro_variation6952); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal515_tree = (object)adaptor.Create(string_literal515);
            	        		adaptor.AddChild(root_0, string_literal515_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6954);
            	        	agentcapabilities_macro_syntax516 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax516.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:961:97: ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )?
            	int alt123 = 2;
            	int LA123_0 = input.LA(1);

            	if ( (LA123_0 == 197) )
            	{
            	    alt123 = 1;
            	}
            	switch (alt123) 
            	{
            	    case 1 :
            	        // Smi.g:961:98: 'WRITE-SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal517=(IToken)Match(input,197,FOLLOW_197_in_agentcapabilities_macro_variation6959); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal517_tree = (object)adaptor.Create(string_literal517);
            	        		adaptor.AddChild(root_0, string_literal517_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6961);
            	        	agentcapabilities_macro_syntax518 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax518.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:961:146: ( 'ACCESS' agentcapabilities_macro_access )?
            	int alt124 = 2;
            	int LA124_0 = input.LA(1);

            	if ( (LA124_0 == 130) )
            	{
            	    alt124 = 1;
            	}
            	switch (alt124) 
            	{
            	    case 1 :
            	        // Smi.g:961:147: 'ACCESS' agentcapabilities_macro_access
            	        {
            	        	string_literal519=(IToken)Match(input,130,FOLLOW_130_in_agentcapabilities_macro_variation6966); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal519_tree = (object)adaptor.Create(string_literal519);
            	        		adaptor.AddChild(root_0, string_literal519_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6968);
            	        	agentcapabilities_macro_access520 = agentcapabilities_macro_access();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_access520.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:962:37: ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt126 = 2;
            	int LA126_0 = input.LA(1);

            	if ( (LA126_0 == 139) )
            	{
            	    alt126 = 1;
            	}
            	switch (alt126) 
            	{
            	    case 1 :
            	        // Smi.g:962:38: 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal521=(IToken)Match(input,139,FOLLOW_139_in_agentcapabilities_macro_variation7010); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal521_tree = (object)adaptor.Create(string_literal521);
            	        		adaptor.AddChild(root_0, string_literal521_tree);
            	        	}
            	        	L_BRACE522=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7012); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE522_tree = (object)adaptor.Create(L_BRACE522);
            	        		adaptor.AddChild(root_0, L_BRACE522_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7014);
            	        	value523 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value523.Tree);
            	        	// Smi.g:962:72: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt125 = 2;
            	        	    int LA125_0 = input.LA(1);

            	        	    if ( (LA125_0 == COMMA) )
            	        	    {
            	        	        alt125 = 1;
            	        	    }


            	        	    switch (alt125) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:962:73: COMMA value
            	        			    {
            	        			    	COMMA524=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7017); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA524_tree = (object)adaptor.Create(COMMA524);
            	        			    		adaptor.AddChild(root_0, COMMA524_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7019);
            	        			    	value525 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value525.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop125;
            	        	    }
            	        	} while (true);

            	        	loop125:
            	        		;	// Stops C# compiler whining that label 'loop125' has no statements

            	        	R_BRACE526=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7023); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE526_tree = (object)adaptor.Create(R_BRACE526);
            	        		adaptor.AddChild(root_0, R_BRACE526_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:963:37: ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )?
            	int alt130 = 2;
            	int LA130_0 = input.LA(1);

            	if ( (LA130_0 == 140) )
            	{
            	    alt130 = 1;
            	}
            	switch (alt130) 
            	{
            	    case 1 :
            	        // Smi.g:963:38: 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        {
            	        	string_literal527=(IToken)Match(input,140,FOLLOW_140_in_agentcapabilities_macro_variation7065); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal527_tree = (object)adaptor.Create(string_literal527);
            	        		adaptor.AddChild(root_0, string_literal527_tree);
            	        	}
            	        	L_BRACE528=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7067); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE528_tree = (object)adaptor.Create(L_BRACE528);
            	        		adaptor.AddChild(root_0, L_BRACE528_tree);
            	        	}
            	        	// Smi.g:963:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        	int alt129 = 2;
            	        	alt129 = dfa129.Predict(input);
            	        	switch (alt129) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:963:56: => L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE
            	        	        {

            	        	        	L_BRACE529=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7088); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{L_BRACE529_tree = (object)adaptor.Create(L_BRACE529);
            	        	        		adaptor.AddChild(root_0, L_BRACE529_tree);
            	        	        	}
            	        	        	// Smi.g:963:103: ( LOWER )?
            	        	        	int alt127 = 2;
            	        	        	int LA127_0 = input.LA(1);

            	        	        	if ( (LA127_0 == LOWER) )
            	        	        	{
            	        	        	    alt127 = 1;
            	        	        	}
            	        	        	switch (alt127) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:963:104: LOWER
            	        	        	        {
            	        	        	        	LOWER530=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7091); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER530_tree = (object)adaptor.Create(LOWER530);
            	        	        	        		adaptor.AddChild(root_0, LOWER530_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	// Smi.g:963:112: ( COMMA LOWER )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt128 = 2;
            	        	        	    int LA128_0 = input.LA(1);

            	        	        	    if ( (LA128_0 == COMMA) )
            	        	        	    {
            	        	        	        alt128 = 1;
            	        	        	    }


            	        	        	    switch (alt128) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:963:113: COMMA LOWER
            	        	        			    {
            	        	        			    	COMMA531=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7096); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA531_tree = (object)adaptor.Create(COMMA531);
            	        	        			    		adaptor.AddChild(root_0, COMMA531_tree);
            	        	        			    	}
            	        	        			    	LOWER532=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7098); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{LOWER532_tree = (object)adaptor.Create(LOWER532);
            	        	        			    		adaptor.AddChild(root_0, LOWER532_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop128;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop128:
            	        	        		;	// Stops C# compiler whining that label 'loop128' has no statements

            	        	        	R_BRACE533=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7102); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{R_BRACE533_tree = (object)adaptor.Create(R_BRACE533);
            	        	        		adaptor.AddChild(root_0, R_BRACE533_tree);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:963:137: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7106);
            	        	        	value534 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value534.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	string_literal535=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro_variation7149); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal535_tree = (object)adaptor.Create(string_literal535);
            		adaptor.AddChild(root_0, string_literal535_tree);
            	}
            	C_STRING536=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro_variation7151); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING536_tree = (object)adaptor.Create(C_STRING536);
            		adaptor.AddChild(root_0, C_STRING536_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_variation"

    public class agentcapabilities_macro_syntax_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_syntax"
    // Smi.g:965:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_syntax_return retval = new SmiParser.agentcapabilities_macro_syntax_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE538 = null;
        IToken COMMA540 = null;
        IToken R_BRACE542 = null;
        SmiParser.smi_type_return smi_type537 = default(SmiParser.smi_type_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit539 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit541 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.smi_type_return smi_type543 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping544 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type545 = default(SmiParser.type_return);


        object L_BRACE538_tree=null;
        object COMMA540_tree=null;
        object R_BRACE542_tree=null;

        try 
    	{
            // Smi.g:965:33: (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt133 = 3;
            alt133 = dfa133.Predict(input);
            switch (alt133) 
            {
                case 1 :
                    // Smi.g:965:33: => smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7202);
                    	smi_type537 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type537.Tree);
                    	L_BRACE538=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7204); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE538_tree = (object)adaptor.Create(L_BRACE538);
                    		adaptor.AddChild(root_0, L_BRACE538_tree);
                    	}
                    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7206);
                    	agentcapabilities_macro_namedbit539 = agentcapabilities_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit539.Tree);
                    	// Smi.g:966:87: ( COMMA agentcapabilities_macro_namedbit )*
                    	do 
                    	{
                    	    int alt131 = 2;
                    	    int LA131_0 = input.LA(1);

                    	    if ( (LA131_0 == COMMA) )
                    	    {
                    	        alt131 = 1;
                    	    }


                    	    switch (alt131) 
                    		{
                    			case 1 :
                    			    // Smi.g:966:88: COMMA agentcapabilities_macro_namedbit
                    			    {
                    			    	COMMA540=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_syntax7209); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA540_tree = (object)adaptor.Create(COMMA540);
                    			    		adaptor.AddChild(root_0, COMMA540_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7211);
                    			    	agentcapabilities_macro_namedbit541 = agentcapabilities_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit541.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop131;
                    	    }
                    	} while (true);

                    	loop131:
                    		;	// Stops C# compiler whining that label 'loop131' has no statements

                    	R_BRACE542=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7215); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE542_tree = (object)adaptor.Create(R_BRACE542);
                    		adaptor.AddChild(root_0, R_BRACE542_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:967:33: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7255);
                    	smi_type543 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type543.Tree);
                    	// Smi.g:967:56: ( smi_subtyping )?
                    	int alt132 = 2;
                    	int LA132_0 = input.LA(1);

                    	if ( (LA132_0 == L_PAREN) )
                    	{
                    	    alt132 = 1;
                    	}
                    	switch (alt132) 
                    	{
                    	    case 1 :
                    	        // Smi.g:967:57: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7258);
                    	        	smi_subtyping544 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping544.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:968:33: type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_agentcapabilities_macro_syntax7294);
                    	type545 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type545.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_syntax"

    public class agentcapabilities_macro_access_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_access"
    // Smi.g:969:0: agentcapabilities_macro_access : l= LOWER ;
    public SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_access_return retval = new SmiParser.agentcapabilities_macro_access_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken l = null;

        object l_tree=null;

        try 
    	{
            // Smi.g:969:33: (l= LOWER )
            // Smi.g:969:33: l= LOWER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_access7303); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (object)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-implemented") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create")
            	                                                  || l.Text == ("write-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_access"

    public class agentcapabilities_macro_namedbit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_namedbit"
    // Smi.g:977:0: agentcapabilities_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_namedbit_return retval = new SmiParser.agentcapabilities_macro_namedbit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER546 = null;
        IToken L_PAREN547 = null;
        IToken NUMBER548 = null;
        IToken R_PAREN549 = null;

        object LOWER546_tree=null;
        object L_PAREN547_tree=null;
        object NUMBER548_tree=null;
        object R_PAREN549_tree=null;

        try 
    	{
            // Smi.g:977:35: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:977:35: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER546=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7351); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER546_tree = (object)adaptor.Create(LOWER546);
            		adaptor.AddChild(root_0, LOWER546_tree);
            	}
            	L_PAREN547=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7353); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN547_tree = (object)adaptor.Create(L_PAREN547);
            		adaptor.AddChild(root_0, L_PAREN547_tree);
            	}
            	NUMBER548=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7355); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER548_tree = (object)adaptor.Create(NUMBER548);
            		adaptor.AddChild(root_0, NUMBER548_tree);
            	}
            	R_PAREN549=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7357); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN549_tree = (object)adaptor.Create(R_PAREN549);
            		adaptor.AddChild(root_0, R_PAREN549_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_namedbit"

    public class traptype_macro_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "traptype_macro"
    // Smi.g:981:0: traptype_macro : 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? ;
    public SmiParser.traptype_macro_return traptype_macro() // throws RecognitionException [1]
    {   
        SmiParser.traptype_macro_return retval = new SmiParser.traptype_macro_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal550 = null;
        IToken string_literal551 = null;
        IToken string_literal553 = null;
        IToken L_BRACE554 = null;
        IToken COMMA556 = null;
        IToken R_BRACE558 = null;
        IToken string_literal559 = null;
        IToken string_literal561 = null;
        SmiParser.value_return value552 = default(SmiParser.value_return);

        SmiParser.value_return value555 = default(SmiParser.value_return);

        SmiParser.value_return value557 = default(SmiParser.value_return);

        SmiParser.value_return value560 = default(SmiParser.value_return);

        SmiParser.value_return value562 = default(SmiParser.value_return);


        object string_literal550_tree=null;
        object string_literal551_tree=null;
        object string_literal553_tree=null;
        object L_BRACE554_tree=null;
        object COMMA556_tree=null;
        object R_BRACE558_tree=null;
        object string_literal559_tree=null;
        object string_literal561_tree=null;

        try 
    	{
            // Smi.g:981:17: ( 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? )
            // Smi.g:981:17: 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal550=(IToken)Match(input,191,FOLLOW_191_in_traptype_macro7367); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal550_tree = (object)adaptor.Create(string_literal550);
            		adaptor.AddChild(root_0, string_literal550_tree);
            	}
            	string_literal551=(IToken)Match(input,144,FOLLOW_144_in_traptype_macro7369); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal551_tree = (object)adaptor.Create(string_literal551);
            		adaptor.AddChild(root_0, string_literal551_tree);
            	}
            	PushFollow(FOLLOW_value_in_traptype_macro7371);
            	value552 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value552.Tree);
            	// Smi.g:981:48: ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt135 = 2;
            	int LA135_0 = input.LA(1);

            	if ( (LA135_0 == 195) )
            	{
            	    alt135 = 1;
            	}
            	switch (alt135) 
            	{
            	    case 1 :
            	        // Smi.g:981:49: 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal553=(IToken)Match(input,195,FOLLOW_195_in_traptype_macro7374); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal553_tree = (object)adaptor.Create(string_literal553);
            	        		adaptor.AddChild(root_0, string_literal553_tree);
            	        	}
            	        	L_BRACE554=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_traptype_macro7376); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE554_tree = (object)adaptor.Create(L_BRACE554);
            	        		adaptor.AddChild(root_0, L_BRACE554_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7378);
            	        	value555 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value555.Tree);
            	        	// Smi.g:981:75: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt134 = 2;
            	        	    int LA134_0 = input.LA(1);

            	        	    if ( (LA134_0 == COMMA) )
            	        	    {
            	        	        alt134 = 1;
            	        	    }


            	        	    switch (alt134) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:981:76: COMMA value
            	        			    {
            	        			    	COMMA556=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_traptype_macro7381); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA556_tree = (object)adaptor.Create(COMMA556);
            	        			    		adaptor.AddChild(root_0, COMMA556_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_traptype_macro7383);
            	        			    	value557 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value557.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop134;
            	        	    }
            	        	} while (true);

            	        	loop134:
            	        		;	// Stops C# compiler whining that label 'loop134' has no statements

            	        	R_BRACE558=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_traptype_macro7387); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE558_tree = (object)adaptor.Create(R_BRACE558);
            	        		adaptor.AddChild(root_0, R_BRACE558_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:982:21: (=> 'DESCRIPTION' value )?
            	int alt136 = 2;
            	alt136 = dfa136.Predict(input);
            	switch (alt136) 
            	{
            	    case 1 :
            	        // Smi.g:982:22: => 'DESCRIPTION' value
            	        {

            	        	string_literal559=(IToken)Match(input,141,FOLLOW_141_in_traptype_macro7419); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal559_tree = (object)adaptor.Create(string_literal559);
            	        		adaptor.AddChild(root_0, string_literal559_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7421);
            	        	value560 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value560.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:982:63: ( 'REFERENCE' value )?
            	int alt137 = 2;
            	int LA137_0 = input.LA(1);

            	if ( (LA137_0 == 177) )
            	{
            	    alt137 = 1;
            	}
            	switch (alt137) 
            	{
            	    case 1 :
            	        // Smi.g:982:64: 'REFERENCE' value
            	        {
            	        	string_literal561=(IToken)Match(input,177,FOLLOW_177_in_traptype_macro7426); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal561_tree = (object)adaptor.Create(string_literal561);
            	        		adaptor.AddChild(root_0, string_literal561_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7428);
            	        	value562 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value562.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "traptype_macro"

    public class operation_errorlist_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "operation_errorlist"
    // Smi.g:984:0: operation_errorlist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.operation_errorlist_return operation_errorlist() // throws RecognitionException [1]
    {   
        SmiParser.operation_errorlist_return retval = new SmiParser.operation_errorlist_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA564 = null;
        SmiParser.typeorvalue_return typeorvalue563 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue565 = default(SmiParser.typeorvalue_return);


        object COMMA564_tree=null;

        try 
    	{
            // Smi.g:984:22: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:984:22: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7438);
            	typeorvalue563 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue563.Tree);
            	// Smi.g:984:34: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt138 = 2;
            	    int LA138_0 = input.LA(1);

            	    if ( (LA138_0 == COMMA) )
            	    {
            	        alt138 = 1;
            	    }


            	    switch (alt138) 
            		{
            			case 1 :
            			    // Smi.g:984:35: COMMA typeorvalue
            			    {
            			    	COMMA564=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_operation_errorlist7441); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA564_tree = (object)adaptor.Create(COMMA564);
            			    		adaptor.AddChild(root_0, COMMA564_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7443);
            			    	typeorvalue565 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue565.Tree);

            			    }
            			    break;

            			default:
            			    goto loop138;
            	    }
            	} while (true);

            	loop138:
            		;	// Stops C# compiler whining that label 'loop138' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_errorlist"

    public class linkedOp_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "linkedOp_list"
    // Smi.g:986:0: linkedOp_list : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.linkedOp_list_return linkedOp_list() // throws RecognitionException [1]
    {   
        SmiParser.linkedOp_list_return retval = new SmiParser.linkedOp_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA567 = null;
        SmiParser.typeorvalue_return typeorvalue566 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue568 = default(SmiParser.typeorvalue_return);


        object COMMA567_tree=null;

        try 
    	{
            // Smi.g:986:16: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:986:16: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7453);
            	typeorvalue566 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue566.Tree);
            	// Smi.g:986:28: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt139 = 2;
            	    int LA139_0 = input.LA(1);

            	    if ( (LA139_0 == COMMA) )
            	    {
            	        alt139 = 1;
            	    }


            	    switch (alt139) 
            		{
            			case 1 :
            			    // Smi.g:986:29: COMMA typeorvalue
            			    {
            			    	COMMA567=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_linkedOp_list7456); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA567_tree = (object)adaptor.Create(COMMA567);
            			    		adaptor.AddChild(root_0, COMMA567_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7458);
            			    	typeorvalue568 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue568.Tree);

            			    }
            			    break;

            			default:
            			    goto loop139;
            	    }
            	} while (true);

            	loop139:
            		;	// Stops C# compiler whining that label 'loop139' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "linkedOp_list"

    public class typeorvalue_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typeorvalue"
    // Smi.g:988:0: typeorvalue : (=> type | value );
    public SmiParser.typeorvalue_return typeorvalue() // throws RecognitionException [1]
    {   
        SmiParser.typeorvalue_return retval = new SmiParser.typeorvalue_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SmiParser.type_return type569 = default(SmiParser.type_return);

        SmiParser.value_return value570 = default(SmiParser.value_return);



        try 
    	{
            // Smi.g:988:14: (=> type | value )
            int alt140 = 2;
            alt140 = dfa140.Predict(input);
            switch (alt140) 
            {
                case 1 :
                    // Smi.g:988:14: => type
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_type_in_typeorvalue7474);
                    	type569 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type569.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:988:31: value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_typeorvalue7478);
                    	value570 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value570.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvalue"

    public class typeorvaluelist_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "typeorvaluelist"
    // Smi.g:991:0: typeorvaluelist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.typeorvaluelist_return typeorvaluelist() // throws RecognitionException [1]
    {   
        SmiParser.typeorvaluelist_return retval = new SmiParser.typeorvaluelist_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA572 = null;
        SmiParser.typeorvalue_return typeorvalue571 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue573 = default(SmiParser.typeorvalue_return);


        object COMMA572_tree=null;

        try 
    	{
            // Smi.g:991:18: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:991:18: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7486);
            	typeorvalue571 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue571.Tree);
            	// Smi.g:991:30: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt141 = 2;
            	    int LA141_0 = input.LA(1);

            	    if ( (LA141_0 == COMMA) )
            	    {
            	        alt141 = 1;
            	    }


            	    switch (alt141) 
            		{
            			case 1 :
            			    // Smi.g:991:31: COMMA typeorvalue
            			    {
            			    	COMMA572=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typeorvaluelist7489); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA572_tree = (object)adaptor.Create(COMMA572);
            			    		adaptor.AddChild(root_0, COMMA572_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7491);
            			    	typeorvalue573 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue573.Tree);

            			    }
            			    break;

            			default:
            			    goto loop141;
            	    }
            	} while (true);

            	loop141:
            		;	// Stops C# compiler whining that label 'loop141' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvaluelist"

    public class elementType_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elementType"
    // Smi.g:994:0: elementType : ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type );
    public SmiParser.elementType_return elementType() // throws RecognitionException [1]
    {   
        SmiParser.elementType_return retval = new SmiParser.elementType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER574 = null;
        IToken OPTIONAL_KW578 = null;
        IToken DEFAULT_KW579 = null;
        IToken COMPONENTS_KW581 = null;
        IToken OF_KW582 = null;
        SmiParser.tag_return tag575 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default576 = default(SmiParser.tag_default_return);

        SmiParser.type_return type577 = default(SmiParser.type_return);

        SmiParser.value_return value580 = default(SmiParser.value_return);

        SmiParser.type_return type583 = default(SmiParser.type_return);


        object LOWER574_tree=null;
        object OPTIONAL_KW578_tree=null;
        object DEFAULT_KW579_tree=null;
        object COMPONENTS_KW581_tree=null;
        object OF_KW582_tree=null;

        try 
    	{
            // Smi.g:994:14: ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type )
            int alt145 = 2;
            int LA145_0 = input.LA(1);

            if ( (LA145_0 == LOWER) )
            {
                alt145 = 1;
            }
            else if ( (LA145_0 == COMPONENTS_KW) )
            {
                alt145 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d145s0 =
                    new NoViableAltException("", 145, 0, input);

                throw nvae_d145s0;
            }
            switch (alt145) 
            {
                case 1 :
                    // Smi.g:994:14: LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LOWER574=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_elementType7503); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER574_tree = (object)adaptor.Create(LOWER574);
                    		adaptor.AddChild(root_0, LOWER574_tree);
                    	}
                    	// Smi.g:994:21: (=> tag )?
                    	int alt142 = 2;
                    	alt142 = dfa142.Predict(input);
                    	switch (alt142) 
                    	{
                    	    case 1 :
                    	        // Smi.g:994:22: => tag
                    	        {

                    	        	PushFollow(FOLLOW_tag_in_elementType7521);
                    	        	tag575 = tag();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag575.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:995:21: ( tag_default )?
                    	int alt143 = 2;
                    	int LA143_0 = input.LA(1);

                    	if ( (LA143_0 == AUTOMATIC_KW || LA143_0 == EXPLICIT_KW || LA143_0 == IMPLICIT_KW) )
                    	{
                    	    alt143 = 1;
                    	}
                    	switch (alt143) 
                    	{
                    	    case 1 :
                    	        // Smi.g:995:22: tag_default
                    	        {
                    	        	PushFollow(FOLLOW_tag_default_in_elementType7547);
                    	        	tag_default576 = tag_default();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default576.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_elementType7551);
                    	type577 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type577.Tree);
                    	// Smi.g:995:41: ( OPTIONAL_KW | DEFAULT_KW value )?
                    	int alt144 = 3;
                    	int LA144_0 = input.LA(1);

                    	if ( (LA144_0 == OPTIONAL_KW) )
                    	{
                    	    alt144 = 1;
                    	}
                    	else if ( (LA144_0 == DEFAULT_KW) )
                    	{
                    	    alt144 = 2;
                    	}
                    	switch (alt144) 
                    	{
                    	    case 1 :
                    	        // Smi.g:995:42: OPTIONAL_KW
                    	        {
                    	        	OPTIONAL_KW578=(IToken)Match(input,OPTIONAL_KW,FOLLOW_OPTIONAL_KW_in_elementType7554); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{OPTIONAL_KW578_tree = (object)adaptor.Create(OPTIONAL_KW578);
                    	        		adaptor.AddChild(root_0, OPTIONAL_KW578_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:995:56: DEFAULT_KW value
                    	        {
                    	        	DEFAULT_KW579=(IToken)Match(input,DEFAULT_KW,FOLLOW_DEFAULT_KW_in_elementType7558); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{DEFAULT_KW579_tree = (object)adaptor.Create(DEFAULT_KW579);
                    	        		adaptor.AddChild(root_0, DEFAULT_KW579_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_value_in_elementType7560);
                    	        	value580 = value();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value580.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // Smi.g:996:14: COMPONENTS_KW OF_KW type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	COMPONENTS_KW581=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_elementType7578); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMPONENTS_KW581_tree = (object)adaptor.Create(COMPONENTS_KW581);
                    		adaptor.AddChild(root_0, COMPONENTS_KW581_tree);
                    	}
                    	OF_KW582=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_elementType7580); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OF_KW582_tree = (object)adaptor.Create(OF_KW582);
                    		adaptor.AddChild(root_0, OF_KW582_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_elementType7582);
                    	type583 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type583.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType"

    public class namedNumber_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "namedNumber"
    // Smi.g:1000:0: namedNumber : LOWER L_PAREN ( signed_number | defined_value ) R_PAREN ;
    public SmiParser.namedNumber_return namedNumber() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_return retval = new SmiParser.namedNumber_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER584 = null;
        IToken L_PAREN585 = null;
        IToken R_PAREN588 = null;
        SmiParser.signed_number_return signed_number586 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value587 = default(SmiParser.defined_value_return);


        object LOWER584_tree=null;
        object L_PAREN585_tree=null;
        object R_PAREN588_tree=null;

        try 
    	{
            // Smi.g:1000:14: ( LOWER L_PAREN ( signed_number | defined_value ) R_PAREN )
            // Smi.g:1000:14: LOWER L_PAREN ( signed_number | defined_value ) R_PAREN
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER584=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_namedNumber7591); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER584_tree = (object)adaptor.Create(LOWER584);
            		adaptor.AddChild(root_0, LOWER584_tree);
            	}
            	L_PAREN585=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_namedNumber7593); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN585_tree = (object)adaptor.Create(L_PAREN585);
            		adaptor.AddChild(root_0, L_PAREN585_tree);
            	}
            	// Smi.g:1000:28: ( signed_number | defined_value )
            	int alt146 = 2;
            	int LA146_0 = input.LA(1);

            	if ( (LA146_0 == MINUS || LA146_0 == NUMBER) )
            	{
            	    alt146 = 1;
            	}
            	else if ( (LA146_0 == LOWER || LA146_0 == UPPER) )
            	{
            	    alt146 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d146s0 =
            	        new NoViableAltException("", 146, 0, input);

            	    throw nvae_d146s0;
            	}
            	switch (alt146) 
            	{
            	    case 1 :
            	        // Smi.g:1000:29: signed_number
            	        {
            	        	PushFollow(FOLLOW_signed_number_in_namedNumber7596);
            	        	signed_number586 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number586.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1000:45: defined_value
            	        {
            	        	PushFollow(FOLLOW_defined_value_in_namedNumber7600);
            	        	defined_value587 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value587.Tree);

            	        }
            	        break;

            	}

            	R_PAREN588=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_namedNumber7603); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN588_tree = (object)adaptor.Create(R_PAREN588);
            		adaptor.AddChild(root_0, R_PAREN588_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber"

    public class signed_number_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "signed_number"
    // Smi.g:1002:0: signed_number : ( MINUS )? NUMBER ;
    public SmiParser.signed_number_return signed_number() // throws RecognitionException [1]
    {   
        SmiParser.signed_number_return retval = new SmiParser.signed_number_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MINUS589 = null;
        IToken NUMBER590 = null;

        object MINUS589_tree=null;
        object NUMBER590_tree=null;

        try 
    	{
            // Smi.g:1002:16: ( ( MINUS )? NUMBER )
            // Smi.g:1002:16: ( MINUS )? NUMBER
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:1002:16: ( MINUS )?
            	int alt147 = 2;
            	int LA147_0 = input.LA(1);

            	if ( (LA147_0 == MINUS) )
            	{
            	    alt147 = 1;
            	}
            	switch (alt147) 
            	{
            	    case 1 :
            	        // Smi.g:1002:17: MINUS
            	        {
            	        	MINUS589=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signed_number7611); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS589_tree = (object)adaptor.Create(MINUS589);
            	        		adaptor.AddChild(root_0, MINUS589_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER590=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_signed_number7615); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER590_tree = (object)adaptor.Create(NUMBER590);
            		adaptor.AddChild(root_0, NUMBER590_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signed_number"

    public class element_set_specs_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "element_set_specs"
    // Smi.g:1004:0: element_set_specs : element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? ;
    public SmiParser.element_set_specs_return element_set_specs() // throws RecognitionException [1]
    {   
        SmiParser.element_set_specs_return retval = new SmiParser.element_set_specs_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA592 = null;
        IToken DOTDOTDOT593 = null;
        IToken COMMA594 = null;
        SmiParser.element_set_spec_return element_set_spec591 = default(SmiParser.element_set_spec_return);

        SmiParser.element_set_spec_return element_set_spec595 = default(SmiParser.element_set_spec_return);


        object COMMA592_tree=null;
        object DOTDOTDOT593_tree=null;
        object COMMA594_tree=null;

        try 
    	{
            // Smi.g:1004:20: ( element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? )
            // Smi.g:1004:20: element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7622);
            	element_set_spec591 = element_set_spec();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec591.Tree);
            	// Smi.g:1004:37: ( COMMA DOTDOTDOT )?
            	int alt148 = 2;
            	int LA148_0 = input.LA(1);

            	if ( (LA148_0 == COMMA) )
            	{
            	    int LA148_1 = input.LA(2);

            	    if ( (LA148_1 == DOTDOTDOT) )
            	    {
            	        alt148 = 1;
            	    }
            	}
            	switch (alt148) 
            	{
            	    case 1 :
            	        // Smi.g:1004:38: COMMA DOTDOTDOT
            	        {
            	        	COMMA592=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7625); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA592_tree = (object)adaptor.Create(COMMA592);
            	        		adaptor.AddChild(root_0, COMMA592_tree);
            	        	}
            	        	DOTDOTDOT593=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_element_set_specs7627); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOTDOT593_tree = (object)adaptor.Create(DOTDOTDOT593);
            	        		adaptor.AddChild(root_0, DOTDOTDOT593_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1004:56: ( COMMA element_set_spec )?
            	int alt149 = 2;
            	int LA149_0 = input.LA(1);

            	if ( (LA149_0 == COMMA) )
            	{
            	    alt149 = 1;
            	}
            	switch (alt149) 
            	{
            	    case 1 :
            	        // Smi.g:1004:57: COMMA element_set_spec
            	        {
            	        	COMMA594=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7632); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA594_tree = (object)adaptor.Create(COMMA594);
            	        		adaptor.AddChild(root_0, COMMA594_tree);
            	        	}
            	        	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7634);
            	        	element_set_spec595 = element_set_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec595.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_specs"

    public class exception_spec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "exception_spec"
    // Smi.g:1006:0: exception_spec : EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) ;
    public SmiParser.exception_spec_return exception_spec() // throws RecognitionException [1]
    {   
        SmiParser.exception_spec_return retval = new SmiParser.exception_spec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EXCLAMATION596 = null;
        IToken COLON600 = null;
        SmiParser.signed_number_return signed_number597 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value598 = default(SmiParser.defined_value_return);

        SmiParser.type_return type599 = default(SmiParser.type_return);

        SmiParser.value_return value601 = default(SmiParser.value_return);


        object EXCLAMATION596_tree=null;
        object COLON600_tree=null;

        try 
    	{
            // Smi.g:1006:17: ( EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) )
            // Smi.g:1006:17: EXCLAMATION (=> signed_number |=> defined_value | type COLON value )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	EXCLAMATION596=(IToken)Match(input,EXCLAMATION,FOLLOW_EXCLAMATION_in_exception_spec7644); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXCLAMATION596_tree = (object)adaptor.Create(EXCLAMATION596);
            		adaptor.AddChild(root_0, EXCLAMATION596_tree);
            	}
            	// Smi.g:1007:17: (=> signed_number |=> defined_value | type COLON value )
            	int alt150 = 3;
            	int LA150_0 = input.LA(1);

            	if ( (LA150_0 == MINUS) && (synpred42_Smi()) )
            	{
            	    alt150 = 1;
            	}
            	else if ( (LA150_0 == NUMBER) && (synpred42_Smi()) )
            	{
            	    alt150 = 1;
            	}
            	else if ( (LA150_0 == UPPER) )
            	{
            	    int LA150_3 = input.LA(2);

            	    if ( (LA150_3 == DOT) )
            	    {
            	        int LA150_6 = input.LA(3);

            	        if ( (LA150_6 == LOWER) && (synpred43_Smi()) )
            	        {
            	            alt150 = 2;
            	        }
            	        else if ( (LA150_6 == UPPER) )
            	        {
            	            alt150 = 3;
            	        }
            	        else 
            	        {
            	            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	            NoViableAltException nvae_d150s6 =
            	                new NoViableAltException("", 150, 6, input);

            	            throw nvae_d150s6;
            	        }
            	    }
            	    else if ( (LA150_3 == COLON || LA150_3 == L_PAREN) )
            	    {
            	        alt150 = 3;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d150s3 =
            	            new NoViableAltException("", 150, 3, input);

            	        throw nvae_d150s3;
            	    }
            	}
            	else if ( (LA150_0 == LOWER) )
            	{
            	    int LA150_4 = input.LA(2);

            	    if ( (LA150_4 == LESS) )
            	    {
            	        alt150 = 3;
            	    }
            	    else if ( (LA150_4 == R_PAREN) && (synpred43_Smi()) )
            	    {
            	        alt150 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d150s4 =
            	            new NoViableAltException("", 150, 4, input);

            	        throw nvae_d150s4;
            	    }
            	}
            	else if ( (LA150_0 == ANY_KW || (LA150_0 >= BIT_KW && LA150_0 <= BOOLEAN_KW) || LA150_0 == CHARACTER_KW || LA150_0 == CHOICE_KW || LA150_0 == EMBEDDED_KW || (LA150_0 >= ENUMERATED_KW && LA150_0 <= ERROR_KW) || LA150_0 == EXTERNAL_KW || (LA150_0 >= GENERAL_STR_KW && LA150_0 <= GRAPHIC_STR_KW) || LA150_0 == IA5_STRING_KW || LA150_0 == INTEGER_KW || LA150_0 == ISO646_STR_KW || LA150_0 == L_BRACKET || LA150_0 == NULL_KW || LA150_0 == NUMERIC_STR_KW || (LA150_0 >= OBJECT_KW && LA150_0 <= OCTET_KW) || LA150_0 == OPERATION_KW || LA150_0 == PRINTABLE_STR_KW || LA150_0 == REAL_KW || (LA150_0 >= SEQUENCE_KW && LA150_0 <= SET_KW) || LA150_0 == T61_STR_KW || LA150_0 == TELETEX_STR_KW || LA150_0 == UNIVERSAL_STR_KW || (LA150_0 >= UTC_TIME_KW && LA150_0 <= VISIBLE_STR_KW) || LA150_0 == 131 || LA150_0 == 137 || (LA150_0 >= 158 && LA150_0 <= 160) || (LA150_0 >= 162 && LA150_0 <= 164) || LA150_0 == 166 || LA150_0 == 179 || LA150_0 == 188 || LA150_0 == 191) )
            	{
            	    alt150 = 3;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d150s0 =
            	        new NoViableAltException("", 150, 0, input);

            	    throw nvae_d150s0;
            	}
            	switch (alt150) 
            	{
            	    case 1 :
            	        // Smi.g:1007:19: => signed_number
            	        {

            	        	PushFollow(FOLLOW_signed_number_in_exception_spec7671);
            	        	signed_number597 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number597.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1008:21: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_exception_spec7700);
            	        	defined_value598 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value598.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:1009:21: type COLON value
            	        {
            	        	PushFollow(FOLLOW_type_in_exception_spec7723);
            	        	type599 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type599.Tree);
            	        	COLON600=(IToken)Match(input,COLON,FOLLOW_COLON_in_exception_spec7725); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON600_tree = (object)adaptor.Create(COLON600);
            	        		adaptor.AddChild(root_0, COLON600_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_exception_spec7727);
            	        	value601 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value601.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exception_spec"

    public class element_set_spec_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "element_set_spec"
    // Smi.g:1012:0: element_set_spec : ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements );
    public SmiParser.element_set_spec_return element_set_spec() // throws RecognitionException [1]
    {   
        SmiParser.element_set_spec_return retval = new SmiParser.element_set_spec_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set603 = null;
        IToken ALL_KW605 = null;
        IToken EXCEPT_KW606 = null;
        SmiParser.intersections_return intersections602 = default(SmiParser.intersections_return);

        SmiParser.intersections_return intersections604 = default(SmiParser.intersections_return);

        SmiParser.constraint_elements_return constraint_elements607 = default(SmiParser.constraint_elements_return);


        object set603_tree=null;
        object ALL_KW605_tree=null;
        object EXCEPT_KW606_tree=null;

        try 
    	{
            // Smi.g:1012:19: ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements )
            int alt152 = 2;
            int LA152_0 = input.LA(1);

            if ( (LA152_0 == ANY_KW || LA152_0 == B_STRING || (LA152_0 >= BIT_KW && LA152_0 <= BOOLEAN_KW) || (LA152_0 >= C_STRING && LA152_0 <= CHARACTER_KW) || LA152_0 == CHOICE_KW || LA152_0 == EMBEDDED_KW || (LA152_0 >= ENUMERATED_KW && LA152_0 <= ERROR_KW) || (LA152_0 >= EXTERNAL_KW && LA152_0 <= H_STRING) || LA152_0 == IA5_STRING_KW || LA152_0 == INCLUDES_KW || LA152_0 == INTEGER_KW || (LA152_0 >= ISO646_STR_KW && LA152_0 <= L_PAREN) || LA152_0 == LOWER || (LA152_0 >= MIN_KW && LA152_0 <= NUMERIC_STR_KW) || (LA152_0 >= OBJECT_KW && LA152_0 <= OCTET_KW) || LA152_0 == OPERATION_KW || LA152_0 == PATTERN_KW || LA152_0 == PLUS_INFINITY_KW || LA152_0 == PRINTABLE_STR_KW || LA152_0 == REAL_KW || (LA152_0 >= SEQUENCE_KW && LA152_0 <= SET_KW) || LA152_0 == SIZE_KW || LA152_0 == T61_STR_KW || (LA152_0 >= TELETEX_STR_KW && LA152_0 <= TRUE_KW) || (LA152_0 >= UNIVERSAL_STR_KW && LA152_0 <= WITH_KW) || LA152_0 == 131 || LA152_0 == 137 || (LA152_0 >= 158 && LA152_0 <= 160) || (LA152_0 >= 162 && LA152_0 <= 164) || LA152_0 == 166 || LA152_0 == 179 || LA152_0 == 188 || LA152_0 == 191) )
            {
                alt152 = 1;
            }
            else if ( (LA152_0 == ALL_KW) )
            {
                alt152 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d152s0 =
                    new NoViableAltException("", 152, 0, input);

                throw nvae_d152s0;
            }
            switch (alt152) 
            {
                case 1 :
                    // Smi.g:1012:19: intersections ( ( BAR | UNION_KW ) intersections )*
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_intersections_in_element_set_spec7752);
                    	intersections602 = intersections();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections602.Tree);
                    	// Smi.g:1012:33: ( ( BAR | UNION_KW ) intersections )*
                    	do 
                    	{
                    	    int alt151 = 2;
                    	    int LA151_0 = input.LA(1);

                    	    if ( (LA151_0 == BAR || LA151_0 == UNION_KW) )
                    	    {
                    	        alt151 = 1;
                    	    }


                    	    switch (alt151) 
                    		{
                    			case 1 :
                    			    // Smi.g:1012:35: ( BAR | UNION_KW ) intersections
                    			    {
                    			    	set603 = (IToken)input.LT(1);
                    			    	if ( input.LA(1) == BAR || input.LA(1) == UNION_KW ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set603));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}

                    			    	PushFollow(FOLLOW_intersections_in_element_set_spec7764);
                    			    	intersections604 = intersections();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections604.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop151;
                    	    }
                    	} while (true);

                    	loop151:
                    		;	// Stops C# compiler whining that label 'loop151' has no statements


                    }
                    break;
                case 2 :
                    // Smi.g:1013:19: ALL_KW EXCEPT_KW constraint_elements
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ALL_KW605=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_element_set_spec7788); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ALL_KW605_tree = (object)adaptor.Create(ALL_KW605);
                    		adaptor.AddChild(root_0, ALL_KW605_tree);
                    	}
                    	EXCEPT_KW606=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_element_set_spec7790); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EXCEPT_KW606_tree = (object)adaptor.Create(EXCEPT_KW606);
                    		adaptor.AddChild(root_0, EXCEPT_KW606_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_elements_in_element_set_spec7792);
                    	constraint_elements607 = constraint_elements();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements607.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_spec"

    public class intersections_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "intersections"
    // Smi.g:1015:0: intersections : constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* ;
    public SmiParser.intersections_return intersections() // throws RecognitionException [1]
    {   
        SmiParser.intersections_return retval = new SmiParser.intersections_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EXCEPT_KW609 = null;
        IToken set611 = null;
        IToken EXCEPT_KW613 = null;
        SmiParser.constraint_elements_return constraint_elements608 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements610 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements612 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements614 = default(SmiParser.constraint_elements_return);


        object EXCEPT_KW609_tree=null;
        object set611_tree=null;
        object EXCEPT_KW613_tree=null;

        try 
    	{
            // Smi.g:1015:16: ( constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* )
            // Smi.g:1015:16: constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_constraint_elements_in_intersections7799);
            	constraint_elements608 = constraint_elements();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements608.Tree);
            	// Smi.g:1015:36: ( EXCEPT_KW constraint_elements )?
            	int alt153 = 2;
            	int LA153_0 = input.LA(1);

            	if ( (LA153_0 == EXCEPT_KW) )
            	{
            	    alt153 = 1;
            	}
            	switch (alt153) 
            	{
            	    case 1 :
            	        // Smi.g:1015:37: EXCEPT_KW constraint_elements
            	        {
            	        	EXCEPT_KW609=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7802); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXCEPT_KW609_tree = (object)adaptor.Create(EXCEPT_KW609);
            	        		adaptor.AddChild(root_0, EXCEPT_KW609_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_elements_in_intersections7804);
            	        	constraint_elements610 = constraint_elements();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements610.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1016:17: ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            	do 
            	{
            	    int alt155 = 2;
            	    int LA155_0 = input.LA(1);

            	    if ( ((LA155_0 >= INTERSECTION && LA155_0 <= INTERSECTION_KW)) )
            	    {
            	        alt155 = 1;
            	    }


            	    switch (alt155) 
            		{
            			case 1 :
            			    // Smi.g:1016:19: ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )?
            			    {
            			    	set611 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= INTERSECTION && input.LA(1) <= INTERSECTION_KW) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set611));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_constraint_elements_in_intersections7835);
            			    	constraint_elements612 = constraint_elements();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements612.Tree);
            			    	// Smi.g:1016:72: ( EXCEPT_KW constraint_elements )?
            			    	int alt154 = 2;
            			    	int LA154_0 = input.LA(1);

            			    	if ( (LA154_0 == EXCEPT_KW) )
            			    	{
            			    	    alt154 = 1;
            			    	}
            			    	switch (alt154) 
            			    	{
            			    	    case 1 :
            			    	        // Smi.g:1016:73: EXCEPT_KW constraint_elements
            			    	        {
            			    	        	EXCEPT_KW613=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7838); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{EXCEPT_KW613_tree = (object)adaptor.Create(EXCEPT_KW613);
            			    	        		adaptor.AddChild(root_0, EXCEPT_KW613_tree);
            			    	        	}
            			    	        	PushFollow(FOLLOW_constraint_elements_in_intersections7840);
            			    	        	constraint_elements614 = constraint_elements();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements614.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop155;
            	    }
            	} while (true);

            	loop155:
            		;	// Stops C# compiler whining that label 'loop155' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intersections"

    public class constraint_elements_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "constraint_elements"
    // Smi.g:1018:0: constraint_elements : (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );
    public SmiParser.constraint_elements_return constraint_elements() // throws RecognitionException [1]
    {   
        SmiParser.constraint_elements_return retval = new SmiParser.constraint_elements_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken SIZE_KW617 = null;
        IToken FROM_KW619 = null;
        IToken L_PAREN621 = null;
        IToken R_PAREN623 = null;
        IToken INCLUDES_KW624 = null;
        IToken PATTERN_KW626 = null;
        IToken WITH_KW628 = null;
        IToken COMPONENT_KW629 = null;
        IToken COMPONENTS_KW631 = null;
        IToken L_BRACE632 = null;
        IToken DOTDOTDOT633 = null;
        IToken COMMA634 = null;
        IToken R_BRACE636 = null;
        SmiParser.value_return value615 = default(SmiParser.value_return);

        SmiParser.value_range_return value_range616 = default(SmiParser.value_range_return);

        SmiParser.constraint_return constraint618 = default(SmiParser.constraint_return);

        SmiParser.constraint_return constraint620 = default(SmiParser.constraint_return);

        SmiParser.element_set_spec_return element_set_spec622 = default(SmiParser.element_set_spec_return);

        SmiParser.type_return type625 = default(SmiParser.type_return);

        SmiParser.value_return value627 = default(SmiParser.value_return);

        SmiParser.constraint_return constraint630 = default(SmiParser.constraint_return);

        SmiParser.type_constraint_list_return type_constraint_list635 = default(SmiParser.type_constraint_list_return);


        object SIZE_KW617_tree=null;
        object FROM_KW619_tree=null;
        object L_PAREN621_tree=null;
        object R_PAREN623_tree=null;
        object INCLUDES_KW624_tree=null;
        object PATTERN_KW626_tree=null;
        object WITH_KW628_tree=null;
        object COMPONENT_KW629_tree=null;
        object COMPONENTS_KW631_tree=null;
        object L_BRACE632_tree=null;
        object DOTDOTDOT633_tree=null;
        object COMMA634_tree=null;
        object R_BRACE636_tree=null;

        try 
    	{
            // Smi.g:1018:22: (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) )
            int alt159 = 8;
            alt159 = dfa159.Predict(input);
            switch (alt159) 
            {
                case 1 :
                    // Smi.g:1018:22: => value
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_in_constraint_elements7859);
                    	value615 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value615.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:1019:22: => value_range
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_range_in_constraint_elements7889);
                    	value_range616 = value_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value_range616.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:1020:22: SIZE_KW constraint
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	SIZE_KW617=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_constraint_elements7912); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SIZE_KW617_tree = (object)adaptor.Create(SIZE_KW617);
                    		adaptor.AddChild(root_0, SIZE_KW617_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7914);
                    	constraint618 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint618.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:1021:22: FROM_KW constraint
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FROM_KW619=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_constraint_elements7938); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FROM_KW619_tree = (object)adaptor.Create(FROM_KW619);
                    		adaptor.AddChild(root_0, FROM_KW619_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7940);
                    	constraint620 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint620.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:1022:22: L_PAREN element_set_spec R_PAREN
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	L_PAREN621=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint_elements7964); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN621_tree = (object)adaptor.Create(L_PAREN621);
                    		adaptor.AddChild(root_0, L_PAREN621_tree);
                    	}
                    	PushFollow(FOLLOW_element_set_spec_in_constraint_elements7966);
                    	element_set_spec622 = element_set_spec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec622.Tree);
                    	R_PAREN623=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint_elements7968); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN623_tree = (object)adaptor.Create(R_PAREN623);
                    		adaptor.AddChild(root_0, R_PAREN623_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:1023:22: ( INCLUDES_KW )? type
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	// Smi.g:1023:22: ( INCLUDES_KW )?
                    	int alt156 = 2;
                    	int LA156_0 = input.LA(1);

                    	if ( (LA156_0 == INCLUDES_KW) )
                    	{
                    	    alt156 = 1;
                    	}
                    	switch (alt156) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1023:23: INCLUDES_KW
                    	        {
                    	        	INCLUDES_KW624=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_constraint_elements7993); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{INCLUDES_KW624_tree = (object)adaptor.Create(INCLUDES_KW624);
                    	        		adaptor.AddChild(root_0, INCLUDES_KW624_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_constraint_elements7997);
                    	type625 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type625.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:1024:22: PATTERN_KW value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PATTERN_KW626=(IToken)Match(input,PATTERN_KW,FOLLOW_PATTERN_KW_in_constraint_elements8021); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PATTERN_KW626_tree = (object)adaptor.Create(PATTERN_KW626);
                    		adaptor.AddChild(root_0, PATTERN_KW626_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_constraint_elements8023);
                    	value627 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value627.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:1025:22: WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	WITH_KW628=(IToken)Match(input,WITH_KW,FOLLOW_WITH_KW_in_constraint_elements8047); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WITH_KW628_tree = (object)adaptor.Create(WITH_KW628);
                    		adaptor.AddChild(root_0, WITH_KW628_tree);
                    	}
                    	// Smi.g:1025:30: ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    	int alt158 = 2;
                    	int LA158_0 = input.LA(1);

                    	if ( (LA158_0 == COMPONENT_KW) )
                    	{
                    	    alt158 = 1;
                    	}
                    	else if ( (LA158_0 == COMPONENTS_KW) )
                    	{
                    	    alt158 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d158s0 =
                    	        new NoViableAltException("", 158, 0, input);

                    	    throw nvae_d158s0;
                    	}
                    	switch (alt158) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1025:31: COMPONENT_KW constraint
                    	        {
                    	        	COMPONENT_KW629=(IToken)Match(input,COMPONENT_KW,FOLLOW_COMPONENT_KW_in_constraint_elements8050); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENT_KW629_tree = (object)adaptor.Create(COMPONENT_KW629);
                    	        		adaptor.AddChild(root_0, COMPONENT_KW629_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_constraint_in_constraint_elements8052);
                    	        	constraint630 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint630.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1026:33: COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE
                    	        {
                    	        	COMPONENTS_KW631=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_constraint_elements8087); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENTS_KW631_tree = (object)adaptor.Create(COMPONENTS_KW631);
                    	        		adaptor.AddChild(root_0, COMPONENTS_KW631_tree);
                    	        	}
                    	        	L_BRACE632=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_constraint_elements8089); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_BRACE632_tree = (object)adaptor.Create(L_BRACE632);
                    	        		adaptor.AddChild(root_0, L_BRACE632_tree);
                    	        	}
                    	        	// Smi.g:1026:55: ( DOTDOTDOT COMMA )?
                    	        	int alt157 = 2;
                    	        	int LA157_0 = input.LA(1);

                    	        	if ( (LA157_0 == DOTDOTDOT) )
                    	        	{
                    	        	    alt157 = 1;
                    	        	}
                    	        	switch (alt157) 
                    	        	{
                    	        	    case 1 :
                    	        	        // Smi.g:1026:56: DOTDOTDOT COMMA
                    	        	        {
                    	        	        	DOTDOTDOT633=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_constraint_elements8092); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{DOTDOTDOT633_tree = (object)adaptor.Create(DOTDOTDOT633);
                    	        	        		adaptor.AddChild(root_0, DOTDOTDOT633_tree);
                    	        	        	}
                    	        	        	COMMA634=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_constraint_elements8094); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{COMMA634_tree = (object)adaptor.Create(COMMA634);
                    	        	        		adaptor.AddChild(root_0, COMMA634_tree);
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	PushFollow(FOLLOW_type_constraint_list_in_constraint_elements8131);
                    	        	type_constraint_list635 = type_constraint_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_constraint_list635.Tree);
                    	        	R_BRACE636=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_constraint_elements8133); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_BRACE636_tree = (object)adaptor.Create(R_BRACE636);
                    	        		adaptor.AddChild(root_0, R_BRACE636_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint_elements"

    public class value_range_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "value_range"
    // Smi.g:1029:0: value_range : ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) ;
    public SmiParser.value_range_return value_range() // throws RecognitionException [1]
    {   
        SmiParser.value_range_return retval = new SmiParser.value_range_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken MIN_KW638 = null;
        IToken LESS639 = null;
        IToken DOTDOT640 = null;
        IToken LESS641 = null;
        IToken MAX_KW643 = null;
        SmiParser.value_return value637 = default(SmiParser.value_return);

        SmiParser.value_return value642 = default(SmiParser.value_return);


        object MIN_KW638_tree=null;
        object LESS639_tree=null;
        object DOTDOT640_tree=null;
        object LESS641_tree=null;
        object MAX_KW643_tree=null;

        try 
    	{
            // Smi.g:1029:14: ( ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) )
            // Smi.g:1029:14: ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// Smi.g:1029:14: ( value | MIN_KW )
            	int alt160 = 2;
            	int LA160_0 = input.LA(1);

            	if ( (LA160_0 == B_STRING || LA160_0 == C_STRING || LA160_0 == FALSE_KW || LA160_0 == H_STRING || LA160_0 == L_BRACE || LA160_0 == LOWER || (LA160_0 >= MINUS && LA160_0 <= NUMBER) || LA160_0 == PLUS_INFINITY_KW || LA160_0 == TRUE_KW || LA160_0 == UPPER) )
            	{
            	    alt160 = 1;
            	}
            	else if ( (LA160_0 == MIN_KW) )
            	{
            	    alt160 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d160s0 =
            	        new NoViableAltException("", 160, 0, input);

            	    throw nvae_d160s0;
            	}
            	switch (alt160) 
            	{
            	    case 1 :
            	        // Smi.g:1029:15: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8142);
            	        	value637 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value637.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1029:23: MIN_KW
            	        {
            	        	MIN_KW638=(IToken)Match(input,MIN_KW,FOLLOW_MIN_KW_in_value_range8146); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MIN_KW638_tree = (object)adaptor.Create(MIN_KW638);
            	        		adaptor.AddChild(root_0, MIN_KW638_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1029:31: ( LESS )?
            	int alt161 = 2;
            	int LA161_0 = input.LA(1);

            	if ( (LA161_0 == LESS) )
            	{
            	    alt161 = 1;
            	}
            	switch (alt161) 
            	{
            	    case 1 :
            	        // Smi.g:1029:32: LESS
            	        {
            	        	LESS639=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8150); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS639_tree = (object)adaptor.Create(LESS639);
            	        		adaptor.AddChild(root_0, LESS639_tree);
            	        	}

            	        }
            	        break;

            	}

            	DOTDOT640=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_value_range8154); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{DOTDOT640_tree = (object)adaptor.Create(DOTDOT640);
            		adaptor.AddChild(root_0, DOTDOT640_tree);
            	}
            	// Smi.g:1029:46: ( LESS )?
            	int alt162 = 2;
            	int LA162_0 = input.LA(1);

            	if ( (LA162_0 == LESS) )
            	{
            	    alt162 = 1;
            	}
            	switch (alt162) 
            	{
            	    case 1 :
            	        // Smi.g:1029:47: LESS
            	        {
            	        	LESS641=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8157); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS641_tree = (object)adaptor.Create(LESS641);
            	        		adaptor.AddChild(root_0, LESS641_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1029:54: ( value | MAX_KW )
            	int alt163 = 2;
            	int LA163_0 = input.LA(1);

            	if ( (LA163_0 == B_STRING || LA163_0 == C_STRING || LA163_0 == FALSE_KW || LA163_0 == H_STRING || LA163_0 == L_BRACE || LA163_0 == LOWER || (LA163_0 >= MINUS && LA163_0 <= NUMBER) || LA163_0 == PLUS_INFINITY_KW || LA163_0 == TRUE_KW || LA163_0 == UPPER) )
            	{
            	    alt163 = 1;
            	}
            	else if ( (LA163_0 == MAX_KW) )
            	{
            	    alt163 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d163s0 =
            	        new NoViableAltException("", 163, 0, input);

            	    throw nvae_d163s0;
            	}
            	switch (alt163) 
            	{
            	    case 1 :
            	        // Smi.g:1029:55: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8162);
            	        	value642 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value642.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1029:63: MAX_KW
            	        {
            	        	MAX_KW643=(IToken)Match(input,MAX_KW,FOLLOW_MAX_KW_in_value_range8166); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MAX_KW643_tree = (object)adaptor.Create(MAX_KW643);
            	        		adaptor.AddChild(root_0, MAX_KW643_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value_range"

    public class type_constraint_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "type_constraint_list"
    // Smi.g:1031:0: type_constraint_list : named_constraint ( COMMA named_constraint )* ;
    public SmiParser.type_constraint_list_return type_constraint_list() // throws RecognitionException [1]
    {   
        SmiParser.type_constraint_list_return retval = new SmiParser.type_constraint_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA645 = null;
        SmiParser.named_constraint_return named_constraint644 = default(SmiParser.named_constraint_return);

        SmiParser.named_constraint_return named_constraint646 = default(SmiParser.named_constraint_return);


        object COMMA645_tree=null;

        try 
    	{
            // Smi.g:1031:23: ( named_constraint ( COMMA named_constraint )* )
            // Smi.g:1031:23: named_constraint ( COMMA named_constraint )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8175);
            	named_constraint644 = named_constraint();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint644.Tree);
            	// Smi.g:1031:40: ( COMMA named_constraint )*
            	do 
            	{
            	    int alt164 = 2;
            	    int LA164_0 = input.LA(1);

            	    if ( (LA164_0 == COMMA) )
            	    {
            	        alt164 = 1;
            	    }


            	    switch (alt164) 
            		{
            			case 1 :
            			    // Smi.g:1031:41: COMMA named_constraint
            			    {
            			    	COMMA645=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_type_constraint_list8178); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA645_tree = (object)adaptor.Create(COMMA645);
            			    		adaptor.AddChild(root_0, COMMA645_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8180);
            			    	named_constraint646 = named_constraint();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint646.Tree);

            			    }
            			    break;

            			default:
            			    goto loop164;
            	    }
            	} while (true);

            	loop164:
            		;	// Stops C# compiler whining that label 'loop164' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_constraint_list"

    public class named_constraint_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "named_constraint"
    // Smi.g:1033:0: named_constraint : LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? ;
    public SmiParser.named_constraint_return named_constraint() // throws RecognitionException [1]
    {   
        SmiParser.named_constraint_return retval = new SmiParser.named_constraint_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER647 = null;
        IToken set649 = null;
        SmiParser.constraint_return constraint648 = default(SmiParser.constraint_return);


        object LOWER647_tree=null;
        object set649_tree=null;

        try 
    	{
            // Smi.g:1033:19: ( LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? )
            // Smi.g:1033:19: LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER647=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_constraint8190); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER647_tree = (object)adaptor.Create(LOWER647);
            		adaptor.AddChild(root_0, LOWER647_tree);
            	}
            	// Smi.g:1033:25: ( constraint )?
            	int alt165 = 2;
            	int LA165_0 = input.LA(1);

            	if ( (LA165_0 == L_PAREN) )
            	{
            	    alt165 = 1;
            	}
            	switch (alt165) 
            	{
            	    case 1 :
            	        // Smi.g:1033:26: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_named_constraint8193);
            	        	constraint648 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint648.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1033:39: ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            	int alt166 = 2;
            	int LA166_0 = input.LA(1);

            	if ( (LA166_0 == ABSENT_KW || LA166_0 == OPTIONAL_KW || LA166_0 == PRESENT_KW) )
            	{
            	    alt166 = 1;
            	}
            	switch (alt166) 
            	{
            	    case 1 :
            	        // Smi.g:
            	        {
            	        	set649 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == ABSENT_KW || input.LA(1) == OPTIONAL_KW || input.LA(1) == PRESENT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set649));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_constraint"

    public class choice_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "choice_value"
    // Smi.g:1035:0: choice_value : LOWER ( COLON )? value ;
    public SmiParser.choice_value_return choice_value() // throws RecognitionException [1]
    {   
        SmiParser.choice_value_return retval = new SmiParser.choice_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER650 = null;
        IToken COLON651 = null;
        SmiParser.value_return value652 = default(SmiParser.value_return);


        object LOWER650_tree=null;
        object COLON651_tree=null;

        try 
    	{
            // Smi.g:1035:15: ( LOWER ( COLON )? value )
            // Smi.g:1035:15: LOWER ( COLON )? value
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER650=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_choice_value8216); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER650_tree = (object)adaptor.Create(LOWER650);
            		adaptor.AddChild(root_0, LOWER650_tree);
            	}
            	// Smi.g:1035:21: ( COLON )?
            	int alt167 = 2;
            	int LA167_0 = input.LA(1);

            	if ( (LA167_0 == COLON) )
            	{
            	    alt167 = 1;
            	}
            	switch (alt167) 
            	{
            	    case 1 :
            	        // Smi.g:1035:22: COLON
            	        {
            	        	COLON651=(IToken)Match(input,COLON,FOLLOW_COLON_in_choice_value8219); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON651_tree = (object)adaptor.Create(COLON651);
            	        		adaptor.AddChild(root_0, COLON651_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_choice_value8223);
            	value652 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value652.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_value"

    public class sequence_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sequence_value"
    // Smi.g:1037:0: sequence_value : L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE ;
    public SmiParser.sequence_value_return sequence_value() // throws RecognitionException [1]
    {   
        SmiParser.sequence_value_return retval = new SmiParser.sequence_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE653 = null;
        IToken COMMA655 = null;
        IToken R_BRACE657 = null;
        SmiParser.named_value_return named_value654 = default(SmiParser.named_value_return);

        SmiParser.named_value_return named_value656 = default(SmiParser.named_value_return);


        object L_BRACE653_tree=null;
        object COMMA655_tree=null;
        object R_BRACE657_tree=null;

        try 
    	{
            // Smi.g:1037:17: ( L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE )
            // Smi.g:1037:17: L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE653=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_value8230); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE653_tree = (object)adaptor.Create(L_BRACE653);
            		adaptor.AddChild(root_0, L_BRACE653_tree);
            	}
            	// Smi.g:1037:25: ( named_value )?
            	int alt168 = 2;
            	int LA168_0 = input.LA(1);

            	if ( (LA168_0 == LOWER) )
            	{
            	    alt168 = 1;
            	}
            	switch (alt168) 
            	{
            	    case 1 :
            	        // Smi.g:1037:26: named_value
            	        {
            	        	PushFollow(FOLLOW_named_value_in_sequence_value8233);
            	        	named_value654 = named_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value654.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1037:40: ( COMMA named_value )*
            	do 
            	{
            	    int alt169 = 2;
            	    int LA169_0 = input.LA(1);

            	    if ( (LA169_0 == COMMA) )
            	    {
            	        alt169 = 1;
            	    }


            	    switch (alt169) 
            		{
            			case 1 :
            			    // Smi.g:1037:41: COMMA named_value
            			    {
            			    	COMMA655=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequence_value8238); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA655_tree = (object)adaptor.Create(COMMA655);
            			    		adaptor.AddChild(root_0, COMMA655_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_value_in_sequence_value8240);
            			    	named_value656 = named_value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value656.Tree);

            			    }
            			    break;

            			default:
            			    goto loop169;
            	    }
            	} while (true);

            	loop169:
            		;	// Stops C# compiler whining that label 'loop169' has no statements

            	R_BRACE657=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_value8244); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE657_tree = (object)adaptor.Create(R_BRACE657);
            		adaptor.AddChild(root_0, R_BRACE657_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_value"

    public class sequenceof_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "sequenceof_value"
    // Smi.g:1039:0: sequenceof_value : L_BRACE ( value )? ( COMMA value )* R_BRACE ;
    public SmiParser.sequenceof_value_return sequenceof_value() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_value_return retval = new SmiParser.sequenceof_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken L_BRACE658 = null;
        IToken COMMA660 = null;
        IToken R_BRACE662 = null;
        SmiParser.value_return value659 = default(SmiParser.value_return);

        SmiParser.value_return value661 = default(SmiParser.value_return);


        object L_BRACE658_tree=null;
        object COMMA660_tree=null;
        object R_BRACE662_tree=null;

        try 
    	{
            // Smi.g:1039:19: ( L_BRACE ( value )? ( COMMA value )* R_BRACE )
            // Smi.g:1039:19: L_BRACE ( value )? ( COMMA value )* R_BRACE
            {
            	root_0 = (object)adaptor.GetNilNode();

            	L_BRACE658=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequenceof_value8251); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE658_tree = (object)adaptor.Create(L_BRACE658);
            		adaptor.AddChild(root_0, L_BRACE658_tree);
            	}
            	// Smi.g:1039:27: ( value )?
            	int alt170 = 2;
            	int LA170_0 = input.LA(1);

            	if ( (LA170_0 == B_STRING || LA170_0 == C_STRING || LA170_0 == FALSE_KW || LA170_0 == H_STRING || LA170_0 == L_BRACE || LA170_0 == LOWER || (LA170_0 >= MINUS && LA170_0 <= NUMBER) || LA170_0 == PLUS_INFINITY_KW || LA170_0 == TRUE_KW || LA170_0 == UPPER) )
            	{
            	    alt170 = 1;
            	}
            	switch (alt170) 
            	{
            	    case 1 :
            	        // Smi.g:1039:28: value
            	        {
            	        	PushFollow(FOLLOW_value_in_sequenceof_value8254);
            	        	value659 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value659.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1039:36: ( COMMA value )*
            	do 
            	{
            	    int alt171 = 2;
            	    int LA171_0 = input.LA(1);

            	    if ( (LA171_0 == COMMA) )
            	    {
            	        alt171 = 1;
            	    }


            	    switch (alt171) 
            		{
            			case 1 :
            			    // Smi.g:1039:37: COMMA value
            			    {
            			    	COMMA660=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequenceof_value8259); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA660_tree = (object)adaptor.Create(COMMA660);
            			    		adaptor.AddChild(root_0, COMMA660_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_sequenceof_value8261);
            			    	value661 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value661.Tree);

            			    }
            			    break;

            			default:
            			    goto loop171;
            	    }
            	} while (true);

            	loop171:
            		;	// Stops C# compiler whining that label 'loop171' has no statements

            	R_BRACE662=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequenceof_value8265); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE662_tree = (object)adaptor.Create(R_BRACE662);
            		adaptor.AddChild(root_0, R_BRACE662_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_value"

    public class cstr_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "cstr_value"
    // Smi.g:1041:0: cstr_value : (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE );
    public SmiParser.cstr_value_return cstr_value() // throws RecognitionException [1]
    {   
        SmiParser.cstr_value_return retval = new SmiParser.cstr_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken H_STRING663 = null;
        IToken B_STRING664 = null;
        IToken L_BRACE665 = null;
        IToken R_BRACE669 = null;
        SmiParser.id_list_return id_list666 = default(SmiParser.id_list_return);

        SmiParser.char_defs_list_return char_defs_list667 = default(SmiParser.char_defs_list_return);

        SmiParser.tuple_or_quad_return tuple_or_quad668 = default(SmiParser.tuple_or_quad_return);


        object H_STRING663_tree=null;
        object B_STRING664_tree=null;
        object L_BRACE665_tree=null;
        object R_BRACE669_tree=null;

        try 
    	{
            // Smi.g:1041:13: (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE )
            int alt173 = 3;
            int LA173_0 = input.LA(1);

            if ( (LA173_0 == H_STRING) && (synpred46_Smi()) )
            {
                alt173 = 1;
            }
            else if ( (LA173_0 == B_STRING) && (synpred47_Smi()) )
            {
                alt173 = 2;
            }
            else if ( (LA173_0 == L_BRACE) )
            {
                alt173 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d173s0 =
                    new NoViableAltException("", 173, 0, input);

                throw nvae_d173s0;
            }
            switch (alt173) 
            {
                case 1 :
                    // Smi.g:1041:13: => H_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	H_STRING663=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_cstr_value8278); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING663_tree = (object)adaptor.Create(H_STRING663);
                    		adaptor.AddChild(root_0, H_STRING663_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1042:13: => B_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();


                    	B_STRING664=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_cstr_value8299); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING664_tree = (object)adaptor.Create(B_STRING664);
                    		adaptor.AddChild(root_0, B_STRING664_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1043:13: L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	L_BRACE665=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_cstr_value8314); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE665_tree = (object)adaptor.Create(L_BRACE665);
                    		adaptor.AddChild(root_0, L_BRACE665_tree);
                    	}
                    	// Smi.g:1044:13: (=> id_list |=> char_defs_list | tuple_or_quad )
                    	int alt172 = 3;
                    	int LA172_0 = input.LA(1);

                    	if ( (LA172_0 == LOWER) )
                    	{
                    	    int LA172_1 = input.LA(2);

                    	    if ( (synpred48_Smi()) )
                    	    {
                    	        alt172 = 1;
                    	    }
                    	    else if ( (synpred49_Smi()) )
                    	    {
                    	        alt172 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        NoViableAltException nvae_d172s1 =
                    	            new NoViableAltException("", 172, 1, input);

                    	        throw nvae_d172s1;
                    	    }
                    	}
                    	else if ( (LA172_0 == C_STRING) && (synpred49_Smi()) )
                    	{
                    	    alt172 = 2;
                    	}
                    	else if ( (LA172_0 == L_BRACE) && (synpred49_Smi()) )
                    	{
                    	    alt172 = 2;
                    	}
                    	else if ( (LA172_0 == UPPER) && (synpred49_Smi()) )
                    	{
                    	    alt172 = 2;
                    	}
                    	else if ( (LA172_0 == MINUS || LA172_0 == NUMBER) )
                    	{
                    	    alt172 = 3;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d172s0 =
                    	        new NoViableAltException("", 172, 0, input);

                    	    throw nvae_d172s0;
                    	}
                    	switch (alt172) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1044:15: => id_list
                    	        {

                    	        	PushFollow(FOLLOW_id_list_in_cstr_value8337);
                    	        	id_list666 = id_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, id_list666.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1045:17: => char_defs_list
                    	        {

                    	        	PushFollow(FOLLOW_char_defs_list_in_cstr_value8362);
                    	        	char_defs_list667 = char_defs_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs_list667.Tree);

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Smi.g:1046:17: tuple_or_quad
                    	        {
                    	        	PushFollow(FOLLOW_tuple_or_quad_in_cstr_value8381);
                    	        	tuple_or_quad668 = tuple_or_quad();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad668.Tree);

                    	        }
                    	        break;

                    	}

                    	R_BRACE669=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_cstr_value8397); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE669_tree = (object)adaptor.Create(R_BRACE669);
                    		adaptor.AddChild(root_0, R_BRACE669_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cstr_value"

    public class id_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "id_list"
    // Smi.g:1049:0: id_list : LOWER ( COMMA LOWER )* ;
    public SmiParser.id_list_return id_list() // throws RecognitionException [1]
    {   
        SmiParser.id_list_return retval = new SmiParser.id_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER670 = null;
        IToken COMMA671 = null;
        IToken LOWER672 = null;

        object LOWER670_tree=null;
        object COMMA671_tree=null;
        object LOWER672_tree=null;

        try 
    	{
            // Smi.g:1049:10: ( LOWER ( COMMA LOWER )* )
            // Smi.g:1049:10: LOWER ( COMMA LOWER )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER670=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8404); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER670_tree = (object)adaptor.Create(LOWER670);
            		adaptor.AddChild(root_0, LOWER670_tree);
            	}
            	// Smi.g:1049:16: ( COMMA LOWER )*
            	do 
            	{
            	    int alt174 = 2;
            	    int LA174_0 = input.LA(1);

            	    if ( (LA174_0 == COMMA) )
            	    {
            	        alt174 = 1;
            	    }


            	    switch (alt174) 
            		{
            			case 1 :
            			    // Smi.g:1049:17: COMMA LOWER
            			    {
            			    	COMMA671=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_id_list8407); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA671_tree = (object)adaptor.Create(COMMA671);
            			    		adaptor.AddChild(root_0, COMMA671_tree);
            			    	}
            			    	LOWER672=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8409); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER672_tree = (object)adaptor.Create(LOWER672);
            			    		adaptor.AddChild(root_0, LOWER672_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop174;
            	    }
            	} while (true);

            	loop174:
            		;	// Stops C# compiler whining that label 'loop174' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id_list"

    public class char_defs_list_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "char_defs_list"
    // Smi.g:1051:0: char_defs_list : char_defs ( COMMA char_defs )* ;
    public SmiParser.char_defs_list_return char_defs_list() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_list_return retval = new SmiParser.char_defs_list_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA674 = null;
        SmiParser.char_defs_return char_defs673 = default(SmiParser.char_defs_return);

        SmiParser.char_defs_return char_defs675 = default(SmiParser.char_defs_return);


        object COMMA674_tree=null;

        try 
    	{
            // Smi.g:1051:17: ( char_defs ( COMMA char_defs )* )
            // Smi.g:1051:17: char_defs ( COMMA char_defs )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_char_defs_in_char_defs_list8419);
            	char_defs673 = char_defs();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs673.Tree);
            	// Smi.g:1051:27: ( COMMA char_defs )*
            	do 
            	{
            	    int alt175 = 2;
            	    int LA175_0 = input.LA(1);

            	    if ( (LA175_0 == COMMA) )
            	    {
            	        alt175 = 1;
            	    }


            	    switch (alt175) 
            		{
            			case 1 :
            			    // Smi.g:1051:28: COMMA char_defs
            			    {
            			    	COMMA674=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_char_defs_list8422); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA674_tree = (object)adaptor.Create(COMMA674);
            			    		adaptor.AddChild(root_0, COMMA674_tree);
            			    	}
            			    	PushFollow(FOLLOW_char_defs_in_char_defs_list8424);
            			    	char_defs675 = char_defs();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs675.Tree);

            			    }
            			    break;

            			default:
            			    goto loop175;
            	    }
            	} while (true);

            	loop175:
            		;	// Stops C# compiler whining that label 'loop175' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs_list"

    public class tuple_or_quad_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "tuple_or_quad"
    // Smi.g:1054:0: tuple_or_quad : signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? ;
    public SmiParser.tuple_or_quad_return tuple_or_quad() // throws RecognitionException [1]
    {   
        SmiParser.tuple_or_quad_return retval = new SmiParser.tuple_or_quad_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken COMMA677 = null;
        IToken COMMA679 = null;
        IToken COMMA681 = null;
        SmiParser.signed_number_return signed_number676 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number678 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number680 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number682 = default(SmiParser.signed_number_return);


        object COMMA677_tree=null;
        object COMMA679_tree=null;
        object COMMA681_tree=null;

        try 
    	{
            // Smi.g:1054:16: ( signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? )
            // Smi.g:1054:16: signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8435);
            	signed_number676 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number676.Tree);
            	COMMA677=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8437); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMA677_tree = (object)adaptor.Create(COMMA677);
            		adaptor.AddChild(root_0, COMMA677_tree);
            	}
            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8439);
            	signed_number678 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number678.Tree);
            	// Smi.g:1054:50: ( COMMA signed_number COMMA signed_number )?
            	int alt176 = 2;
            	int LA176_0 = input.LA(1);

            	if ( (LA176_0 == COMMA) )
            	{
            	    alt176 = 1;
            	}
            	switch (alt176) 
            	{
            	    case 1 :
            	        // Smi.g:1054:51: COMMA signed_number COMMA signed_number
            	        {
            	        	COMMA679=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8442); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA679_tree = (object)adaptor.Create(COMMA679);
            	        		adaptor.AddChild(root_0, COMMA679_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8444);
            	        	signed_number680 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number680.Tree);
            	        	COMMA681=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8446); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA681_tree = (object)adaptor.Create(COMMA681);
            	        		adaptor.AddChild(root_0, COMMA681_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8448);
            	        	signed_number682 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number682.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tuple_or_quad"

    public class char_defs_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "char_defs"
    // Smi.g:1057:0: char_defs : ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value );
    public SmiParser.char_defs_return char_defs() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_return retval = new SmiParser.char_defs_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken C_STRING683 = null;
        IToken L_BRACE684 = null;
        IToken R_BRACE686 = null;
        SmiParser.tuple_or_quad_return tuple_or_quad685 = default(SmiParser.tuple_or_quad_return);

        SmiParser.defined_value_return defined_value687 = default(SmiParser.defined_value_return);


        object C_STRING683_tree=null;
        object L_BRACE684_tree=null;
        object R_BRACE686_tree=null;

        try 
    	{
            // Smi.g:1057:12: ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value )
            int alt177 = 3;
            switch ( input.LA(1) ) 
            {
            case C_STRING:
            	{
                alt177 = 1;
                }
                break;
            case L_BRACE:
            	{
                alt177 = 2;
                }
                break;
            case LOWER:
            case UPPER:
            	{
                alt177 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d177s0 =
            	        new NoViableAltException("", 177, 0, input);

            	    throw nvae_d177s0;
            }

            switch (alt177) 
            {
                case 1 :
                    // Smi.g:1057:12: C_STRING
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	C_STRING683=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_char_defs8459); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING683_tree = (object)adaptor.Create(C_STRING683);
                    		adaptor.AddChild(root_0, C_STRING683_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1058:12: L_BRACE tuple_or_quad R_BRACE
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	L_BRACE684=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_char_defs8473); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE684_tree = (object)adaptor.Create(L_BRACE684);
                    		adaptor.AddChild(root_0, L_BRACE684_tree);
                    	}
                    	PushFollow(FOLLOW_tuple_or_quad_in_char_defs8475);
                    	tuple_or_quad685 = tuple_or_quad();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad685.Tree);
                    	R_BRACE686=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_char_defs8477); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE686_tree = (object)adaptor.Create(R_BRACE686);
                    		adaptor.AddChild(root_0, R_BRACE686_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1059:12: defined_value
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_char_defs8490);
                    	defined_value687 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value687.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs"

    public class named_value_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "named_value"
    // Smi.g:1064:0: named_value : LOWER value ;
    public SmiParser.named_value_return named_value() // throws RecognitionException [1]
    {   
        SmiParser.named_value_return retval = new SmiParser.named_value_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken LOWER688 = null;
        SmiParser.value_return value689 = default(SmiParser.value_return);


        object LOWER688_tree=null;

        try 
    	{
            // Smi.g:1064:14: ( LOWER value )
            // Smi.g:1064:14: LOWER value
            {
            	root_0 = (object)adaptor.GetNilNode();

            	LOWER688=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_value8500); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER688_tree = (object)adaptor.Create(LOWER688);
            		adaptor.AddChild(root_0, LOWER688_tree);
            	}
            	PushFollow(FOLLOW_value_in_named_value8502);
            	value689 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value689.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_value"

    // $ANTLR start "synpred1_Smi"
    public void synpred1_Smi_fragment() {
        // Smi.g:606:27: ( LOWER ( LOWER | NUMBER ) )
        // Smi.g:606:28: LOWER ( LOWER | NUMBER )
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred1_Smi1952); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred1_Smi"

    // $ANTLR start "synpred10_Smi"
    public void synpred10_Smi_fragment() {
        // Smi.g:662:8: ( sequence_value )
        // Smi.g:662:9: sequence_value
        {
        	PushFollow(FOLLOW_sequence_value_in_synpred10_Smi2578);
        	sequence_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Smi"

    // $ANTLR start "synpred11_Smi"
    public void synpred11_Smi_fragment() {
        // Smi.g:663:8: ( sequenceof_value )
        // Smi.g:663:9: sequenceof_value
        {
        	PushFollow(FOLLOW_sequenceof_value_in_synpred11_Smi2594);
        	sequenceof_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_Smi"

    // $ANTLR start "synpred12_Smi"
    public void synpred12_Smi_fragment() {
        // Smi.g:664:8: ( cstr_value )
        // Smi.g:664:9: cstr_value
        {
        	PushFollow(FOLLOW_cstr_value_in_synpred12_Smi2610);
        	cstr_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_Smi"

    // $ANTLR start "synpred13_Smi"
    public void synpred13_Smi_fragment() {
        // Smi.g:665:8: ( obj_id_comp_lst )
        // Smi.g:665:9: obj_id_comp_lst
        {
        	PushFollow(FOLLOW_obj_id_comp_lst_in_synpred13_Smi2626);
        	obj_id_comp_lst();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_Smi"

    // $ANTLR start "synpred14_Smi"
    public void synpred14_Smi_fragment() {
        // Smi.g:666:8: ( PLUS_INFINITY_KW )
        // Smi.g:666:9: PLUS_INFINITY_KW
        {
        	Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2642); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_Smi"

    // $ANTLR start "synpred15_Smi"
    public void synpred15_Smi_fragment() {
        // Smi.g:667:8: ( MINUS_INFINITY_KW )
        // Smi.g:667:9: MINUS_INFINITY_KW
        {
        	Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2658); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_Smi"

    // $ANTLR start "synpred16_Smi"
    public void synpred16_Smi_fragment() {
        // Smi.g:696:36: ( L_BRACE namedNumber )
        // Smi.g:696:37: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred16_Smi2971); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred16_Smi2973);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_Smi"

    // $ANTLR start "synpred17_Smi"
    public void synpred17_Smi_fragment() {
        // Smi.g:712:27: ( L_BRACE namedNumber )
        // Smi.g:712:28: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred17_Smi3064); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred17_Smi3066);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_Smi"

    // $ANTLR start "synpred18_Smi"
    public void synpred18_Smi_fragment() {
        // Smi.g:756:44: ( LOWER )
        // Smi.g:756:45: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred18_Smi3424); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred18_Smi"

    // $ANTLR start "synpred19_Smi"
    public void synpred19_Smi_fragment() {
        // Smi.g:757:23: ( RESULT_KW )
        // Smi.g:757:24: RESULT_KW
        {
        	Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_synpred19_Smi3462); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_Smi"

    // $ANTLR start "synpred2_Smi"
    public void synpred2_Smi_fragment() {
        // Smi.g:640:29: ( defined_value )
        // Smi.g:640:30: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred2_Smi2250);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Smi"

    // $ANTLR start "synpred20_Smi"
    public void synpred20_Smi_fragment() {
        // Smi.g:758:26: ( LOWER )
        // Smi.g:758:27: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred20_Smi3496); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_Smi"

    // $ANTLR start "synpred21_Smi"
    public void synpred21_Smi_fragment() {
        // Smi.g:758:38: ( LOWER )
        // Smi.g:758:39: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred21_Smi3503); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_Smi"

    // $ANTLR start "synpred22_Smi"
    public void synpred22_Smi_fragment() {
        // Smi.g:760:23: ( ERRORS_KW )
        // Smi.g:760:24: ERRORS_KW
        {
        	Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_synpred22_Smi3549); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_Smi"

    // $ANTLR start "synpred23_Smi"
    public void synpred23_Smi_fragment() {
        // Smi.g:761:23: ( LINKED_KW )
        // Smi.g:761:24: LINKED_KW
        {
        	Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_synpred23_Smi3592); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_Smi"

    // $ANTLR start "synpred24_Smi"
    public void synpred24_Smi_fragment() {
        // Smi.g:771:39: ( LOWER )
        // Smi.g:771:40: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred24_Smi3634); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_Smi"

    // $ANTLR start "synpred25_Smi"
    public void synpred25_Smi_fragment() {
        // Smi.g:802:23: ( smi_type L_BRACE )
        // Smi.g:802:24: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred25_Smi3964);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred25_Smi3966); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred25_Smi"

    // $ANTLR start "synpred26_Smi"
    public void synpred26_Smi_fragment() {
        // Smi.g:803:24: ( smi_type )
        // Smi.g:803:25: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred26_Smi4000);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred26_Smi"

    // $ANTLR start "synpred27_Smi"
    public void synpred27_Smi_fragment() {
        // Smi.g:812:21: ( 'DESCRIPTION' )
        // Smi.g:812:22: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred27_Smi4304); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_Smi"

    // $ANTLR start "synpred28_Smi"
    public void synpred28_Smi_fragment() {
        // Smi.g:815:7: (~ ( 'PIB-INDEX' ) )
        // Smi.g:
        {
        	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= 169) || (input.LA(1) >= 171 && input.LA(1) <= 197) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred28_Smi"

    // $ANTLR start "synpred29_Smi"
    public void synpred29_Smi_fragment() {
        // Smi.g:822:7: ( 'DEFVAL' )
        // Smi.g:822:8: 'DEFVAL'
        {
        	Match(input,140,FOLLOW_140_in_synpred29_Smi4700); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_Smi"

    // $ANTLR start "synpred3_Smi"
    public void synpred3_Smi_fragment() {
        // Smi.g:655:8: ( TRUE_KW )
        // Smi.g:655:9: TRUE_KW
        {
        	Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_synpred3_Smi2466); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Smi"

    // $ANTLR start "synpred30_Smi"
    public void synpred30_Smi_fragment() {
        // Smi.g:823:23: ( L_BRACE LOWER ( COMMA | R_BRACE ) )
        // Smi.g:823:24: L_BRACE LOWER ( COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred30_Smi4733); if (state.failed) return ;
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred30_Smi4735); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred30_Smi"

    // $ANTLR start "synpred31_Smi"
    public void synpred31_Smi_fragment() {
        // Smi.g:887:40: ( smi_type L_BRACE )
        // Smi.g:887:41: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred31_Smi5655);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred31_Smi5657); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Smi"

    // $ANTLR start "synpred32_Smi"
    public void synpred32_Smi_fragment() {
        // Smi.g:922:42: ( UPPER )
        // Smi.g:922:43: UPPER
        {
        	Match(input,UPPER,FOLLOW_UPPER_in_synpred32_Smi6133); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Smi"

    // $ANTLR start "synpred33_Smi"
    public void synpred33_Smi_fragment() {
        // Smi.g:922:60: ( value )
        // Smi.g:922:61: value
        {
        	PushFollow(FOLLOW_value_in_synpred33_Smi6142);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_Smi"

    // $ANTLR start "synpred34_Smi"
    public void synpred34_Smi_fragment() {
        // Smi.g:932:32: ( smi_type L_BRACE )
        // Smi.g:932:33: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred34_Smi6525);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred34_Smi6527); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_Smi"

    // $ANTLR start "synpred35_Smi"
    public void synpred35_Smi_fragment() {
        // Smi.g:933:32: ( smi_type )
        // Smi.g:933:33: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred35_Smi6579);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_Smi"

    // $ANTLR start "synpred36_Smi"
    public void synpred36_Smi_fragment() {
        // Smi.g:963:56: ( L_BRACE ( LOWER | COMMA | R_BRACE ) )
        // Smi.g:963:57: L_BRACE ( LOWER | COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred36_Smi7071); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == LOWER || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred36_Smi"

    // $ANTLR start "synpred37_Smi"
    public void synpred37_Smi_fragment() {
        // Smi.g:965:33: ( smi_type L_BRACE )
        // Smi.g:965:34: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred37_Smi7158);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred37_Smi7160); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_Smi"

    // $ANTLR start "synpred38_Smi"
    public void synpred38_Smi_fragment() {
        // Smi.g:967:33: ( smi_type )
        // Smi.g:967:34: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred38_Smi7250);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_Smi"

    // $ANTLR start "synpred39_Smi"
    public void synpred39_Smi_fragment() {
        // Smi.g:982:22: ( 'DESCRIPTION' )
        // Smi.g:982:23: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred39_Smi7414); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_Smi"

    // $ANTLR start "synpred4_Smi"
    public void synpred4_Smi_fragment() {
        // Smi.g:656:8: ( FALSE_KW )
        // Smi.g:656:9: FALSE_KW
        {
        	Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_synpred4_Smi2482); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_Smi"

    // $ANTLR start "synpred40_Smi"
    public void synpred40_Smi_fragment() {
        // Smi.g:988:14: ( type )
        // Smi.g:988:15: type
        {
        	PushFollow(FOLLOW_type_in_synpred40_Smi7469);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_Smi"

    // $ANTLR start "synpred41_Smi"
    public void synpred41_Smi_fragment() {
        // Smi.g:994:22: ( L_BRACKET ( NUMBER | UPPER | LOWER ) )
        // Smi.g:994:23: L_BRACKET ( NUMBER | UPPER | LOWER )
        {
        	Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_synpred41_Smi7508); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER || input.LA(1) == UPPER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred41_Smi"

    // $ANTLR start "synpred42_Smi"
    public void synpred42_Smi_fragment() {
        // Smi.g:1007:19: ( signed_number )
        // Smi.g:1007:20: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred42_Smi7666);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_Smi"

    // $ANTLR start "synpred43_Smi"
    public void synpred43_Smi_fragment() {
        // Smi.g:1008:21: ( defined_value )
        // Smi.g:1008:22: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred43_Smi7695);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_Smi"

    // $ANTLR start "synpred44_Smi"
    public void synpred44_Smi_fragment() {
        // Smi.g:1018:22: ( value )
        // Smi.g:1018:23: value
        {
        	PushFollow(FOLLOW_value_in_synpred44_Smi7854);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_Smi"

    // $ANTLR start "synpred45_Smi"
    public void synpred45_Smi_fragment() {
        // Smi.g:1019:22: ( value_range )
        // Smi.g:1019:23: value_range
        {
        	PushFollow(FOLLOW_value_range_in_synpred45_Smi7884);
        	value_range();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_Smi"

    // $ANTLR start "synpred46_Smi"
    public void synpred46_Smi_fragment() {
        // Smi.g:1041:13: ( H_STRING )
        // Smi.g:1041:14: H_STRING
        {
        	Match(input,H_STRING,FOLLOW_H_STRING_in_synpred46_Smi8273); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred46_Smi"

    // $ANTLR start "synpred47_Smi"
    public void synpred47_Smi_fragment() {
        // Smi.g:1042:13: ( B_STRING )
        // Smi.g:1042:14: B_STRING
        {
        	Match(input,B_STRING,FOLLOW_B_STRING_in_synpred47_Smi8294); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_Smi"

    // $ANTLR start "synpred48_Smi"
    public void synpred48_Smi_fragment() {
        // Smi.g:1044:15: ( id_list )
        // Smi.g:1044:16: id_list
        {
        	PushFollow(FOLLOW_id_list_in_synpred48_Smi8332);
        	id_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_Smi"

    // $ANTLR start "synpred49_Smi"
    public void synpred49_Smi_fragment() {
        // Smi.g:1045:17: ( char_defs_list )
        // Smi.g:1045:18: char_defs_list
        {
        	PushFollow(FOLLOW_char_defs_list_in_synpred49_Smi8357);
        	char_defs_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_Smi"

    // $ANTLR start "synpred5_Smi"
    public void synpred5_Smi_fragment() {
        // Smi.g:657:8: ( NULL_KW )
        // Smi.g:657:9: NULL_KW
        {
        	Match(input,NULL_KW,FOLLOW_NULL_KW_in_synpred5_Smi2498); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_Smi"

    // $ANTLR start "synpred6_Smi"
    public void synpred6_Smi_fragment() {
        // Smi.g:658:8: ( C_STRING )
        // Smi.g:658:9: C_STRING
        {
        	Match(input,C_STRING,FOLLOW_C_STRING_in_synpred6_Smi2515); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_Smi"

    // $ANTLR start "synpred7_Smi"
    public void synpred7_Smi_fragment() {
        // Smi.g:659:8: ( defined_value )
        // Smi.g:659:9: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred7_Smi2531);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_Smi"

    // $ANTLR start "synpred8_Smi"
    public void synpred8_Smi_fragment() {
        // Smi.g:660:8: ( signed_number )
        // Smi.g:660:9: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred8_Smi2547);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Smi"

    // $ANTLR start "synpred9_Smi"
    public void synpred9_Smi_fragment() {
        // Smi.g:661:8: ( choice_value )
        // Smi.g:661:9: choice_value
        {
        	PushFollow(FOLLOW_choice_value_in_synpred9_Smi2562);
        	choice_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Smi"

    // Delegated rules

   	public bool synpred1_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Smi_fragment(); // can never throw exception
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
   	public bool synpred2_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_Smi_fragment(); // can never throw exception
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
   	public bool synpred7_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_Smi_fragment(); // can never throw exception
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
   	public bool synpred9_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_Smi_fragment(); // can never throw exception
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
   	public bool synpred10_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_Smi_fragment(); // can never throw exception
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
   	public bool synpred11_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_Smi_fragment(); // can never throw exception
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
   	public bool synpred12_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Smi_fragment(); // can never throw exception
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
   	public bool synpred13_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_Smi_fragment(); // can never throw exception
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
   	public bool synpred3_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_Smi_fragment(); // can never throw exception
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
   	public bool synpred4_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_Smi_fragment(); // can never throw exception
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
   	public bool synpred5_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_Smi_fragment(); // can never throw exception
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
   	public bool synpred6_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_Smi_fragment(); // can never throw exception
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
   	public bool synpred8_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_Smi_fragment(); // can never throw exception
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
   	public bool synpred14_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_Smi_fragment(); // can never throw exception
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
   	public bool synpred15_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_Smi_fragment(); // can never throw exception
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
   	public bool synpred16_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_Smi_fragment(); // can never throw exception
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
   	public bool synpred17_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_Smi_fragment(); // can never throw exception
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
   	public bool synpred18_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_Smi_fragment(); // can never throw exception
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
   	public bool synpred21_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_Smi_fragment(); // can never throw exception
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
   	public bool synpred20_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_Smi_fragment(); // can never throw exception
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
   	public bool synpred19_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_Smi_fragment(); // can never throw exception
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
   	public bool synpred22_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred22_Smi_fragment(); // can never throw exception
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
   	public bool synpred23_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred23_Smi_fragment(); // can never throw exception
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
   	public bool synpred24_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_Smi_fragment(); // can never throw exception
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
   	public bool synpred26_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred26_Smi_fragment(); // can never throw exception
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
   	public bool synpred25_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred25_Smi_fragment(); // can never throw exception
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
   	public bool synpred27_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_Smi_fragment(); // can never throw exception
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
   	public bool synpred28_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred28_Smi_fragment(); // can never throw exception
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
   	public bool synpred30_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_Smi_fragment(); // can never throw exception
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
   	public bool synpred29_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_Smi_fragment(); // can never throw exception
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
   	public bool synpred31_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Smi_fragment(); // can never throw exception
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
   	public bool synpred33_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_Smi_fragment(); // can never throw exception
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
   	public bool synpred32_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Smi_fragment(); // can never throw exception
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
   	public bool synpred35_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred35_Smi_fragment(); // can never throw exception
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
   	public bool synpred34_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_Smi_fragment(); // can never throw exception
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
   	public bool synpred36_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_Smi_fragment(); // can never throw exception
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
   	public bool synpred38_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred38_Smi_fragment(); // can never throw exception
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
   	public bool synpred37_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred37_Smi_fragment(); // can never throw exception
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
   	public bool synpred39_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred39_Smi_fragment(); // can never throw exception
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
   	public bool synpred40_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred40_Smi_fragment(); // can never throw exception
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
   	public bool synpred41_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_Smi_fragment(); // can never throw exception
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
   	public bool synpred42_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred42_Smi_fragment(); // can never throw exception
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
   	public bool synpred43_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred43_Smi_fragment(); // can never throw exception
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
   	public bool synpred44_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred44_Smi_fragment(); // can never throw exception
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
   	public bool synpred45_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred45_Smi_fragment(); // can never throw exception
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
   	public bool synpred48_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_Smi_fragment(); // can never throw exception
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
   	public bool synpred49_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_Smi_fragment(); // can never throw exception
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
   	public bool synpred46_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred46_Smi_fragment(); // can never throw exception
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
   	public bool synpred47_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_Smi_fragment(); // can never throw exception
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


   	protected DFA19 dfa19;
   	protected DFA22 dfa22;
   	protected DFA23 dfa23;
   	protected DFA24 dfa24;
   	protected DFA45 dfa45;
   	protected DFA48 dfa48;
   	protected DFA47 dfa47;
   	protected DFA54 dfa54;
   	protected DFA65 dfa65;
   	protected DFA74 dfa74;
   	protected DFA80 dfa80;
   	protected DFA79 dfa79;
   	protected DFA96 dfa96;
   	protected DFA105 dfa105;
   	protected DFA104 dfa104;
   	protected DFA116 dfa116;
   	protected DFA129 dfa129;
   	protected DFA133 dfa133;
   	protected DFA136 dfa136;
   	protected DFA140 dfa140;
   	protected DFA142 dfa142;
   	protected DFA159 dfa159;
	private void InitializeCyclicDFAs()
	{
    	this.dfa19 = new DFA19(this);
    	this.dfa22 = new DFA22(this);
    	this.dfa23 = new DFA23(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa45 = new DFA45(this);
    	this.dfa48 = new DFA48(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa54 = new DFA54(this);
    	this.dfa65 = new DFA65(this);
    	this.dfa74 = new DFA74(this);
    	this.dfa80 = new DFA80(this);
    	this.dfa79 = new DFA79(this);
    	this.dfa96 = new DFA96(this);
    	this.dfa105 = new DFA105(this);
    	this.dfa104 = new DFA104(this);
    	this.dfa116 = new DFA116(this);
    	this.dfa129 = new DFA129(this);
    	this.dfa133 = new DFA133(this);
    	this.dfa136 = new DFA136(this);
    	this.dfa140 = new DFA140(this);
    	this.dfa142 = new DFA142(this);
    	this.dfa159 = new DFA159(this);
	    this.dfa19.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA19_SpecialStateTransition);

	    this.dfa23.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA23_SpecialStateTransition);

	    this.dfa45.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA45_SpecialStateTransition);
	    this.dfa48.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA48_SpecialStateTransition);
	    this.dfa47.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA47_SpecialStateTransition);
	    this.dfa54.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA54_SpecialStateTransition);
	    this.dfa65.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA65_SpecialStateTransition);
	    this.dfa74.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA74_SpecialStateTransition);
	    this.dfa80.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA80_SpecialStateTransition);
	    this.dfa79.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA79_SpecialStateTransition);
	    this.dfa96.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA96_SpecialStateTransition);
	    this.dfa105.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA105_SpecialStateTransition);
	    this.dfa104.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA104_SpecialStateTransition);
	    this.dfa116.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA116_SpecialStateTransition);
	    this.dfa129.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA129_SpecialStateTransition);
	    this.dfa133.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA133_SpecialStateTransition);
	    this.dfa136.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA136_SpecialStateTransition);
	    this.dfa140.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA140_SpecialStateTransition);
	    this.dfa142.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA142_SpecialStateTransition);
	    this.dfa159.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA159_SpecialStateTransition);
	}

    const string DFA19_eotS =
        "\x22\xFFFF";
    const string DFA19_eofS =
        "\x22\xFFFF";
    const string DFA19_minS =
        "\x1\x2B\x1\xFFFF\x2\x1D\x1E\xFFFF";
    const string DFA19_maxS =
        "\x1\xC0\x1\xFFFF\x1\x34\x1\xC0\x1E\xFFFF";
    const string DFA19_acceptS =
        "\x1\xFFFF\x1\x1\x2\xFFFF\x1\x3\x1D\x2";
    const string DFA19_specialS =
        "\x2\xFFFF\x1\x0\x1\x1\x1E\xFFFF}>";
    static readonly string[] DFA19_transitionS = {
            "\x1\x4\x19\xFFFF\x1\x1\x4\xFFFF\x1\x3\x8\xFFFF\x1\x4\x3\xFFFF"+
            "\x1\x4\xF\xFFFF\x1\x4\xF\xFFFF\x1\x2\x6\xFFFF\x4\x4\x1\xFFFF"+
            "\x4\x4\x1\xFFFF\x1\x4\x6\xFFFF\x1\x4\x2\xFFFF\x3\x4\x9\xFFFF"+
            "\x3\x4\x1\xFFFF\x3\x4\x1\xFFFF\x1\x4\x7\xFFFF\x1\x4\x1\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x4\x2\xFFFF\x3\x4\x4\xFFFF\x5\x4",
            "",
            "\x1\x4\x7\xFFFF\x1\x5\xE\xFFFF\x1\x4",
            "\x1\x4\xD\xFFFF\x1\xA\x8\xFFFF\x1\x4\x15\xFFFF\x1\x8\x8\xFFFF"+
            "\x1\x15\x3\xFFFF\x1\x9\xF\xFFFF\x1\x6\xF\xFFFF\x1\x7\x6\xFFFF"+
            "\x1\x18\x1\x1B\x1\x1A\x1\x19\x1\xFFFF\x1\x21\x1\x1C\x1\xE\x1"+
            "\xD\x1\xFFFF\x1\xB\x6\xFFFF\x1\x1D\x2\xFFFF\x1\xF\x1\x11\x1"+
            "\x10\x9\xFFFF\x3\x21\x1\xFFFF\x3\x21\x1\xFFFF\x1\x21\x7\xFFFF"+
            "\x1\x16\x1\xFFFF\x1\x20\x1\xFFFF\x1\x17\x2\xFFFF\x1\x14\x1\x1F"+
            "\x1\x1E\x4\xFFFF\x1\x21\x1\x12\x1\x13\x1\x21\x1\xC",
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
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "639:25: ( obj_id_comp_lst |=> defined_value )?"; }
        }

    }


    protected internal int DFA19_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA19_2 = input.LA(1);

                   	 
                   	int index19_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA19_2 == DOT) && (synpred2_Smi()) ) { s = 5; }

                   	else if ( (LA19_2 == COMMA || LA19_2 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index19_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA19_3 = input.LA(1);

                   	 
                   	int index19_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA19_3 == SEMI) && (synpred2_Smi()) ) { s = 6; }

                   	else if ( (LA19_3 == UPPER) && (synpred2_Smi()) ) { s = 7; }

                   	else if ( (LA19_3 == LOWER) && (synpred2_Smi()) ) { s = 8; }

                   	else if ( (LA19_3 == OPERATION_KW) && (synpred2_Smi()) ) { s = 9; }

                   	else if ( (LA19_3 == ERROR_KW) && (synpred2_Smi()) ) { s = 10; }

                   	else if ( (LA19_3 == 136) && (synpred2_Smi()) ) { s = 11; }

                   	else if ( (LA19_3 == 192) && (synpred2_Smi()) ) { s = 12; }

                   	else if ( (LA19_3 == 134) && (synpred2_Smi()) ) { s = 13; }

                   	else if ( (LA19_3 == 133) && (synpred2_Smi()) ) { s = 14; }

                   	else if ( (LA19_3 == 146) && (synpred2_Smi()) ) { s = 15; }

                   	else if ( (LA19_3 == 148) && (synpred2_Smi()) ) { s = 16; }

                   	else if ( (LA19_3 == 147) && (synpred2_Smi()) ) { s = 17; }

                   	else if ( (LA19_3 == 189) && (synpred2_Smi()) ) { s = 18; }

                   	else if ( (LA19_3 == 190) && (synpred2_Smi()) ) { s = 19; }

                   	else if ( (LA19_3 == 181) && (synpred2_Smi()) ) { s = 20; }

                   	else if ( (LA19_3 == OBJECT_KW) && (synpred2_Smi()) ) { s = 21; }

                   	else if ( (LA19_3 == 174) && (synpred2_Smi()) ) { s = 22; }

                   	else if ( (LA19_3 == 178) && (synpred2_Smi()) ) { s = 23; }

                   	else if ( (LA19_3 == 126) && (synpred2_Smi()) ) { s = 24; }

                   	else if ( (LA19_3 == 129) && (synpred2_Smi()) ) { s = 25; }

                   	else if ( (LA19_3 == 128) && (synpred2_Smi()) ) { s = 26; }

                   	else if ( (LA19_3 == 127) && (synpred2_Smi()) ) { s = 27; }

                   	else if ( (LA19_3 == 132) && (synpred2_Smi()) ) { s = 28; }

                   	else if ( (LA19_3 == 143) && (synpred2_Smi()) ) { s = 29; }

                   	else if ( (LA19_3 == 183) && (synpred2_Smi()) ) { s = 30; }

                   	else if ( (LA19_3 == 182) && (synpred2_Smi()) ) { s = 31; }

                   	else if ( (LA19_3 == 176) && (synpred2_Smi()) ) { s = 32; }

                   	else if ( (LA19_3 == 131 || (LA19_3 >= 158 && LA19_3 <= 160) || (LA19_3 >= 162 && LA19_3 <= 164) || LA19_3 == 166 || LA19_3 == 188 || LA19_3 == 191) && (synpred2_Smi()) ) { s = 33; }

                   	else if ( (LA19_3 == COMMA || LA19_3 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index19_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae19 =
            new NoViableAltException(dfa.Description, 19, _s, input);
        dfa.Error(nvae19);
        throw nvae19;
    }
    const string DFA22_eotS =
        "\xB\xFFFF";
    const string DFA22_eofS =
        "\xB\xFFFF";
    const string DFA22_minS =
        "\x1\x7\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA22_maxS =
        "\x1\xBF\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA22_acceptS =
        "\x1\xFFFF\x2\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x2\x1";
    const string DFA22_specialS =
        "\xB\xFFFF}>";
    static readonly string[] DFA22_transitionS = {
            "\x1\x1\xA\xFFFF\x3\x1\x2\xFFFF\x1\x1\x2\xFFFF\x1\x1\xD\xFFFF"+
            "\x1\x1\x1\xFFFF\x1\x1\x1\x7\x6\xFFFF\x1\x1\x2\xFFFF\x3\x1\x2"+
            "\xFFFF\x1\x1\x6\xFFFF\x1\x2\x2\xFFFF\x1\x1\x1\xFFFF\x1\x2\x3"+
            "\xFFFF\x1\x6\x4\xFFFF\x1\x2\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1"+
            "\x4\x2\xFFFF\x1\x7\x7\xFFFF\x1\x1\x4\xFFFF\x1\x2\x3\xFFFF\x2"+
            "\x2\x4\xFFFF\x1\x1\x1\xFFFF\x1\x1\x5\xFFFF\x1\x1\x1\x5\x4\x1"+
            "\x7\xFFFF\x1\x7\x5\xFFFF\x1\x8\x14\xFFFF\x3\x7\x1\xFFFF\x3\x7"+
            "\x1\xFFFF\x1\x7\xC\xFFFF\x1\x2\x8\xFFFF\x1\x7\x2\xFFFF\x1\x7",
            "",
            "",
            "\x1\x9",
            "\x1\xA",
            "",
            "",
            "",
            "",
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
            get { return "653:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );"; }
        }

    }

    const string DFA23_eotS =
        "\x12\xFFFF";
    const string DFA23_eofS =
        "\x12\xFFFF";
    const string DFA23_minS =
        "\x1\xD\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA23_maxS =
        "\x1\x77\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA23_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\xFFFF\x2\x6\x1\xFFFF"+
        "\x2\xA\x1\xC\x1\xD\x1\x7\x1\x8\x1\x9\x1\xB";
    const string DFA23_specialS =
        "\x1\x0\x5\xFFFF\x1\x1\x2\xFFFF\x1\x2\x8\xFFFF}>";
    static readonly string[] DFA23_transitionS = {
            "\x1\xB\x8\xFFFF\x1\x4\x1C\xFFFF\x1\x2\x4\xFFFF\x1\xA\xC\xFFFF"+
            "\x1\x9\x4\xFFFF\x1\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\xC\xFFFF"+
            "\x1\xC\x13\xFFFF\x1\x1\x5\xFFFF\x1\x5",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "655:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );"; }
        }

    }


    protected internal int DFA23_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA23_0 = input.LA(1);

                   	 
                   	int index23_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA23_0 == TRUE_KW) && (synpred3_Smi()) ) { s = 1; }

                   	else if ( (LA23_0 == FALSE_KW) && (synpred4_Smi()) ) { s = 2; }

                   	else if ( (LA23_0 == NULL_KW) && (synpred5_Smi()) ) { s = 3; }

                   	else if ( (LA23_0 == C_STRING) && (synpred6_Smi()) ) { s = 4; }

                   	else if ( (LA23_0 == UPPER) && (synpred7_Smi()) ) { s = 5; }

                   	else if ( (LA23_0 == LOWER) ) { s = 6; }

                   	else if ( (LA23_0 == MINUS) && (synpred8_Smi()) ) { s = 7; }

                   	else if ( (LA23_0 == NUMBER) && (synpred8_Smi()) ) { s = 8; }

                   	else if ( (LA23_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA23_0 == H_STRING) && (synpred12_Smi()) ) { s = 10; }

                   	else if ( (LA23_0 == B_STRING) && (synpred12_Smi()) ) { s = 11; }

                   	else if ( (LA23_0 == PLUS_INFINITY_KW) && (synpred14_Smi()) ) { s = 12; }

                   	else if ( (LA23_0 == MINUS_INFINITY_KW) && (synpred15_Smi()) ) { s = 13; }

                   	 
                   	input.Seek(index23_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA23_6 = input.LA(1);

                   	 
                   	int index23_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Smi()) ) { s = 5; }

                   	else if ( (synpred9_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index23_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA23_9 = input.LA(1);

                   	 
                   	int index23_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Smi()) ) { s = 15; }

                   	else if ( (synpred11_Smi()) ) { s = 16; }

                   	else if ( (synpred12_Smi()) ) { s = 11; }

                   	else if ( (synpred13_Smi()) ) { s = 17; }

                   	 
                   	input.Seek(index23_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae23 =
            new NoViableAltException(dfa.Description, 23, _s, input);
        dfa.Error(nvae23);
        throw nvae23;
    }
    const string DFA24_eotS =
        "\x16\xFFFF";
    const string DFA24_eofS =
        "\x16\xFFFF";
    const string DFA24_minS =
        "\x1\x7\xE\xFFFF\x2\x45\x5\xFFFF";
    const string DFA24_maxS =
        "\x1\xB3\xE\xFFFF\x2\x6B\x5\xFFFF";
    const string DFA24_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
        "\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x2\xFFFF\x1\x13\x1\xF\x1\x10\x1\x11"+
        "\x1\x12";
    const string DFA24_specialS =
        "\x16\xFFFF}>";
    static readonly string[] DFA24_transitionS = {
            "\x1\x1\xA\xFFFF\x1\x2\x1\x4\x1\x3\x2\xFFFF\x1\x4\x2\xFFFF\x1"+
            "\x5\xD\xFFFF\x1\x6\x1\xFFFF\x1\x7\x7\xFFFF\x1\x8\x2\xFFFF\x3"+
            "\x4\x2\xFFFF\x1\x4\x6\xFFFF\x1\x9\x2\xFFFF\x1\x4\x1\xFFFF\x1"+
            "\x11\x8\xFFFF\x1\xA\x1\xFFFF\x1\x4\x1\xFFFF\x1\xB\x1\xC\xA\xFFFF"+
            "\x1\x4\x4\xFFFF\x1\xD\x3\xFFFF\x1\xF\x1\x10\x4\xFFFF\x1\x4\x1"+
            "\xFFFF\x1\x4\x5\xFFFF\x1\x4\x1\xFFFF\x4\x4\x37\xFFFF\x1\xE",
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
            "",
            "\x1\x12\xF\xFFFF\x1\x13\x15\xFFFF\x1\x13",
            "\x1\x14\xF\xFFFF\x1\x15\x15\xFFFF\x1\x15",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "669:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );"; }
        }

    }

    const string DFA45_eotS =
        "\x24\xFFFF";
    const string DFA45_eofS =
        "\x24\xFFFF";
    const string DFA45_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA45_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA45_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA45_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA45_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA45_eot = DFA.UnpackEncodedString(DFA45_eotS);
    static readonly short[] DFA45_eof = DFA.UnpackEncodedString(DFA45_eofS);
    static readonly char[] DFA45_min = DFA.UnpackEncodedStringToUnsignedChars(DFA45_minS);
    static readonly char[] DFA45_max = DFA.UnpackEncodedStringToUnsignedChars(DFA45_maxS);
    static readonly short[] DFA45_accept = DFA.UnpackEncodedString(DFA45_acceptS);
    static readonly short[] DFA45_special = DFA.UnpackEncodedString(DFA45_specialS);
    static readonly short[][] DFA45_transition = DFA.UnpackEncodedStringArray(DFA45_transitionS);

    protected class DFA45 : DFA
    {
        public DFA45(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 45;
            this.eot = DFA45_eot;
            this.eof = DFA45_eof;
            this.min = DFA45_min;
            this.max = DFA45_max;
            this.accept = DFA45_accept;
            this.special = DFA45_special;
            this.transition = DFA45_transition;

        }

        override public string Description
        {
            get { return "756:43: (=> LOWER )?"; }
        }

    }


    protected internal int DFA45_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA45_1 = input.LA(1);

                   	 
                   	int index45_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA45_1 == LESS) ) { s = 2; }

                   	else if ( (LA45_1 == ANY_KW) && (synpred18_Smi()) ) { s = 3; }

                   	else if ( (LA45_1 == BIT_KW) && (synpred18_Smi()) ) { s = 4; }

                   	else if ( (LA45_1 == BOOLEAN_KW) && (synpred18_Smi()) ) { s = 5; }

                   	else if ( (LA45_1 == CHARACTER_KW) && (synpred18_Smi()) ) { s = 6; }

                   	else if ( (LA45_1 == BMP_STR_KW || (LA45_1 >= GENERAL_STR_KW && LA45_1 <= GRAPHIC_STR_KW) || LA45_1 == IA5_STRING_KW || LA45_1 == ISO646_STR_KW || LA45_1 == NUMERIC_STR_KW || LA45_1 == PRINTABLE_STR_KW || LA45_1 == T61_STR_KW || LA45_1 == TELETEX_STR_KW || LA45_1 == UNIVERSAL_STR_KW || (LA45_1 >= UTC_TIME_KW && LA45_1 <= VISIBLE_STR_KW)) && (synpred18_Smi()) ) { s = 7; }

                   	else if ( (LA45_1 == CHOICE_KW) && (synpred18_Smi()) ) { s = 8; }

                   	else if ( (LA45_1 == EMBEDDED_KW) && (synpred18_Smi()) ) { s = 9; }

                   	else if ( (LA45_1 == ENUMERATED_KW) && (synpred18_Smi()) ) { s = 10; }

                   	else if ( (LA45_1 == EXTERNAL_KW) && (synpred18_Smi()) ) { s = 11; }

                   	else if ( (LA45_1 == INTEGER_KW) && (synpred18_Smi()) ) { s = 12; }

                   	else if ( (LA45_1 == NULL_KW) && (synpred18_Smi()) ) { s = 13; }

                   	else if ( (LA45_1 == OBJECT_KW) && (synpred18_Smi()) ) { s = 14; }

                   	else if ( (LA45_1 == OCTET_KW) && (synpred18_Smi()) ) { s = 15; }

                   	else if ( (LA45_1 == REAL_KW) && (synpred18_Smi()) ) { s = 16; }

                   	else if ( (LA45_1 == 179) && (synpred18_Smi()) ) { s = 17; }

                   	else if ( (LA45_1 == SEQUENCE_KW) && (synpred18_Smi()) ) { s = 18; }

                   	else if ( (LA45_1 == SET_KW) && (synpred18_Smi()) ) { s = 19; }

                   	else if ( (LA45_1 == L_BRACKET) && (synpred18_Smi()) ) { s = 20; }

                   	else if ( (LA45_1 == UPPER) && (synpred18_Smi()) ) { s = 21; }

                   	else if ( (LA45_1 == LOWER) && (synpred18_Smi()) ) { s = 22; }

                   	else if ( (LA45_1 == OPERATION_KW) && (synpred18_Smi()) ) { s = 23; }

                   	else if ( (LA45_1 == ERROR_KW) && (synpred18_Smi()) ) { s = 24; }

                   	else if ( (LA45_1 == 166) && (synpred18_Smi()) ) { s = 25; }

                   	else if ( (LA45_1 == 159) && (synpred18_Smi()) ) { s = 26; }

                   	else if ( (LA45_1 == 164) && (synpred18_Smi()) ) { s = 27; }

                   	else if ( (LA45_1 == 162) && (synpred18_Smi()) ) { s = 28; }

                   	else if ( (LA45_1 == 188) && (synpred18_Smi()) ) { s = 29; }

                   	else if ( (LA45_1 == 163) && (synpred18_Smi()) ) { s = 30; }

                   	else if ( (LA45_1 == 160) && (synpred18_Smi()) ) { s = 31; }

                   	else if ( (LA45_1 == 158) && (synpred18_Smi()) ) { s = 32; }

                   	else if ( (LA45_1 == 131) && (synpred18_Smi()) ) { s = 33; }

                   	else if ( (LA45_1 == 191) && (synpred18_Smi()) ) { s = 34; }

                   	else if ( (LA45_1 == 137) && (synpred18_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index45_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae45 =
            new NoViableAltException(dfa.Description, 45, _s, input);
        dfa.Error(nvae45);
        throw nvae45;
    }
    const string DFA48_eotS =
        "\x54\xFFFF";
    const string DFA48_eofS =
        "\x1\x22\x53\xFFFF";
    const string DFA48_minS =
        "\x1\x7\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA48_maxS =
        "\x1\xC5\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA48_acceptS =
        "\x2\xFFFF\xB\x1\x1\xFFFF\x6\x1\xD\xFFFF\x1\x1\x1\x2\x31\xFFFF";
    const string DFA48_specialS =
        "\x1\x0\x1\x1\xB\xFFFF\x1\x2\x6\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1"+
        "\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x33\xFFFF}>";
    static readonly string[] DFA48_transitionS = {
            "\x1\x2\x2\xFFFF\x1\x22\x3\xFFFF\x1\x22\x3\xFFFF\x1\x3\x1\x6"+
            "\x1\x4\x2\xFFFF\x1\x5\x2\xFFFF\x1\x7\x1\xFFFF\x2\x22\x4\xFFFF"+
            "\x1\x22\x5\xFFFF\x1\x8\x1\x22\x1\x9\x1\x16\x3\x22\x3\xFFFF\x1"+
            "\xA\x2\xFFFF\x3\x6\x2\xFFFF\x1\x6\x6\xFFFF\x1\xB\x2\x22\x1\x6"+
            "\x1\xFFFF\x1\x13\x2\xFFFF\x1\x22\x1\x1\x4\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xD\x1\xE\x2\xFFFF\x1\x15\x1\x22\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\xF\x1\xFFFF\x1\x22"+
            "\x1\xFFFF\x1\x11\x1\x12\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x6\x1\x14\x4\x6\x2\xFFFF\x5\x22\x1\x1F\x3"+
            "\x22\x1\xFFFF\x1\x22\x1\x21\x1\xFFFF\x3\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x3\x22\x6\xFFFF\x2\x22\x1\xFFFF\x1\x1E\x1\x18\x1\x1D"+
            "\x1\xFFFF\x1\x1A\x1\x1C\x1\x19\x1\xFFFF\x1\x17\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\x10\x1\xFFFF"+
            "\x4\x22\x3\xFFFF\x1\x1B\x2\x22\x1\x20\x1\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x1\x22",
            "\x1\xFFFF",
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
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
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
            ""
    };

    static readonly short[] DFA48_eot = DFA.UnpackEncodedString(DFA48_eotS);
    static readonly short[] DFA48_eof = DFA.UnpackEncodedString(DFA48_eofS);
    static readonly char[] DFA48_min = DFA.UnpackEncodedStringToUnsignedChars(DFA48_minS);
    static readonly char[] DFA48_max = DFA.UnpackEncodedStringToUnsignedChars(DFA48_maxS);
    static readonly short[] DFA48_accept = DFA.UnpackEncodedString(DFA48_acceptS);
    static readonly short[] DFA48_special = DFA.UnpackEncodedString(DFA48_specialS);
    static readonly short[][] DFA48_transition = DFA.UnpackEncodedStringArray(DFA48_transitionS);

    protected class DFA48 : DFA
    {
        public DFA48(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 48;
            this.eot = DFA48_eot;
            this.eof = DFA48_eof;
            this.min = DFA48_min;
            this.max = DFA48_max;
            this.accept = DFA48_accept;
            this.special = DFA48_special;
            this.transition = DFA48_transition;

        }

        override public string Description
        {
            get { return "758:25: (=> (=> LOWER )? type )?"; }
        }

    }


    protected internal int DFA48_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA48_0 = input.LA(1);

                   	 
                   	int index48_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA48_0 == LOWER) ) { s = 1; }

                   	else if ( (LA48_0 == ANY_KW) && (synpred20_Smi()) ) { s = 2; }

                   	else if ( (LA48_0 == BIT_KW) && (synpred20_Smi()) ) { s = 3; }

                   	else if ( (LA48_0 == BOOLEAN_KW) && (synpred20_Smi()) ) { s = 4; }

                   	else if ( (LA48_0 == CHARACTER_KW) && (synpred20_Smi()) ) { s = 5; }

                   	else if ( (LA48_0 == BMP_STR_KW || (LA48_0 >= GENERAL_STR_KW && LA48_0 <= GRAPHIC_STR_KW) || LA48_0 == IA5_STRING_KW || LA48_0 == ISO646_STR_KW || LA48_0 == NUMERIC_STR_KW || LA48_0 == PRINTABLE_STR_KW || LA48_0 == T61_STR_KW || LA48_0 == TELETEX_STR_KW || LA48_0 == UNIVERSAL_STR_KW || (LA48_0 >= UTC_TIME_KW && LA48_0 <= VISIBLE_STR_KW)) && (synpred20_Smi()) ) { s = 6; }

                   	else if ( (LA48_0 == CHOICE_KW) && (synpred20_Smi()) ) { s = 7; }

                   	else if ( (LA48_0 == EMBEDDED_KW) && (synpred20_Smi()) ) { s = 8; }

                   	else if ( (LA48_0 == ENUMERATED_KW) && (synpred20_Smi()) ) { s = 9; }

                   	else if ( (LA48_0 == EXTERNAL_KW) && (synpred20_Smi()) ) { s = 10; }

                   	else if ( (LA48_0 == INTEGER_KW) && (synpred20_Smi()) ) { s = 11; }

                   	else if ( (LA48_0 == NULL_KW) && (synpred20_Smi()) ) { s = 12; }

                   	else if ( (LA48_0 == OBJECT_KW) ) { s = 13; }

                   	else if ( (LA48_0 == OCTET_KW) && (synpred20_Smi()) ) { s = 14; }

                   	else if ( (LA48_0 == REAL_KW) && (synpred20_Smi()) ) { s = 15; }

                   	else if ( (LA48_0 == 179) && (synpred20_Smi()) ) { s = 16; }

                   	else if ( (LA48_0 == SEQUENCE_KW) && (synpred20_Smi()) ) { s = 17; }

                   	else if ( (LA48_0 == SET_KW) && (synpred20_Smi()) ) { s = 18; }

                   	else if ( (LA48_0 == L_BRACKET) && (synpred20_Smi()) ) { s = 19; }

                   	else if ( (LA48_0 == UPPER) ) { s = 20; }

                   	else if ( (LA48_0 == OPERATION_KW) ) { s = 21; }

                   	else if ( (LA48_0 == ERROR_KW) ) { s = 22; }

                   	else if ( (LA48_0 == 166) ) { s = 23; }

                   	else if ( (LA48_0 == 159) ) { s = 24; }

                   	else if ( (LA48_0 == 164) ) { s = 25; }

                   	else if ( (LA48_0 == 162) ) { s = 26; }

                   	else if ( (LA48_0 == 188) ) { s = 27; }

                   	else if ( (LA48_0 == 163) ) { s = 28; }

                   	else if ( (LA48_0 == 160) ) { s = 29; }

                   	else if ( (LA48_0 == 158) ) { s = 30; }

                   	else if ( (LA48_0 == 131) ) { s = 31; }

                   	else if ( (LA48_0 == 191) ) { s = 32; }

                   	else if ( (LA48_0 == 137) && (synpred20_Smi()) ) { s = 33; }

                   	else if ( (LA48_0 == EOF || LA48_0 == ASSIGN_OP || LA48_0 == BAR || (LA48_0 >= COLON && LA48_0 <= COMMA) || LA48_0 == DEFAULT_KW || LA48_0 == END_KW || (LA48_0 >= ERRORS_KW && LA48_0 <= EXCLAMATION) || (LA48_0 >= INTERSECTION && LA48_0 <= INTERSECTION_KW) || LA48_0 == LINKED_KW || LA48_0 == OPTIONAL_KW || LA48_0 == R_BRACE || LA48_0 == R_PAREN || LA48_0 == RESULT_KW || LA48_0 == UNION_KW || (LA48_0 >= 126 && LA48_0 <= 130) || (LA48_0 >= 132 && LA48_0 <= 134) || LA48_0 == 136 || (LA48_0 >= 139 && LA48_0 <= 141) || LA48_0 == 143 || (LA48_0 >= 146 && LA48_0 <= 148) || (LA48_0 >= 155 && LA48_0 <= 156) || LA48_0 == 168 || (LA48_0 >= 171 && LA48_0 <= 174) || LA48_0 == 176 || LA48_0 == 178 || (LA48_0 >= 181 && LA48_0 <= 184) || (LA48_0 >= 189 && LA48_0 <= 190) || LA48_0 == 192 || LA48_0 == 194 || LA48_0 == 197) ) { s = 34; }

                   	 
                   	input.Seek(index48_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA48_1 = input.LA(1);

                   	 
                   	int index48_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA48_13 = input.LA(1);

                   	 
                   	int index48_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA48_20 = input.LA(1);

                   	 
                   	int index48_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA48_21 = input.LA(1);

                   	 
                   	int index48_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA48_22 = input.LA(1);

                   	 
                   	int index48_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA48_23 = input.LA(1);

                   	 
                   	int index48_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA48_24 = input.LA(1);

                   	 
                   	int index48_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA48_25 = input.LA(1);

                   	 
                   	int index48_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA48_26 = input.LA(1);

                   	 
                   	int index48_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA48_27 = input.LA(1);

                   	 
                   	int index48_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA48_28 = input.LA(1);

                   	 
                   	int index48_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA48_29 = input.LA(1);

                   	 
                   	int index48_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA48_30 = input.LA(1);

                   	 
                   	int index48_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA48_31 = input.LA(1);

                   	 
                   	int index48_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA48_32 = input.LA(1);

                   	 
                   	int index48_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index48_32);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae48 =
            new NoViableAltException(dfa.Description, 48, _s, input);
        dfa.Error(nvae48);
        throw nvae48;
    }
    const string DFA47_eotS =
        "\x24\xFFFF";
    const string DFA47_eofS =
        "\x24\xFFFF";
    const string DFA47_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA47_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA47_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA47_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA47_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "758:37: (=> LOWER )?"; }
        }

    }


    protected internal int DFA47_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA47_1 = input.LA(1);

                   	 
                   	int index47_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA47_1 == LESS) ) { s = 2; }

                   	else if ( (LA47_1 == ANY_KW) && (synpred21_Smi()) ) { s = 3; }

                   	else if ( (LA47_1 == BIT_KW) && (synpred21_Smi()) ) { s = 4; }

                   	else if ( (LA47_1 == BOOLEAN_KW) && (synpred21_Smi()) ) { s = 5; }

                   	else if ( (LA47_1 == CHARACTER_KW) && (synpred21_Smi()) ) { s = 6; }

                   	else if ( (LA47_1 == BMP_STR_KW || (LA47_1 >= GENERAL_STR_KW && LA47_1 <= GRAPHIC_STR_KW) || LA47_1 == IA5_STRING_KW || LA47_1 == ISO646_STR_KW || LA47_1 == NUMERIC_STR_KW || LA47_1 == PRINTABLE_STR_KW || LA47_1 == T61_STR_KW || LA47_1 == TELETEX_STR_KW || LA47_1 == UNIVERSAL_STR_KW || (LA47_1 >= UTC_TIME_KW && LA47_1 <= VISIBLE_STR_KW)) && (synpred21_Smi()) ) { s = 7; }

                   	else if ( (LA47_1 == CHOICE_KW) && (synpred21_Smi()) ) { s = 8; }

                   	else if ( (LA47_1 == EMBEDDED_KW) && (synpred21_Smi()) ) { s = 9; }

                   	else if ( (LA47_1 == ENUMERATED_KW) && (synpred21_Smi()) ) { s = 10; }

                   	else if ( (LA47_1 == EXTERNAL_KW) && (synpred21_Smi()) ) { s = 11; }

                   	else if ( (LA47_1 == INTEGER_KW) && (synpred21_Smi()) ) { s = 12; }

                   	else if ( (LA47_1 == NULL_KW) && (synpred21_Smi()) ) { s = 13; }

                   	else if ( (LA47_1 == OBJECT_KW) && (synpred21_Smi()) ) { s = 14; }

                   	else if ( (LA47_1 == OCTET_KW) && (synpred21_Smi()) ) { s = 15; }

                   	else if ( (LA47_1 == REAL_KW) && (synpred21_Smi()) ) { s = 16; }

                   	else if ( (LA47_1 == 179) && (synpred21_Smi()) ) { s = 17; }

                   	else if ( (LA47_1 == SEQUENCE_KW) && (synpred21_Smi()) ) { s = 18; }

                   	else if ( (LA47_1 == SET_KW) && (synpred21_Smi()) ) { s = 19; }

                   	else if ( (LA47_1 == L_BRACKET) && (synpred21_Smi()) ) { s = 20; }

                   	else if ( (LA47_1 == UPPER) && (synpred21_Smi()) ) { s = 21; }

                   	else if ( (LA47_1 == LOWER) && (synpred21_Smi()) ) { s = 22; }

                   	else if ( (LA47_1 == OPERATION_KW) && (synpred21_Smi()) ) { s = 23; }

                   	else if ( (LA47_1 == ERROR_KW) && (synpred21_Smi()) ) { s = 24; }

                   	else if ( (LA47_1 == 166) && (synpred21_Smi()) ) { s = 25; }

                   	else if ( (LA47_1 == 159) && (synpred21_Smi()) ) { s = 26; }

                   	else if ( (LA47_1 == 164) && (synpred21_Smi()) ) { s = 27; }

                   	else if ( (LA47_1 == 162) && (synpred21_Smi()) ) { s = 28; }

                   	else if ( (LA47_1 == 188) && (synpred21_Smi()) ) { s = 29; }

                   	else if ( (LA47_1 == 163) && (synpred21_Smi()) ) { s = 30; }

                   	else if ( (LA47_1 == 160) && (synpred21_Smi()) ) { s = 31; }

                   	else if ( (LA47_1 == 158) && (synpred21_Smi()) ) { s = 32; }

                   	else if ( (LA47_1 == 131) && (synpred21_Smi()) ) { s = 33; }

                   	else if ( (LA47_1 == 191) && (synpred21_Smi()) ) { s = 34; }

                   	else if ( (LA47_1 == 137) && (synpred21_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index47_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae47 =
            new NoViableAltException(dfa.Description, 47, _s, input);
        dfa.Error(nvae47);
        throw nvae47;
    }
    const string DFA54_eotS =
        "\x24\xFFFF";
    const string DFA54_eofS =
        "\x24\xFFFF";
    const string DFA54_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA54_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA54_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA54_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA54_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA54_eot = DFA.UnpackEncodedString(DFA54_eotS);
    static readonly short[] DFA54_eof = DFA.UnpackEncodedString(DFA54_eofS);
    static readonly char[] DFA54_min = DFA.UnpackEncodedStringToUnsignedChars(DFA54_minS);
    static readonly char[] DFA54_max = DFA.UnpackEncodedStringToUnsignedChars(DFA54_maxS);
    static readonly short[] DFA54_accept = DFA.UnpackEncodedString(DFA54_acceptS);
    static readonly short[] DFA54_special = DFA.UnpackEncodedString(DFA54_specialS);
    static readonly short[][] DFA54_transition = DFA.UnpackEncodedStringArray(DFA54_transitionS);

    protected class DFA54 : DFA
    {
        public DFA54(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 54;
            this.eot = DFA54_eot;
            this.eof = DFA54_eof;
            this.min = DFA54_min;
            this.max = DFA54_max;
            this.accept = DFA54_accept;
            this.special = DFA54_special;
            this.transition = DFA54_transition;

        }

        override public string Description
        {
            get { return "771:38: (=> LOWER )?"; }
        }

    }


    protected internal int DFA54_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA54_1 = input.LA(1);

                   	 
                   	int index54_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA54_1 == LESS) ) { s = 2; }

                   	else if ( (LA54_1 == ANY_KW) && (synpred24_Smi()) ) { s = 3; }

                   	else if ( (LA54_1 == BIT_KW) && (synpred24_Smi()) ) { s = 4; }

                   	else if ( (LA54_1 == BOOLEAN_KW) && (synpred24_Smi()) ) { s = 5; }

                   	else if ( (LA54_1 == CHARACTER_KW) && (synpred24_Smi()) ) { s = 6; }

                   	else if ( (LA54_1 == BMP_STR_KW || (LA54_1 >= GENERAL_STR_KW && LA54_1 <= GRAPHIC_STR_KW) || LA54_1 == IA5_STRING_KW || LA54_1 == ISO646_STR_KW || LA54_1 == NUMERIC_STR_KW || LA54_1 == PRINTABLE_STR_KW || LA54_1 == T61_STR_KW || LA54_1 == TELETEX_STR_KW || LA54_1 == UNIVERSAL_STR_KW || (LA54_1 >= UTC_TIME_KW && LA54_1 <= VISIBLE_STR_KW)) && (synpred24_Smi()) ) { s = 7; }

                   	else if ( (LA54_1 == CHOICE_KW) && (synpred24_Smi()) ) { s = 8; }

                   	else if ( (LA54_1 == EMBEDDED_KW) && (synpred24_Smi()) ) { s = 9; }

                   	else if ( (LA54_1 == ENUMERATED_KW) && (synpred24_Smi()) ) { s = 10; }

                   	else if ( (LA54_1 == EXTERNAL_KW) && (synpred24_Smi()) ) { s = 11; }

                   	else if ( (LA54_1 == INTEGER_KW) && (synpred24_Smi()) ) { s = 12; }

                   	else if ( (LA54_1 == NULL_KW) && (synpred24_Smi()) ) { s = 13; }

                   	else if ( (LA54_1 == OBJECT_KW) && (synpred24_Smi()) ) { s = 14; }

                   	else if ( (LA54_1 == OCTET_KW) && (synpred24_Smi()) ) { s = 15; }

                   	else if ( (LA54_1 == REAL_KW) && (synpred24_Smi()) ) { s = 16; }

                   	else if ( (LA54_1 == 179) && (synpred24_Smi()) ) { s = 17; }

                   	else if ( (LA54_1 == SEQUENCE_KW) && (synpred24_Smi()) ) { s = 18; }

                   	else if ( (LA54_1 == SET_KW) && (synpred24_Smi()) ) { s = 19; }

                   	else if ( (LA54_1 == L_BRACKET) && (synpred24_Smi()) ) { s = 20; }

                   	else if ( (LA54_1 == UPPER) && (synpred24_Smi()) ) { s = 21; }

                   	else if ( (LA54_1 == LOWER) && (synpred24_Smi()) ) { s = 22; }

                   	else if ( (LA54_1 == OPERATION_KW) && (synpred24_Smi()) ) { s = 23; }

                   	else if ( (LA54_1 == ERROR_KW) && (synpred24_Smi()) ) { s = 24; }

                   	else if ( (LA54_1 == 166) && (synpred24_Smi()) ) { s = 25; }

                   	else if ( (LA54_1 == 159) && (synpred24_Smi()) ) { s = 26; }

                   	else if ( (LA54_1 == 164) && (synpred24_Smi()) ) { s = 27; }

                   	else if ( (LA54_1 == 162) && (synpred24_Smi()) ) { s = 28; }

                   	else if ( (LA54_1 == 188) && (synpred24_Smi()) ) { s = 29; }

                   	else if ( (LA54_1 == 163) && (synpred24_Smi()) ) { s = 30; }

                   	else if ( (LA54_1 == 160) && (synpred24_Smi()) ) { s = 31; }

                   	else if ( (LA54_1 == 158) && (synpred24_Smi()) ) { s = 32; }

                   	else if ( (LA54_1 == 131) && (synpred24_Smi()) ) { s = 33; }

                   	else if ( (LA54_1 == 191) && (synpred24_Smi()) ) { s = 34; }

                   	else if ( (LA54_1 == 137) && (synpred24_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index54_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae54 =
            new NoViableAltException(dfa.Description, 54, _s, input);
        dfa.Error(nvae54);
        throw nvae54;
    }
    const string DFA65_eotS =
        "\xB\xFFFF";
    const string DFA65_eofS =
        "\xB\xFFFF";
    const string DFA65_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA65_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA65_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA65_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA65_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA65_eot = DFA.UnpackEncodedString(DFA65_eotS);
    static readonly short[] DFA65_eof = DFA.UnpackEncodedString(DFA65_eofS);
    static readonly char[] DFA65_min = DFA.UnpackEncodedStringToUnsignedChars(DFA65_minS);
    static readonly char[] DFA65_max = DFA.UnpackEncodedStringToUnsignedChars(DFA65_maxS);
    static readonly short[] DFA65_accept = DFA.UnpackEncodedString(DFA65_acceptS);
    static readonly short[] DFA65_special = DFA.UnpackEncodedString(DFA65_specialS);
    static readonly short[][] DFA65_transition = DFA.UnpackEncodedStringArray(DFA65_transitionS);

    protected class DFA65 : DFA
    {
        public DFA65(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 65;
            this.eot = DFA65_eot;
            this.eof = DFA65_eof;
            this.min = DFA65_min;
            this.max = DFA65_max;
            this.accept = DFA65_accept;
            this.special = DFA65_special;
            this.transition = DFA65_transition;

        }

        override public string Description
        {
            get { return "802:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )"; }
        }

    }


    protected internal int DFA65_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA65_1 = input.LA(1);

                   	 
                   	int index65_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA65_1 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index65_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA65_2 = input.LA(1);

                   	 
                   	int index65_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA65_2 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index65_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA65_5 = input.LA(1);

                   	 
                   	int index65_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA65_5 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index65_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA65_9 = input.LA(1);

                   	 
                   	int index65_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA65_9 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index65_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA65_10 = input.LA(1);

                   	 
                   	int index65_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA65_10 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index65_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae65 =
            new NoViableAltException(dfa.Description, 65, _s, input);
        dfa.Error(nvae65);
        throw nvae65;
    }
    const string DFA74_eotS =
        "\x3F\xFFFF";
    const string DFA74_eofS =
        "\x1\x5\x3E\xFFFF";
    const string DFA74_minS =
        "\x1\xA\x1\x0\x3D\xFFFF";
    const string DFA74_maxS =
        "\x1\xC5\x1\x0\x3D\xFFFF";
    const string DFA74_acceptS =
        "\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x38\xFFFF\x1\x1";
    const string DFA74_specialS =
        "\x1\xFFFF\x1\x0\x3D\xFFFF}>";
    static readonly string[] DFA74_transitionS = {
            "\x1\x5\x3\xFFFF\x1\x5\xD\xFFFF\x2\x5\x4\xFFFF\x1\x5\x6\xFFFF"+
            "\x1\x5\x1\xFFFF\x4\x5\x13\xFFFF\x2\x5\x5\xFFFF\x2\x5\x8\xFFFF"+
            "\x1\x5\x3\xFFFF\x2\x5\x8\xFFFF\x1\x5\x1\xFFFF\x1\x5\x2\xFFFF"+
            "\x1\x5\xC\xFFFF\x1\x5\x3\xFFFF\x1\x5\x6\xFFFF\x9\x5\x1\x2\x1"+
            "\x5\x2\xFFFF\x3\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x4\x3\x5\x1\xFFFF"+
            "\x1\x1\x4\xFFFF\x2\x5\x1\xFFFF\x3\x5\x1\xFFFF\x3\x5\x1\xFFFF"+
            "\x1\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x3\x4\x5\x1\xFFFF\x1\x5\x1"+
            "\xFFFF\x1\x5\x2\xFFFF\x4\x5\x3\xFFFF\x7\x5\x2\xFFFF\x1\x5",
            "\x1\xFFFF",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA74_eot = DFA.UnpackEncodedString(DFA74_eotS);
    static readonly short[] DFA74_eof = DFA.UnpackEncodedString(DFA74_eofS);
    static readonly char[] DFA74_min = DFA.UnpackEncodedStringToUnsignedChars(DFA74_minS);
    static readonly char[] DFA74_max = DFA.UnpackEncodedStringToUnsignedChars(DFA74_maxS);
    static readonly short[] DFA74_accept = DFA.UnpackEncodedString(DFA74_acceptS);
    static readonly short[] DFA74_special = DFA.UnpackEncodedString(DFA74_specialS);
    static readonly short[][] DFA74_transition = DFA.UnpackEncodedStringArray(DFA74_transitionS);

    protected class DFA74 : DFA
    {
        public DFA74(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 74;
            this.eot = DFA74_eot;
            this.eof = DFA74_eof;
            this.min = DFA74_min;
            this.max = DFA74_max;
            this.accept = DFA74_accept;
            this.special = DFA74_special;
            this.transition = DFA74_transition;

        }

        override public string Description
        {
            get { return "815:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?"; }
        }

    }


    protected internal int DFA74_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA74_1 = input.LA(1);

                   	 
                   	int index74_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred28_Smi()) ) { s = 62; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index74_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae74 =
            new NoViableAltException(dfa.Description, 74, _s, input);
        dfa.Error(nvae74);
        throw nvae74;
    }
    const string DFA80_eotS =
        "\x3A\xFFFF";
    const string DFA80_eofS =
        "\x1\x2\x39\xFFFF";
    const string DFA80_minS =
        "\x1\xA\x1\x0\x38\xFFFF";
    const string DFA80_maxS =
        "\x1\xC5\x1\x0\x38\xFFFF";
    const string DFA80_acceptS =
        "\x2\xFFFF\x1\x2\x36\xFFFF\x1\x1";
    const string DFA80_specialS =
        "\x1\xFFFF\x1\x0\x38\xFFFF}>";
    static readonly string[] DFA80_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\x1\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3"+
            "\x2\x6\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1"+
            "\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1"+
            "\x2\x2\xFFFF\x4\x2\x3\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
            "\x1\xFFFF",
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
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA80_eot = DFA.UnpackEncodedString(DFA80_eotS);
    static readonly short[] DFA80_eof = DFA.UnpackEncodedString(DFA80_eofS);
    static readonly char[] DFA80_min = DFA.UnpackEncodedStringToUnsignedChars(DFA80_minS);
    static readonly char[] DFA80_max = DFA.UnpackEncodedStringToUnsignedChars(DFA80_maxS);
    static readonly short[] DFA80_accept = DFA.UnpackEncodedString(DFA80_acceptS);
    static readonly short[] DFA80_special = DFA.UnpackEncodedString(DFA80_specialS);
    static readonly short[][] DFA80_transition = DFA.UnpackEncodedStringArray(DFA80_transitionS);

    protected class DFA80 : DFA
    {
        public DFA80(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 80;
            this.eot = DFA80_eot;
            this.eof = DFA80_eof;
            this.min = DFA80_min;
            this.max = DFA80_max;
            this.accept = DFA80_accept;
            this.special = DFA80_special;
            this.transition = DFA80_transition;

        }

        override public string Description
        {
            get { return "822:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?"; }
        }

    }


    protected internal int DFA80_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA80_1 = input.LA(1);

                   	 
                   	int index80_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_Smi()) ) { s = 57; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index80_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae80 =
            new NoViableAltException(dfa.Description, 80, _s, input);
        dfa.Error(nvae80);
        throw nvae80;
    }
    const string DFA79_eotS =
        "\xA\xFFFF";
    const string DFA79_eofS =
        "\xA\xFFFF";
    const string DFA79_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\xFFFF\x1\x0\x1\xD";
    const string DFA79_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\xFFFF\x1\x0\x1\x77";
    const string DFA79_acceptS =
        "\x2\xFFFF\x1\x2\x4\xFFFF\x1\x1\x2\xFFFF";
    const string DFA79_specialS =
        "\x5\xFFFF\x1\x0\x2\xFFFF\x1\x1\x1\xFFFF}>";
    static readonly string[] DFA79_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x2\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x2\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x4\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x9\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\x8\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA79_eot = DFA.UnpackEncodedString(DFA79_eotS);
    static readonly short[] DFA79_eof = DFA.UnpackEncodedString(DFA79_eofS);
    static readonly char[] DFA79_min = DFA.UnpackEncodedStringToUnsignedChars(DFA79_minS);
    static readonly char[] DFA79_max = DFA.UnpackEncodedStringToUnsignedChars(DFA79_maxS);
    static readonly short[] DFA79_accept = DFA.UnpackEncodedString(DFA79_acceptS);
    static readonly short[] DFA79_special = DFA.UnpackEncodedString(DFA79_specialS);
    static readonly short[][] DFA79_transition = DFA.UnpackEncodedStringArray(DFA79_transitionS);

    protected class DFA79 : DFA
    {
        public DFA79(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 79;
            this.eot = DFA79_eot;
            this.eof = DFA79_eof;
            this.min = DFA79_min;
            this.max = DFA79_max;
            this.accept = DFA79_accept;
            this.special = DFA79_special;
            this.transition = DFA79_transition;

        }

        override public string Description
        {
            get { return "823:21: (=> objecttype_macro_bitsvalue | value )"; }
        }

    }


    protected internal int DFA79_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA79_5 = input.LA(1);

                   	 
                   	int index79_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index79_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA79_8 = input.LA(1);

                   	 
                   	int index79_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index79_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae79 =
            new NoViableAltException(dfa.Description, 79, _s, input);
        dfa.Error(nvae79);
        throw nvae79;
    }
    const string DFA96_eotS =
        "\x17\xFFFF";
    const string DFA96_eofS =
        "\x1\xFFFF\x2\x6\x2\xFFFF\x1\x6\x3\xFFFF\x2\x6\xC\xFFFF";
    const string DFA96_minS =
        "\x1\x7\x2\xA\x1\x6D\x1\x3B\x1\xA\x2\xFFFF\x1\x4A\x2\xA\x1\x47\x1"+
        "\x4A\x1\x50\x1\x63\x1\x1D\x1\x4A\x1\x0\x1\x47\x1\x4A\x1\x50\x1\x63"+
        "\x1\x1D";
    const string DFA96_maxS =
        "\x1\xBF\x2\xC5\x1\x6D\x1\x3B\x1\xC5\x2\xFFFF\x1\x4A\x2\xC5\x1\x47"+
        "\x1\x77\x1\x50\x1\x63\x1\x61\x1\x4A\x1\x0\x1\x47\x1\x77\x1\x50\x1"+
        "\x63\x1\x61";
    const string DFA96_acceptS =
        "\x6\xFFFF\x1\x2\x1\x1\xF\xFFFF";
    const string DFA96_specialS =
        "\x1\xFFFF\x1\x0\x3\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\x3\x6\xFFFF\x1"+
        "\x4\x5\xFFFF}>";
    static readonly string[] DFA96_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x8\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x9",
            "\x1\xA",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF"+
            "\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "",
            "",
            "\x1\xB",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\xC",
            "\x1\x6\x2\xFFFF\x1\xD\x2\xFFFF\x1\xE\x26\xFFFF\x1\x6",
            "\x1\xE",
            "\x1\xF",
            "\x1\x10\x43\xFFFF\x1\x11",
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\x13",
            "\x1\x6\x2\xFFFF\x1\x14\x2\xFFFF\x1\x15\x26\xFFFF\x1\x6",
            "\x1\x15",
            "\x1\x16",
            "\x1\x10\x43\xFFFF\x1\x11"
    };

    static readonly short[] DFA96_eot = DFA.UnpackEncodedString(DFA96_eotS);
    static readonly short[] DFA96_eof = DFA.UnpackEncodedString(DFA96_eofS);
    static readonly char[] DFA96_min = DFA.UnpackEncodedStringToUnsignedChars(DFA96_minS);
    static readonly char[] DFA96_max = DFA.UnpackEncodedStringToUnsignedChars(DFA96_maxS);
    static readonly short[] DFA96_accept = DFA.UnpackEncodedString(DFA96_acceptS);
    static readonly short[] DFA96_special = DFA.UnpackEncodedString(DFA96_specialS);
    static readonly short[][] DFA96_transition = DFA.UnpackEncodedStringArray(DFA96_transitionS);

    protected class DFA96 : DFA
    {
        public DFA96(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 96;
            this.eot = DFA96_eot;
            this.eof = DFA96_eof;
            this.min = DFA96_min;
            this.max = DFA96_max;
            this.accept = DFA96_accept;
            this.special = DFA96_special;
            this.transition = DFA96_transition;

        }

        override public string Description
        {
            get { return "887:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )"; }
        }

    }


    protected internal int DFA96_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA96_1 = input.LA(1);

                   	 
                   	int index96_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA96_1 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA96_1 == EOF || LA96_1 == ASSIGN_OP || LA96_1 == BAR || (LA96_1 >= COLON && LA96_1 <= COMMA) || LA96_1 == DEFAULT_KW || LA96_1 == END_KW || (LA96_1 >= ERROR_KW && LA96_1 <= EXCLAMATION) || (LA96_1 >= INTERSECTION && LA96_1 <= INTERSECTION_KW) || (LA96_1 >= LINKED_KW && LA96_1 <= LOWER) || LA96_1 == OBJECT_KW || (LA96_1 >= OPERATION_KW && LA96_1 <= OPTIONAL_KW) || LA96_1 == R_BRACE || LA96_1 == R_PAREN || LA96_1 == RESULT_KW || LA96_1 == UNION_KW || LA96_1 == UPPER || (LA96_1 >= 126 && LA96_1 <= 134) || LA96_1 == 136 || (LA96_1 >= 139 && LA96_1 <= 141) || LA96_1 == 143 || (LA96_1 >= 146 && LA96_1 <= 148) || (LA96_1 >= 155 && LA96_1 <= 156) || (LA96_1 >= 158 && LA96_1 <= 160) || (LA96_1 >= 162 && LA96_1 <= 164) || LA96_1 == 166 || LA96_1 == 168 || (LA96_1 >= 171 && LA96_1 <= 174) || LA96_1 == 176 || LA96_1 == 178 || (LA96_1 >= 181 && LA96_1 <= 184) || (LA96_1 >= 188 && LA96_1 <= 192) || LA96_1 == 194 || LA96_1 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index96_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA96_5 = input.LA(1);

                   	 
                   	int index96_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA96_5 == EOF || LA96_5 == ASSIGN_OP || LA96_5 == BAR || (LA96_5 >= COLON && LA96_5 <= COMMA) || LA96_5 == DEFAULT_KW || LA96_5 == DOT || LA96_5 == END_KW || (LA96_5 >= ERROR_KW && LA96_5 <= EXCLAMATION) || (LA96_5 >= INTERSECTION && LA96_5 <= INTERSECTION_KW) || LA96_5 == L_PAREN || (LA96_5 >= LINKED_KW && LA96_5 <= LOWER) || LA96_5 == OBJECT_KW || (LA96_5 >= OPERATION_KW && LA96_5 <= OPTIONAL_KW) || LA96_5 == R_BRACE || LA96_5 == R_PAREN || LA96_5 == RESULT_KW || LA96_5 == UNION_KW || LA96_5 == UPPER || (LA96_5 >= 126 && LA96_5 <= 134) || LA96_5 == 136 || (LA96_5 >= 139 && LA96_5 <= 141) || LA96_5 == 143 || (LA96_5 >= 146 && LA96_5 <= 148) || (LA96_5 >= 155 && LA96_5 <= 156) || (LA96_5 >= 158 && LA96_5 <= 160) || (LA96_5 >= 162 && LA96_5 <= 164) || LA96_5 == 166 || LA96_5 == 168 || (LA96_5 >= 171 && LA96_5 <= 174) || LA96_5 == 176 || LA96_5 == 178 || (LA96_5 >= 181 && LA96_5 <= 184) || (LA96_5 >= 188 && LA96_5 <= 192) || LA96_5 == 194 || LA96_5 == 197) ) { s = 6; }

                   	else if ( (LA96_5 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	 
                   	input.Seek(index96_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA96_9 = input.LA(1);

                   	 
                   	int index96_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA96_9 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA96_9 == EOF || LA96_9 == ASSIGN_OP || LA96_9 == BAR || (LA96_9 >= COLON && LA96_9 <= COMMA) || LA96_9 == DEFAULT_KW || LA96_9 == END_KW || (LA96_9 >= ERROR_KW && LA96_9 <= EXCLAMATION) || (LA96_9 >= INTERSECTION && LA96_9 <= INTERSECTION_KW) || LA96_9 == L_PAREN || (LA96_9 >= LINKED_KW && LA96_9 <= LOWER) || LA96_9 == OBJECT_KW || (LA96_9 >= OPERATION_KW && LA96_9 <= OPTIONAL_KW) || LA96_9 == R_BRACE || LA96_9 == R_PAREN || LA96_9 == RESULT_KW || LA96_9 == UNION_KW || LA96_9 == UPPER || (LA96_9 >= 126 && LA96_9 <= 134) || LA96_9 == 136 || (LA96_9 >= 139 && LA96_9 <= 141) || LA96_9 == 143 || (LA96_9 >= 146 && LA96_9 <= 148) || (LA96_9 >= 155 && LA96_9 <= 156) || (LA96_9 >= 158 && LA96_9 <= 160) || (LA96_9 >= 162 && LA96_9 <= 164) || LA96_9 == 166 || LA96_9 == 168 || (LA96_9 >= 171 && LA96_9 <= 174) || LA96_9 == 176 || LA96_9 == 178 || (LA96_9 >= 181 && LA96_9 <= 184) || (LA96_9 >= 188 && LA96_9 <= 192) || LA96_9 == 194 || LA96_9 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index96_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA96_10 = input.LA(1);

                   	 
                   	int index96_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA96_10 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA96_10 == EOF || LA96_10 == ASSIGN_OP || LA96_10 == BAR || (LA96_10 >= COLON && LA96_10 <= COMMA) || LA96_10 == DEFAULT_KW || LA96_10 == END_KW || (LA96_10 >= ERROR_KW && LA96_10 <= EXCLAMATION) || (LA96_10 >= INTERSECTION && LA96_10 <= INTERSECTION_KW) || (LA96_10 >= LINKED_KW && LA96_10 <= LOWER) || LA96_10 == OBJECT_KW || (LA96_10 >= OPERATION_KW && LA96_10 <= OPTIONAL_KW) || LA96_10 == R_BRACE || LA96_10 == R_PAREN || LA96_10 == RESULT_KW || LA96_10 == UNION_KW || LA96_10 == UPPER || (LA96_10 >= 126 && LA96_10 <= 134) || LA96_10 == 136 || (LA96_10 >= 139 && LA96_10 <= 141) || LA96_10 == 143 || (LA96_10 >= 146 && LA96_10 <= 148) || (LA96_10 >= 155 && LA96_10 <= 156) || (LA96_10 >= 158 && LA96_10 <= 160) || (LA96_10 >= 162 && LA96_10 <= 164) || LA96_10 == 166 || LA96_10 == 168 || (LA96_10 >= 171 && LA96_10 <= 174) || LA96_10 == 176 || LA96_10 == 178 || (LA96_10 >= 181 && LA96_10 <= 184) || (LA96_10 >= 188 && LA96_10 <= 192) || LA96_10 == 194 || LA96_10 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index96_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA96_17 = input.LA(1);

                   	 
                   	int index96_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index96_17);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae96 =
            new NoViableAltException(dfa.Description, 96, _s, input);
        dfa.Error(nvae96);
        throw nvae96;
    }
    const string DFA105_eotS =
        "\x67\xFFFF";
    const string DFA105_eofS =
        "\x1\x2\x1\x3F\x65\xFFFF";
    const string DFA105_minS =
        "\x2\xA\x1\xFFFF\x1\x7\x45\xFFFF\x1\x0\x1\x25\x1\xD\xA\xFFFF\x1\x4A"+
        "\x10\xFFFF";
    const string DFA105_maxS =
        "\x2\xC5\x1\xFFFF\x1\xBF\x45\xFFFF\x1\x0\x2\xC0\xA\xFFFF\x1\x77\x10"+
        "\xFFFF";
    const string DFA105_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\x45\x1\x3\xFFFF\xA\x1\x1\xFFFF\x10\x1";
    const string DFA105_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\x45\xFFFF\x1\x2\x1\xFFFF\x1\x3\xA"+
        "\xFFFF\x1\x4\x10\xFFFF}>";
    static readonly string[] DFA105_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x1\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x4\xFFFF"+
            "\x7\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x3\xFFFF"+
            "\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\x2\xFFFF\x1\xE\x1\x47\x7\xFFFF\x1\x7\x5\xFFFF\x1\x42"+
            "\x1\x3D\x4\xFFFF\x1\x41\x6\xFFFF\x1\x14\x1\xFFFF\x1\x16\x1\x2E"+
            "\x1\x45\x1\x43\x4\xFFFF\x1\x5\x4\xFFFF\x1\xD\x9\xFFFF\x2\x46"+
            "\x1\xFFFF\x1\xC\x3\xFFFF\x1\x2F\x1\x9\x2\xFFFF\x1\xA\x1\x10"+
            "\x1\x6\x1\xB\x2\xFFFF\x1\x13\x3\xFFFF\x1\x15\x1\x40\x4\xFFFF"+
            "\x1\xF\x3\xFFFF\x1\x3E\x1\xFFFF\x1\x44\x2\xFFFF\x1\x2D\xA\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x47\x3\xFFFF\x1\x8\x6\xFFFF\x1\x23\x1\x26"+
            "\x1\x25\x1\x24\x1\x31\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1"+
            "\x17\x2\xFFFF\x1\x3B\x1\x3C\x1\x39\x1\xFFFF\x1\x28\x2\xFFFF"+
            "\x1\x1B\x1\x1D\x1\x1C\x1\x12\x3\xFFFF\x1\x2\x1\x11\x1\x3A\x1"+
            "\x37\x1\x48\x3\x2C\x1\xFFFF\x3\x2C\x1\xFFFF\x1\x2C\x1\xFFFF"+
            "\x1\x32\x2\xFFFF\x1\x38\x1\x33\x1\x34\x1\x21\x1\xFFFF\x1\x2B"+
            "\x1\xFFFF\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x1\x35\x3\xFFFF"+
            "\x1\x2C\x1\x1E\x1\x1F\x1\x2C\x1\x18\x1\xFFFF\x1\x30\x2\xFFFF"+
            "\x1\x36",
            "",
            "\x1\x2\x5\xFFFF\x1\x53\x4\xFFFF\x3\x2\x1\xFFFF\x1\x4E\x1\x2"+
            "\x2\xFFFF\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2"+
            "\x1\x4D\x1\xFFFF\x3\x2\x1\x52\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
            "\x2\xFFFF\x1\x2\x1\x51\x1\x2\x3\xFFFF\x1\x4B\x2\xFFFF\x1\x4F"+
            "\x1\x55\x1\x49\x1\x50\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x54\x1\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4"+
            "\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x4C\x4\xFFFF\x1\x2\x1\x4A\x4"+
            "\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3"+
            "\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
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
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\x56\x3\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x3\xFFFF\x1\x2\x1F\xFFFF\x1\x2\x6\xFFFF"+
            "\x4\x2\x1\xFFFF\x4\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF"+
            "\x3\x2\x9\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x4\xFFFF"+
            "\x5\x2",
            "\x1\x63\x8\xFFFF\x1\x5E\x5\xFFFF\x1\x5A\xC\xFFFF\x1\x14\x1\xFFFF"+
            "\x1\x16\x7\xFFFF\x1\x5C\x4\xFFFF\x1\x62\xC\xFFFF\x1\x61\x2\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x58\x2\xFFFF\x1\x5F\x1\x65\x1\x5D\x1\x60"+
            "\x2\xFFFF\x1\x59\x3\xFFFF\x1\x15\x5\xFFFF\x1\x64\x13\xFFFF\x1"+
            "\x5B\x5\xFFFF\x1\x57\x6\xFFFF\x1\x23\x1\x26\x1\x25\x1\x24\x1"+
            "\xFFFF\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1\x17\x6\xFFFF"+
            "\x1\x28\x2\xFFFF\x1\x1B\x1\x1D\x1\x1C\x9\xFFFF\x3\x2C\x1\xFFFF"+
            "\x3\x2C\x1\xFFFF\x1\x2C\x7\xFFFF\x1\x21\x1\xFFFF\x1\x2B\x1\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x4\xFFFF\x1\x2C\x1\x1E"+
            "\x1\x1F\x1\x2C\x1\x18",
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
            "\x1\x66\x2C\xFFFF\x1\x2",
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
            "",
            "",
            ""
    };

    static readonly short[] DFA105_eot = DFA.UnpackEncodedString(DFA105_eotS);
    static readonly short[] DFA105_eof = DFA.UnpackEncodedString(DFA105_eofS);
    static readonly char[] DFA105_min = DFA.UnpackEncodedStringToUnsignedChars(DFA105_minS);
    static readonly char[] DFA105_max = DFA.UnpackEncodedStringToUnsignedChars(DFA105_maxS);
    static readonly short[] DFA105_accept = DFA.UnpackEncodedString(DFA105_acceptS);
    static readonly short[] DFA105_special = DFA.UnpackEncodedString(DFA105_specialS);
    static readonly short[][] DFA105_transition = DFA.UnpackEncodedStringArray(DFA105_transitionS);

    protected class DFA105 : DFA
    {
        public DFA105(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 105;
            this.eot = DFA105_eot;
            this.eof = DFA105_eof;
            this.min = DFA105_min;
            this.max = DFA105_max;
            this.accept = DFA105_accept;
            this.special = DFA105_special;
            this.transition = DFA105_transition;

        }

        override public string Description
        {
            get { return "922:41: (=> UPPER (=> value )? )?"; }
        }

    }


    protected internal int DFA105_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA105_1 = input.LA(1);

                   	 
                   	int index105_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_1 == ASSIGN_OP) ) { s = 3; }

                   	else if ( (LA105_1 == TRUE_KW) && (synpred32_Smi()) ) { s = 4; }

                   	else if ( (LA105_1 == FALSE_KW) && (synpred32_Smi()) ) { s = 5; }

                   	else if ( (LA105_1 == NULL_KW) && (synpred32_Smi()) ) { s = 6; }

                   	else if ( (LA105_1 == C_STRING) && (synpred32_Smi()) ) { s = 7; }

                   	else if ( (LA105_1 == UPPER) && (synpred32_Smi()) ) { s = 8; }

                   	else if ( (LA105_1 == LOWER) && (synpred32_Smi()) ) { s = 9; }

                   	else if ( (LA105_1 == MINUS) && (synpred32_Smi()) ) { s = 10; }

                   	else if ( (LA105_1 == NUMBER) && (synpred32_Smi()) ) { s = 11; }

                   	else if ( (LA105_1 == L_BRACE) && (synpred32_Smi()) ) { s = 12; }

                   	else if ( (LA105_1 == H_STRING) && (synpred32_Smi()) ) { s = 13; }

                   	else if ( (LA105_1 == B_STRING) && (synpred32_Smi()) ) { s = 14; }

                   	else if ( (LA105_1 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 15; }

                   	else if ( (LA105_1 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 16; }

                   	else if ( (LA105_1 == 154) && (synpred32_Smi()) ) { s = 17; }

                   	else if ( (LA105_1 == 149) && (synpred32_Smi()) ) { s = 18; }

                   	else if ( (LA105_1 == OBJECT_KW) && (synpred32_Smi()) ) { s = 19; }

                   	else if ( (LA105_1 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA105_1 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA105_1 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA105_1 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA105_1 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA105_1 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA105_1 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA105_1 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA105_1 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA105_1 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA105_1 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA105_1 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA105_1 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA105_1 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA105_1 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA105_1 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA105_1 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA105_1 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA105_1 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA105_1 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA105_1 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA105_1 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA105_1 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA105_1 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA105_1 == 131 || (LA105_1 >= 158 && LA105_1 <= 160) || (LA105_1 >= 162 && LA105_1 <= 164) || LA105_1 == 166 || LA105_1 == 188 || LA105_1 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA105_1 == RESULT_KW) && (synpred32_Smi()) ) { s = 45; }

                   	else if ( (LA105_1 == ERRORS_KW) && (synpred32_Smi()) ) { s = 46; }

                   	else if ( (LA105_1 == LINKED_KW) && (synpred32_Smi()) ) { s = 47; }

                   	else if ( (LA105_1 == 194) && (synpred32_Smi()) ) { s = 48; }

                   	else if ( (LA105_1 == 130) && (synpred32_Smi()) ) { s = 49; }

                   	else if ( (LA105_1 == 168) && (synpred32_Smi()) ) { s = 50; }

                   	else if ( (LA105_1 == 172) && (synpred32_Smi()) ) { s = 51; }

                   	else if ( (LA105_1 == 173) && (synpred32_Smi()) ) { s = 52; }

                   	else if ( (LA105_1 == 184) && (synpred32_Smi()) ) { s = 53; }

                   	else if ( (LA105_1 == 197) && (synpred32_Smi()) ) { s = 54; }

                   	else if ( (LA105_1 == 156) && (synpred32_Smi()) ) { s = 55; }

                   	else if ( (LA105_1 == 171) && (synpred32_Smi()) ) { s = 56; }

                   	else if ( (LA105_1 == 141) && (synpred32_Smi()) ) { s = 57; }

                   	else if ( (LA105_1 == 155) && (synpred32_Smi()) ) { s = 58; }

                   	else if ( (LA105_1 == 139) && (synpred32_Smi()) ) { s = 59; }

                   	else if ( (LA105_1 == 140) && (synpred32_Smi()) ) { s = 60; }

                   	else if ( (LA105_1 == COMMA) && (synpred32_Smi()) ) { s = 61; }

                   	else if ( (LA105_1 == R_BRACE) && (synpred32_Smi()) ) { s = 62; }

                   	else if ( (LA105_1 == EOF) && (synpred32_Smi()) ) { s = 63; }

                   	else if ( (LA105_1 == OPTIONAL_KW) && (synpred32_Smi()) ) { s = 64; }

                   	else if ( (LA105_1 == DEFAULT_KW) && (synpred32_Smi()) ) { s = 65; }

                   	else if ( (LA105_1 == COLON) && (synpred32_Smi()) ) { s = 66; }

                   	else if ( (LA105_1 == EXCLAMATION) && (synpred32_Smi()) ) { s = 67; }

                   	else if ( (LA105_1 == R_PAREN) && (synpred32_Smi()) ) { s = 68; }

                   	else if ( (LA105_1 == EXCEPT_KW) && (synpred32_Smi()) ) { s = 69; }

                   	else if ( ((LA105_1 >= INTERSECTION && LA105_1 <= INTERSECTION_KW)) && (synpred32_Smi()) ) { s = 70; }

                   	else if ( (LA105_1 == BAR || LA105_1 == UNION_KW) && (synpred32_Smi()) ) { s = 71; }

                   	else if ( (LA105_1 == 157) && (synpred32_Smi()) ) { s = 72; }

                   	else if ( (LA105_1 == 153) ) { s = 2; }

                   	 
                   	input.Seek(index105_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA105_3 = input.LA(1);

                   	 
                   	int index105_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_3 == ANY_KW || (LA105_3 >= BIT_KW && LA105_3 <= BOOLEAN_KW) || LA105_3 == CHARACTER_KW || LA105_3 == CHOICE_KW || LA105_3 == EMBEDDED_KW || (LA105_3 >= ENUMERATED_KW && LA105_3 <= ERROR_KW) || LA105_3 == EXTERNAL_KW || (LA105_3 >= GENERAL_STR_KW && LA105_3 <= GRAPHIC_STR_KW) || LA105_3 == IA5_STRING_KW || LA105_3 == INTEGER_KW || LA105_3 == ISO646_STR_KW || LA105_3 == L_BRACKET || LA105_3 == NUMERIC_STR_KW || (LA105_3 >= OBJECT_KW && LA105_3 <= OCTET_KW) || LA105_3 == OPERATION_KW || LA105_3 == PRINTABLE_STR_KW || LA105_3 == REAL_KW || (LA105_3 >= SEQUENCE_KW && LA105_3 <= SET_KW) || LA105_3 == T61_STR_KW || LA105_3 == TELETEX_STR_KW || LA105_3 == UNIVERSAL_STR_KW || (LA105_3 >= UTC_TIME_KW && LA105_3 <= VISIBLE_STR_KW) || LA105_3 == 131 || LA105_3 == 137 || (LA105_3 >= 158 && LA105_3 <= 160) || (LA105_3 >= 162 && LA105_3 <= 164) || LA105_3 == 166 || LA105_3 == 179 || LA105_3 == 188 || LA105_3 == 191) ) { s = 2; }

                   	else if ( (LA105_3 == NULL_KW) ) { s = 73; }

                   	else if ( (LA105_3 == UPPER) ) { s = 74; }

                   	else if ( (LA105_3 == LOWER) ) { s = 75; }

                   	else if ( (LA105_3 == TRUE_KW) && (synpred32_Smi()) ) { s = 76; }

                   	else if ( (LA105_3 == FALSE_KW) && (synpred32_Smi()) ) { s = 77; }

                   	else if ( (LA105_3 == C_STRING) && (synpred32_Smi()) ) { s = 78; }

                   	else if ( (LA105_3 == MINUS) && (synpred32_Smi()) ) { s = 79; }

                   	else if ( (LA105_3 == NUMBER) && (synpred32_Smi()) ) { s = 80; }

                   	else if ( (LA105_3 == L_BRACE) && (synpred32_Smi()) ) { s = 81; }

                   	else if ( (LA105_3 == H_STRING) && (synpred32_Smi()) ) { s = 82; }

                   	else if ( (LA105_3 == B_STRING) && (synpred32_Smi()) ) { s = 83; }

                   	else if ( (LA105_3 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 84; }

                   	else if ( (LA105_3 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 85; }

                   	 
                   	input.Seek(index105_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA105_73 = input.LA(1);

                   	 
                   	int index105_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Smi()) ) { s = 85; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index105_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA105_75 = input.LA(1);

                   	 
                   	int index105_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_75 == LESS) ) { s = 2; }

                   	else if ( (LA105_75 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA105_75 == UPPER) && (synpred32_Smi()) ) { s = 87; }

                   	else if ( (LA105_75 == LOWER) && (synpred32_Smi()) ) { s = 88; }

                   	else if ( (LA105_75 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA105_75 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA105_75 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA105_75 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA105_75 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA105_75 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA105_75 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA105_75 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA105_75 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA105_75 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA105_75 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA105_75 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA105_75 == OBJECT_KW) && (synpred32_Smi()) ) { s = 89; }

                   	else if ( (LA105_75 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA105_75 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA105_75 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA105_75 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA105_75 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA105_75 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA105_75 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA105_75 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA105_75 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA105_75 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA105_75 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA105_75 == 131 || (LA105_75 >= 158 && LA105_75 <= 160) || (LA105_75 >= 162 && LA105_75 <= 164) || LA105_75 == 166 || LA105_75 == 188 || LA105_75 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA105_75 == COLON) && (synpred32_Smi()) ) { s = 90; }

                   	else if ( (LA105_75 == TRUE_KW) && (synpred32_Smi()) ) { s = 91; }

                   	else if ( (LA105_75 == FALSE_KW) && (synpred32_Smi()) ) { s = 92; }

                   	else if ( (LA105_75 == NULL_KW) && (synpred32_Smi()) ) { s = 93; }

                   	else if ( (LA105_75 == C_STRING) && (synpred32_Smi()) ) { s = 94; }

                   	else if ( (LA105_75 == MINUS) && (synpred32_Smi()) ) { s = 95; }

                   	else if ( (LA105_75 == NUMBER) && (synpred32_Smi()) ) { s = 96; }

                   	else if ( (LA105_75 == L_BRACE) && (synpred32_Smi()) ) { s = 97; }

                   	else if ( (LA105_75 == H_STRING) && (synpred32_Smi()) ) { s = 98; }

                   	else if ( (LA105_75 == B_STRING) && (synpred32_Smi()) ) { s = 99; }

                   	else if ( (LA105_75 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 100; }

                   	else if ( (LA105_75 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 101; }

                   	 
                   	input.Seek(index105_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA105_86 = input.LA(1);

                   	 
                   	int index105_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA105_86 == UPPER) ) { s = 2; }

                   	else if ( (LA105_86 == LOWER) && (synpred32_Smi()) ) { s = 102; }

                   	 
                   	input.Seek(index105_86);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae105 =
            new NoViableAltException(dfa.Description, 105, _s, input);
        dfa.Error(nvae105);
        throw nvae105;
    }
    const string DFA104_eotS =
        "\x47\xFFFF";
    const string DFA104_eofS =
        "\x1\xE\x46\xFFFF";
    const string DFA104_minS =
        "\x1\xA\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA104_maxS =
        "\x1\xC5\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA104_acceptS =
        "\x1\xFFFF\x4\x1\x2\xFFFF\x7\x1\x1\x2\x38\xFFFF";
    const string DFA104_specialS =
        "\x1\x0\x4\xFFFF\x1\x1\x1\x2\x40\xFFFF}>";
    static readonly string[] DFA104_transitionS = {
            "\x1\xE\x2\xFFFF\x1\xB\x1\xE\x7\xFFFF\x1\x4\x5\xFFFF\x2\xE\x4"+
            "\xFFFF\x1\xE\x6\xFFFF\x1\xE\x1\xFFFF\x4\xE\x4\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\xA\x9\xFFFF\x2\xE\x1\xFFFF\x1\x9\x3\xFFFF\x1\xE\x1"+
            "\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\x2\xFFFF\x1\xE\x3\xFFFF"+
            "\x2\xE\x4\xFFFF\x1\xC\x3\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x1\xE\xA\xFFFF\x1\x1\x1\xFFFF\x1\xE\x3\xFFFF\x1\x5\x6\xFFFF"+
            "\x9\xE\x1\xFFFF\x1\xE\x2\xFFFF\x3\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x4\xFFFF\x7\xE\x1\xFFFF\x3\xE\x1\xFFFF\x1\xE\x1\xFFFF"+
            "\x1\xE\x2\xFFFF\x4\xE\x1\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x3\xFFFF\x5\xE\x1\xFFFF\x1\xE\x2\xFFFF\x1\xE",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
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
            ""
    };

    static readonly short[] DFA104_eot = DFA.UnpackEncodedString(DFA104_eotS);
    static readonly short[] DFA104_eof = DFA.UnpackEncodedString(DFA104_eofS);
    static readonly char[] DFA104_min = DFA.UnpackEncodedStringToUnsignedChars(DFA104_minS);
    static readonly char[] DFA104_max = DFA.UnpackEncodedStringToUnsignedChars(DFA104_maxS);
    static readonly short[] DFA104_accept = DFA.UnpackEncodedString(DFA104_acceptS);
    static readonly short[] DFA104_special = DFA.UnpackEncodedString(DFA104_specialS);
    static readonly short[][] DFA104_transition = DFA.UnpackEncodedStringArray(DFA104_transitionS);

    protected class DFA104 : DFA
    {
        public DFA104(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 104;
            this.eot = DFA104_eot;
            this.eof = DFA104_eof;
            this.min = DFA104_min;
            this.max = DFA104_max;
            this.accept = DFA104_accept;
            this.special = DFA104_special;
            this.transition = DFA104_transition;

        }

        override public string Description
        {
            get { return "922:59: (=> value )?"; }
        }

    }


    protected internal int DFA104_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA104_0 = input.LA(1);

                   	 
                   	int index104_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA104_0 == TRUE_KW) && (synpred33_Smi()) ) { s = 1; }

                   	else if ( (LA104_0 == FALSE_KW) && (synpred33_Smi()) ) { s = 2; }

                   	else if ( (LA104_0 == NULL_KW) && (synpred33_Smi()) ) { s = 3; }

                   	else if ( (LA104_0 == C_STRING) && (synpred33_Smi()) ) { s = 4; }

                   	else if ( (LA104_0 == UPPER) ) { s = 5; }

                   	else if ( (LA104_0 == LOWER) ) { s = 6; }

                   	else if ( (LA104_0 == MINUS) && (synpred33_Smi()) ) { s = 7; }

                   	else if ( (LA104_0 == NUMBER) && (synpred33_Smi()) ) { s = 8; }

                   	else if ( (LA104_0 == L_BRACE) && (synpred33_Smi()) ) { s = 9; }

                   	else if ( (LA104_0 == H_STRING) && (synpred33_Smi()) ) { s = 10; }

                   	else if ( (LA104_0 == B_STRING) && (synpred33_Smi()) ) { s = 11; }

                   	else if ( (LA104_0 == PLUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 12; }

                   	else if ( (LA104_0 == MINUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 13; }

                   	else if ( (LA104_0 == EOF || LA104_0 == ASSIGN_OP || LA104_0 == BAR || (LA104_0 >= COLON && LA104_0 <= COMMA) || LA104_0 == DEFAULT_KW || LA104_0 == END_KW || (LA104_0 >= ERROR_KW && LA104_0 <= EXCLAMATION) || (LA104_0 >= INTERSECTION && LA104_0 <= INTERSECTION_KW) || LA104_0 == LINKED_KW || LA104_0 == OBJECT_KW || (LA104_0 >= OPERATION_KW && LA104_0 <= OPTIONAL_KW) || LA104_0 == R_BRACE || LA104_0 == R_PAREN || LA104_0 == RESULT_KW || LA104_0 == UNION_KW || (LA104_0 >= 126 && LA104_0 <= 134) || LA104_0 == 136 || (LA104_0 >= 139 && LA104_0 <= 141) || LA104_0 == 143 || (LA104_0 >= 146 && LA104_0 <= 149) || (LA104_0 >= 154 && LA104_0 <= 160) || (LA104_0 >= 162 && LA104_0 <= 164) || LA104_0 == 166 || LA104_0 == 168 || (LA104_0 >= 171 && LA104_0 <= 174) || LA104_0 == 176 || LA104_0 == 178 || (LA104_0 >= 181 && LA104_0 <= 184) || (LA104_0 >= 188 && LA104_0 <= 192) || LA104_0 == 194 || LA104_0 == 197) ) { s = 14; }

                   	 
                   	input.Seek(index104_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA104_5 = input.LA(1);

                   	 
                   	int index104_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index104_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA104_6 = input.LA(1);

                   	 
                   	int index104_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index104_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae104 =
            new NoViableAltException(dfa.Description, 104, _s, input);
        dfa.Error(nvae104);
        throw nvae104;
    }
    const string DFA116_eotS =
        "\xB\xFFFF";
    const string DFA116_eofS =
        "\xB\xFFFF";
    const string DFA116_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA116_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA116_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA116_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA116_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA116_eot = DFA.UnpackEncodedString(DFA116_eotS);
    static readonly short[] DFA116_eof = DFA.UnpackEncodedString(DFA116_eofS);
    static readonly char[] DFA116_min = DFA.UnpackEncodedStringToUnsignedChars(DFA116_minS);
    static readonly char[] DFA116_max = DFA.UnpackEncodedStringToUnsignedChars(DFA116_maxS);
    static readonly short[] DFA116_accept = DFA.UnpackEncodedString(DFA116_acceptS);
    static readonly short[] DFA116_special = DFA.UnpackEncodedString(DFA116_specialS);
    static readonly short[][] DFA116_transition = DFA.UnpackEncodedStringArray(DFA116_transitionS);

    protected class DFA116 : DFA
    {
        public DFA116(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 116;
            this.eot = DFA116_eot;
            this.eof = DFA116_eof;
            this.min = DFA116_min;
            this.max = DFA116_max;
            this.accept = DFA116_accept;
            this.special = DFA116_special;
            this.transition = DFA116_transition;

        }

        override public string Description
        {
            get { return "932:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA116_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA116_1 = input.LA(1);

                   	 
                   	int index116_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA116_1 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index116_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA116_2 = input.LA(1);

                   	 
                   	int index116_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA116_2 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index116_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA116_5 = input.LA(1);

                   	 
                   	int index116_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA116_5 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index116_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA116_9 = input.LA(1);

                   	 
                   	int index116_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA116_9 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index116_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA116_10 = input.LA(1);

                   	 
                   	int index116_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA116_10 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index116_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae116 =
            new NoViableAltException(dfa.Description, 116, _s, input);
        dfa.Error(nvae116);
        throw nvae116;
    }
    const string DFA129_eotS =
        "\x10\xFFFF";
    const string DFA129_eofS =
        "\x10\xFFFF";
    const string DFA129_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\x0\x1\xD\x1\xFFFF\x1\xD\x1"+
        "\x0\x1\xD\x1\x0\x2\xD";
    const string DFA129_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\x0\x1\x77\x1\xFFFF\x1\x77"+
        "\x1\x0\x1\x77\x1\x0\x2\x77";
    const string DFA129_acceptS =
        "\x2\xFFFF\x1\x2\x6\xFFFF\x1\x1\x6\xFFFF";
    const string DFA129_specialS =
        "\x5\xFFFF\x1\x0\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\xFFFF\x1\x3\x2"+
        "\xFFFF}>";
    static readonly string[] DFA129_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x4\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x6\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x7\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x8\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xE\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xD\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xF\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA129_eot = DFA.UnpackEncodedString(DFA129_eotS);
    static readonly short[] DFA129_eof = DFA.UnpackEncodedString(DFA129_eofS);
    static readonly char[] DFA129_min = DFA.UnpackEncodedStringToUnsignedChars(DFA129_minS);
    static readonly char[] DFA129_max = DFA.UnpackEncodedStringToUnsignedChars(DFA129_maxS);
    static readonly short[] DFA129_accept = DFA.UnpackEncodedString(DFA129_acceptS);
    static readonly short[] DFA129_special = DFA.UnpackEncodedString(DFA129_specialS);
    static readonly short[][] DFA129_transition = DFA.UnpackEncodedStringArray(DFA129_transitionS);

    protected class DFA129 : DFA
    {
        public DFA129(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 129;
            this.eot = DFA129_eot;
            this.eof = DFA129_eof;
            this.min = DFA129_min;
            this.max = DFA129_max;
            this.accept = DFA129_accept;
            this.special = DFA129_special;
            this.transition = DFA129_transition;

        }

        override public string Description
        {
            get { return "963:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )"; }
        }

    }


    protected internal int DFA129_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA129_5 = input.LA(1);

                   	 
                   	int index129_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index129_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA129_7 = input.LA(1);

                   	 
                   	int index129_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index129_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA129_11 = input.LA(1);

                   	 
                   	int index129_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index129_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA129_13 = input.LA(1);

                   	 
                   	int index129_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index129_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae129 =
            new NoViableAltException(dfa.Description, 129, _s, input);
        dfa.Error(nvae129);
        throw nvae129;
    }
    const string DFA133_eotS =
        "\xB\xFFFF";
    const string DFA133_eofS =
        "\xB\xFFFF";
    const string DFA133_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA133_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA133_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA133_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA133_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA133_eot = DFA.UnpackEncodedString(DFA133_eotS);
    static readonly short[] DFA133_eof = DFA.UnpackEncodedString(DFA133_eofS);
    static readonly char[] DFA133_min = DFA.UnpackEncodedStringToUnsignedChars(DFA133_minS);
    static readonly char[] DFA133_max = DFA.UnpackEncodedStringToUnsignedChars(DFA133_maxS);
    static readonly short[] DFA133_accept = DFA.UnpackEncodedString(DFA133_acceptS);
    static readonly short[] DFA133_special = DFA.UnpackEncodedString(DFA133_specialS);
    static readonly short[][] DFA133_transition = DFA.UnpackEncodedStringArray(DFA133_transitionS);

    protected class DFA133 : DFA
    {
        public DFA133(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 133;
            this.eot = DFA133_eot;
            this.eof = DFA133_eof;
            this.min = DFA133_min;
            this.max = DFA133_max;
            this.accept = DFA133_accept;
            this.special = DFA133_special;
            this.transition = DFA133_transition;

        }

        override public string Description
        {
            get { return "965:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA133_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA133_1 = input.LA(1);

                   	 
                   	int index133_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA133_1 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index133_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA133_2 = input.LA(1);

                   	 
                   	int index133_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA133_2 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index133_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA133_5 = input.LA(1);

                   	 
                   	int index133_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA133_5 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index133_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA133_9 = input.LA(1);

                   	 
                   	int index133_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA133_9 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index133_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA133_10 = input.LA(1);

                   	 
                   	int index133_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA133_10 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index133_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae133 =
            new NoViableAltException(dfa.Description, 133, _s, input);
        dfa.Error(nvae133);
        throw nvae133;
    }
    const string DFA136_eotS =
        "\x10\xFFFF";
    const string DFA136_eofS =
        "\x1\x2\xF\xFFFF";
    const string DFA136_minS =
        "\x1\xA\x1\xD\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA136_maxS =
        "\x1\xC5\x1\x77\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA136_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\xC\x1";
    const string DFA136_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\xC\xFFFF}>";
    static readonly string[] DFA136_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x2\x2\x1\x1\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x6"+
            "\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1"+
            "\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x3\x2\x2\xFFFF\x4\x2\x3"+
            "\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xD\x8\xFFFF\x1\x3\x1C\xFFFF\x1\x5\x4\xFFFF\x1\xC\xC\xFFFF"+
            "\x1\xB\x4\xFFFF\x1\x8\x2\xFFFF\x1\x9\x1\xF\x1\x6\x1\xA\xC\xFFFF"+
            "\x1\xE\x13\xFFFF\x1\x4\x5\xFFFF\x1\x7",
            "",
            "\x1\xFFFF",
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
            ""
    };

    static readonly short[] DFA136_eot = DFA.UnpackEncodedString(DFA136_eotS);
    static readonly short[] DFA136_eof = DFA.UnpackEncodedString(DFA136_eofS);
    static readonly char[] DFA136_min = DFA.UnpackEncodedStringToUnsignedChars(DFA136_minS);
    static readonly char[] DFA136_max = DFA.UnpackEncodedStringToUnsignedChars(DFA136_maxS);
    static readonly short[] DFA136_accept = DFA.UnpackEncodedString(DFA136_acceptS);
    static readonly short[] DFA136_special = DFA.UnpackEncodedString(DFA136_specialS);
    static readonly short[][] DFA136_transition = DFA.UnpackEncodedStringArray(DFA136_transitionS);

    protected class DFA136 : DFA
    {
        public DFA136(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 136;
            this.eot = DFA136_eot;
            this.eof = DFA136_eof;
            this.min = DFA136_min;
            this.max = DFA136_max;
            this.accept = DFA136_accept;
            this.special = DFA136_special;
            this.transition = DFA136_transition;

        }

        override public string Description
        {
            get { return "982:21: (=> 'DESCRIPTION' value )?"; }
        }

    }


    protected internal int DFA136_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA136_1 = input.LA(1);

                   	 
                   	int index136_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA136_1 == C_STRING) ) { s = 3; }

                   	else if ( (LA136_1 == TRUE_KW) && (synpred39_Smi()) ) { s = 4; }

                   	else if ( (LA136_1 == FALSE_KW) && (synpred39_Smi()) ) { s = 5; }

                   	else if ( (LA136_1 == NULL_KW) && (synpred39_Smi()) ) { s = 6; }

                   	else if ( (LA136_1 == UPPER) && (synpred39_Smi()) ) { s = 7; }

                   	else if ( (LA136_1 == LOWER) && (synpred39_Smi()) ) { s = 8; }

                   	else if ( (LA136_1 == MINUS) && (synpred39_Smi()) ) { s = 9; }

                   	else if ( (LA136_1 == NUMBER) && (synpred39_Smi()) ) { s = 10; }

                   	else if ( (LA136_1 == L_BRACE) && (synpred39_Smi()) ) { s = 11; }

                   	else if ( (LA136_1 == H_STRING) && (synpred39_Smi()) ) { s = 12; }

                   	else if ( (LA136_1 == B_STRING) && (synpred39_Smi()) ) { s = 13; }

                   	else if ( (LA136_1 == PLUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 14; }

                   	else if ( (LA136_1 == MINUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 15; }

                   	 
                   	input.Seek(index136_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA136_3 = input.LA(1);

                   	 
                   	int index136_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_Smi()) ) { s = 15; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index136_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae136 =
            new NoViableAltException(dfa.Description, 136, _s, input);
        dfa.Error(nvae136);
        throw nvae136;
    }
    const string DFA140_eotS =
        "\x2A\xFFFF";
    const string DFA140_eofS =
        "\x13\xFFFF\x1\x27\x1\x22\x15\xFFFF";
    const string DFA140_minS =
        "\x1\x7\xA\xFFFF\x1\x0\x7\xFFFF\x1\x1D\x1\xD\xE\xFFFF\x1\x4A\x6\xFFFF";
    const string DFA140_maxS =
        "\x1\xBF\xA\xFFFF\x1\x0\x7\xFFFF\x1\x61\x1\x77\xE\xFFFF\x1\x77\x6"+
        "\xFFFF";
    const string DFA140_acceptS =
        "\x1\xFFFF\xA\x1\x1\xFFFF\x7\x1\x2\xFFFF\xD\x1\x1\x2\x1\xFFFF\x6"+
        "\x1";
    const string DFA140_specialS =
        "\x1\x0\xA\xFFFF\x1\x1\x7\xFFFF\x1\x2\x1\x3\xE\xFFFF\x1\x4\x6\xFFFF}>";
    static readonly string[] DFA140_transitionS = {
            "\x1\x1\x5\xFFFF\x1\x22\x4\xFFFF\x1\x2\x1\x5\x1\x3\x1\xFFFF\x1"+
            "\x22\x1\x4\x2\xFFFF\x1\x6\xD\xFFFF\x1\x7\x1\xFFFF\x1\x8\x1\x16"+
            "\x6\xFFFF\x1\x9\x1\x22\x1\xFFFF\x3\x5\x1\x22\x1\xFFFF\x1\x5"+
            "\x6\xFFFF\x1\xA\x2\xFFFF\x1\x5\x1\x22\x1\x12\x3\xFFFF\x1\x14"+
            "\x2\xFFFF\x2\x22\x1\xB\x1\x22\x1\x5\x1\xFFFF\x1\xC\x1\xD\x2"+
            "\xFFFF\x1\x15\x5\xFFFF\x1\x22\x1\xFFFF\x1\x5\x4\xFFFF\x1\xE"+
            "\x3\xFFFF\x1\x10\x1\x11\x4\xFFFF\x1\x5\x1\xFFFF\x1\x5\x1\x22"+
            "\x4\xFFFF\x1\x5\x1\x13\x4\x5\x7\xFFFF\x1\x1F\x5\xFFFF\x1\x21"+
            "\x14\xFFFF\x1\x1E\x1\x18\x1\x1D\x1\xFFFF\x1\x1A\x1\x1C\x1\x19"+
            "\x1\xFFFF\x1\x17\xC\xFFFF\x1\xF\x8\xFFFF\x1\x1B\x2\xFFFF\x1"+
            "\x20",
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
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x25\x7\xFFFF\x1\x23\x21\xFFFF\x1\x24\x19\xFFFF\x1\x26",
            "\x1\x22\x8\xFFFF\x1\x22\x5\xFFFF\x2\x22\x15\xFFFF\x1\x22\x4"+
            "\xFFFF\x1\x22\xC\xFFFF\x1\x22\x2\xFFFF\x1\x28\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\xC\xFFFF\x1\x22\x3\xFFFF\x1\x22\xF\xFFFF\x1"+
            "\x22\x5\xFFFF\x1\x22",
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
            "",
            "\x1\x22\x2C\xFFFF\x1\x29",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA140_eot = DFA.UnpackEncodedString(DFA140_eotS);
    static readonly short[] DFA140_eof = DFA.UnpackEncodedString(DFA140_eofS);
    static readonly char[] DFA140_min = DFA.UnpackEncodedStringToUnsignedChars(DFA140_minS);
    static readonly char[] DFA140_max = DFA.UnpackEncodedStringToUnsignedChars(DFA140_maxS);
    static readonly short[] DFA140_accept = DFA.UnpackEncodedString(DFA140_acceptS);
    static readonly short[] DFA140_special = DFA.UnpackEncodedString(DFA140_specialS);
    static readonly short[][] DFA140_transition = DFA.UnpackEncodedStringArray(DFA140_transitionS);

    protected class DFA140 : DFA
    {
        public DFA140(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 140;
            this.eot = DFA140_eot;
            this.eof = DFA140_eof;
            this.min = DFA140_min;
            this.max = DFA140_max;
            this.accept = DFA140_accept;
            this.special = DFA140_special;
            this.transition = DFA140_transition;

        }

        override public string Description
        {
            get { return "988:0: typeorvalue : (=> type | value );"; }
        }

    }


    protected internal int DFA140_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA140_0 = input.LA(1);

                   	 
                   	int index140_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA140_0 == ANY_KW) && (synpred40_Smi()) ) { s = 1; }

                   	else if ( (LA140_0 == BIT_KW) && (synpred40_Smi()) ) { s = 2; }

                   	else if ( (LA140_0 == BOOLEAN_KW) && (synpred40_Smi()) ) { s = 3; }

                   	else if ( (LA140_0 == CHARACTER_KW) && (synpred40_Smi()) ) { s = 4; }

                   	else if ( (LA140_0 == BMP_STR_KW || (LA140_0 >= GENERAL_STR_KW && LA140_0 <= GRAPHIC_STR_KW) || LA140_0 == IA5_STRING_KW || LA140_0 == ISO646_STR_KW || LA140_0 == NUMERIC_STR_KW || LA140_0 == PRINTABLE_STR_KW || LA140_0 == T61_STR_KW || LA140_0 == TELETEX_STR_KW || LA140_0 == UNIVERSAL_STR_KW || (LA140_0 >= UTC_TIME_KW && LA140_0 <= VISIBLE_STR_KW)) && (synpred40_Smi()) ) { s = 5; }

                   	else if ( (LA140_0 == CHOICE_KW) && (synpred40_Smi()) ) { s = 6; }

                   	else if ( (LA140_0 == EMBEDDED_KW) && (synpred40_Smi()) ) { s = 7; }

                   	else if ( (LA140_0 == ENUMERATED_KW) && (synpred40_Smi()) ) { s = 8; }

                   	else if ( (LA140_0 == EXTERNAL_KW) && (synpred40_Smi()) ) { s = 9; }

                   	else if ( (LA140_0 == INTEGER_KW) && (synpred40_Smi()) ) { s = 10; }

                   	else if ( (LA140_0 == NULL_KW) ) { s = 11; }

                   	else if ( (LA140_0 == OBJECT_KW) && (synpred40_Smi()) ) { s = 12; }

                   	else if ( (LA140_0 == OCTET_KW) && (synpred40_Smi()) ) { s = 13; }

                   	else if ( (LA140_0 == REAL_KW) && (synpred40_Smi()) ) { s = 14; }

                   	else if ( (LA140_0 == 179) && (synpred40_Smi()) ) { s = 15; }

                   	else if ( (LA140_0 == SEQUENCE_KW) && (synpred40_Smi()) ) { s = 16; }

                   	else if ( (LA140_0 == SET_KW) && (synpred40_Smi()) ) { s = 17; }

                   	else if ( (LA140_0 == L_BRACKET) && (synpred40_Smi()) ) { s = 18; }

                   	else if ( (LA140_0 == UPPER) ) { s = 19; }

                   	else if ( (LA140_0 == LOWER) ) { s = 20; }

                   	else if ( (LA140_0 == OPERATION_KW) && (synpred40_Smi()) ) { s = 21; }

                   	else if ( (LA140_0 == ERROR_KW) && (synpred40_Smi()) ) { s = 22; }

                   	else if ( (LA140_0 == 166) && (synpred40_Smi()) ) { s = 23; }

                   	else if ( (LA140_0 == 159) && (synpred40_Smi()) ) { s = 24; }

                   	else if ( (LA140_0 == 164) && (synpred40_Smi()) ) { s = 25; }

                   	else if ( (LA140_0 == 162) && (synpred40_Smi()) ) { s = 26; }

                   	else if ( (LA140_0 == 188) && (synpred40_Smi()) ) { s = 27; }

                   	else if ( (LA140_0 == 163) && (synpred40_Smi()) ) { s = 28; }

                   	else if ( (LA140_0 == 160) && (synpred40_Smi()) ) { s = 29; }

                   	else if ( (LA140_0 == 158) && (synpred40_Smi()) ) { s = 30; }

                   	else if ( (LA140_0 == 131) && (synpred40_Smi()) ) { s = 31; }

                   	else if ( (LA140_0 == 191) && (synpred40_Smi()) ) { s = 32; }

                   	else if ( (LA140_0 == 137) && (synpred40_Smi()) ) { s = 33; }

                   	else if ( (LA140_0 == B_STRING || LA140_0 == C_STRING || LA140_0 == FALSE_KW || LA140_0 == H_STRING || LA140_0 == L_BRACE || (LA140_0 >= MINUS && LA140_0 <= MINUS_INFINITY_KW) || LA140_0 == NUMBER || LA140_0 == PLUS_INFINITY_KW || LA140_0 == TRUE_KW) ) { s = 34; }

                   	 
                   	input.Seek(index140_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA140_11 = input.LA(1);

                   	 
                   	int index140_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred40_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index140_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA140_19 = input.LA(1);

                   	 
                   	int index140_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA140_19 == DOT) ) { s = 35; }

                   	else if ( (LA140_19 == L_PAREN) && (synpred40_Smi()) ) { s = 36; }

                   	else if ( (LA140_19 == COMMA) && (synpred40_Smi()) ) { s = 37; }

                   	else if ( (LA140_19 == R_BRACE) && (synpred40_Smi()) ) { s = 38; }

                   	else if ( (LA140_19 == EOF) && (synpred40_Smi()) ) { s = 39; }

                   	 
                   	input.Seek(index140_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA140_20 = input.LA(1);

                   	 
                   	int index140_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA140_20 == LESS) && (synpred40_Smi()) ) { s = 40; }

                   	else if ( (LA140_20 == EOF || LA140_20 == B_STRING || LA140_20 == C_STRING || (LA140_20 >= COLON && LA140_20 <= COMMA) || LA140_20 == FALSE_KW || LA140_20 == H_STRING || LA140_20 == L_BRACE || LA140_20 == LOWER || (LA140_20 >= MINUS && LA140_20 <= NUMBER) || LA140_20 == PLUS_INFINITY_KW || LA140_20 == R_BRACE || LA140_20 == TRUE_KW || LA140_20 == UPPER) ) { s = 34; }

                   	 
                   	input.Seek(index140_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA140_35 = input.LA(1);

                   	 
                   	int index140_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA140_35 == UPPER) && (synpred40_Smi()) ) { s = 41; }

                   	else if ( (LA140_35 == LOWER) ) { s = 34; }

                   	 
                   	input.Seek(index140_35);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae140 =
            new NoViableAltException(dfa.Description, 140, _s, input);
        dfa.Error(nvae140);
        throw nvae140;
    }
    const string DFA142_eotS =
        "\x24\xFFFF";
    const string DFA142_eofS =
        "\x24\xFFFF";
    const string DFA142_minS =
        "\x1\x7\x1\x0\x22\xFFFF";
    const string DFA142_maxS =
        "\x1\xBF\x1\x0\x22\xFFFF";
    const string DFA142_acceptS =
        "\x2\xFFFF\x1\x2\x20\xFFFF\x1\x1";
    const string DFA142_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA142_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x3\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF\x1\x2\x1\xFFFF"+
            "\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF"+
            "\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xFFFF",
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
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA142_eot = DFA.UnpackEncodedString(DFA142_eotS);
    static readonly short[] DFA142_eof = DFA.UnpackEncodedString(DFA142_eofS);
    static readonly char[] DFA142_min = DFA.UnpackEncodedStringToUnsignedChars(DFA142_minS);
    static readonly char[] DFA142_max = DFA.UnpackEncodedStringToUnsignedChars(DFA142_maxS);
    static readonly short[] DFA142_accept = DFA.UnpackEncodedString(DFA142_acceptS);
    static readonly short[] DFA142_special = DFA.UnpackEncodedString(DFA142_specialS);
    static readonly short[][] DFA142_transition = DFA.UnpackEncodedStringArray(DFA142_transitionS);

    protected class DFA142 : DFA
    {
        public DFA142(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 142;
            this.eot = DFA142_eot;
            this.eof = DFA142_eof;
            this.min = DFA142_min;
            this.max = DFA142_max;
            this.accept = DFA142_accept;
            this.special = DFA142_special;
            this.transition = DFA142_transition;

        }

        override public string Description
        {
            get { return "994:21: (=> tag )?"; }
        }

    }


    protected internal int DFA142_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA142_1 = input.LA(1);

                   	 
                   	int index142_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred41_Smi()) ) { s = 35; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index142_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae142 =
            new NoViableAltException(dfa.Description, 142, _s, input);
        dfa.Error(nvae142);
        throw nvae142;
    }
    const string DFA159_eotS =
        "\x34\xFFFF";
    const string DFA159_eofS =
        "\x34\xFFFF";
    const string DFA159_minS =
        "\x1\x7\xD\x0\x26\xFFFF";
    const string DFA159_maxS =
        "\x1\xBF\xD\x0\x26\xFFFF";
    const string DFA159_acceptS =
        "\xE\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1E\xFFFF\x1\x7\x1\x8\x1"+
        "\x1";
    const string DFA159_specialS =
        "\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1"+
        "\xA\x1\xB\x1\xC\x1\xD\x26\xFFFF}>";
    static readonly string[] DFA159_transitionS = {
            "\x1\x12\x5\xFFFF\x1\xB\x4\xFFFF\x3\x12\x1\xFFFF\x1\x4\x1\x12"+
            "\x2\xFFFF\x1\x12\xD\xFFFF\x1\x12\x1\xFFFF\x2\x12\x6\xFFFF\x1"+
            "\x12\x1\x2\x1\x10\x3\x12\x1\xA\x1\xFFFF\x1\x12\x4\xFFFF\x1\x12"+
            "\x1\xFFFF\x1\x12\x2\xFFFF\x1\x12\x1\x9\x1\x12\x1\x11\x2\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xE\x1\x7\x1\xD\x1\x3\x1\x8\x1\x12\x1\xFFFF"+
            "\x2\x12\x2\xFFFF\x1\x12\x2\xFFFF\x1\x31\x2\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x12\x4\xFFFF\x1\x12\x3\xFFFF\x2\x12\x1\xFFFF\x1\xF\x2\xFFFF"+
            "\x1\x12\x1\xFFFF\x1\x12\x1\x1\x4\xFFFF\x1\x12\x1\x5\x4\x12\x1"+
            "\x32\x6\xFFFF\x1\x12\x5\xFFFF\x1\x12\x14\xFFFF\x3\x12\x1\xFFFF"+
            "\x3\x12\x1\xFFFF\x1\x12\xC\xFFFF\x1\x12\x8\xFFFF\x1\x12\x2\xFFFF"+
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
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
            ""
    };

    static readonly short[] DFA159_eot = DFA.UnpackEncodedString(DFA159_eotS);
    static readonly short[] DFA159_eof = DFA.UnpackEncodedString(DFA159_eofS);
    static readonly char[] DFA159_min = DFA.UnpackEncodedStringToUnsignedChars(DFA159_minS);
    static readonly char[] DFA159_max = DFA.UnpackEncodedStringToUnsignedChars(DFA159_maxS);
    static readonly short[] DFA159_accept = DFA.UnpackEncodedString(DFA159_acceptS);
    static readonly short[] DFA159_special = DFA.UnpackEncodedString(DFA159_specialS);
    static readonly short[][] DFA159_transition = DFA.UnpackEncodedStringArray(DFA159_transitionS);

    protected class DFA159 : DFA
    {
        public DFA159(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 159;
            this.eot = DFA159_eot;
            this.eof = DFA159_eof;
            this.min = DFA159_min;
            this.max = DFA159_max;
            this.accept = DFA159_accept;
            this.special = DFA159_special;
            this.transition = DFA159_transition;

        }

        override public string Description
        {
            get { return "1018:0: constraint_elements : (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );"; }
        }

    }


    protected internal int DFA159_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA159_0 = input.LA(1);

                   	 
                   	int index159_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA159_0 == TRUE_KW) ) { s = 1; }

                   	else if ( (LA159_0 == FALSE_KW) ) { s = 2; }

                   	else if ( (LA159_0 == NULL_KW) ) { s = 3; }

                   	else if ( (LA159_0 == C_STRING) ) { s = 4; }

                   	else if ( (LA159_0 == UPPER) ) { s = 5; }

                   	else if ( (LA159_0 == LOWER) ) { s = 6; }

                   	else if ( (LA159_0 == MINUS) ) { s = 7; }

                   	else if ( (LA159_0 == NUMBER) ) { s = 8; }

                   	else if ( (LA159_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA159_0 == H_STRING) ) { s = 10; }

                   	else if ( (LA159_0 == B_STRING) ) { s = 11; }

                   	else if ( (LA159_0 == PLUS_INFINITY_KW) ) { s = 12; }

                   	else if ( (LA159_0 == MINUS_INFINITY_KW) ) { s = 13; }

                   	else if ( (LA159_0 == MIN_KW) && (synpred45_Smi()) ) { s = 14; }

                   	else if ( (LA159_0 == SIZE_KW) ) { s = 15; }

                   	else if ( (LA159_0 == FROM_KW) ) { s = 16; }

                   	else if ( (LA159_0 == L_PAREN) ) { s = 17; }

                   	else if ( (LA159_0 == ANY_KW || (LA159_0 >= BIT_KW && LA159_0 <= BOOLEAN_KW) || LA159_0 == CHARACTER_KW || LA159_0 == CHOICE_KW || LA159_0 == EMBEDDED_KW || (LA159_0 >= ENUMERATED_KW && LA159_0 <= ERROR_KW) || LA159_0 == EXTERNAL_KW || (LA159_0 >= GENERAL_STR_KW && LA159_0 <= GRAPHIC_STR_KW) || LA159_0 == IA5_STRING_KW || LA159_0 == INCLUDES_KW || LA159_0 == INTEGER_KW || LA159_0 == ISO646_STR_KW || LA159_0 == L_BRACKET || LA159_0 == NUMERIC_STR_KW || (LA159_0 >= OBJECT_KW && LA159_0 <= OCTET_KW) || LA159_0 == OPERATION_KW || LA159_0 == PRINTABLE_STR_KW || LA159_0 == REAL_KW || (LA159_0 >= SEQUENCE_KW && LA159_0 <= SET_KW) || LA159_0 == T61_STR_KW || LA159_0 == TELETEX_STR_KW || LA159_0 == UNIVERSAL_STR_KW || (LA159_0 >= UTC_TIME_KW && LA159_0 <= VISIBLE_STR_KW) || LA159_0 == 131 || LA159_0 == 137 || (LA159_0 >= 158 && LA159_0 <= 160) || (LA159_0 >= 162 && LA159_0 <= 164) || LA159_0 == 166 || LA159_0 == 179 || LA159_0 == 188 || LA159_0 == 191) ) { s = 18; }

                   	else if ( (LA159_0 == PATTERN_KW) ) { s = 49; }

                   	else if ( (LA159_0 == WITH_KW) ) { s = 50; }

                   	 
                   	input.Seek(index159_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA159_1 = input.LA(1);

                   	 
                   	int index159_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA159_2 = input.LA(1);

                   	 
                   	int index159_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA159_3 = input.LA(1);

                   	 
                   	int index159_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index159_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA159_4 = input.LA(1);

                   	 
                   	int index159_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA159_5 = input.LA(1);

                   	 
                   	int index159_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index159_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA159_6 = input.LA(1);

                   	 
                   	int index159_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index159_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA159_7 = input.LA(1);

                   	 
                   	int index159_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA159_8 = input.LA(1);

                   	 
                   	int index159_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA159_9 = input.LA(1);

                   	 
                   	int index159_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA159_10 = input.LA(1);

                   	 
                   	int index159_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA159_11 = input.LA(1);

                   	 
                   	int index159_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA159_12 = input.LA(1);

                   	 
                   	int index159_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA159_13 = input.LA(1);

                   	 
                   	int index159_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index159_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae159 =
            new NoViableAltException(dfa.Description, 159, _s, input);
        dfa.Error(nvae159);
        throw nvae159;
    }
 

    public static readonly BitSet FOLLOW_module_identifier_in_module_definition1855 = new BitSet(new ulong[]{0x0000001000000000UL,0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1857 = new BitSet(new ulong[]{0x1002800000000C00UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1870 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_TAGS_KW_in_module_definition1882 = new BitSet(new ulong[]{0x0002000000000400UL});
    public static readonly BitSet FOLLOW_EXTENSIBILITY_KW_in_module_definition1891 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_module_definition1893 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_module_definition1899 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_module_definition1901 = new BitSet(new ulong[]{0x40010A0000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_module_body_in_module_definition1903 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_END_KW_in_module_definition1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_module_identifier1912 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_module_identifier1915 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exports_in_module_body1926 = new BitSet(new ulong[]{0x4000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_imports_in_module_body1931 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_assignment_in_module_body1936 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_obj_id_comp_lst1948 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_defined_value_in_obj_id_comp_lst1963 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_obj_id_component_in_obj_id_comp_lst1968 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000200010400UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_obj_id_comp_lst1972 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_value1983 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_value1985 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_defined_value1989 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component1999 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_obj_id_component2020 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_obj_id_component2023 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component2025 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_obj_id_component2027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_tag_default2040 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXPORTS_KW_in_exports2055 = new BitSet(new ulong[]{0x0000080000000040UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_list_in_exports2060 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_exports2066 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_SEMI_in_exports2070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPORTS_KW_in_imports2077 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbols_from_module_in_imports2080 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_SEMI_in_imports2084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2094 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2096 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2098 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_assignment2113 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2115 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2117 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_assignment2119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2135 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_macroName_in_assignment2139 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_153_in_assignment2142 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2144 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_assignment2146 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_set_in_assignment2148 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_END_KW_in_assignment2156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2170 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_symbol_list2173 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2175 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_symbol_list_in_symbols_from_module2185 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_symbols_from_module2187 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbols_from_module2189 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_symbols_from_module2218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_symbols_from_module2255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbol2291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_symbol2295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macroName_in_symbol2299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_macroName2306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_macroName2310 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_136_in_macroName2315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_192_in_macroName2319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_134_in_macroName2333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_133_in_macroName2337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_macroName2341 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_macroName2355 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_147_in_macroName2359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_189_in_macroName2363 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_190_in_macroName2367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_181_in_macroName2374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_macroName2378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_174_in_macroName2382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_178_in_macroName2386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_126_in_macroName2390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_129_in_macroName2397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_128_in_macroName2401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_127_in_macroName2405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_132_in_macroName2412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_macroName2416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_183_in_macroName2420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_182_in_macroName2424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_176_in_macroName2428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_macros_in_macroName2435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_built_in_type_in_type2442 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_type_in_type2446 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selection_type_in_type2450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macros_type_in_type2454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_type2458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_value2471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_value2487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_value2503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_value2520 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_value2536 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_value2552 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_value2567 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_value2583 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_value2599 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_value2615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_value2631 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_value2647 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_value2663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_any_type_in_built_in_type2670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bit_string_type_in_built_in_type2688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_type_in_built_in_type2706 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_str_type_in_built_in_type2724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_type_in_built_in_type2742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_embedded_type_in_built_in_type2759 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_built_in_type2761 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_built_in_type2763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enum_type_in_built_in_type2781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_external_type_in_built_in_type2798 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_type_in_built_in_type2808 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_null_type_in_built_in_type2818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_object_identifier_type_in_built_in_type2828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_octetString_type_in_built_in_type2838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_real_type_in_built_in_type2848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relativeOid_type_in_built_in_type2858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_type_in_built_in_type2868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_type_in_built_in_type2878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_type_in_built_in_type2888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setof_type_in_built_in_type2898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tagged_type_in_built_in_type2908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2916 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_type2918 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2922 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_defined_type2925 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_selection_type2935 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_selection_type2937 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_selection_type2939 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_KW_in_any_type2946 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_DEFINED_KW_in_any_type2949 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_BY_KW_in_any_type2951 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_any_type2953 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIT_KW_in_bit_string_type2965 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_bit_string_type2967 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_bit_string_type2978 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_bit_string_type2983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOLEAN_KW_in_boolean_type2994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARACTER_KW_in_character_str_type3001 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_character_str_type3003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_set_in_character_str_type3007 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_character_str_type3010 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHOICE_KW_in_choice_type3020 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_choice_type3022 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_choice_type3024 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_choice_type3026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_embedded_type3033 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_embedded_type3035 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENUMERATED_KW_in_enum_type3042 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_enum_type3044 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTERNAL_KW_in_external_type3051 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_integer_type3060 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_integer_type3071 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_in_integer_type3075 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_null_type3086 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_object_identifier_type3093 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_object_identifier_type3095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_octetString_type3102 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_octetString_type3104 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_octetString_type3107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REAL_KW_in_real_type3117 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_179_in_relativeOid_type3126 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequence_type3134 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_type3136 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_sequence_type3139 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_type3143 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequenceof_type3151 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_sequenceof_type3154 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_sequenceof_type3156 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_sequenceof_type3160 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_sequenceof_type3162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_set_type3169 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_set_type3171 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_set_type3174 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_set_type3178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_setof_type3185 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_setof_type3188 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_setof_type3190 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_setof_type3194 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_setof_type3196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tag_in_tagged_type3203 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_tagged_type3206 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_tagged_type3210 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_namedNumber_list3217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3219 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_namedNumber_list3222 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3224 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_namedNumber_list3228 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint3235 = new BitSet(new ulong[]{0x85FC4D0004DC20C0UL,0x1FC34B18A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_specs_in_constraint3238 = new BitSet(new ulong[]{0x0000400000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_exception_spec_in_constraint3243 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint3247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_character_set3254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3356 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_elementType_list3359 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3361 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_tag3371 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_clazz_in_tag3374 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_class_NUMBER_in_tag3378 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_R_BRACKET_in_tag3380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_clazz3387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_class_NUMBER3404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_class_NUMBER3408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_operation_macro3417 = new BitSet(new ulong[]{0x0000100000000202UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_ARGUMENT_KW_in_operation_macro3420 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3429 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3433 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_operation_macro3467 = new BitSet(new ulong[]{0x04E41D00049C0082UL,0x0FC14310809A8652UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3508 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3512 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_operation_macro3554 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3556 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_operation_errorlist_in_operation_macro3559 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3563 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_operation_macro3597 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3599 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_linkedOp_list_in_operation_macro3602 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_error_macro3626 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_PARAMETER_KW_in_error_macro3630 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_error_macro3639 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_error_macro3643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operation_macro_in_macros_type3661 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_error_macro_in_macros_type3665 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objecttype_macro_in_macros_type3669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_in_macros_type3673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_in_macros_type3689 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_in_macros_type3693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_in_macros_type3697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_in_macros_type3713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_in_macros_type3717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_in_macros_type3721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_in_macros_type3737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_traptype_macro_in_macros_type3741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_smi_macros3748 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_137_in_smi_type3815 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_smi_type3819 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_smi_type3823 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_smi_type3825 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_smi_type3829 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_smi_type3831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_smi_type3835 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3849 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3851 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3854 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3856 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3877 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000000000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_smi_subtyping3879 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3881 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3883 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3886 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3888 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3892 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3894 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3900 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_subtype_range3903 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_subtype_value3915 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_subtype_value3919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_subtype_value3923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_subtype_value3927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_166_in_objecttype_macro3936 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_objecttype_macro3938 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro3971 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_namedbits_in_objecttype_macro3973 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro4005 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_objecttype_macro4008 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_type_in_objecttype_macro4035 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_194_in_objecttype_macro4079 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4081 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL});
    public static readonly BitSet FOLLOW_set_in_objecttype_macro4106 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4114 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_168_in_objecttype_macro4138 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4140 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_172_in_objecttype_macro4178 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4180 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4182 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4184 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100200000000000UL});
    public static readonly BitSet FOLLOW_173_in_objecttype_macro4225 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4227 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4229 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4231 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objecttype_macro4278 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4280 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C23080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_objecttype_macro4309 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4311 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C21080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_objecttype_macro4367 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4369 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4371 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4374 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4376 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4380 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_177_in_objecttype_macro4395 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4397 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4418 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4420 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_135_in_objecttype_macro4445 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_augments_in_objecttype_macro4447 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_170_in_objecttype_macro4472 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4474 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4476 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4478 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_objecttype_macro4524 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4526 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4528 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4530 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4598 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4600 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_193_in_objecttype_macro4649 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4651 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4654 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4657 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4659 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4666 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_140_in_objecttype_macro4705 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4707 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4748 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4775 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_accesstypes4813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_pibaccess4866 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_statustypes4919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_index4969 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4971 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_index4974 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index4976 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_index4980 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype4994 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_indextype4998 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_augments5004 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_augments5006 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_augments5008 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_namedbits5018 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5021 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5024 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5026 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5028 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_namedbits5031 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5034 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5037 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5039 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5041 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_namedbits5045 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5056 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5058 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_bitsvalue5061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5063 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5067 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_error5078 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_error5080 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_error5082 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_error5084 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_159_in_moduleidentity_macro5093 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0200000001000000UL});
    public static readonly BitSet FOLLOW_185_in_moduleidentity_macro5121 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_moduleidentity_macro5123 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5125 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_moduleidentity_macro5127 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_moduleidentity_macro5157 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5159 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_167_in_moduleidentity_macro5161 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_138_in_moduleidentity_macro5165 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5167 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro5194 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5196 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5199 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_180_in_moduleidentity_macro_revision5208 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5210 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro_revision5212 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categories5223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5261 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_moduleidentity_macro_categories5264 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5266 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categoryid5274 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5276 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5278 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_164_in_objectidentity_macro5290 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectidentity_macro5292 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5294 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectidentity_macro5296 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5298 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectidentity_macro5301 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5303 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectidentity_macro_statustypes5316 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_162_in_notificationtype_macro5369 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100002000000000UL});
    public static readonly BitSet FOLLOW_165_in_notificationtype_macro5372 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationtype_macro5374 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5376 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationtype_macro5379 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5381 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationtype_macro5385 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationtype_macro5434 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_status_in_notificationtype_macro5436 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationtype_macro5438 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5440 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationtype_macro5443 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationtype_macro_status5458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_188_in_textualconvention_macro5510 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000004000UL});
    public static readonly BitSet FOLLOW_142_in_textualconvention_macro5513 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5515 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_textualconvention_macro5548 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_status_in_textualconvention_macro5550 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_textualconvention_macro5581 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0802000000000000UL});
    public static readonly BitSet FOLLOW_177_in_textualconvention_macro5615 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5617 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_textualconvention_macro5650 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_textualconvention_macro5662 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_textualconvention_macro5664 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5666 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_textualconvention_macro5706 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5708 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_textualconvention_macro5712 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_textualconvention_macro5716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_status5727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_namedbit5776 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5778 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_MINUS_in_textualconvention_macro_namedbit5781 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_textualconvention_macro_namedbit5785 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5787 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_163_in_objectgroup_macro5796 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_165_in_objectgroup_macro5798 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objectgroup_macro5800 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5802 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objectgroup_macro5805 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5807 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objectgroup_macro5811 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectgroup_macro5838 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_status_in_objectgroup_macro5840 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectgroup_macro5842 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5844 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectgroup_macro5847 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectgroup_macro_status5860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_160_in_notificationgroup_macro5912 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_161_in_notificationgroup_macro5914 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationgroup_macro5916 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5918 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationgroup_macro5921 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5923 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationgroup_macro5927 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationgroup_macro5954 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5956 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationgroup_macro5958 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5960 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationgroup_macro5963 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5965 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationgroup_macro_status5976 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_158_in_modulecompliance_macro6028 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_modulecompliance_macro6030 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6032 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro6058 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6060 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_177_in_modulecompliance_macro6063 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6065 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6070 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_status6081 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_157_in_modulecompliance_macro_module6129 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_UPPER_in_modulecompliance_macro_module6138 = new BitSet(new ulong[]{0x0108000000402002UL,0x008200002009E420UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6147 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_154_in_modulecompliance_macro_module6188 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_module6190 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6192 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_module6195 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6197 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_module6201 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6238 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_modulecompliance_macro_compliance6247 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6249 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6251 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6290 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6292 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_modulecompliance_macro_compliance6332 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6334 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_modulecompliance_macro_compliance6376 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6378 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL});
    public static readonly BitSet FOLLOW_156_in_modulecompliance_macro_compliance6425 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6427 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080000002000UL});
    public static readonly BitSet FOLLOW_171_in_modulecompliance_macro_compliance6469 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6471 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6516 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6518 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6532 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6534 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6536 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_syntax6539 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6541 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6584 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6587 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_modulecompliance_macro_syntax6622 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_namedbit6628 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6630 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6632 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_access6642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_131_in_agentcapabilities_macro6743 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_175_in_agentcapabilities_macro6745 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6747 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_agentcapabilities_macro6749 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6751 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro6778 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6780 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0402000000000000UL});
    public static readonly BitSet FOLLOW_177_in_agentcapabilities_macro6783 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6785 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6790 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_status6800 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_186_in_agentcapabilities_macro_module6848 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_module6850 = new BitSet(new ulong[]{0x8108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6853 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6890 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_module6892 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6894 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_module6897 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6899 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_module6903 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6939 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_196_in_agentcapabilities_macro_variation6947 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation6949 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_agentcapabilities_macro_variation6952 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6954 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_agentcapabilities_macro_variation6959 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6961 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL});
    public static readonly BitSet FOLLOW_130_in_agentcapabilities_macro_variation6966 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6968 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_139_in_agentcapabilities_macro_variation7010 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7012 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7014 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7017 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7019 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7023 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003000UL});
    public static readonly BitSet FOLLOW_140_in_agentcapabilities_macro_variation7065 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7067 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7088 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7091 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7096 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7098 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7102 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7106 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro_variation7149 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro_variation7151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7202 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7204 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7206 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_syntax7209 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7211 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7255 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_agentcapabilities_macro_syntax7294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_access7303 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7351 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7353 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7355 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_191_in_traptype_macro7367 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_traptype_macro7369 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7371 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_195_in_traptype_macro7374 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_traptype_macro7376 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7378 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_traptype_macro7381 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7383 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_traptype_macro7387 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL});
    public static readonly BitSet FOLLOW_141_in_traptype_macro7419 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7421 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_traptype_macro7426 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7428 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7438 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_operation_errorlist7441 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7443 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7453 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_linkedOp_list7456 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7458 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_type_in_typeorvalue7474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_typeorvalue7478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7486 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_typeorvaluelist7489 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7491 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_elementType7503 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_in_elementType7521 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_elementType7547 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7551 = new BitSet(new ulong[]{0x0000000400000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_OPTIONAL_KW_in_elementType7554 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_KW_in_elementType7558 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_elementType7560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_elementType7578 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_elementType7580 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7582 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_namedNumber7591 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_namedNumber7593 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000012400UL});
    public static readonly BitSet FOLLOW_signed_number_in_namedNumber7596 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_defined_value_in_namedNumber7600 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_namedNumber7603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_signed_number7611 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_signed_number7615 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7622 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7625 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_element_set_specs7627 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7632 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXCLAMATION_in_exception_spec7644 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809BA452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_signed_number_in_exception_spec7671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_exception_spec7700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_exception_spec7723 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_COLON_in_exception_spec7725 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_exception_spec7727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7752 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_set_in_element_set_spec7756 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7764 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_element_set_spec7788 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_element_set_spec7790 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_element_set_spec7792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7799 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7802 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7804 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_set_in_intersections7827 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7835 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7838 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7840 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements7859 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_range_in_constraint_elements7889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_constraint_elements7912 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_constraint_elements7938 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint_elements7964 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_constraint_elements7966 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint_elements7968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_constraint_elements7993 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_constraint_elements7997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PATTERN_KW_in_constraint_elements8021 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements8023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WITH_KW_in_constraint_elements8047 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_COMPONENT_KW_in_constraint_elements8050 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements8052 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_constraint_elements8087 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_constraint_elements8089 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_constraint_elements8092 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_constraint_elements8094 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_type_constraint_list_in_constraint_elements8131 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_constraint_elements8133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_value_range8142 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_MIN_KW_in_value_range8146 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8150 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_value_range8154 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001ED20UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8157 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001EC20UL});
    public static readonly BitSet FOLLOW_value_in_value_range8162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAX_KW_in_value_range8166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8175 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_type_constraint_list8178 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8180 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_constraint8190 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000080UL});
    public static readonly BitSet FOLLOW_constraint_in_named_constraint8193 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000000UL});
    public static readonly BitSet FOLLOW_set_in_named_constraint8197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_choice_value8216 = new BitSet(new ulong[]{0x0108000010402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_COLON_in_choice_value8219 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_choice_value8223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_value8230 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8233 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequence_value8238 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8240 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_value8244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequenceof_value8251 = new BitSet(new ulong[]{0x0108000020402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8254 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequenceof_value8259 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8261 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequenceof_value8265 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_cstr_value8278 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_cstr_value8299 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_cstr_value8314 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_id_list_in_cstr_value8337 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_cstr_value8362 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_cstr_value8381 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_cstr_value8397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8404 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_id_list8407 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8409 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8419 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_char_defs_list8422 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8424 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8435 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8437 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8439 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8442 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8444 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8446 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_char_defs8459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_char_defs8473 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_char_defs8475 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_char_defs8477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_char_defs8490 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_value8500 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_named_value8502 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred1_Smi1952 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred1_Smi1954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_synpred10_Smi2578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_synpred11_Smi2594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_synpred12_Smi2610 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_synpred13_Smi2626 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2658 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred16_Smi2971 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred16_Smi2973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred17_Smi3064 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred17_Smi3066 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred18_Smi3424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_synpred19_Smi3462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred2_Smi2250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred20_Smi3496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred21_Smi3503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_synpred22_Smi3549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_synpred23_Smi3592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred24_Smi3634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred25_Smi3964 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred25_Smi3966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred26_Smi4000 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred27_Smi4304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred28_Smi4409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_synpred29_Smi4700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_synpred3_Smi2466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred30_Smi4733 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred30_Smi4735 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_set_in_synpred30_Smi4737 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred31_Smi5655 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred31_Smi5657 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_synpred32_Smi6133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred33_Smi6142 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred34_Smi6525 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred34_Smi6527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred35_Smi6579 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred36_Smi7071 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_set_in_synpred36_Smi7073 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred37_Smi7158 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred37_Smi7160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred38_Smi7250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred39_Smi7414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_synpred4_Smi2482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred40_Smi7469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_synpred41_Smi7508 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred41_Smi7510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred42_Smi7666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred43_Smi7695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred44_Smi7854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_range_in_synpred45_Smi7884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_synpred46_Smi8273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_synpred47_Smi8294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_list_in_synpred48_Smi8332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_synpred49_Smi8357 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_synpred5_Smi2498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_synpred6_Smi2515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred7_Smi2531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred8_Smi2547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_synpred9_Smi2562 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}