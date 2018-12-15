lexer grammar Simple;
options {
  language=CSharp2;

}

// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\HelloWorld\Simple.g" 15
ID:   ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')*;// $ANTLR src "D:\Szkolenia\Artykuł ProgramistaMag - DSL\Code\DSLSamples\HelloWorld\Simple.g" 17
WS  :   (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};