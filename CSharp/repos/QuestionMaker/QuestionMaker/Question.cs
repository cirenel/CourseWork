using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionMaker
{
    public enum qType
        {
            MC,
            TF,
            MATCHING,
            CAT,
            CLICKDRAG
        }
    public class Question
    {
        protected string title, question, instructions;
        protected qType type;
        protected List<string> tags; 

        public override string ToString()
        {
            return "::" + title + ":: " + question; 
        }

        public void MakeTags(string s)
        {
            string[] tagStr = s.Split(',');
            tags = new List<string>();
            tags.AddRange(tagStr);
        }

        public virtual string MakeGIFT()
        {
            if (tags == null) return "\n"; 
            string ret = "\n";
            if (tags.Count > 0)
            {
                ret += "//";
                foreach (string tag in tags)
                {
                    if (tag != "" && tag != " ")
                    {
                        ret += "[tag:" + tag + "] ";
                    }
                }
                ret += "\n";
            }
            return ret;
        }
    }

    public class DragQuestion : Question
    {
        protected  Dictionary<string, string> QandA;
        protected string htmlOut;
        public DragQuestion(string t, string q, Dictionary<string, string> qa, int border, int padding, int numCol, int numRow)
        {
            title = t;
            question = q;
            QandA = qa;

            string cellStyle = "style=\"border: black solid " + border + "px; padding:" + padding + "px;\"";

            htmlOut += "<tr><td colSpan=" + numCol + " " + cellStyle + ">" + question + "</td></tr>";
            Random rand = new Random();
            int questNum = 0;
            List<string> keys = new List<string>(QandA.Keys);
            int chosenIndex = rand.Next(0, keys.Count);
            string answerStr = "";
            for (int r = 1; r <= numRow; r++)
            {
                htmlOut += "<tr>";
                for (int c = 1; c <= numCol; c++)
                {
                    questNum++;
                    htmlOut += "<td " + cellStyle + ">";
                    // Console.WriteLine(">>>>>> " + chosenIndex);
                    string val = QandA[keys[chosenIndex]];

                    htmlOut += "[[" + questNum + "]] : " + val;
                    answerStr += questNum + ": " + keys[chosenIndex] + "  \n";

                    keys.Remove(keys[chosenIndex]);
                    chosenIndex = rand.Next(0, keys.Count);

                    htmlOut += "</td>";
                }

                htmlOut += "</tr>";
            }
            htmlOut += "</table> \n\n" + answerStr + "\n";

        }

        public override string ToString()
        {
            return "Click and Drag: "+title + " : " + instructions;
        }

        public override string MakeGIFT()
        {
            return htmlOut;
        }
    }

    public class CatQuestion : Question
    {
        public CatQuestion(string cat)
        {
            title = cat; 
        }

        public override string MakeGIFT()
        {
            string ret = "\n$CATEGORY:";

            ret += title+"\n\n"; 

            return ret; 
        }

        public override string ToString()
        {
            return "Cat change : "+ title;
        }

    }

    public class MCQuestion : Question
    {
        protected List<string> options;
        protected List<string> answers; 

        public MCQuestion(string t, string q)
        {
            type = qType.MC;
            title = t;
            question = q;

            options = new List<string>();
            answers = new List<string>();
        }

        public void AddOption(string s, bool ans=false)
        {
            if (ans)
            {
                answers.Add(s);
            } else
            {
                options.Add(s);
            }
        }

        public override string MakeGIFT()
        {
            string ret = base.MakeGIFT()+base.ToString();

            ret += "\n { \n";

            
            if (answers.Count > 1)
            {
                foreach (string s in options)
                {
                    ret += "\t~%-100%" + s + "\n";
                }
                double per = 100 / answers.Count;
                foreach (string s in answers)
                {
                    ret += "\t=%" + per + "%" + s + "\n";
                }
            }
            else
            {
                foreach (string s in options)
                {
                    ret += "\t~" + s + "\n";
                }
                ret += "\t=" + answers[0] + "\n";
            }

            ret += " } \n";
            return ret; 
        }

        public override string ToString()
        {
            string ret = "MC : "+base.ToString();

            return ret;
        }

    }

    public class TFQuestion : Question
    {
        bool answer; 
        public TFQuestion(string t, string q)
        {
            type = qType.TF;
            title = t;
            question = q;

        }

        public void SetAnswer(bool b)
        {
            answer = b; 
        }

        public override string MakeGIFT()
        {
            string ret = base.MakeGIFT() + base.ToString();

            ret += "\n { \n\t" + answer.ToString()[0] + " } \n";

            return ret;
        }

        public override string ToString()
        {
            string ret = "TF: "+base.ToString();

            ret += " : "+ answer.ToString();

            return ret;
        }

    }

    public class MatchQuestion : Question
    {
        List<(string, string)> pairs; 
        public MatchQuestion(string t, string q)
        {
            type = qType.MATCHING;
            title = t;
            question = q;
            pairs = new List<(string, string)>();
        }

        public void AddPair(string word, string ans)
        {
            pairs.Add((word, ans));
        }
               
        public string[] getQuestionRep()
        {
            (string, string)[] str = pairs.ToArray();
            string[] ret = new string[str.Length];
            for(int i = 0; i < ret.Length; i++)
            {
                ret[i] = str[i].Item1 + " : " + str[i].Item2;
            }
            return ret;
        }

        public override string MakeGIFT()
        {
            string ret = base.MakeGIFT() + base.ToString();

            ret += "\n {\n";

            (string, string)[] str = pairs.ToArray();
            foreach ((string, string) s in str)
            {
                ret += "\t=<hr>" + s.Item1 + "<hr> -> " + s.Item2 + "\n";
            }

            ret += " }\n";

            return ret;
        }

        public override string ToString()
        {
            return "MATCH: " + base.ToString() ;
        }


    }

}
