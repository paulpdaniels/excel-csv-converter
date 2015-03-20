using LinqToExcel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unicode_csv_converter
{
    public class ExcelConverter
    {

        public async Task Convert(IEnumerable<string> inputFiles, IEnumerable<string> outputFiles, string delimiter, Encoding outputEncoding)
        {

            var x = from file in inputFiles
                    let rows = ConvertExcel(file, delimiter)
                    select rows;

            var tasks = x.Zip(outputFiles, async (rows, output) =>
            {
                using (var writer = new StreamWriter(File.Create(output), outputEncoding))
                {
                    await writer.WriteAsync(rows);
                }
            });

            await Task.WhenAll(tasks.ToList());

        }

        public string ConvertExcel(string input, string delimiter)
        {
            var excel = new ExcelQueryFactory(input);

            var rows = from row in excel.WorksheetNoHeader().AsEnumerable()
                       let str = String.Join(delimiter, row.Select(cell => cell.Value.ToString()))
                       select str;


            return String.Join(Environment.NewLine, rows);
        }

    }
}
