//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\code\Quokka\Grammar\Quokka\QuokkaLex.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Quokka.Generated {
using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
internal partial class QuokkaLex : Lexer {
	public const int
		SingleInstructionComment=1, OutputInstructionStart=2, ControlInstructionStart=3, 
		Fluff=4, InstructionEnd=5, If=6, EndIf=7, End=8, Else=9, ElseIf=10, For=11, 
		In=12, EndFor=13, Comment=14, EndComment=15, MemberAccessOperator=16, 
		Pipe=17, CommaSeparator=18, LeftParen=19, RightParen=20, And=21, Or=22, 
		Not=23, Equals=24, NotEquals=25, GreaterThan=26, LessThan=27, GreaterThanOrEquals=28, 
		LessThanOrEquals=29, Plus=30, Minus=31, Multiply=32, Divide=33, Number=34, 
		Digit=35, DoubleQuotedString=36, Identifier=37, WhiteSpace=38;
	public const int Instruction = 1;
	public static string[] modeNames = {
		"DEFAULT_MODE", "Instruction"
	};

	public static readonly string[] ruleNames = {
		"SingleInstructionComment", "OutputInstructionStart", "ControlInstructionStart", 
		"Fluff", "InstructionEnd", "If", "EndIf", "End", "Else", "ElseIf", "For", 
		"In", "EndFor", "Comment", "EndComment", "MemberAccessOperator", "Pipe", 
		"CommaSeparator", "LeftParen", "RightParen", "And", "Or", "Not", "Equals", 
		"NotEquals", "GreaterThan", "LessThan", "GreaterThanOrEquals", "LessThanOrEquals", 
		"Plus", "Minus", "Multiply", "Divide", "Number", "Digit", "DoubleQuotedString", 
		"Identifier", "WhiteSpace"
	};


