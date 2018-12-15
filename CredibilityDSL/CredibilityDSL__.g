lexer grammar CredibilityDSL;
options {
  language=CSharp2;

}

T__7 : '-' ;
T__8 : '!=' ;
T__9 : '%' ;
T__10 : '&&' ;
T__11 : '*' ;
T__12 : '/' ;
T__13 : '||' ;
T__14 : '+' ;
T__15 : '<' ;
T__16 : '<=' ;
T__17 : '=' ;
T__18 : '>' ;
T__19 : '>=' ;
T__20 : 'Jesli' ;
T__21 : 'to' ;

// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag\Code\DSLSamples\CredibilityDSL\CredibilityDSL.g" 29
ID: ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')* ;// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag\Code\DSLSamples\CredibilityDSL\CredibilityDSL.g" 30
IntegerLiteral : ('0' | '1'..'9' '0'..'9'*);// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag\Code\DSLSamples\CredibilityDSL\CredibilityDSL.g" 32
WS: (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};