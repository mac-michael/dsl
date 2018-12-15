lexer grammar CredibilityDSL;
options {
  language=CSharp2;

}

T__21 : '(' ;
T__22 : ')' ;
T__23 : '=' ;
T__24 : 'to' ;

// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 36
CONDITION: 'Jesli';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 38
ID: ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')* ;// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 39
MONEY : ('0' | '1'..'9' '0'..'9'*) |  ('0'..'9')+ '.' ('0'..'9')*;// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 41
PLUS: 		'+';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 42
MINUS: 		'-';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 43
MULTIPLY: 	'*';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 44
DIVIDE:		'/';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 45
MODULO	:	'%';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 46
EQUALS	: 	'==';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 47
NOTEQUALS: 	'!=';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 48
OR	:	'||';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 49
AND	:	'&&';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 50
LESS	:	 '<';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 51
LESSOREQUALS:	 '<=';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 52
GREATER	:	 '>';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 53
GREATEROREQUALS: '>=';// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\CredibilityDSL\DSL\CredibilityDSL.g" 55
WS: (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};