	public QuokkaLex(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'${'", "'@{'", null, "'}'", null, null, null, null, null, 
		null, null, null, null, null, "'.'", "'|'", "','", "'('", "')'", null, 
		null, null, "'='", "'!='", "'>'", "'<'", "'>='", "'<='", "'+'", "'-'", 
		"'*'", "'/'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "SingleInstructionComment", "OutputInstructionStart", "ControlInstructionStart", 
		"Fluff", "InstructionEnd", "If", "EndIf", "End", "Else", "ElseIf", "For", 
		"In", "EndFor", "Comment", "EndComment", "MemberAccessOperator", "Pipe", 
		"CommaSeparator", "LeftParen", "RightParen", "And", "Or", "Not", "Equals", 
		"NotEquals", "GreaterThan", "LessThan", "GreaterThanOrEquals", "LessThanOrEquals", 
		"Plus", "Minus", "Multiply", "Divide", "Number", "Digit", "DoubleQuotedString", 
		"Identifier", "WhiteSpace"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "QuokkaLex.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2(\x108\b\x1\b\x1"+
		"\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b"+
		"\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF"+
		"\x4\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 "+
		"\t \x4!\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x3\x2\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\a\x2V\n\x2\f\x2\xE\x2Y\v\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5"+
		"\a\x5k\n\x5\f\x5\xE\x5n\v\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5u\n\x5"+
		"\f\x5\xE\x5x\v\x5\x3\x5\x3\x5\x3\x5\x6\x5}\n\x5\r\x5\xE\x5~\x5\x5\x81"+
		"\n\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\b\x3\b\x6\b\x8C\n\b\r"+
		"\b\xE\b\x8D\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3"+
		"\v\x3\v\x6\v\x9D\n\v\r\v\xE\v\x9E\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\r\x3"+
		"\r\x3\r\x3\xE\x3\xE\x6\xE\xAC\n\xE\r\xE\xE\xE\xAD\x3\xE\x3\xE\x3\xF\x3"+
		"\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x6\x10\xBC\n\x10"+
		"\r\x10\xE\x10\xBD\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3"+
		"\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3"+
		"\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3"+
		"\x1E\x3\x1F\x3\x1F\x3 \x3 \x3!\x3!\x3\"\x3\"\x3#\x6#\xEF\n#\r#\xE#\xF0"+
		"\x3$\x3$\x3%\x3%\a%\xF7\n%\f%\xE%\xFA\v%\x3%\x3%\x3&\x3&\a&\x100\n&\f"+
		"&\xE&\x103\v&\x3\'\x3\'\x3\'\x3\'\x4lv\x2(\x4\x3\x6\x4\b\x5\n\x6\f\a\xE"+
		"\b\x10\t\x12\n\x14\v\x16\f\x18\r\x1A\xE\x1C\xF\x1E\x10 \x11\"\x12$\x13"+
		"&\x14(\x15*\x16,\x17.\x18\x30\x19\x32\x1A\x34\x1B\x36\x1C\x38\x1D:\x1E"+
		"<\x1F> @!\x42\"\x44#\x46$H%J&L\'N(\x4\x2\x3\x16\x3\x2\x7F\x7F\x4\x2&&"+
		"\x42\x42\x3\x2}}\x4\x2KKkk\x4\x2HHhh\x4\x2GGgg\x4\x2PPpp\x4\x2\x46\x46"+
		"\x66\x66\x4\x2NNnn\x4\x2UUuu\x4\x2QQqq\x4\x2TTtt\x4\x2\x45\x45\x65\x65"+
		"\x4\x2OOoo\x4\x2VVvv\x4\x2\x43\x43\x63\x63\x3\x2$$\x4\x2\x43\\\x63|\x5"+
		"\x2\x32;\x43\\\x63|\x5\x2\v\f\xF\xF\"\"\x114\x2\x4\x3\x2\x2\x2\x2\x6\x3"+
		"\x2\x2\x2\x2\b\x3\x2\x2\x2\x2\n\x3\x2\x2\x2\x3\f\x3\x2\x2\x2\x3\xE\x3"+
		"\x2\x2\x2\x3\x10\x3\x2\x2\x2\x3\x12\x3\x2\x2\x2\x3\x14\x3\x2\x2\x2\x3"+
		"\x16\x3\x2\x2\x2\x3\x18\x3\x2\x2\x2\x3\x1A\x3\x2\x2\x2\x3\x1C\x3\x2\x2"+
		"\x2\x3\x1E\x3\x2\x2\x2\x3 \x3\x2\x2\x2\x3\"\x3\x2\x2\x2\x3$\x3\x2\x2\x2"+
		"\x3&\x3\x2\x2\x2\x3(\x3\x2\x2\x2\x3*\x3\x2\x2\x2\x3,\x3\x2\x2\x2\x3.\x3"+
		"\x2\x2\x2\x3\x30\x3\x2\x2\x2\x3\x32\x3\x2\x2\x2\x3\x34\x3\x2\x2\x2\x3"+
		"\x36\x3\x2\x2\x2\x3\x38\x3\x2\x2\x2\x3:\x3\x2\x2\x2\x3<\x3\x2\x2\x2\x3"+
		">\x3\x2\x2\x2\x3@\x3\x2\x2\x2\x3\x42\x3\x2\x2\x2\x3\x44\x3\x2\x2\x2\x3"+
		"\x46\x3\x2\x2\x2\x3H\x3\x2\x2\x2\x3J\x3\x2\x2\x2\x3L\x3\x2\x2\x2\x3N\x3"+
		"\x2\x2\x2\x4P\x3\x2\x2\x2\x6]\x3\x2\x2\x2\b\x62\x3\x2\x2\x2\n\x80\x3\x2"+
		"\x2\x2\f\x82\x3\x2\x2\x2\xE\x86\x3\x2\x2\x2\x10\x89\x3\x2\x2\x2\x12\x91"+
		"\x3\x2\x2\x2\x14\x95\x3\x2\x2\x2\x16\x9A\x3\x2\x2\x2\x18\xA2\x3\x2\x2"+
		"\x2\x1A\xA6\x3\x2\x2\x2\x1C\xA9\x3\x2\x2\x2\x1E\xB1\x3\x2\x2\x2 \xB9\x3"+
		"\x2\x2\x2\"\xC1\x3\x2\x2\x2$\xC3\x3\x2\x2\x2&\xC5\x3\x2\x2\x2(\xC7\x3"+
		"\x2\x2\x2*\xC9\x3\x2\x2\x2,\xCB\x3\x2\x2\x2.\xCF\x3\x2\x2\x2\x30\xD2\x3"+
		"\x2\x2\x2\x32\xD6\x3\x2\x2\x2\x34\xD8\x3\x2\x2\x2\x36\xDB\x3\x2\x2\x2"+
		"\x38\xDD\x3\x2\x2\x2:\xDF\x3\x2\x2\x2<\xE2\x3\x2\x2\x2>\xE5\x3\x2\x2\x2"+
		"@\xE7\x3\x2\x2\x2\x42\xE9\x3\x2\x2\x2\x44\xEB\x3\x2\x2\x2\x46\xEE\x3\x2"+
		"\x2\x2H\xF2\x3\x2\x2\x2J\xF4\x3\x2\x2\x2L\xFD\x3\x2\x2\x2N\x104\x3\x2"+
		"\x2\x2PQ\a\x42\x2\x2QR\a}\x2\x2RS\a,\x2\x2SW\x3\x2\x2\x2TV\n\x2\x2\x2"+
		"UT\x3\x2\x2\x2VY\x3\x2\x2\x2WU\x3\x2\x2\x2WX\x3\x2\x2\x2XZ\x3\x2\x2\x2"+
		"YW\x3\x2\x2\x2Z[\a,\x2\x2[\\\a\x7F\x2\x2\\\x5\x3\x2\x2\x2]^\a&\x2\x2^"+
		"_\a}\x2\x2_`\x3\x2\x2\x2`\x61\b\x3\x2\x2\x61\a\x3\x2\x2\x2\x62\x63\a\x42"+
		"\x2\x2\x63\x64\a}\x2\x2\x64\x65\x3\x2\x2\x2\x65\x66\b\x4\x2\x2\x66\t\x3"+
		"\x2\x2\x2gh\t\x3\x2\x2hl\n\x4\x2\x2ik\n\x3\x2\x2ji\x3\x2\x2\x2kn\x3\x2"+
		"\x2\x2lm\x3\x2\x2\x2lj\x3\x2\x2\x2mo\x3\x2\x2\x2nl\x3\x2\x2\x2o\x81\a"+
		"\x7F\x2\x2pq\t\x3\x2\x2qr\a}\x2\x2rv\a}\x2\x2su\n\x3\x2\x2ts\x3\x2\x2"+
		"\x2ux\x3\x2\x2\x2vw\x3\x2\x2\x2vt\x3\x2\x2\x2wy\x3\x2\x2\x2xv\x3\x2\x2"+
		"\x2y\x81\a\x7F\x2\x2z\x81\t\x3\x2\x2{}\n\x3\x2\x2|{\x3\x2\x2\x2}~\x3\x2"+
		"\x2\x2~|\x3\x2\x2\x2~\x7F\x3\x2\x2\x2\x7F\x81\x3\x2\x2\x2\x80g\x3\x2\x2"+
		"\x2\x80p\x3\x2\x2\x2\x80z\x3\x2\x2\x2\x80|\x3\x2\x2\x2\x81\v\x3\x2\x2"+
		"\x2\x82\x83\a\x7F\x2\x2\x83\x84\x3\x2\x2\x2\x84\x85\b\x6\x3\x2\x85\r\x3"+
		"\x2\x2\x2\x86\x87\t\x5\x2\x2\x87\x88\t\x6\x2\x2\x88\xF\x3\x2\x2\x2\x89"+
		"\x8B\x5\x12\t\x2\x8A\x8C\x5N\'\x2\x8B\x8A\x3\x2\x2\x2\x8C\x8D\x3\x2\x2"+
		"\x2\x8D\x8B\x3\x2\x2\x2\x8D\x8E\x3\x2\x2\x2\x8E\x8F\x3\x2\x2\x2\x8F\x90"+
		"\x5\xE\a\x2\x90\x11\x3\x2\x2\x2\x91\x92\t\a\x2\x2\x92\x93\t\b\x2\x2\x93"+
		"\x94\t\t\x2\x2\x94\x13\x3\x2\x2\x2\x95\x96\t\a\x2\x2\x96\x97\t\n\x2\x2"+
		"\x97\x98\t\v\x2\x2\x98\x99\t\a\x2\x2\x99\x15\x3\x2\x2\x2\x9A\x9C\x5\x14"+
		"\n\x2\x9B\x9D\x5N\'\x2\x9C\x9B\x3\x2\x2\x2\x9D\x9E\x3\x2\x2\x2\x9E\x9C"+
		"\x3\x2\x2\x2\x9E\x9F\x3\x2\x2\x2\x9F\xA0\x3\x2\x2\x2\xA0\xA1\x5\xE\a\x2"+
		"\xA1\x17\x3\x2\x2\x2\xA2\xA3\t\x6\x2\x2\xA3\xA4\t\f\x2\x2\xA4\xA5\t\r"+
		"\x2\x2\xA5\x19\x3\x2\x2\x2\xA6\xA7\t\x5\x2\x2\xA7\xA8\t\b\x2\x2\xA8\x1B"+
		"\x3\x2\x2\x2\xA9\xAB\x5\x12\t\x2\xAA\xAC\x5N\'\x2\xAB\xAA\x3\x2\x2\x2"+
		"\xAC\xAD\x3\x2\x2\x2\xAD\xAB\x3\x2\x2\x2\xAD\xAE\x3\x2\x2\x2\xAE\xAF\x3"+
		"\x2\x2\x2\xAF\xB0\x5\x18\f\x2\xB0\x1D\x3\x2\x2\x2\xB1\xB2\t\xE\x2\x2\xB2"+
		"\xB3\t\f\x2\x2\xB3\xB4\t\xF\x2\x2\xB4\xB5\t\xF\x2\x2\xB5\xB6\t\a\x2\x2"+
		"\xB6\xB7\t\b\x2\x2\xB7\xB8\t\x10\x2\x2\xB8\x1F\x3\x2\x2\x2\xB9\xBB\x5"+
		"\x12\t\x2\xBA\xBC\x5N\'\x2\xBB\xBA\x3\x2\x2\x2\xBC\xBD\x3\x2\x2\x2\xBD"+
		"\xBB\x3\x2\x2\x2\xBD\xBE\x3\x2\x2\x2\xBE\xBF\x3\x2\x2\x2\xBF\xC0\x5\x1E"+
		"\xF\x2\xC0!\x3\x2\x2\x2\xC1\xC2\a\x30\x2\x2\xC2#\x3\x2\x2\x2\xC3\xC4\a"+
		"~\x2\x2\xC4%\x3\x2\x2\x2\xC5\xC6\a.\x2\x2\xC6\'\x3\x2\x2\x2\xC7\xC8\a"+
		"*\x2\x2\xC8)\x3\x2\x2\x2\xC9\xCA\a+\x2\x2\xCA+\x3\x2\x2\x2\xCB\xCC\t\x11"+
		"\x2\x2\xCC\xCD\t\b\x2\x2\xCD\xCE\t\t\x2\x2\xCE-\x3\x2\x2\x2\xCF\xD0\t"+
		"\f\x2\x2\xD0\xD1\t\r\x2\x2\xD1/\x3\x2\x2\x2\xD2\xD3\t\b\x2\x2\xD3\xD4"+
		"\t\f\x2\x2\xD4\xD5\t\x10\x2\x2\xD5\x31\x3\x2\x2\x2\xD6\xD7\a?\x2\x2\xD7"+
		"\x33\x3\x2\x2\x2\xD8\xD9\a#\x2\x2\xD9\xDA\a?\x2\x2\xDA\x35\x3\x2\x2\x2"+
		"\xDB\xDC\a@\x2\x2\xDC\x37\x3\x2\x2\x2\xDD\xDE\a>\x2\x2\xDE\x39\x3\x2\x2"+
		"\x2\xDF\xE0\a@\x2\x2\xE0\xE1\a?\x2\x2\xE1;\x3\x2\x2\x2\xE2\xE3\a>\x2\x2"+
		"\xE3\xE4\a?\x2\x2\xE4=\x3\x2\x2\x2\xE5\xE6\a-\x2\x2\xE6?\x3\x2\x2\x2\xE7"+
		"\xE8\a/\x2\x2\xE8\x41\x3\x2\x2\x2\xE9\xEA\a,\x2\x2\xEA\x43\x3\x2\x2\x2"+
		"\xEB\xEC\a\x31\x2\x2\xEC\x45\x3\x2\x2\x2\xED\xEF\x5H$\x2\xEE\xED\x3\x2"+
		"\x2\x2\xEF\xF0\x3\x2\x2\x2\xF0\xEE\x3\x2\x2\x2\xF0\xF1\x3\x2\x2\x2\xF1"+
		"G\x3\x2\x2\x2\xF2\xF3\x4\x32;\x2\xF3I\x3\x2\x2\x2\xF4\xF8\a$\x2\x2\xF5"+
		"\xF7\n\x12\x2\x2\xF6\xF5\x3\x2\x2\x2\xF7\xFA\x3\x2\x2\x2\xF8\xF6\x3\x2"+
		"\x2\x2\xF8\xF9\x3\x2\x2\x2\xF9\xFB\x3\x2\x2\x2\xFA\xF8\x3\x2\x2\x2\xFB"+
		"\xFC\a$\x2\x2\xFCK\x3\x2\x2\x2\xFD\x101\t\x13\x2\x2\xFE\x100\t\x14\x2"+
		"\x2\xFF\xFE\x3\x2\x2\x2\x100\x103\x3\x2\x2\x2\x101\xFF\x3\x2\x2\x2\x101"+
		"\x102\x3\x2\x2\x2\x102M\x3\x2\x2\x2\x103\x101\x3\x2\x2\x2\x104\x105\t"+
		"\x15\x2\x2\x105\x106\x3\x2\x2\x2\x106\x107\b\'\x4\x2\x107O\x3\x2\x2\x2"+
		"\x10\x2\x3Wlv~\x80\x8D\x9E\xAD\xBD\xF0\xF8\x101\x5\a\x3\x2\x6\x2\x2\b"+
		"\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Quokka.Generated
