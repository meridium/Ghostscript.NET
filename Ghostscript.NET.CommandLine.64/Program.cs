using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ghostscript.NET.Processor;

namespace Ghostscript.NET.CommandLine._64 {
    class Program {
        static void Main(string[] args) {
            try {
                var switches = new List<string>();
                switches.Add("programName");
                switches.AddRange(args);
                Console.WriteLine(switches.Aggregate((a,b)=>a+" "+b));
                var file = new FileInfo(Assembly.GetEntryAssembly().Location);
                var dll = new FileInfo(Path.Combine(file.DirectoryName, "gsdll64.dll"));
                if (!dll.Exists) {
                    throw new FileNotFoundException("Missing Ghostscript 64 bit dll.", dll.FullName);
                }
                var gvi = new GhostscriptVersionInfo(dll.FullName);
                using (var processor = new GhostscriptProcessor(gvi, false)) {
                    processor.DisableOutputParsing = true;
                    processor.Process(switches.ToArray(),new StandardIO());
                }
            } catch (Exception e) {
                Console.Error.WriteLine("Exception: "+e.Message);
            }
        }
    }

    internal class StandardIO : GhostscriptStdIO {
        public StandardIO() : base(true, true, true) { }
        public override void StdIn(out string input, int count) {
            if (count == 0) {
                input = "";
                return;
            }
            var buffer = new char[count];
            Console.In.Read(buffer, 0, count);
            input = buffer.ToString();
        }

        public override void StdOut(string output) {
            Console.Write(output);
        }

        public override void StdError(string error) {
            Console.Error.Write(error);
        }
    }
}
