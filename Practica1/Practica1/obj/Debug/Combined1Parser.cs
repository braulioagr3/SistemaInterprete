﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Braulio García R\Documents\GitHub\SistemaInterprete\Practica1\Practica1\Combined1.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Practica1 {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class Combined1Parser : Parser {
	public const int
		PARENI=1, PAREND=2, MAS=3, MENOS=4, POR=5, INT=6, ENTRE=7, NEWLINE=8, 
		WS=9;
	public const int
		RULE_programa = 0, RULE_stat = 1, RULE_expresion = 2, RULE_multiplicacion = 3, 
		RULE_numero = 4;
	public static readonly string[] ruleNames = {
		"programa", "stat", "expresion", "multiplicacion", "numero"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'+'", "'-'", "'*'", null, "'/'", "'\n'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "PARENI", "PAREND", "MAS", "MENOS", "POR", "INT", "ENTRE", "NEWLINE", 
		"WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Combined1.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public Combined1Parser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramaContext : ParserRuleContext {
		public float value;
		public StatContext _stat;
		public StatContext stat() {
			return GetRuleContext<StatContext>(0);
		}
		public ProgramaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_programa; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterPrograma(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitPrograma(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPrograma(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramaContext programa() {
		ProgramaContext _localctx = new ProgramaContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_programa);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 10; _localctx._stat = stat();
			System.Console.WriteLine(_localctx._stat.value);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatContext : ParserRuleContext {
		public float value;
		public ExpresionContext c;
		public ITerminalNode NEWLINE() { return GetToken(Combined1Parser.NEWLINE, 0); }
		public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		public StatContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stat; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterStat(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitStat(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStat(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatContext stat() {
		StatContext _localctx = new StatContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_stat);
		try {
			State = 18;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case PARENI:
			case INT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 13; _localctx.c = expresion();
				State = 14; Match(NEWLINE);
				System.Console.WriteLine(_localctx.c.value);
				}
				break;
			case NEWLINE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 17; Match(NEWLINE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpresionContext : ParserRuleContext {
		public float value;
		public MultiplicacionContext a;
		public MultiplicacionContext b;
		public MultiplicacionContext[] multiplicacion() {
			return GetRuleContexts<MultiplicacionContext>();
		}
		public MultiplicacionContext multiplicacion(int i) {
			return GetRuleContext<MultiplicacionContext>(i);
		}
		public ITerminalNode[] MAS() { return GetTokens(Combined1Parser.MAS); }
		public ITerminalNode MAS(int i) {
			return GetToken(Combined1Parser.MAS, i);
		}
		public ITerminalNode[] MENOS() { return GetTokens(Combined1Parser.MENOS); }
		public ITerminalNode MENOS(int i) {
			return GetToken(Combined1Parser.MENOS, i);
		}
		public ExpresionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expresion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterExpresion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitExpresion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpresion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpresionContext expresion() {
		ExpresionContext _localctx = new ExpresionContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_expresion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 20; _localctx.a = multiplicacion();
			_localctx.value =  _localctx.a.value;
			State = 32;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==MAS || _la==MENOS) {
				{
				State = 30;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case MAS:
					{
					State = 22; Match(MAS);
					State = 23; _localctx.b = multiplicacion();
					_localctx.value = _localctx.value + _localctx.b.value;
					}
					break;
				case MENOS:
					{
					State = 26; Match(MENOS);
					State = 27; _localctx.b = multiplicacion();
					_localctx.value = _localctx.value- _localctx.b.value;
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 34;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			System.Console.WriteLine(_localctx.value);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MultiplicacionContext : ParserRuleContext {
		public float value;
		public NumeroContext a;
		public NumeroContext b;
		public NumeroContext[] numero() {
			return GetRuleContexts<NumeroContext>();
		}
		public NumeroContext numero(int i) {
			return GetRuleContext<NumeroContext>(i);
		}
		public ITerminalNode[] POR() { return GetTokens(Combined1Parser.POR); }
		public ITerminalNode POR(int i) {
			return GetToken(Combined1Parser.POR, i);
		}
		public ITerminalNode[] ENTRE() { return GetTokens(Combined1Parser.ENTRE); }
		public ITerminalNode ENTRE(int i) {
			return GetToken(Combined1Parser.ENTRE, i);
		}
		public MultiplicacionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_multiplicacion; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterMultiplicacion(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitMultiplicacion(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicacion(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MultiplicacionContext multiplicacion() {
		MultiplicacionContext _localctx = new MultiplicacionContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_multiplicacion);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37; _localctx.a = numero();
			_localctx.value =  _localctx.a.value;
			State = 49;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while (_la==POR || _la==ENTRE) {
				{
				State = 47;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case POR:
					{
					State = 39; Match(POR);
					State = 40; _localctx.b = numero();
					_localctx.value = _localctx.value* _localctx.b.value;
					}
					break;
				case ENTRE:
					{
					State = 43; Match(ENTRE);
					State = 44; _localctx.b = numero();
                        if (_localctx.b.value != 0)
                        {
                            _localctx.value = _localctx.value / _localctx.b.value;
                        }
                        else
                        {
                            throw new System.DivideByZeroException();
                        }
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 51;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumeroContext : ParserRuleContext {
		public float value;
		public IToken _INT;
		public ExpresionContext _expresion;
		public ITerminalNode INT() { return GetToken(Combined1Parser.INT, 0); }
		public ITerminalNode PARENI() { return GetToken(Combined1Parser.PARENI, 0); }
		public ExpresionContext expresion() {
			return GetRuleContext<ExpresionContext>(0);
		}
		public ITerminalNode PAREND() { return GetToken(Combined1Parser.PAREND, 0); }
		public NumeroContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_numero; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.EnterNumero(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICombined1Listener typedListener = listener as ICombined1Listener;
			if (typedListener != null) typedListener.ExitNumero(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICombined1Visitor<TResult> typedVisitor = visitor as ICombined1Visitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumero(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumeroContext numero() {
		NumeroContext _localctx = new NumeroContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_numero);
		try {
			State = 59;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case INT:
				EnterOuterAlt(_localctx, 1);
				{
				State = 52; _localctx._INT = Match(INT);
				_localctx.value =  float.Parse((_localctx._INT!=null?_localctx._INT.Text:null));
				}
				break;
			case PARENI:
				EnterOuterAlt(_localctx, 2);
				{
				State = 54; Match(PARENI);
				State = 55; _localctx._expresion = expresion();
				State = 56; Match(PAREND);
				_localctx.value =  _localctx._expresion.value;
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\v@\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x5\x3\x15\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\a\x4!\n\x4\f\x4\xE\x4$\v\x4\x3\x4\x3\x4\x3\x5"+
		"\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\a\x5\x32\n\x5\f"+
		"\x5\xE\x5\x35\v\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x5\x6>\n"+
		"\x6\x3\x6\x2\x2\x2\a\x2\x2\x4\x2\x6\x2\b\x2\n\x2\x2\x2@\x2\f\x3\x2\x2"+
		"\x2\x4\x14\x3\x2\x2\x2\x6\x16\x3\x2\x2\x2\b\'\x3\x2\x2\x2\n=\x3\x2\x2"+
		"\x2\f\r\x5\x4\x3\x2\r\xE\b\x2\x1\x2\xE\x3\x3\x2\x2\x2\xF\x10\x5\x6\x4"+
		"\x2\x10\x11\a\n\x2\x2\x11\x12\b\x3\x1\x2\x12\x15\x3\x2\x2\x2\x13\x15\a"+
		"\n\x2\x2\x14\xF\x3\x2\x2\x2\x14\x13\x3\x2\x2\x2\x15\x5\x3\x2\x2\x2\x16"+
		"\x17\x5\b\x5\x2\x17\"\b\x4\x1\x2\x18\x19\a\x5\x2\x2\x19\x1A\x5\b\x5\x2"+
		"\x1A\x1B\b\x4\x1\x2\x1B!\x3\x2\x2\x2\x1C\x1D\a\x6\x2\x2\x1D\x1E\x5\b\x5"+
		"\x2\x1E\x1F\b\x4\x1\x2\x1F!\x3\x2\x2\x2 \x18\x3\x2\x2\x2 \x1C\x3\x2\x2"+
		"\x2!$\x3\x2\x2\x2\" \x3\x2\x2\x2\"#\x3\x2\x2\x2#%\x3\x2\x2\x2$\"\x3\x2"+
		"\x2\x2%&\b\x4\x1\x2&\a\x3\x2\x2\x2\'(\x5\n\x6\x2(\x33\b\x5\x1\x2)*\a\a"+
		"\x2\x2*+\x5\n\x6\x2+,\b\x5\x1\x2,\x32\x3\x2\x2\x2-.\a\t\x2\x2./\x5\n\x6"+
		"\x2/\x30\b\x5\x1\x2\x30\x32\x3\x2\x2\x2\x31)\x3\x2\x2\x2\x31-\x3\x2\x2"+
		"\x2\x32\x35\x3\x2\x2\x2\x33\x31\x3\x2\x2\x2\x33\x34\x3\x2\x2\x2\x34\t"+
		"\x3\x2\x2\x2\x35\x33\x3\x2\x2\x2\x36\x37\a\b\x2\x2\x37>\b\x6\x1\x2\x38"+
		"\x39\a\x3\x2\x2\x39:\x5\x6\x4\x2:;\a\x4\x2\x2;<\b\x6\x1\x2<>\x3\x2\x2"+
		"\x2=\x36\x3\x2\x2\x2=\x38\x3\x2\x2\x2>\v\x3\x2\x2\x2\b\x14 \"\x31\x33"+
		"=";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Practica1