grammar Simple;
options {
    output=AST;
    ASTLabelType=CommonTree; // type of $stat.tree ref etc...
    language=CSharp2;
}

start: 
	additiveExpression;
additiveExpression: 
	(multiplicativeExpression) (('+'^|'-'^) multiplicativeExpression)*;
multiplicativeExpression:  
	(term) (('*'^|'/'^|'%'^) term)*;
term: 
	IntegerLiteral  |
	ID | 
	'('! additiveExpression ')'!;

ID: ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')* ;
IntegerLiteral : ('0' | '1'..'9' '0'..'9'*);

WS: (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};