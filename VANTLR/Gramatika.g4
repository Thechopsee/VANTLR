
grammar Gramatika;

program   :   command+                                ;

command   :   '{' command+ '}'                              # Code_block 
          |   DATA_TYPE IDENTIFIER (',' IDENTIFIER)* ';'   # Declaration
          |   IF '(' expr ')' command (ELSE command)?      # If
          |   WHILE '(' expr ')' command                   # While
          |   expr ';'                                     # Expression
          |   READ IDENTIFIER (',' IDENTIFIER)* ';'        # Read
          |   WRITE expr (',' expr)* ';'                   # Write
          |   ';'                                          # Empty;


expr      :  '(' expr ')'                                 # Parenthesis
          |   INTEGER                                      # Integer
          |   FLOAT                                        # Float
          |   BOOLEAN                                      # Boolean
          |   STRING                                       # String
          |   IDENTIFIER                                   # Identifier
          |   '-' expr                                     # Minus
          |   NOT expr                                     # Negation
          |   expr op=(MUL | DIV | MOD) expr               # Multiplication
          |   expr op=(ADD | SUB | CCT) expr               # Addition
          |   expr op=(LTN | MTN) expr                     # Relation
          |   expr op=(EQL | NEQ) expr                     # Equality
          |   expr AND expr                                # And
          |   expr OR expr                                 # Or
          |   <assoc = right> IDENTIFIER '=' expr          # Assignment;


// LITERALS
// DATA TYPES KEYWORDS
DATA_TYPE: INT_KEY | FLT_KEY | BLN_KEY | STR_KEY      ;

INT_KEY     :   'int'        ;
FLT_KEY     :   'float'      ;
BLN_KEY     :   'bool'       ;
STR_KEY     :   'string'     ;

// OPERATIONS
ADD         :   '+'          ;
SUB         :   '-'          ;
MUL         :   '*'          ;
DIV         :   '/'          ;
NOT         :   '!' | 'not'  ;
MOD         :   '%'          ;
CCT         :   '.'          ;
LTN         :   '<'          ;
MTN         :   '>'          ;
EQL         :   '=='         ;
NEQ         :   '!='         ;
AND         :   '&&' | 'and' ;
OR          :   '||' | 'or'  ;


// OTHER KEY WORDS
IF          :   'if'         ;
ELSE        :   'else'       ;
WHILE       :   'while'      ;
WRITE       :   'write'      ;
READ        :   'read'       ;


// VARIABLES
BOOLEAN     :   'true'
            |   'false'                               ;
IDENTIFIER  :   LETTER (LETTER | DIGIT)*              ;
fragment LETTER: [a-z] | [A-Z];


// DATA TYPES VALUES
INTEGER     :   DIGIT+                                ;
FLOAT       :   DIGIT+ '.' DIGIT*
            |          '.' DIGIT+                     ;
fragment DIGIT: [0-9];



STRING      :   '"' (ESCAPE_CHARACTER|.)*? '"'        ;
fragment ESCAPE_CHARACTER: '\\"' | '\\\\';


// COMMENT
LINE_COMMENT: '//' ~[\n\r]*  -> skip                  ;
// IGNORE WHITE SPACES
WHITE_SPACES: [ \t\r\n]+ -> skip                      ;
