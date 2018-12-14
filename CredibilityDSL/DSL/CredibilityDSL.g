grammar CredibilityDSL;
options {
    output=AST;
    ASTLabelType=CommonTree; // type of $stat.tree ref etc...
    language=CSharp2;
}

start: 
	('Jesli'^ conditionalOrExpression 'to'!)? expression;

conditionalOrExpression:
    conditionalAndExpression ( '||'^ conditionalAndExpression )*;

conditionalAndExpression:
    equalityExpression ( '&&'^ equalityExpression )*;

equalityExpression:
    relationalExpression ( ('='^ | '!='^) relationalExpression )*;

relationalExpression:
    additiveExpression ( ('<='^ | '>='^ | '<'^ | '>'^) additiveExpression )*;

expression:
	('+'^ | '-'^| '*'^| '/'^) additiveExpression;

additiveExpression:
	(multiplicativeExpression) (('+'^|'-'^) multiplicativeExpression)*;
multiplicativeExpression:
	(term) (('*'^|'/'^|'%'^) term)*;

term: 
	MONEY | 
	ID |
	'('! additiveExpression ')'!;

CONDITION: 'Jesli';

ID: ('a'..'z'|'A'..'Z')('a'..'z'|'A'..'Z'|'0'..'9')* ;
MONEY : ('0' | '1'..'9' '0'..'9'*) |  ('0'..'9')+ '.' ('0'..'9')*;

PLUS: 		'+';
MINUS: 		'-';
MULTIPLY: 	'*';
DIVIDE:		'/';
MODULO	:	'%';
EQUALS	: 	'==';
NOTEQUALS: 	'!=';
OR	:	'||';
AND	:	'&&';
LESS	:	 '<';
LESSOREQUALS:	 '<=';
GREATER	:	 '>';
GREATEROREQUALS: '>=';

WS: (' '|'\t'|'\n'|'\r')+ {$channel=HIDDEN;};