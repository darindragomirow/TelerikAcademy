function solve(args)
{
             readText = args[0];
            var text;
            var url;
            let startIndex=0;
            let endIndex=0;
            var line='';
            let firstQuoteIndex;
            let secondQuoteIndex;
            let textStartIndex;
            let textEndIndex;

            while (startIndex != -1 && endIndex != -1)
            {
                startIndex = readText.indexOf("<a");
                endIndex = readText.indexOf("a>") + 1;
                if (startIndex < 0 || endIndex < 0) break;
                line = readText.substring(startIndex, endIndex - startIndex + 1);

              //  Console.WriteLine(line);

                firstQuoteIndex = line.indexOf('"');
                secondQuoteIndex = line.indexOf('"' + ">");
                url = line.substring(firstQuoteIndex + 1, secondQuoteIndex - firstQuoteIndex - 1);
               // Console.WriteLine(url);

                textStartIndex = line.indexOf('>');
                textEndIndex = line.indexOf("</");
                text = line.substring(textStartIndex + 1, textEndIndex - textStartIndex - 1);
               // Console.WriteLine(text);

                var replaced = "[" + text + "]" + "(" + url + ")";w
                readText = readText.replace(line, replaced);
            }
            console.log(readText);

}
