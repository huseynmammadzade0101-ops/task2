using System.Text;


namespace C__ders2
{
    internal class task
    {
        static void Main(string[] args)
        {
            string text =(@"
azerbaijan (uk: /??z?rba??d???n, -?d??n/ (listen), us: /???z?rba??d???n, ??z-/;[9]
azerbaijani: az?rbaycan [??z??b?j?d??n]), officially the republic of azerbaijan,[b] is a
transcontinental country located at the boundary of eastern europe and western asia.[10] ?t
is a part of the south caucasus region, and is bounded by the caspian sea to the east, russia
(republic of dagestan) to the north, georgia to the northwest, armenia and turkey to the west,
and ?ran to the south. baku is the capital and largest city.
the azerbaijan democratic republic proclaimed its independence from the transcaucasian
democratic federative republic in 1918 and became the first secular democratic
muslim-majority state. ?n 1920, the country was incorporated into the soviet union as the
azerbaijan ssr.[11][12] the modern republic of azerbaijan proclaimed its independence on 30
august 1991,[13][14] shortly before the dissolution of the soviet union in the same year. ?n
september 1991, the ethnic armenian majority of the nagorno-karabakh region formed
breakaway republic of artsakh.[15] the region and seven surrounding districts are
internationally recognized as part of azerbaijan pending a solution to the status of the
nagorno-karabakh through negotiations facilitated by the osce, became de facto
independent with the end of the first nagorno-karabakh war in 1994.[16][17][18][19] following
the 2020 nagorno-karabakh war, the seven districts and parts of nagorno-karabakh were
returned to azerbaijani control.[20]
azerbaijan is a unitary semi-presidential republic.[4] ?t is one of six independent turkic states
and an active member of the organization of turkic states and the turksoy community.
azerbaijan has diplomatic relations with 182 countries and holds membership in 38
international organizations,[21] including the united nations, the council of europe, the
non-aligned movement, the osce, and the nato pfp program. ?t is one of the founding
members of guam, the c?s,[22] and the opcw. azerbaijan is also an observer state of the
wto.
the vast majority of the country's population (97%) is nominally[3] muslim,[23] but the
constitution does not declare an official religion and all major political forces in the country
are secularist. azerbaijan is a developing country and ranks 88th on the human development
?ndex. ?t has a high rate of economic development,[24] literacy,[25] and a low rate of
unemployment.[26] however, the ruling new azerbaijan party, in power since 1993, has been
accused of authoritarian leadership and the deterioration of the country's human rights
record, including increasing restrictions on civil liberties, particularly on press freedom and
political repression.[27]");

            StringBuilder sb = new StringBuilder();
            bool inside = false; 
            bool lastSpace = false;   
            bool newSentence = true; 
            int number = 1;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == '[') { 
                    inside = true; continue;
                 }
                if (symbol == ']') { 
                    inside = false; continue;
                    
                     }
                if (inside) continue;

                if (symbol == '.')
                {
                    if (sb.Length > 0)
                    {
                        Console.WriteLine(number + ". " + sb.ToString() + ".");
                        number++;
                        sb.Clear();
                    }
                    newSentence = true;
                    lastSpace = false;
                    continue;
                }

                if (symbol == ' ' || symbol == '\n'  || symbol == '\t')
                {
                    if (sb.Length > 0 && !lastSpace)
                    {
                        sb.Append(' ');
                        lastSpace = true;
                    }
                    continue;
                }

                if (char.IsLetterOrDigit(symbol) || symbol == ',' || symbol == '(' || symbol == ')' || symbol == ':' || symbol == ';' ||
                    symbol == '-' || symbol == '%' || symbol == '\'')
                {
             
                    if (newSentence)
                    {
                        symbol= char.ToUpper(symbol);
                        newSentence = false;
                    }
                    sb.Append(symbol);
                    lastSpace = false;
                }
            }

            if (sb.Length > 0)
            {
                Console.WriteLine(number + ". " + sb.ToString().Trim() + ".");
            }

            Console.WriteLine(sb);
        }
    }
}