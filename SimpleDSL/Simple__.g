lexer grammar Simple;
options {
  language=CSharp2;

}

T__7 : '-' ;
T__8 : '%' ;
T__9 : '(' ;
T__10 : ')' ;
T__11 : '*' ;
T__12 : '/' ;
T__13 : '+' ;

// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\SimpleDSL\Simple.g" 19
ID: ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')* ;// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\SimpleDSL\Simple.g" 20
IntegerLiteral : ('0' | '1'..'9' '0'..'9'*);// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\SimpleDSL\Simple.g" 22
WS: (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};