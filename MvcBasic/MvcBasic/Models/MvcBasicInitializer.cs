using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcBasic.Models
{
    // public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    public class MvcBasicInitializer : CreateDatabaseIfNotExists<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member> {
                new Member {
                    Name = "山田リオ",
                    Email = "rio@wings.msn.to",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "ピアノが大好きです。"
                },
                new Member {
                    Name = "日尾直弘",
                    Email = "naohiro@wings.msn.to",
                    Birth = DateTime.Parse("1975-07-19"),
                    Married = false,
                    Memo = "子供にやさしいお医者さんです。"
                }
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}