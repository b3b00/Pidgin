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
else {
foreach(var e in b.Errors) {
System.IO.File.AppendAllText("./build.txt",e+"\n");
}
}
            }
            return _parser;
        }

        public static void Parse(string source)
        {
            var p = GetParser();
            var r=p.Parse(source);
            if(r.IsError) {
               foreach(var e in r.Errors) {
               System.IO.File.AppendAllText("./build.txt",e.ErrorMessage+"\n");
               }
            } }
    }
}