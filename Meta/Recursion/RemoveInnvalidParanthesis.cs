using System;

namespace Meta.Recursion;

public class RemoveInnvalidParanthesis
{
    public int min = int.MaxValue;
    public HashSet<string> set = new HashSet<string>();
    public List<string> solve(string s)
    {
        if(s==null || s.Length==0)
        {
            set.ToList();
        }

         search(s, 0, 0, 0, 0,"");

         return set.ToList();
    }

    private void search(string s, int i, int lc, int rc, int remc,string val)
    {
        if(rc>lc)
        {
            return;
        }

        if(i>=s.Length)
        {
            if(lc==rc)//valid
            {
                if (remc < min)
                {
                    set = new HashSet<string>();
                    set.Add(val);
                    min = remc;
                }
                if(remc==min)
                {
                    set.Add(val);
                }

            }
            return;
        }

        while(i<s.Length && (s[i]!='(' && s[i]!=')'))
        {
            val+=s[i];
            i++;
        }

        //don't take
        search(s,i+1,lc,rc,remc+1,val);

        if(i<s.Length && s[i]==')')
        {
            rc++;
            val+=s[i];
        }
        
        if(i<s.Length && s[i]=='(')
        {
            lc++;
            val+=s[i];

        }

        //take
        search(s,i+1,lc,rc,remc,val);

    }
}
