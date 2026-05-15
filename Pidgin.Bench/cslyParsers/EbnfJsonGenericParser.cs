using System.Collections.Generic;
using sly.lexer;
using sly.parser.generator;

namespace cslyparser
{
    #pragma warning disable CA1002
    // [BroadenTokenWindow]
    [ParserRoot("root")]
    // [FirstDerivation]
    public class EbnfJsonGenericParser
    {

        object val = null;

        [Production("root : value")]
        public object Root(object value)
        {
            return val;
        }



        [Production("value : STRING")]
        public object StringValue(Token<JsonTokenGeneric> stringToken)
        {
            return val;
        }

        [Production("value : INT")]
        public object IntValue(Token<JsonTokenGeneric> intToken)
        {
            return val;
        }
        [Production("value : DOUBLE")]
        public object DoubleValue(Token<JsonTokenGeneric> doubleToken)
        {
            return val;
        }

        [Production("value : BOOLEAN")]
        public object BooleanValue(Token<JsonTokenGeneric> boolToken)
        {
            return val;
        }
        [Production("value : NULL[d]")]
        public object NullValue()
        {
            return val;
        }


        [Production("value : object")]
        public object ObjectValue(object value)
        {
            return val;
        }

        [Production("value: list")]
        public object ListValue(object list)
        {
            return val;
        }



        [Production("object: ACCG[d] ACCD[d]")]
        public object EmptyObjectValue()
        {
            return val;
        }

        [Production("object: ACCG[d] members ACCD[d]")]
        public object AttributesObjectValue(object members)
        {
            return val;
        }



        [Production("list: CROG[d] CROD[d]")]
        public object EmptyList()
        {
            return val;
        }

        [Production("list: CROG[d] listElements CROD[d]")]
        public object List(object elements)
        {
            return val;
        }


        [Production("listElements: value additionalValue*")]
        
        public object ListElements(object head,  List<object> tail)
        {
            return val;
        }
        [Production("additionalValue: COMMA value")]
        public object ListElementsOne(Token<JsonTokenGeneric> discardedComma, object value)
        {
            return val;
        }



        [Production("members: property additionalProperty*")]
        public object Members(object head, List<object> tail)
        {
            return val;
        }

        [Production("additionalProperty : COMMA[d] property")]
        public object Property(object property)
        {
            return val;
        }

        [Production("property: STRING COLON[d] value")]
        public object Property(Token<JsonTokenGeneric> key, object value)
        {
            return val;
        }

    }


}