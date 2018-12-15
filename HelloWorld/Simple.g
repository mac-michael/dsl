grammar Simple;
options {
    output=AST;
    ASTLabelType=CommonTree; // type of $stat.tree ref etc...
    language=CSharp2;
}

tokens
{
	START;
}

start: ID EOF -> ^(START ID);

ID:   ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')*;

WS  :   (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};






/*grammar Simple;
options {
    output=AST;
    ASTLabelType=CommonTree; // type of $stat.tree ref etc...
    language=CSharp2;
}

start	:	multi ('+'^ multi)*;
multi	:	ID ('*'^ ID)*;

ID  :   ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')*;

WS  :   (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};*/