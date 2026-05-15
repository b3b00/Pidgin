using sly.parser;
using sly.parser.generator;

namespace cslyparser
{
    
    public class Csly
    {
        private static Parser<JsonTokenGeneric, object> _parser ;

        private static Parser<JsonTokenGeneric, object> GetParser()
        {
            if (_parser == null)
            {
                ParserBuilder<JsonTokenGeneric, object> builder = new ParserBuilder<JsonTokenGeneric, object>();
                var instance = new EbnfJsonGenericParser();
                var b = builder.BuildParser(instance, ParserType.EBNF_LL_RECURSIVE_DESCENT, "root");
                if (b.IsOk)
                {
                    _parser = b.Result;
                }
            }
            return _parser;
        }

        public static void Parse(string source)
        {
            var p = GetParser();
            p.Parse(source);
        }
    }
}