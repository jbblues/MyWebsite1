using System.Collections.Generic;

namespace Drug.Models
{
    public class Ogun
    {
        public string Header { get; set; }
        public string ID { get; set; }
        public List<Row> Rows { get; set; }
        public List<string> CombinationList { get; set; }
        public string HtmlDescription { get; set; }
        public string Usage { get; set; }
        public List<string> Images { get; set; }
        public string Price { get; set; }
        public List<string> Cautions { get; set; }
        public List<Combination> Combinations { get; set; }
    }
   
    public class Combination
    {
        public string HtmlDescription { get; set; }
        public string Image { get; set; }
    }
    public class Row
    {
        public List<string> Body { get; set; }
    }
    public class DrugGroup
    {
        public string Name { get; set; }
        public string Photo { get; set; }
        public List<Ogun> AwonOgun { get; set; }
    }
    public class GroupList
    {
        public List<DrugGroup> DrugGroups { get; set; }
        public GroupList()
        {
            this.DrugGroups = new List<DrugGroup>() {
               new DrugGroup(){
                   Name = "Sexual (Male 👨)",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559033233/jd_t3uqrf.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Erectile Dysfunctions",
                               ID ="f139b055-776e-4ca5-a112-62725dbafaf0".Replace("-",""),
                                HtmlDescription = @"<div style=""font-family: Verdana; font-size: 15px; line-height: 30px; text-align: center;"">
<big style=""color: #cc0000;""><big><big><span style=""color: black;""><span style=""font-style: italic; font-weight: bold;"">The&nbsp;</span><span style=""color: #cc0000; font-style: italic; font-weight: bold;"">Natural Remedy</span><span style=""font-style: italic; font-weight: bold;"">&nbsp;You Really Need To Keep Fit For&nbsp;<span style=""color: #cc0000;"">Peak Sexual Performance&nbsp;</span>With Your Woman Is Here!</span></span></big></big></big><br />
<br />
<big style=""font-weight: bold;""><big><big><span style=""text-decoration-line: underline;"">This is so Effective</span>&nbsp;<span style=""color: #3333ff;"">That 100% Of Nigerians Men That Used It&nbsp;</span>All Said ""Thank You"".</big></big></big><br />
<big style=""color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;;""><big><big><span style=""color: black;""></span></big></big></big></div>
<big style=""color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;; text-align: justify;""><big><big><span style=""color: black;""></span></big></big></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify;""></big><big style=""color: #333399; font-family: &quot;Arial Rounded MT Bold&quot;; text-align: justify;""><big><strong><span class=""auto-style76""></span></strong></big></big><big style=""color: #cc0000; font-family: &quot;Courier New&quot;, Courier, monospace; text-align: justify;""><big><strong></strong></big></big><big style=""font-family: &quot;Arial Rounded MT Bold&quot;; text-align: justify;""><big><big><strong><span style=""color: #cc0000; font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></strong></big></big></big><big style=""font-family: Verdana; text-align: justify;""><strong style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""color: red;""></span><span style=""background-color: #33cc00;""><br /></span></strong></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span>
<br />
<div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<big><big><big><span style=""text-decoration-line: underline;""></span></big></big></big><big><big><big><span style=""color: #cc0000;""></span></big></big></big><big><big><big><span style=""color: #cc0000;""></span></big></big></big>&nbsp;&nbsp;<span style=""color: navy; font-family: &quot;arial rounded mt bold&quot;;""><span class=""auto-style22""><strong><span class=""style79"" style=""color: #221799; font-size: 26pt; line-height: 39.8667px;"" xml:lang=""EN-GB""><span style=""color: black;""></span></span></strong></span></span><big style=""font-weight: bold;""><big><big><span style=""background-color: #33cc00;"">It's NAFDAC Certified - No Side Effects&nbsp;</span></big></big></big></div>
<big style=""font-family: Verdana; text-align: justify;""><strong style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""background-color: #33cc00;""><br /></span></strong></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span>
<br />
<div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<big style=""font-style: italic;""><strong>a</strong></big></div>
<br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559138720/unhockbra_g1fnun.jpg"" style=""height: 289px; width: 348px;"" /></td></tr>
</tbody></table>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<span class=""auto-style10""><big>Many of my research work and reports have helped</big></span><big>&nbsp;many Nigerian Men to get rid of their unwanted&nbsp;</big><big>Weak Erections, Premature Ejaculation, Low Libido, Loss of Energy and Sex Stamina etc. And with everything I know and with my experience, I can confidently tell you that, ending all your sexual troubles boils down to</big><big>&nbsp;Nutrition.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""></span></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>The best way I know I can reach and help meet the need of most men including you, that cannot be reached in my locality is the internet.&nbsp;</big><big>Internet gives me access to you and lot of men that really need my help.&nbsp;</big><big>Even in my offline base, I discovered some men are so shy that they prefer to die with their problem(s) than to disclose it to people. Good enough, internet is faceless. It conceals your identity while you get your problem solved.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
</div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
<span style=""color: #221799; font-family: &quot;times new roman&quot;; font-size: 26pt; line-height: normal; text-align: center;""><span style=""color: #cc0000;""></span></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><strong></strong></big><br />
<div style=""font-family: &quot;Comic Sans MS&quot;;"">
</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; widows: 1;"">
<big><strong style=""color: #993399;""></strong><span style=""font-weight: bold;""></span></big></div>
<span class=""style46""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style78""></span></big><span class=""auto-style10""><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></span><big><span style=""font-family: &quot;comic sans ms&quot;;"">Really, information is power and can be more powerful than medicine at times if you really make use of it. To every problem, there is always a solution.&nbsp;</span></big><big style=""font-family: &quot;Comic Sans MS&quot;;"">Nothing is more painful than a missed privilege that brings healing and freedom from series of health challenges and restriction due to negligence. Our Erectile Dysfunction Solution Pack has been carefully and successfully researched and acknowledge to be able to reverse Erectile Dysfunction in men and also increase sex stamina in no time.<br /><br />Your sexual problem is a wake-up call for you to discover a new insight, that will add to your wealth of knowledge and walk you out of any of the above Men's Health Challenges.<span style=""font-weight: bold;""></span></big><strong></strong></div>
<div class=""auto-style18"" style=""color: #6633ff; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
<big style=""color: #333399;""><strong style=""color: #330099; font-style: italic;""><br /></strong></big></div>
<div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
<big><strong style=""font-style: italic;"">This is why I'm introducing to you, the only Natural Supplement that can help relax blood vessels and increase Blood Flow especially to the penis,Erection Quality and Sex Stamina.</strong><strong></strong><strong></strong></big><big><strong style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""background-color: yellow;""></span></strong></big></div>
<div class=""auto-style18"" style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-style: italic; font-weight: bold; text-align: center;"">
<br /></div>
<div class=""auto-style18"" style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-style: italic; font-weight: bold; text-align: center;"">
JUST EXACTLY WHAT YOU ARE THINKING<br />
<strong>YES! THIS IS AMAZING FINDINGS</strong>!</div>
<div class=""auto-style18"" style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-style: italic; font-weight: bold; text-align: center;"">
<br /></div>
<div class=""auto-style40"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559138789/visit_us_owtcs6.gif"" style=""height: 70px; width: 125px;"" /></strong><span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559138887/bf-menpower_gx4et5.jpg"" style=""height: 300px; width: 261px;"" /></td></tr>
</tbody></table>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><span class=""auto-style82"" style=""color: #cc0000;""><strong><br /></strong></span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style40"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
</div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: center;"">
<big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559138957/mens-naturalhealth_rdsb0o.jpg"" style=""height: 289px; width: 348px;"" /></td></tr>
</tbody></table>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: center;"">
<big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<br />
<big><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style40"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
</div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: center;"">
<big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: center;"">
<big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><span class=""auto-style82"" style=""color: #cc0000;""><strong>2-in-1 For Peak Sexual Performance</strong></span><span class=""auto-style78"">&nbsp;is a Natural Supplement combination that can help you maintain Optimum Erection and Stamina for Sex.</span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><br /></big></div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
</div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big></big><big style=""color: #cc0000;""><span class=""auto-style82""><strong></strong></span><span class=""auto-style78""></span></big><big><span class=""auto-style82"" style=""color: #cc0000;""><strong>2-in-1 For Peak Sexual Performance</strong></span></big><big><span class=""auto-style82"" style=""color: #cc0000;""><strong>&nbsp;</strong></span></big><big><span class=""auto-style82""><strong></strong></span><span class=""auto-style78"">is made up of strictly natural ingredients. It has No negative side effects rather than improving your&nbsp;</span></big><big>Erection and Stamina for Sex.</big><br />
<big><span class=""auto-style78""><span class=""auto-style35""><strong><br style=""color: #993399;"" /><span style=""color: #993399;""></span></strong></span></span></big><big><span class=""auto-style82"" style=""color: #cc0000;""><strong>2-in-1 For Peak Sexual Performance</strong></span></big><big style=""color: #cc0000;""><span class=""auto-style82""><strong></strong></span></big><big><span class=""auto-style35"" style=""color: #cc0000;""><strong></strong></span>&nbsp;is a Natural Dietary Pack and it contains the following components:</big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-size: 15px; text-align: justify;"">
<big><span class=""auto-style78""></span></big><span class=""style46""></span><br /></div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
<div style=""text-align: center;"">
<big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""font-style: italic;"">Therefore, 2-in-1 Products Combination above will give your body back what your busy lifestyle takes out! Together these two legendary products pack a powerful punch to help you get through the day and even while dancing kerewa on bed with your partner.&nbsp;</span></big><br />
<br />
<big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #cc0000; font-style: italic;""></span></big></div>
<big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #cc0000; font-style: italic;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""></big></div>
<div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
<span style=""color: #006600;"">So, what makes&nbsp;<span style=""color: #cc0000;"">""Our 2-in-1 For Peak Sexual Performance""</span>&nbsp;safe to use and why do I even recommend it for you in the first place? The answer is simple!</span></div>
<div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
<span style=""color: #006600;""><br /></span></div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
The above products combination have the prestigious Kosher Seal (which makes them acceptable to the Jews. The Jews don't take anything that is not 100% natural. In-fact, they don't even take bread with yeast! They believe in no additives.</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<br /></div>
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: justify;"">
<big>They also have other seals including the seal of International Aloe Science Council, Halal and Islamic seals, these are seals of highest form of purity including our own NAFDAC in Nigeria.</big></div>
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: justify;"">
<big><br /></big></div>
<span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><big style=""font-style: italic;""><span class=""style146""></span></big></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""><big></big></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><big style=""font-family: Verdana; text-align: justify;""><big style=""font-style: italic;""><span class=""style146""></span></big></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""><big></big></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><big style=""font-style: italic;""><span class=""style146""></span></big></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""><big></big></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><big style=""font-family: Verdana; text-align: justify;""><big style=""font-style: italic;""><span class=""style146""></span></big></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""><big></big></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style82"" style=""color: #cc0000;""><strong></strong></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""><span style=""font-style: italic;""></span></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
<img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559139323/cert_ahq54q.jpg"" style=""height: 195px; width: 483.5px;"" /></div>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/be-strong-morethan-your-wife_files/bf-menpower.jpg"" style=""height: 300px; width: 261px;"" /></td></tr>
</tbody></table>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<big style=""color: #cc0000; font-family: Verdana; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong></strong></span></big><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""color: #cc0000; font-family: Verdana; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong></strong></span></big><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""font-family: Verdana; text-align: justify;""><span class=""auto-style6""></span></big><big style=""color: #cc0000; font-family: Verdana; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong></strong></span></big><big style=""color: #cc0000; font-family: Verdana; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span style=""color: black;""></span><span style=""color: black;""></span></strong></span></big><span style=""font-family: &quot;times new roman&quot; , serif; font-size: 14pt; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><big style=""color: #cc0000; font-family: Verdana; text-align: justify;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span style=""color: black;""></span></strong></span></big><br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
<div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span class=""auto-style156""><span style=""color: black;"">Do WOMEN really need and love sex? Absolutely yes! Below are comments from women&nbsp;</span></span></strong></span></big><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span class=""auto-style156""><span style=""color: black;"">in real life&nbsp;</span></span></strong></span></big><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span class=""auto-style156""><span style=""color: black;"">on why they want their man to perform well in bed with them</span><span style=""color: black;""><br /></span></span></strong></span></big></td></tr>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""></td></tr>
</tbody></table>
<br />
<div>
<span style=""font-family: &quot;comic sans ms&quot;;""></span><br />
<div class=""auto-style18"">
<strong></strong></div>
<big><span class=""auto-style6""></span></big><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong></strong></span></big><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span style=""color: black;""></span><span style=""color: black;""></span></strong></span></big><span style=""font-family: &quot;times new roman&quot; , serif; font-size: 14pt;""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span><span class=""style18"" style=""font-family: &quot;arial rounded mt bold&quot;; font-size: 18px; font-weight: bold;""></span><big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong><span style=""color: black;""></span></strong></span></big></div>
<big style=""color: #cc0000;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong>""Okay! How Much Is The 2-in-1 Above Going<br />To Cost To Delivered To Me At My Doorstep</strong></span></big></div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
</div>
<div class=""auto-style28"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: justify;"">
<big>Have you ever takes time to think about how happy and relieved you will be if you finally get rid of your Erectile dysfunction and Low Sexual Drive. This simply means, with Our 2-in-1 products combination for Men's Health:</big></div>
<div class=""auto-style28"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: justify;"">
<big><br /></big></div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: center; widows: 1;"">
<span style=""font-family: &quot;trebuchet ms&quot; , &quot;lucida sans unicode&quot; , &quot;lucida grande&quot; , &quot;lucida sans&quot; , &quot;arial&quot; , sans-serif;""></span></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); font-family: Verdana; margin-left: auto; margin-right: auto; padding: 5px; width: 348px;""><tbody>
<tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559140352/bullet5_dasawu.png"" style=""height: 30px; width: 33px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>you will never have to complain about Week Erection</big><span style=""font-size: large;""></span></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559140352/bullet5_dasawu.png"" style=""height: 30px; width: 33px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>You will never have to complain about&nbsp;</big><big>Low Sexual Stamina</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559140352/bullet5_dasawu.png"" style=""height: 30px; width: 33px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>You will never have to complain about Low Libido</big><big><span class=""auto-style78""></span></big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559140352/bullet5_dasawu.png"" style=""height: 30px; width: 33px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>You will never have to complain about Quick Ejaculation</big><big><span class=""auto-style78""></span></big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559140352/bullet5_dasawu.png"" style=""height: 30px; width: 33px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big style=""font-family: &quot;Comic Sans MS&quot;;"">And finally, your woman will always sees you as Super Rider when it comes to S/ex.</big><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style78""></span></big></td></tr>
</tbody></table>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<span style=""font-style: italic;""><span style=""font-weight: bold;""></span></span></div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
</div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<span class=""auto-style78""><br /></span></div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<span class=""auto-style78"">Before you answer that question, I want you to consider the value of what you are getting. It will save you lots of money, time and efforts.</span>This is why I'm giving you&nbsp;<span style=""font-style: italic;""><span style=""font-weight: bold;"">2-in-1&nbsp;</span></span><span style=""font-style: italic; font-weight: bold;"">&nbsp;Products Combination For Peak Sexual Performance&nbsp;</span>at a heavily discounted Price of,</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<br /></div>
<div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
<big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
<div class=""auto-style40"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong><img alt="""" src=""https://doctornaturalsolution.com.ng/be-strong-morethan-your-wife_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong><span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""font-family: &quot;Lucida Sans Unicode&quot;; text-align: center;"">
<big><strong><span style=""font-family: &quot;comic sans ms&quot;;""><br /></span></strong></big>
<br />
<div class=""circle c2"" style=""background-color: #990000; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-transform: uppercase; width: 200px;"">
#26,000</div>
<big><strong><span style=""font-family: &quot;comic sans ms&quot;;""></span></strong></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><strong>This Discounted Price,&nbsp;</strong></big><br />
<big style=""font-family: &quot;Comic Sans MS&quot;;""><strong><strong></strong></strong></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><strong>Open for just few days Only.</strong></big></div>
<div style=""text-align: center;"">
<br /></div>
</td></tr>
</tbody></table>
<div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
<strong></strong></div>
<div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
<big style=""font-family: &quot;Comic Sans MS&quot;;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;;""><big><br />Again, I'm giving you a chance to get it at the low price of #26,000 for Just This Week Only. After Which the price will go up to its normal retail price of&nbsp;</big><big></big><big>#31,000. So don't waste time! Your limited timed price for the next few days is only&nbsp;</big><big></big><big>#26,000.</big></span><big style=""font-family: &quot;Comic Sans MS&quot;;"">&nbsp;Therefore, what are you waiting for?</big><br />
<br />
<div style=""text-align: center;"">
</div>
</div>
<br />
<table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 584px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""text-align: center;"">
<br /></div>
<div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><small style=""font-family: Verdana;""><span style=""color: #cc0000; font-style: italic;""><strong><span class=""auto-style95""><big><big>Don't Wait A Moment, Order<br />Your 2-in-1 For Peak Sexual<br />Performance Now!</big></big></span></strong></span></small></big></div>
<br />
<div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/be-strong-morethan-your-wife_files/bf-menpower.jpg"" style=""height: 300px; width: 427.5px;"" /><br />
<big><small style=""font-family: Verdana;""><span style=""color: #cc0000; font-style: italic;""><strong><span class=""auto-style95""></span></strong></span></small><span style=""color: #cc0000; text-decoration-line: underline;""><strong></strong></span></big></div>
<div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<br /></div>
<span style=""font-family: &quot;comic sans ms&quot;;""></span></td></tr>
</tbody></table>
<span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><strong style=""font-family: Verdana; font-size: 15px; text-align: justify;""></strong><strong style=""font-family: Verdana; font-size: 15px; text-align: justify;""></strong><span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;""></span><span style=""font-family: &quot;comic sans ms&quot;; font-size: 15px; text-align: justify;""></span><strong style=""font-family: Verdana; font-size: 15px; text-align: justify;""></strong><strong style=""font-family: Verdana; font-size: 15px; text-align: justify;""></strong><br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
<span style=""font-family: &quot;verdana&quot;; font-size: 15px; font-style: italic; font-weight: bold; text-align: justify;""></span>

<br />
",
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{"Weak Erection", "Premature Ejaculation" } },
                                  new Row(){ Body = new List<string>{ "Loss of Energy", "Sex Stamina" } },
                                   new Row(){ Body = new List<string>{ "Low Libido" } },
                              }
                          },
                           new Ogun()
                           {
                               Header = "Prostate Enlargement",
                               HtmlDescription = @"<div style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; font-size: 30px; text-align: center;"">
    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span style=""color: #990000;""><span
                style=""color: #009900;"">A Simple And Tested Approach You Can Use To End Enlarged Prostate And Urinary
                Problems Starting From Today!</span></span></span><span
        style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span style=""color: #990000;""></span></span></div>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151403/enterprost_eqex3v.jpg""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; height: 250px; text-align: justify; width: 487.5px;"" /><big
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br /></span></span></big><br />
<big style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />You have arrived at what is,
            without question, the most valuable website on the entire Internet to get solution to prostate
            enlargement!<br /><br />If you're a man in your fifties, sixties or seventies then there's a better than
            even chance that you will be suffering from an enlarged prostate gland and will be experiencing a range of
            common symptoms including:</span></span></big><br />
<table border=""0"" cellpadding=""7"" cellspacing=""7""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top; width: 301px;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Hesitancy</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">You just can't get
                            your bladder to co-operate, you stand and stare at the toilet, you strain every muscles but
                            nothing comes out, despite the urge to urinate.</span></span></big>
            </td>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top; width: 300px;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Weak Flow</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">Eventually you
                            manage to find release and start a flow, but its barely going, it's dripping, it's stopping
                            and starting, it's just not what it should be.</span></span></big>
            </td>
        </tr>
        <tr>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Urgency</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">You only just went
                            to the toilet 30 minutes ago but you feel the urge to urinate again. You feel like a
                            prisoner in your own ho</span></span></big><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;"">me, unable to move more than 100ft from the
                            nearest toliet.</span></span></big>
            </td>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Dribbling</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">Throughout the day
                            you suffer a humiliating inability to stop occasional dribbling leading to uncomfortable or
                            even embarrassing<span style=""font-weight: bold;"">&nbsp;pants
                                wetting.</span></span></span></big>
            </td>
        </tr>
        <tr>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top; width: 301px;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Nocturia</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">You wake constantly
                            during the night to urinate, it doesn't matter how many times you go to the toilet, you know
                            you will be back there in an hour or two.</span></span></big><big><span
                        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><span
                                style=""font-weight: bold;""></span></span></span></big>
            </td>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top; width: 300px;"">
                <div style=""background-color: #009900; color: white; padding: 5px; text-align: center;"">
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Retention</span></span></big></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">It doesnt matter
                            how many times you go to the toilet, you feel like you cannot empty your bladder
                            completely.</span></span></big><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;""></span></span></big>
            </td>
        </tr>
        <tr>
            <td class=""image-border"" colspan=""2"" rowspan=""1""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;"">
                <big><span style=""font-family: &quot;comic sans ms&quot;;"">You may also experience more serious symptoms
                        such as Urination Obstruction, Nausea, Back Pain, Presence of Blood in the Urine, and
                        Fever.</span></big></td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""text-align: justify; vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #990000;""><span style=""color: #009900;"">But Should You Be Worried About Your
                                Enlarged Prostate And Symptoms?</span></span></span><img alt=""""
                        src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151456/worried-3_t1hygd.png""
                        style=""height: 250px; width: 481.5px;"" /></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">Having an enlarged
                            prostate is not only painful, it can be embarrassing as well. To make matters worse, the
                            condition can lead to life-threatening complications.<br /><br />Swollen prostate can lead
                            to further complication in future if you don't treat it now. It causes blockage by clogging
                            your kidneys with urine. In such cases, Acute Urinary Retention can happen.<br /><br />It
                            may even develop into Chronic Kidney Disease, Kidney Damage or Infection, Bladder Damage,
                            and Bladder Stones.<br /><br />Unfortunately, because most men will suffer from an enlarged
                            prostate, particularly in their sixties and seventies, many men don't worry when the
                            symptoms appear and certainly wouldn't take it seriously until it become life threatening.
                            This is a mistake&nbsp; you should not make.</span></span></big><br />
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #990000;""></span></span><span
                        style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span style=""color: #009900;"">This
                            Was My Case Then&nbsp; -&nbsp; According To Mr. Ibikunle&nbsp; (One Of The Men This Solution
                            You Are About To Discover Has Greatly Help)</span><span style=""color: red;""></span></span>
                </div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">In February 2017, I
                            discovered what is by far the most Effective and Natural Remedy For Prostate Enlargement. At
                            first, I was skeptical about this natural approach because I'd always thought the best way
                            to deal with Prostate Enlargement was to undergo surgery [according to my doctor friend], so
                            I ignored the ""Natural Solution"".<br /><br />About three days later, as I sat alone in my
                            sitting room feeling hopeless and anxious about my prostate problem, especially the frequent
                            urination every night and the urgency with which it comes, I said to myself what's the worst
                            that can happen?<br /><br />So, I went back on the internet to search for the solution I saw
                            earlier if I can still get it. I eventually got it after some time through a Prostate
                            Enlargement Newsletter I subscribed to.</span></span></big>
            </td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""text-align: justify; vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span style=""color: #009900;"">The
                            Turning Point</span><span style=""color: red;""></span></span></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />I decided to
                            give the&nbsp;<span style=""font-weight: bold;"">Natural Remedy</span>&nbsp;a trial and see if
                            it's as effective as the report says it is, and to my amazement, in less than two months, I
                            was completely relieved and free from most of the symptoms I was
                            having.</span></span></big><span
                    style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                        style=""color: #990000;""></span></span><br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">I also noticed I no
                            longer wake up frequently at night to urinate and the difficulty I experienced when
                            urinating was completely gone. I said to myself; don't celebrate yet. I needed to be sure
                            this was not just coincidence.<br /><br />So I decided to keep this to myself for some time
                            and see if the symptoms will return or not, but as this time of writing, it’s been more than
                            10 months now and I can tell you I’ve not experienced any of those terrible symptoms ever
                            since.<br /><br />In addition to this, I feel stronger, healthier, and in charge of my life.
                            I am thrilled with my experience that I inspire others to experience for themselves the
                            profound transformation this Prostate Enlargement solution offers and that is why I decided
                            to share my experience to help anyone out there suffering from prostate enlargement to try
                            this profound Solution.<br /><br />So, if you have this exact same problem, you don't have
                            to accept prostate enlargement to overstay its welcome in your life. You have the power to
                            change how you live. The effects of enlarged prostate are real, so also the solution.
                            Addressing your prostate problems now can help avoid complications later in
                            future.</span></span></big><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;""></span></span></big>
            </td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""text-align: justify; vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #990000;""><span style=""color: #009900;"">How Do Doctors Deal With Enlarged
                                Prostate?</span></span></span><img alt=""""
                        src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151498/turp-3_hrmevm.png""
                        style=""height: 250px; width: 481.5px;"" /></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />In the past,
                            the only option for people with Prostate Enlargement[BPH] was surgery called&nbsp;<span
                                style=""font-weight: bold;"">Trans Urethral Resection Of The Prostate
                                (TURP),</span>&nbsp;this procedure involves ""shaving"" or ""removing"" small pieces of the
                            enlarged prostate that block the flow of urine&nbsp;<span
                                style=""color: #990000; font-weight: bold;"">(see the picture above).</span>&nbsp;TURP
                            usually relieves the uncomfortable symptoms of enlarged prostate but with some few
                            problems.</span></span></big><span
                    style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                        style=""color: #990000;""></span></span><br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">First, the prostate
                            may enlarge again, requiring another operation. This is true for one in four men who may
                            have to undergo a second TURP procedure in three years.<br /><br />Secondly, surgery does
                            not prolong life. Study suggests that it actually reduces a person's lifespan by a
                            year.<br /><br />In some cases, TURP can cause impotence or complete inability to control
                            urination. The most common side effect, however, is retrograde ejaculation, that is, the
                            ejaculated semen enters the bladder instead of shooting out of the penis. This may impair a
                            man's fertility.</span></span></big><br />
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #990000;""><span style=""color: #009900;"">The Scary Truth About Prostate
                                Surgery</span></span><span style=""color: red;""></span></span></div>
                <br />
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">Prostate
                            enlargement has reached almost epidemic proportions in our modern civilization, with it
                            being the second biggest killer of men in Africa.<br /><br />When the prostate gland
                            enlarges, it pushes against the urethra (the waterworks tube), affecting a man's ability to
                            urinate, and also affects his sexual performance.<br /><br />Many men become totally
                            impotent as a result and some experience the added embarrassment of incontinence
                            (uncontrolled wetting).<br /><br />The psychological effects can be devastating. The
                            orthodox medical approach to Prostate disorders has always been prescription drugs and/or
                            invasive surgery which are less effective not to mention the risks involved in surgery with
                            some potentially serious side effects which are often almost as serious as the Prostate
                            disorder itself; such as reduced sex drive, retrograde ejaculation and
                            impotence.&nbsp;</span></span></big><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;""></span></span></big>
            </td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""text-align: justify; vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span style=""color: #009900;"">An
                            End To Enlarged Prostate</span><span style=""color: red;""></span></span></div>
                <big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;""><br /></span></span></big>
                <br />
                <div style=""text-align: center;"">
                    <big style=""color: #000099; font-style: italic; font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">European and Asian doctors have
                                traditionally been using natural holistic approach to cure Prostate Enlargement, with
                                resounding success and with no side effects.</span></span></big><br />
                    <big><span style=""font-family: &quot;comic sans ms&quot;;""></span></big></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />Prostate
                            patients respond so well to these Natural Solution that over 90% of Foreign Doctors
                            prescribe them, rather than prescription drugs. The American Botanical Council registers
                            various natural herbal or plant extracts as a treatment for Prostate Enlargement and these
                            ingredients and many others are now made available as Prostate remedies and numerous
                            clinical trials reinforce their effectiveness.<br /><br />One of such is Our Natural
                            Prostate Care Pack. It has a unique formula which contains over 37 years of research into
                            natural Prostate disorder treatments.<br /><br />It's formulation of 25 key active
                            ingredients, has made it, the most comprehensive and successful Prostate solution ever
                            developed; Giving better, lasting and faster results for more men than any other treatment
                            just like it did for Mr. Ibikunle.</span></span></big><br />
                <div style=""text-align: center;"">
                    <big style=""font-style: italic;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;""><span
                                    style=""color: #990000; font-weight: bold;"">WARNING:</span><span
                                    style=""font-weight: bold;"">&nbsp;Not All Natural Prostate Remedies Are Created
                                    Equal!</span></span></span></big><br />
                    <big><span style=""font-family: &quot;comic sans ms&quot;;""></span></big></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />Be careful,
                            there are a lot of bogus products on the market. There are none that I am aware of that work
                            like this one, that have been researched and scientifically proven to effectively correct
                            enlarged prostate.<br /><br />With Our Prostate Care Pack, you obtain your goals with ease -
                            in no time. You CAN stop wondering what to do about your enlarged prostate, once and for
                            all.<br /><br />""You will never ever have to go back to being unhappy with your aging
                            appearance or feeling less than anybody else ever again""&nbsp;</span></span></big><span
                    style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                        style=""color: #990000;""></span></span><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;""></span></span></big>
            </td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""text-align: justify; vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #990000;""><span style=""color: #009900;"">What You Stand To Get With This
                                Incredible Solution</span></span><span style=""color: red;""></span></span></div>
                <big><span style=""font-family: &quot;comic sans ms&quot;;""></span></big><br />
                <table border=""0"" cellpadding=""5"" cellspacing=""5"" style=""width: 642px;"">
                    <tbody>
                        <tr>
                            <td style=""text-align: center; vertical-align: top; width: 35px;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top; width: 95px;""><big><span
                                        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">Your
                                            enlarged prostate or your prostate gland will be corrected and restored to
                                            its original healthy state.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">You will never have to wake
                                            up frequently at night to urinate again; which means you will enjoy a
                                            peaceful sleep always.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">The difficulty you
                                            experience when urinating will finally stop.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">You will be able to fully
                                            empty your bladder at a go and the dribbling will finally
                                            stop.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">If you’re already
                                            experiencing blood in urine or you’ve developed a urinary tract infection
                                            due to poor treatment of the enlarged prostate, this pack will also help you
                                            treat these conditions successfully.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">Your sex life and vitality
                                            will be restored and come back to life.</span></span></big></td>
                        </tr>
                        <tr>
                            <td style=""text-align: center; vertical-align: top;""><img alt=""""
                                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151597/green-bullet_nnllz8.png""
                                    style=""height: 35px; width: 35px;"" /></td>
                            <td style=""text-align: justify; vertical-align: top;""><big><span class=""auto-style6""><span
                                            style=""font-family: &quot;comic sans ms&quot;;"">Most importantly, you’ll
                                            become healthy once again and thus prolong your life, and many
                                            more.﻿</span></span></big></td>
                        </tr>
                    </tbody>
                </table>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />So
                            e</span></span></big><span
                    style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                        style=""color: #990000;""></span></span><big><span class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;"">ven if you've tried other treatments in the
                            past with little or no result, Our Natural Prostate Care Pack could be the answer, as it
                            works very successfully for 99% of men, Mr. Ibikunle included.<br /><br />Containing 25
                            natural phytoceutical extracts, proven to reverse and cure Prostate Enlargement and other
                            prostate symptoms.<br /><br />It is the most comprehensive Prostate and general men's
                            product on the market.</span></span></big><br />
                <div style=""text-align: center;"">
                    <big style=""color: #000099; font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Our Natural Prostate Care Pack contains
                                the latest clinically trialled ingredients such as Stabilized Aloe Vera from Texas and
                                Dominica Republic, Bee hive, standardized Saw Palmetto, Berry extract, Lycopene and
                                Zinc, to name but a few.</span></span></big><br />
                    <big><span style=""font-family: &quot;comic sans ms&quot;;""></span></big></div>
                <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />It has no
                            known side effects. It's a complete, easy to use Program for correcting enlarged
                            prostate.<br /><br />The system includes 3 specially formulated components that works in
                            harmony with your body to achieve rapid results.&nbsp;<span
                                style=""color: #990000; font-weight: bold;"">See image
                                below:</span></span></span></big><big style=""color: #990000; font-weight: bold;""><span
                        class=""auto-style6""><span
                            style=""font-family: &quot;comic sans ms&quot;;"">&nbsp;</span></span></big><big><span
                        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span></big>
            </td>
        </tr>
    </tbody>
</table>
<br style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<div style=""background-color: white; font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: center;"">
    <span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;"">Introducing Well Researched
                        Plants And Fruits Extract For Optimum Prostate Health&nbsp;<span style=""color: #009900;"">""The
                            Most Powerful Natural Supplement For Prostate Health!</span></span></div>
                <br />
                <div style=""text-align: center;"">
                    <img alt=""""
                        src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151639/tripple_facedown_l0q4jk.gif""
                        style=""height: 252px; width: 500px;"" />&nbsp;</div>
                <div style=""text-align: center;"">
                </div>
                <div class=""separator"" style=""clear: both; text-align: center;"">
                    <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151694/BF_Suma_Prost_combo_255B1_255D_qpguoh.jpg""
                        imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0""
                            data-original-height=""1080"" data-original-width=""1072"" height=""320""
                            src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151694/BF_Suma_Prost_combo_255B1_255D_qpguoh.jpg""
                            width=""317"" /></a></div>
                <br />
                <div style=""text-align: center;"">
                    <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151777/3q_ch3vdm.jpg""
                        style=""height: 120px; width: 385.188px;"" /></div>
                <br />
                <div style=""color: #009900; font-size: 30px; text-align: center;"">
                    <span style=""font-family: &quot;verdana&quot;; font-weight: bold;"">Manufactured in Los Angeles U.S.
                        Cerified By NAFDAC And Other International Organisations!</span></div>
                &nbsp;&nbsp;<span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
                        style=""color: #990000;""><br /></span></span><br />
                <div style=""text-align: center;"">
                    <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151856/certi_taj0ex.jpg""
                        style=""height: 120px; width: 481.5px;"" /><br />
                    <br />
                    <div style=""text-align: justify;"">
                        <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">The Products you are looking at above is
                                the exact same Natural Remedy Mr. Ibikunle used to correct his enlarged prostate and
                                restored his Optimum Prostate Health Back.</span></span><br />
                        <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;""><span
                                style=""font-family: &quot;comic sans ms&quot;;""></span></span><br />
                        <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;""><span
                                style=""font-family: &quot;comic sans ms&quot;;"">Read some of the numerous testimonials
                                of people who have shared their success stories using our Natural Prostate Care
                                Pack;</span></span></div>
                </div>
            </td>
        </tr>
    </tbody>
</table>
<big style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        class=""auto-style6""></span></big><big
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        style=""font-family: &quot;comic sans ms&quot;;""></span></big><big
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        style=""font-family: &quot;comic sans ms&quot;;""></span></big><span
    style=""background-color: white; font-family: &quot;lato&quot; , sans-serif , &quot;time new roman&quot;; text-align: justify;""></span><big
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        style=""font-family: &quot;comic sans ms&quot;;""></span></big><br
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;"" />
<table border=""0"" cellpadding=""2"" cellspacing=""2""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td style=""vertical-align: top;"">
                <div style=""font-size: 30px; text-align: center;"">
                    <span style=""color: #cc0000; font-family: &quot;verdana&quot;; font-weight: bold;""><span
                            style=""color: #009900;"">Proof that it works!</span>&nbsp;<span style=""color: black;"">Here
                            are the few words of men that Our Prostate Care Pack has greatly helped</span></span></div>
                <br />
                <div style=""text-align: justify;"">
                    <div class=""image-border div-shadow""
                        style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); box-shadow: rgb(0, 153, 0) 5px 5px; padding: 5px; text-align: center;"">
                        <div style=""background-color: #cccccc; padding: 5px;"">
                            <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                        style=""font-family: &quot;comic sans ms&quot;;"">~ Mr. Ibikunle (Lagos)
                                        ~</span></span></big><br />
                            <big style=""font-weight: bold;""><span
                                    style=""font-family: &quot;comic sans ms&quot;;""></span></big></div>
                        <br />
                        <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                    style=""font-family: &quot;comic sans ms&quot;;"">""My overall experience was very
                                    positive. It has reduced my anxiety regarding prostate issues and has helped lower
                                    my PSA. I therefore recommend this product for any man with Prostate Health
                                    Palava!""&nbsp;</span></span></big>
                    </div>
                </div>
                <br />
                <div style=""font-weight: bold; text-align: justify;"">
                    <div style=""text-align: center;"">
                    </div>
                    <div class=""image-border div-shadow""
                        style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); box-shadow: rgb(0, 153, 0) 5px 5px; padding: 5px; text-align: center;"">
                        <div style=""background-color: #cccccc; padding: 5px;"">
                            <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;"">~ Mr.
                                        Johnson (Abeokuta) ~</span></span></big></div>
                        <big><span class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br />""It's
                                    the best product so far that I have ever used. I just love the combination. Before I
                                    started use the products, I was encountering issues like hard to urinate, pain while
                                    urinating, heaviness, I could feel it, so I was always thinking about it. I don't
                                    think I could live without it. Therefore, anyone with prostate issues should be
                                    aware of these products.""</span></span></big>
                    </div>
                </div>
                <br />
                <div class=""image-border div-shadow""
                    style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); box-shadow: rgb(0, 153, 0) 5px 5px; padding: 5px; text-align: center;"">
                    <div style=""background-color: #cccccc; padding: 5px;"">
                        <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                    style=""font-family: &quot;comic sans ms&quot;;"">~ Mr. Richard (Calabar)
                                    ~</span></span></big></div>
                    <big style=""font-weight: bold;""><span class=""auto-style6""><span
                                style=""font-family: &quot;comic sans ms&quot;;""><br />""I have tried many different
                                products to treat my BPH symptoms and I can definitely say that these products
                                combination has by far worked the best. My nightly trips to the bathroom have gone from
                                several to just one. Great Product!! ""</span></span></big>
                </div>
            </td>
        </tr>
    </tbody>
</table>
<big style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: justify;""><span
        class=""auto-style6""><span style=""font-family: &quot;comic sans ms&quot;;""><br /></span></span></big><span
    style=""background-color: white; font-family: &quot;lato&quot; , sans-serif , &quot;time new roman&quot;; text-align: justify;""></span>
<br />
<div style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: center;"">
    <strong><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151991/visit_us_jdhvx7.gif""
            style=""height: 70px; width: 125px;"" /></strong></div>
<div style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: center;"">
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
        style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong>Therefore, Get Our
            Natural Prostate Care Pack Today For Your Optimum Prostate Health. These Products Combination Below Can Be
            Delivered To Your Door Step.<br /><br /><span style=""color: #990000;""><span style=""color: #009900;"">Here
                    Below The Cost Analysis Table For You To Place Your Order At A Huge Discounted
                    Price.</span></span></strong></span><br />
    <div>
        <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151639/tripple_facedown_l0q4jk.gif""
            style=""height: 252px; width: 500px;"" /></div>
    <div>
        <div class=""separator"" style=""clear: both; text-align: center;"">
            <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151694/BF_Suma_Prost_combo_255B1_255D_qpguoh.jpg""
                imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""1080""
                    data-original-width=""1072"" height=""320""
                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151694/BF_Suma_Prost_combo_255B1_255D_qpguoh.jpg""
                    width=""317"" /></a></div>
    </div>
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
        style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong></strong></span><big
        style=""color: #cc0000;""><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""><strong><span
                    style=""font-family: &quot;verdana&quot;;""></span></strong></big></big><br />
    <table border=""1"" cellpadding=""0"" cellspacing=""0"" id=""table2""
        style=""border-collapse: collapse; border-radius: 7px; border: 3px solid black; box-shadow: rgb(0, 153, 0) 5px 5px; padding: 15px; width: 617px;"">
        <tbody>
            <tr>
                <td
                    style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 235px;"">
                    <big><br />Desired/Duration<br />Usage Pack</big></td>
                <td
                    style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 204px;"">
                    <big><br />Quantity To Be<br />Delivered</big></td>
                <td
                    style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 203px;"">
                    <big><br />Total Cost In<br />Naira (#)</big></td>
            </tr>
            <tr>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <big style=""color: red;""><big><big><big>1</big></big></big></big><br />
                    Usage<br />
                    Pack</td>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    1 bottle of each<br />
                    of the products<br />
                    above will be<br />
                    delivered</td>
                <td
                    style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <big><span style=""text-decoration-line: line-through;""><br /></span></big>
                    <br />
                    <div class=""circle c1""
                        style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                        <br />
                        <span style=""color: red;"">#32,500</span></div>
                    <big><span style=""text-decoration-line: line-through;""></span></big>
                </td>
            </tr>
            <tr>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <big style=""color: red;""><big><big><big>2</big></big></big></big><br />
                    Usage<br />
                    Pack</td>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    2 bottle of each<br />
                    of the products<br />
                    above will be<br />
                    delivered</td>
                <td
                    style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <br />
                    <div class=""circle c1""
                        style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                        <br />
                        <span style=""color: red;"">#63,000</span></div>
                </td>
            </tr>
            <tr>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <big style=""color: red;""><big><big><big>3</big></big></big></big><br />
                    Usage<br />
                    Pack</td>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    3 bottle of each<br />
                    of the products<br />
                    above will be<br />
                    delivered</td>
                <td
                    style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                    <br />
                    <div class=""circle c1""
                        style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                        <br />
                        <span style=""color: red;"">#93,500</span></div>
                </td>
            </tr>
        </tbody>
    </table>
    <br />
    <div style=""text-align: justify;"">
        <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px; font-style: italic;""><span
                style=""font-family: &quot;comic sans ms&quot;;""><span style=""color: #990000; font-weight: bold;"">Please
                    Note:</span>&nbsp;How long you will be taken the above products combination is greatly depends on
                the severity of your Symptoms (either Mild or Complex). But irrespective of the severity, your Prostate
                Health will be restored within 3 months of usage.</span></span></div>
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
        style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong></strong></span>
</div>
<span
    style=""background-color: white; font-family: &quot;lato&quot; , sans-serif , &quot;time new roman&quot;; text-align: justify;"">&nbsp;&nbsp;</span><span
    style=""font-family: &quot;verdana&quot;; font-weight: bold; text-align: justify;""><span
        style=""color: #990000;""></span></span><br />
<span data-mce-style=""font-size: 18px; color: #000000;""
    style=""font-family: &quot;lato&quot; , sans-serif , &quot;time new roman&quot;; font-size: 18px; font-style: italic; text-align: justify;""><span
        style=""font-family: &quot;comic sans ms&quot;;""><span style=""color: #990000; font-weight: bold;"">Also
            Note:</span>&nbsp;This incredible discounted price offer is open for the next few days and it comes
        with<span style=""color: #000099;"">&nbsp;</span><span style=""color: #000099; font-weight: bold;"">Free Shipping
            with No Extra Delivery Charges.</span><span style=""color: #990000; font-weight: bold;""></span>These products
        are manufactured in Los Angeles U.S.A and has been certified by several International Bodies including our own
        NAFDAC in Nigeria.<br />&nbsp;&nbsp;</span></span><span
    style=""font-family: &quot;lato&quot; , sans-serif , &quot;time new roman&quot;; font-style: italic; text-align: justify;""></span><br />
<table border=""0"" cellpadding=""10"" cellspacing=""0""
    style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; margin-left: auto; margin-right: auto; width: 650px;"">
    <tbody>
        <tr>
            <td class=""image-border""
                style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;"">
                <div style=""text-align: center;"">
                    <strong
                        style=""color: #cc0000; font-family: &quot;arial rounded mt bold&quot;; font-style: italic;""><span
                            class=""auto-style95""><big><big><span style=""font-family: &quot;verdana&quot;;"">DON'T WAIT A
                                        MOMENT,&nbsp;<span
                                            style=""color: #6633ff;"">ORDER</span></span></big></big></span></strong>
                </div>
                <div style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
                    <big><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span
                                style=""color: #cc0000; font-style: italic;""><strong><span
                                        class=""auto-style95""><big><big><span
                                                    style=""color: #6633ff; font-family: &quot;verdana&quot;;""></span></big></big></span></strong></span></small></big><span
                        style=""color: #6633ff; font-family: &quot;verdana&quot;; font-weight: bold;""></span><big
                        style=""color: #6633ff;""><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span
                                style=""font-style: italic;""><strong><span class=""auto-style95""><big><big><span
                                                    style=""font-family: &quot;verdana&quot;;"">OUR PROSTATE CARE PACK
                                                    NOW!</span></big></big></span></strong></span></small></big></div>
                <div style=""text-align: center;"">
                    <br /></div>
                <div style=""text-align: center;"">
                </div>
            </td>
        </tr>
    </tbody>
</table>
<div style=""font-family: Lato, sans-serif, &quot;Time New Roman&quot;; text-align: center;"">
    <br /></div>",
                               ID ="44129e4c-8262-4489-a214-50ed35367d44".Replace("-",""),
                                Rows = new List<Row>(){
                                  new Row(){ Body = new List<string>{ "Back-pain", "Urinary Issues" } },
                                  new Row(){ Body = new List<string>{ "Frequent Urination", "dribbling Urination" } },
                                  }
                              }
                           }
               },
               new DrugGroup(){
                   Name = "Sexual (Female 👩‍⚕️)",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559033240/vjay_zpsowa.png",
                     AwonOgun = new List<Ogun>()
                     {
                           new Ogun()
                           {
                               Header = "Fibroids / Ovarian cysts / Infertility",
                               HtmlDescription =@"<div style=""font-family: Verdana; font-size: 15px; font-weight: bold; line-height: 30px; text-align: center;"">
    <big><big><big><span style=""text-decoration-line: underline;"">This is so Effective</span>&nbsp;<span style=""color: #cc0000;"">That 100% Of Nigerian Women That Used It&nbsp;</span>All Said ""Thank You""</big></big></big></div>
    <br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big style=""font-weight: bold;""><big><big><span style=""background-color: #33cc00;"">&nbsp;It's NAFDAC Certified - No Side Effects</span></big></big></big></div>
    <br />
    <table border=""0"" cellpadding=""15"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 483px;""><tbody>
    <tr style=""background-color: white;""><td class=""image-border"" style=""text-align: center; vertical-align: middle;""><div style=""font-style: italic; line-height: 32px;"">
    <div style=""line-height: 32px;"">
    <big><big><strong><span style=""color: #cc0000;"">Welcome to the world of Middle Age and Older Women!</span>&nbsp;Your Fibroid And Infertility Health Challenges Can Be Reverse, If Only You Know What To Do!</strong></big></big></div>
    </div>
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><div style=""font-style: italic; line-height: 32px;"">
    <div style=""line-height: 32px;"">
    <big><big><strong><span style=""background-color: yellow;"">If you are really serious in getting rid of your&nbsp;<span style=""color: #cc0000;"">Fibroid And Infertility&nbsp;</span></span></strong></big><big><strong><span style=""background-color: yellow;"">just in a Natural and Safe way within a short period of time then, this is the most important report you will ever read.</span></strong></big></big></div>
    </div>
    </td></tr>
    </tbody></table>
    <div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    </div>
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <div style=""text-align: justify;"">
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Fibroids are the most frequently seen tumors of the female reproductive system. Fibroids, also known as uterine myomas, leiomyomas, or fibromas, are firm, compact tumors that are made of smooth muscle cells and fibrous connective tissue that develop in the uterus. It is estimated that between 20 to 50 percent of women of reproductive age have Fibroids. Some estimates state that up to 30 to 77 percent of women will develop Fibroids sometime during their childbearing years.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Recently, a 35-year old housewife walked into a clinic, she was full with bundle of worry. The mother of two beautiful daughters had a problem of secondary infertility. She and her spouse had been through thick and thin to resolve the problem without success. Apart from painful menstruation, she had symptoms of pregnancy (such as missed periods, swollen breasts and protruding stomach).<br /><br />The trip to yet another clinic was part of her search for help. Following physical examination, the doctor recommended an abdominal scan. Only then was the cause of her worries unveiled. Really, she had uterine fibroid. Her case was not unusual because fibroid is quite common.&nbsp;<span style=""color: #cc0000; font-weight: bold;"">It is a condition that is bringing sorrow into the lives of many women and wrecking marriages.&nbsp;</span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Even when surgery is recommended, pregnancy may not be guaranteed. Experts say surgery for fibroid could involve the removal of the patient’s womb. Fibroid as a non-cancerous tissue found in the womb.<span style=""color: #993300; font-weight: bold;"">&nbsp;<span style=""color: #cc0000;"">“It is a mass which creates a lot of problems for women in terms of fertility, menstrual problems and frequent abdominal pains”.</span></span>&nbsp;Fibroid has become rampant among women due to modern lifestyle. “The causes of fibroid can be traced to lifestyle women now adopt nowadays.<br /><br />Such lifestyles cannot be compared&nbsp;<span style=""font-weight: bold;"">with the Natural Lifestyles of the people of old.</span>&nbsp;There are now so many things bringing in a lot of Estrogen into the body systems, such as plastics, pesticides and even the foods and the processes under which we breed animals for consumption. “Most of these things, including fishes, are bred artificially. So they store those hormones that we are imbibing that is causing some of these problems.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style11"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Fibroid tumors are composed of renegade muscle cells that come together to form a fibrous ""knot"" or ""mass"" within the uterus. Although all uterine fibroid are the same, they are categorized based on their location. See the picture below;</big></div>
    <div class=""auto-style11"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""color: black; font-family: &quot;Times New Roman&quot;; font-size: 15px; margin-left: auto; margin-right: auto; width: 314px;""><tbody>
    <tr><td class=""image-border"" style=""border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fib-09.png"" style=""height: 333px; width: 255px;"" /></td></tr>
    </tbody></table>
    <br />
    <div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    </div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""color: black; font-family: &quot;Times New Roman&quot;; font-size: 15px; margin-left: auto; margin-right: auto; width: 314px;""><tbody>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle; width: 67.2px;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet5.png"" style=""height: 42px; width: 45px;"" /></span></big></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle; width: 939.2px;""><big>Submucosal fibroids; are located just under the uterine lining.</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 306px;"" />
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet5.png"" style=""height: 42px; width: 45px;"" /></span></big></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>Intramural fibroids; lie between the muscles of the uterine wall.</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 306px;"" />
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet5.png"" style=""height: 42px; width: 45px;"" /></span></big></td><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>Cervical fibroids; these are located in the neck of the womb (the cervix).</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 306px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet5.png"" style=""height: 42px; width: 45px;"" /></span></big></td><td style=""text-align: justify; vertical-align: middle;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">Subserosal fibroids; extend from the uterine wall into the pelvic cavity.</span></big></td></tr>
    </tbody></table>
    <div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <br />
    <div style=""text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/whatodo.png"" style=""height: 70px; width: 241.75px;"" /></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><span style=""font-weight: bold;"">Women need Natural Supplements,</span>&nbsp;""they do help and they will continue to help. Herbal supplements are holistic in that they go into the body and try to correct what went wrong inside the body and they do that holistically. That is the way they help”.&nbsp;<span style=""color: #cc0000; font-weight: bold;"">Supplements are capable of not only managing the ailment, but capable of providing possible cure.</span><br /><br />Supplements also help to restore and check re-growth for those who had undergone surgery. “Definitely, a surgery for fibroid is recommended for cases which cannot be cured. In cases of surgery, where patient that is bleeding uncontrollably, or patient who has a big fibroid mass, surgery is recommended for such cases and thereafter they can go back and use supplements to prevent re-occurrence.</big></div>
    <br />
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><big><strong><span style=""color: #3333ff; font-style: italic;"">Are you ready to sacrifice your womb in the name of surgery especially if you are not yet through with child bearing?</span><br style=""font-style: italic;"" /><br style=""font-style: italic;"" /><span style=""font-style: italic;"">The good news is that you can now get rid of your Fibroids and all its related complications without surgery. Yes without Surgery.</span><br style=""font-style: italic;"" /><br style=""font-style: italic;"" /><span style=""font-style: italic;"">Take a look at the testimonials of people who once had Fibroids and used Natural Supplement I'm about to introduce to you.</span></strong></big></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 314px;""><tbody>
    <tr><td class=""image-border"" style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fib-05.png"" style=""height: 1000px; width: 314px;"" /></td></tr>
    </tbody></table>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 314px;""><tbody>
    <tr><td class=""image-border"" style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fib-06.png"" style=""height: 1000px; width: 314px;"" /></td></tr>
    </tbody></table>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fibroid%20testimony%202.png"" style=""height: 640px; width: 360px;"" /></div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fibroid%20testimony%203.png"" style=""height: 640px; width: 360px;"" /></div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fibroid%20testimony%204.jpg"" style=""height: 700px; width: 393px;"" /></div>
    <br />
    <div style=""text-align: center;"">
    <big><big><strong><span style=""font-style: italic;"">Finally Introducing 100% Proven<br /><span style=""color: #cc0000;"">Natural Supplements</span>&nbsp;That Deal<br />With Fibroid In No Time.</span></strong></big></big></div>
    </div>
    </div>
    <br />
    <div class=""auto-style18"" style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <span class=""auto-style23""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/tripplefacedown.gif"" style=""height: 66px; width: 245px;"" /></span></div>
    <div class=""auto-style18"" style=""color: #993399; font-family: Verdana; font-size: 15px; font-style: italic; text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fibroid1.jpg"" style=""height: 300px; width: 500px;"" /></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 362px;""><tbody>
    <tr style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><td colspan=""2"" rowspan=""1"" style=""text-align: justify; vertical-align: top;""><div class=""auto-style11"">
    <big style=""color: #666666;""><span class=""auto-style82""><strong>FIBROID REMOVAL Pack&nbsp;</strong></span></big><big>is a collection of Natural Supplements that helps to shrink and get rid of Fibroids, eliminate Fibroids pain and other related complications within few weeks.</big><br />
    <br />
    <big style=""color: #666666;""><span class=""auto-style82""><strong>FIBROID REMOVAL Pack&nbsp;</strong></span></big><big>contains different natural health supplements that will help you get back the perfect health that you deserve.</big></div>
    <br />
    <big style=""color: #666666;""><span class=""auto-style82""><strong>FIBROID REMOVAL Pack</strong></span></big><big><span class=""auto-style35""><strong>&nbsp;</strong></span>is a Natural Dietary Pack and it contains the following components:</big></td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top; width: 35px;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet.png"" style=""height: 36px; width: 35px;"" /></span></big></td><td style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: justify; vertical-align: top; width: 313px;""><big style=""color: #666666;""><span style=""font-weight: bold;""></span></big><big><span style=""color: #666666; font-weight: bold;"">/ Refined Yunzhi Essence:</span>HEALTH BENEFITS OF REFINED YUNZHI ESSENCE CAPSULES Refined Yunzhi Essence from Natural Turkey Tail Mushroom (Yunzhi) is made up of Yunzhi Essence, Polysaccharide Peptide – Krestin, PSP – Polysaccharide which is very essential in enhancing immunity system and improving energy and vitality. Increases the white blood cell and lymphocytes and reduces chemotherapy effects. It reduces pain during episodes of serious immune challenges and a strong cancer treatment by detering abnormal cell growth. Good for malignant melanoma, metastatic cerebroma, lung carcinoma, malignant lymphoma, Leukemia, esophagus carcinoma, mammary carcinoma and uterus carcinoma more than 40 cancers. It is a post partum medication to help contract the birth canal and very good on working on gynecological problems e.g fibroid cytes. It fights hormonal imbalance thus very good for menopausal syndromes Raises female libido and enhances orgasms and its a great Dymenorrhea that cleans and avoids painful or difficult menstruation.</big><big></big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 354px;"" />
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet.png"" style=""height: 36px; width: 35px;"" /></span></big></td><td style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: justify; vertical-align: middle;""><big style=""color: #666666;""><span class=""auto-style78""><span style=""font-weight: bold;"">ConstiRelax Solutionn</span></span></big><big><span style=""color: #666666; font-weight: bold;"">:</span>&nbsp;is made up of FOS (Fructo-oligosaccharide, Radix Astragali and Prebiotic. Regulates the functions of Microcirculation, edema, Lymphatic function and capillary filtration, &nbsp; fragility and permeability.&nbsp; breast,&nbsp; adenomyosis, premenstrual pains and other excess estrogen related issues, while also encouraging beneficial and good estrogen to boost fertility and alleviate the feeling of bloating and estrogen dominance. Helps to boost energy, support the immune system, regulate hormonal change and improve reproductive health. Alleviates Acute Hemorrhoids symptoms like swelling, bleeding and reduces seizure frequency</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 354px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/bullet.png"" style=""height: 36px; width: 35px;"" /></span></big></td><td style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: justify; vertical-align: top;""><big><span style=""color: #666666; font-weight: bold;""></span><br /></big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""></td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""></td><td style=""text-align: justify; vertical-align: top;""></td></tr>
    </tbody></table>
    <br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big><big><strong><span style=""font-style: italic;"">Supplements are Natural Products which have been accepted all over the world as a check against contamination modern living has brought.</span></strong></big></big></div>
    <br />
    <div class=""auto-style31"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: justify;"">
    <big>It is our desire to help stop Fibroid Patients from spending ridiculous amount of money on risky surgeries and other short-term treatments that doesn't last. No matter the amount of money that you spend, it cannot replace having a very good safe health.</big></div>
    <br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big><big><strong><span style=""font-style: italic;"">Therefore, You Need To Decide Today,<br />To Get Rid Of Fibroid For Good!.</span></strong></big></big></div>
    <br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
    <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-family: &quot;comic sans ms&quot;; font-size: 18px;"">This&nbsp;<span style=""color: #cc0000; font-weight: bold;"">Natural Supplements</span><span data-mce-style=""color: #ff0000;"" style=""color: red;"">&nbsp;</span>will detoxify your body system and improve your overall health. So not only will you Get Rid of Fibroid, you will also prolong your life as well.</span><br />
    <br />
    <div align=""justify"" class=""style36"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;"">Using this Natural&nbsp;<span data-mce-style=""color: #ff0000;"" style=""color: red;""><strong><span style=""color: #cc0000;"">Solution,</span></strong></span>&nbsp;you will&nbsp;<span data-mce-style=""color: #ff0000;"" style=""color: red;""><strong><span style=""color: #cc0000;"">notice drastic changes&nbsp;</span></strong></span>and not too long into the therapy, you will literally be free from the worry and pain of battling with Fibroid.<strong>&nbsp;Really, these Supplements have no side effect.</strong></span></div>
    <div align=""justify"" class=""style36"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""style36"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;""><strong><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong></span></div>
    <br />
    <div style=""text-align: center;"">
    <big><big><strong><span style=""font-style: italic;"">These Products Are Cerified By NAFDAC And Other International Organisations</span></strong></big></big></div>
    <br />
    <div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/cert-2.jpg"" style=""height: 200px; width: 362.625px;"" /></div>
    <div>
    </div>
    <div style=""text-align: center;"">
    <big style=""color: #993300;""><big><strong><span style=""font-style: italic;"">You Will Surely Laugh Last!</span></strong></big></big><br />
    <br />
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fib-10.png"" style=""height: 300px; width: 362.625px;"" /></div>
    <div class=""auto-style28"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    </div>
    <div class=""auto-style40"" style=""text-align: center;"">
    <strong><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong></div>
    <div style=""text-align: center;"">
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong><a href=""https://gainmuchhealthy.com.ng/fibroid_shrink_removal/"" style=""text-decoration-line: none;"">Natural Fibroid Pack</a></strong></span><br />
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>A Discount Price!</strong></span></div>
    <div class=""auto-style40"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style40"" style=""text-align: center;"">
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 362px;""><tbody>
    <tr><td class=""image-border"" style=""text-align: justify; vertical-align: top;""><div style=""background-color: #ccccff; font-family: &quot;Lucida Sans Unicode&quot;; text-align: center;"">
    <hr style=""height: 2px; width: 362px;"" />
    <br style=""color: #cc0000;"" />
    <big><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""><big style=""font-family: Verdana;""><big><span style=""color: black;"">N38,500</span></big></big></span></span></strong></big><br />
    <br />
    <hr style=""height: 2px; width: 362px;"" />
    </div>
    </td></tr>
    </tbody></table>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    <span class=""auto-style23""><img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/tripplefacedown.gif"" style=""height: 66px; width: 245px;"" /></span></div>
    <div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/fibroid-magic-removal_files/fibroid1.jpg"" style=""height: 300px; width: 500px;"" /></div>
    <br />
    <div style=""text-align: center;"">
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>You can't go wrong with<br />this incredible Solution!</strong></span></div>
    <br />
    <div>
    <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px;""><span style=""font-family: &quot;comic sans ms&quot;;"">I'm absolutely sure that our Fibroid Removal Pack will help you deal with your fibroid, NO-question-asked 30-day money back guaranteed.&nbsp;&nbsp;</span><br style=""font-family: &quot;Comic Sans MS&quot;;"" /><br style=""font-family: &quot;Comic Sans MS&quot;;"" /><span style=""font-family: &quot;comic sans ms&quot;;"">If for whatever any reason our Fibroid Removal Pack does not satisfy you in any way, simply send us an email within 30 days from your purchase!&nbsp; Just give it a try!</span></span></div>
    <table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 627px;""><tbody>
    <tr><td class=""image-border"" style=""text-align: justify; vertical-align: top;""><div style=""text-align: center;"">
    <br /></div>
    <div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    </div>
    </td></tr>
    </tbody></table>
    </div>
    ",
                               ID="7ee84b68-4f74-4a8f-8226-dbceca3297a4".Replace("-",""),
                                Rows = new List<Row>(){
                                   new Row(){ Body = new List<string>{ "Pregnancy Delay", "No Conception" } },
                                  new Row(){ Body = new List<string>{ "Abdominal Pain", "Tommy Protrusion" } },
                                   new Row(){ Body = new List<string>{ "Stomach Pain", "Abdominal Fatigue"} },

                                  }

                              },
                           }
               },
                 new DrugGroup(){
                   Name = "Blood Sugar",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1558989675/js_x3mkw1.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Diabetics",
                              HtmlDescription = @"<div class=""separator"" style=""clear: both; text-align: center;"">
    <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153916/Glucogone_capsule__255B1_255D_ditru7.jpg""
        imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""447""
            data-original-width=""480"" height=""297""
            src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153916/Glucogone_capsule__255B1_255D_ditru7.jpg""
            width=""320"" /></a></div>
<big style=""color: #cc0000; font-family: Verdana; text-align: center;""><big><big><span style=""color: black;""><span
                    style=""font-style: italic;""><span style=""color: #990000; font-weight: bold;""><span
                            style=""color: #cc0000;"">""What If You Don't Need Insulin Injection And Prescription
                            Drugs</span>&nbsp;<span style=""color: #000099;"">To Lower And Normalize Your Blood
                            Sugar""</span></span></span></span></big></big></big><a
    href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153650/type_2_diabetes_b_zbecm3.png"" style=""text-align: center;""><img alt=""""
        src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153650/type_2_diabetes_b_zbecm3.png""
        style=""border: 0px solid; height: 300px; width: 386.797px;"" /></a><br />
<br style=""text-align: center;"" />
<br />
<div style=""text-align: justify;"">
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Diabetes is a chronic, often
        debilitating and sometimes fatal disease, in which the body either cannot produce insulin or cannot properly use
        the insulin it produces. Insulin is a hormone that controls the amount of glucose (sugar) in the blood. Diabetes
        leads to high blood sugar levels, which can damage organs, blood vessels and nerves. The body needs insulin to
        use sugar as an energy source. It is a situation where the sugar level of the blood goes beyond
        normal.<br /><br />Diabetes could be very deceptive in the sense that one may not feel sick as the blood sugar
        rises higher than normal, but rising sugar levels can damage blood vessels in no time. Blood vessels are to the
        body what fuel hoses are to a vehicle. Imagine them being damaged.<br /><br />Diabetes is a defect in the body’s
        ability to convert glucose (sugar) to energy. Glucose is the main source of fuel for our body. When food is
        digested it is changed into fats, protein, or carbohydrates. Foods that affect blood sugars are called
        carbohydrates. Carbohydrates, when digested, change to glucose.<br /><br />When we consume carbohydrates, they
        are broken into the form of energy which the body recognizes and utilizes called Glucose. Glucose is then
        transferred to the blood where the cells use them for energy. For this transfer to take place, insulin is
        needed. The organ than produces this insulin is known as pancreas. They are produced by the better cells in the
        pancreas.<br /><br />When a person develops diabetes, the process is somewhat truncated. When production of
        insulin is insufficient, diabetes develops. This is not a palatable condition to live in or live with.<span
            style=""font-weight: bold;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                style=""font-weight: bold;""><big>Thousands Of People Like You Have Effectively Reversed Their
                    Condition!</big></span></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><span
            style=""font-weight: bold;""><br /></span><span style=""font-style: italic;""><span
                style=""font-weight: bold;"">M</span></span><span style=""font-style: italic; font-weight: bold;"">odern
            Medicine is failing miserably</span>&nbsp;to stop diabetes and to save patients' lives, this new approach is
        achieving 100% success in getting patients completely OFF diabetes medicines and related drugs, and back to a
        healthy, normal life.<br /><br />This groundbreaking protocol is the only internationally certified and proven
        holistic system that I know for reversing diabetes and pre-diabetes.<br /><br />And chances are, you won't hear
        or read about this system anywhere else, because it isn't in the interest of pharmaceutical companies or medical
        professionals for you to know about this solution.</big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><big style=""color: #993399;""><span
                    style=""font-weight: bold;"">How is that possible, you ask?&nbsp;</span></big></big><br />
        <big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><big style=""color: #993399;""><span
                    style=""font-weight: bold;"">I thought Diabetes was not reversible?</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /><span
            style=""color: #990000; font-weight: bold;"">You are right! At least, partially.</span>&nbsp;With conventional
        medicine, Diabetes will be a lifelong condition. Conventional medicine fight Diabetes through drugs that treat
        the symptoms of the disease, but never deals with the root cause of the problem. In fact, doctors acknowledge
        they have no idea how to cure Diabetes.</big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Does that make sense to you?</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br />Why would you therefore take
        drugs if doctors don't know the cure for diabetes? Yet, people do just that for every physical condition, such
        as Cancer, Heart Disease, Cholesterol, Arthritis, And Diabetes.<br /><br />When millions of people around the
        world start experiencing the same health problems (two new cases are diagnosed every 10 seconds!) something is
        seriously wrong.</big><span style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""color: #993399; font-family: &quot;Comic Sans MS&quot;;"">Something is unbalanced. And it's
                never an ""accident"".<br /><span style=""color: #cc0000;""><span style=""color: #6666cc;"">If you really
                        think about it...</span><br style=""color: #6666cc;"" /><br />We're not paying attention to the
                    SOURCE of our health problems and until we do, these problems are going to continue and even get
                    worse...</span></big></big><br />
        <big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                style=""font-weight: bold;""></span></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><span
            style=""font-weight: bold;""><br /></span></big><big
        style=""background-color: white; font-weight: 700;""><big><big><span
                    class=""auto-style116""></span></big></big></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span>
    <br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 407.2px;"">
        <tbody>
            <tr>
                <td class=""image-border""
                    style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: center; vertical-align: middle;"">
                    <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153582/pac_w7sswn.jpg""
                        style=""height: 332px; width: 390px;"" /><br />
                    <hr style=""height: 2px; width: 390px;"" />
                    <br />
                    <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153624/pac2_ocktxh.jpg"" style=""height: 289px; width: 390px;"" />
                </td>
            </tr>
        </tbody>
    </table>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><br
        style=""background-color: white; font-size: 15px; font-weight: 700;"" />
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;"">The simple and overlooked truth about Diabetes and many other modern diseases
            is that it's infinitely more important to pay attention to what is wrong in your body, than to have to deal
            with the symptoms.<br /><br />It is truly scandalous that harmful diabetes drugs like Invokana, Avandia
            (which greatly increases risk of heart attack and stroke), Actos (which raises bladder cancer risk) and
            Rezulin (recalled for causing liver failure) are pushed onto the public. Not only are these drugs worthless
            against complications, but they actually are killing diabetes patients.&nbsp;<span
                style=""font-weight: bold;"">(I'll show you the research in a moment.)</span></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Food for thought:</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br />If prescriptive drugs were the long-term solution for this disease, why
            is Diabetes now the 4th leading cause of death in the World, and the cause of many other serious health
            issues such as high blood pressure, heart attack, Alzheimer, and kidney damage?</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Now Let's Go To The Researches:</span><br /><br />&nbsp;<span
                    style=""font-weight: bold;""><span
                        style=""background-color: #cc0000; color: white;"">&nbsp;Warning:&nbsp;</span>&nbsp;<span
                        style=""color: black;"">Dangerous Diabetes Drugs Don't Work, Scientists have already proved
                        it.</span></span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><br
        style=""background-color: white; font-size: 15px; font-weight: 700;"" />
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;"">A large-scale study at Duke University School of Medicine and published in the
            New England Journal of Medicine showed that despite serious risks and dangerous side effects, diabetes drugs
            don't live up to their claims.<br /><br />Duke researchers found that the combination of the&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">blood-pressure drug Diovan (valsartan) and the
                anti-diabetes drug Starlix (nateglinide) failed to reduce risk of heart attack at
                all.</span><br /><br />Furthermore, according to the researchers, practically all anti-diabetic drugs
            result in&nbsp;<span style=""font-style: italic; font-weight: bold;"">weight gain and eventual total
                dependency upon insulin injections.</span><br /><br />Lead researcher&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">Robert Califf</span>&nbsp;of the Duke study said, ""This
            is a sobering confirmation of the need to&nbsp;<span
                style=""color: #cc0000; font-style: italic; font-weight: bold;"">focus on lifestyle
                improvements.""</span><br /><br />Also, results from the 2010 randomized&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">ACCORD CLINICAL STUDY</span>&nbsp;(a large study funded
            by US government) confirmed the danger of blood sugar lowering drugs:<br /><br />Researchers examined the
            risks for heart attack, stroke, and death in&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">10,000 diabetic patients.</span>&nbsp;Those who reduced
            their blood sugar levels the most (to 6.0% A1C or lower-considered exaggerated by doctors) had&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">a HIGHER risk of cardiovascular death and heart failure
                in patients with type 2 diabetes.</span><br /><br />As blood sugar levels dropped, there were more heart
            attacks, and more patients died. In fact, the study had to be canceled to protect the remaining
            participants. That's right, they stopped the study 18 months early because it was&nbsp;<span
                style=""color: #cc0000; font-style: italic; font-weight: bold;"">killing too many
                people!</span><br /><br />Yet the World at large continues to pay billions of dollars annually for this
            types of care for diabetes, despite clear evidence that&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">nature works better than
                medications.</span></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Please, listen carefully!</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br />Glucose lowering drugs kill more Type 2 patients than those who don't
            take them at all. Just look at this;<br /><br />A prominent study published in the prestigious&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">New England Journal of Medicine</span>&nbsp;found that
            Avandia (Rosiglitazone) increases a patient's risk of heart attack by 43% and death by a whopping 64%
            compared to patients not on the drug. This means that NOT taking Avandia actually IMPROVES a Type 2
            patient's chance of survival by more than 200%!arni</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br style=""font-style: italic; font-weight: bold;"" /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""background-color: #cc0000; color: white;""><big
                style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""></span></big></big><big><big
                style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""><span style=""background-color: #cc0000; color: white;"">&nbsp; But It Gets
                        Worse And Further Research confirmed it &nbsp;</span><span
                        style=""color: black;""></span></span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <div class=""separator"" style=""clear: both; text-align: center;"">
            <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152807/new-england-journal-of-medicine_dzhbte.png""
                imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""270""
                    data-original-width=""588"" height=""146""
                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152807/new-england-journal-of-medicine_dzhbte.png""
                    width=""320"" /></a></div>
        <br />
        <big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""font-weight: normal;""></span></big>
    </div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;"">A follow-up to the ACCORD study published again in the prestigious&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">New England Journal of Medicine</span>&nbsp;reports that
            blood pressure drugs routinely prescribed to diabetics increased the risk of strokes, heart attacks and
            deaths by 50%&nbsp; and fibrate/statin cholesterol-lowering therapy failed to reduce the risk of
            cardiovascular disease.<br /><br /><span style=""font-style: italic; font-weight: bold;"">Please
                Listen:</span>&nbsp;No drug in the world can successfully treat your diabetes, no matter what the Big
            Pharmaceutical Companies are&nbsp; promising. In fact, drugs are often worse than ineffective, they can even
            make your life miserable or even be more risky than diabetes itself (if you've been diabetic for up to a
            year, I belief you can attest to this fact yourself).</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br style=""font-style: italic; font-weight: bold;"" /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153550/avandia_drug_olplgs.jpg""
                        style=""height: 200px; width: 300px;"" /><br />Think about Avandia,</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br />whose research I just showed you... This diabetes medicine, once the most
            popular diabetes drug in the world, was found in 2008 to dramatically increase risk of heart attacks and
            death . Yet it's still being prescribed today.<br /><br />Since the main reason for taking diabetes drugs is
            to prevent diabetic complications, and cardiovascular disease is by far the most important of these
            complications, you certainly don't want to be taking a diabetes drug that increases your chance of getting a
            heart attack or stroke!</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Another population diabetes drug, Actos!</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;"">Has its own array of ugly side effects, including average weight gain of nearly
            9 pounds (it's true, some diabetes drugs encourage your body to gain weight) and a higher risk of dangerous
            and possibly deadly fluid buildups. Furthermore, Actos's heart risks may be almost as bad as Avandia's, and
            some researchers have linked this drug to bladder cancer.<br /><br />In the US, FDA has even issued this
            warning:&nbsp;<span style=""font-style: italic; font-weight: bold;"">""The use of the diabetes medication Actos
                (pioglitazone) may be associated with an increased risk of bladder cancer.""</span></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #990000; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""color: #cc0000;""><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">So, what's the solution then ?</span></big></big></div>
    <big style=""background-color: white; color: #990000; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br />The solution to all of these is to get back into your&nbsp;<span
                style=""font-style: italic; font-weight: bold;"">natural state of vibrant health, by ""cleansing"" yourself
                from the inside, allowing your body to get rid of the toxins</span>&nbsp;that are taxing your cells, to
            enable them to start functioning properly again.<br /><br />You see, for every disease, your immune system
            is triggered and it immediately starts fighting it. Your body can restore every wound, diseased organ or
            damaged cell that it needs to, but it cannot do that if you keep polluting it, your body simply can't keep
            up!</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""background-color: #cc0000; color: white;""><big
                style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""></span></big></big><big><big
                style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""><span style=""background-color: #cc0000; color: white;"">Take Back Your
                        Life! You Deserve To Be Healthy and Happy! Vibrant Health is Your Birthright!</span><span
                        style=""color: black;""></span></span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span>
    <br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">According to current statistics,</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style48""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 3.75403e-39px; font-weight: 700;"">
        <big><strong></strong></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 491.2px;"">
        <tbody>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td style=""text-align: center; vertical-align: middle;""><big><span class=""style209""
                            style=""color: #009900;""><img alt=""""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153522/arrow-right-2_imxbly.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;"">
                    <big>More than two million new cases of Type 2 Diabetes are diagnosed each year.</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle; width: 38.4px;"">
                    <big><span class=""style209"" style=""color: #009900;""><img alt=""""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153522/arrow-right-2_imxbly.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle; width: 440px;"">
                    <big>One person dies every 10 seconds from its nasty complications.</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle;"">
                    <big><span class=""style209"" style=""color: #009900;""><img alt=""""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153522/arrow-right-2_imxbly.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;"">
                    <big>Right now, more than 7 million (known) Nigerians are walking around with this silently
                        destructive disease and most are completely unaware!</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
        </tbody>
    </table>
    <span class=""style46"" style=""background-color: white; font-size: 15px; font-weight: 700;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span>
    <br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Please Don't Become Another<br />Statistic Of The Diabetes
                    Epidemic!</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;"">Take control of your health because what really matters right now is YOU.
            Because statistics don't tell your story. How every day you have to constantly worry about getting your
            blood sugar right. The stress and anxiety that come with managing your condition. Living with diabetes is
            devastating and nerve-racking both physically and emotionally. AND, from doctor visits to medications, the
            ongoing list of diabetes expenses can quickly add up.<span
                style=""font-weight: bold;""></span></span></big><big
        style=""background-color: white; font-weight: 700;""><big
            style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                style=""font-weight: bold;""></span></big></big><br />
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style48""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 3.75403e-39px; font-weight: 700;"">
        <big><strong></strong></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 491.2px;"">
        <tbody>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td style=""text-align: center; vertical-align: middle;""><big><span class=""style209""
                            style=""color: #009900;""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153346/check_ecxr7p.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;"">
                    <big>Take responsibility for your own life. Your doctor can only feel your pain, he/she doesn't know
                        how much you are suffering.&nbsp;</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle; width: 38.4px;"">
                    <big><span class=""style209"" style=""color: #009900;""><img alt=""""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153346/check_ecxr7p.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td
                    style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle; width: 440px;"">
                    <big>He/she doesn't know how much you mean to yourself and family.</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
            <tr>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: middle;"">
                    <big><span class=""style209"" style=""color: #009900;""><img alt=""""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153346/check_ecxr7p.png""
                                style=""height: 37px; width: 38px;"" /></span></big></td>
                <td style=""font-family: &quot;Comic Sans MS&quot;; text-align: justify; vertical-align: middle;""><big>He
                        only knows it's important to keep you alive, he doesn't know how important it is for you to live
                        a healthy live.</big></td>
            </tr>
            <tr>
                <td colspan=""2"" rowspan=""1"" style=""vertical-align: top;"">
                    <hr style=""height: 2px; width: 484px;"" />
                </td>
            </tr>
        </tbody>
    </table>
    <span class=""style46"" style=""background-color: white; font-size: 15px; font-weight: 700;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span>
    <br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">Listen To What International<br />Experts Are Saying!</span></big></big>
    </div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style48""
        style=""background-color: white; font-family: &quot;Trebuchet MS&quot;, &quot;Lucida Sans Unicode&quot;, &quot;Lucida Grande&quot;, &quot;Lucida Sans&quot;, Arial, sans-serif; font-size: 3.75403e-39px; font-weight: 700;"">
        <big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""font-weight: normal;"">With millions even
                billions of dollars of profits at stake, it's absolutely no wonder that the Big Pharmaceuticals
                desperately hope you (and millions of other diabetics) never find out about this breakthrough diabetes
                research!</span></big></div>
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 491.2px;"">
        <tbody>
            <tr>
                <td class=""image-border""
                    style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;"">
                    <div style=""text-align: center;"">
                        <span style=""font-family: &quot;comic sans ms&quot;;""><img alt="""" hspace=""5""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153319/dr-daniel-nuchovich_xiimtw.jpg""
                                style=""border: 1px solid; height: 173px; width: 154px;"" vspace=""5"" /></span><br />
                        <span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
                    <span style=""font-family: &quot;comic sans ms&quot;; font-style: italic;"">""As a doctor who has
                        treated Diabetes for nearly thirty years, I can tell you with certainty that the standard
                        medical protocols and management of this illness are not only INAPPROPRIATE, they're ABSURD. Dr
                        Daniel Nuchovich, MD, director of Jupiter Gardens Medical Center</span><span
                        style=""font-style: italic;"">.</span>
                </td>
            </tr>
        </tbody>
    </table>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 491.2px;"">
        <tbody>
            <tr>
                <td class=""image-border""
                    style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;"">
                    <div style=""text-align: center;"">
                        <span style=""font-family: &quot;comic sans ms&quot;;""><img alt="""" hspace=""5""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153287/herbert_l_ley_u8fwya.jpg""
                                style=""border: 1px solid; height: 173px; width: 154px;"" vspace=""5"" /></span><br />
                        <span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
                    <span style=""font-family: &quot;comic sans ms&quot;; font-style: italic;"">Drug companies are intent
                        on keeping the consumer on drugs... for the simple requirement of profit. Dr. Drummond Rennie,
                        Journal of the American Medical Association</span><span style=""font-style: italic;"">.</span>
                </td>
            </tr>
        </tbody>
    </table>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2""
        style=""background-color: white; margin-left: auto; margin-right: auto; width: 491.2px;"">
        <tbody>
            <tr>
                <td class=""image-border""
                    style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;"">
                    <div style=""text-align: center;"">
                        <span style=""font-family: &quot;comic sans ms&quot;;""><img alt="""" hspace=""5""
                                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153744/jmercola_ccyeyn.jpg""
                                style=""border: 1px solid; height: 173px; width: 154px;"" vspace=""5"" /></span><br />
                        <span style=""font-family: &quot;comic sans ms&quot;;""></span></div>
                    <span style=""font-family: &quot;comic sans ms&quot;; font-style: italic;"">""My personal experience
                        with diabetes made it VERY clear to me that virtually every case of type 2 diabetes is 100
                        percent reversible."" - Dr. Joseph Mercola, M.D.</span><span style=""font-style: italic;"">.</span>
                </td>
            </tr>
        </tbody>
    </table>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">So Why Aren't You Hearing About This? Why Isn't THIS Headline News
                    Broadcast On Every News Channel, Every Radio Station, Every Newspaper Or Taught In Every Medical
                    School And Used As A Standard Treatment In Every Doctor's Office!</span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: 700;""><br /></span><big
        style=""background-color: white; font-weight: 700;""><span
            style=""font-family: &quot;comic sans ms&quot;; font-weight: normal;"">But please understand, it's not that
            physicians are bad or uncaring, the system is trying to treat diseases of lifestyle with medications which
            just doesn't make any sense. We don't have a Health Care system, we have a Sick Care system and a Disease
            Management system.<br /><br />Listen, Doctors are well-intentioned and hard-working people, and everyone in
            the system is doing their job efficiently, we just designed the jobs wrong. We pay doctors for how many
            patients they manage to see and for the quantity of medical care provided to each patient (dispensing more
            drugs, more tests, more labs, more procedures), but not for succeeding in healing people or keeping them
            healthy.<br /><br />Doctors tend to do what they get paid to do, and they get trained to do what they get
            paid to do. So the problem is not the people; it's the system that's broken. And certainly they are NOT
            reimbursed for patient education.<br /><br />Bottom line: Diabetes is the biggest health epidemic we have
            and the standard medical treatment is focused on medications and insulin and it's simply the WRONG approach.
            Restoring healthy blood sugar levels and reversing diabetes is simple if you give your body what it needs.
            And you can achieve that in a few weeks from now.<br /><br />That's right: Reversing Diabetes is quite
            simple and straightforward using basic biochemical cause and effect. The only reason people don't beat their
            Diabetes is because; they don't know about this information, and big Medicine doesn't teach anybody this
            information. Drug companies would much prefer to keep you dependent on drugs. The moment you beat Diabetes,
            they lose a customer.&nbsp;</span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""><br /></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;"">It's time to stop poisoning yourself!<br />It's time to kick Diabetes out
                    of your life!<br /><br /><span style=""color: #cc0000;"">&nbsp;That Is Why Am INTRODUCING
                        You</span><br style=""color: #cc0000;"" /><span style=""color: #cc0000;"">To The Nature Made
                        Diabetes Therapy.</span></span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style18"" style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <span class=""auto-style23""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151639/tripple_facedown_l0q4jk.gif""
                style=""height: 100px; width: 245px;"" /></span><br />
        <div class=""separator"" style=""clear: both; text-align: center;"">
            <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152993/BF_2BSUMA_2Bdiabetes_2B_n6x9x8.jpg""
                imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""632""
                    data-original-width=""1080"" height=""187""
                    src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152993/BF_2BSUMA_2Bdiabetes_2B_n6x9x8.jpg""
                    width=""320"" /></a></div>
    </div>
    <div style=""text-align: center;"">
    </div>
    <div class=""auto-style18""
        style=""background-color: white; color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;; font-size: 15px; font-weight: 700; text-align: center;"">
        <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559153174/3q_cljvj0.jpg"" style=""height: 150px; width: 290.094px;"" /></div>
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
        <strong><strong></strong></strong></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            class=""auto-style163"" style=""font-size: 12pt;""><em></em></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
        <strong><strong></strong></strong></div>
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px;"">
        <big><strong style=""color: #cc0000;""><span class=""auto-style135""></span></strong>This natural therapy offers a
            100% natural, safe, and powerful treatment that eliminates the ROOT cause of your Diabetes. There's nothing
            like this that exists anywhere else-on or off the web and I'm honored for the opportunity to share it with
            you.<br /><br />This pioneering remedy is the outcome of countless studies conducted over the past three
            decades by teams of internationally-respected scientists and diabetes' specialists, including Prof. John
            Mash of Corneil University, NYC. As a result, thousands of people who were in your EXACT same situation are
            now living symptom-free.</big></div>
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""><span style=""color: #cc0000;"">Decide TODAY To Get OFF</span><br
                        style=""color: #cc0000;"" /><span style=""color: #cc0000;"">Your Drugs For
                        Good!</span></span></big></big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px;"">
        <big>This therapy will also give you healthy cholesterol levels and lower blood pressure naturally. So not only
            will you rid off your blood sugar, you will drop your risk of heart disease and stroke as well! Tinkering
            with blood pressure and cholesterol in a patient who already has dysfunctional blood sugar is ineffective
            and dangerous. And all these studies prove it. Unfortunately, patients will keep dying until they heal
            diabetes at the most fundamental level.</big></div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div style=""background-color: white; color: #993399; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big style=""font-family: &quot;Comic Sans MS&quot;; font-weight: normal;""><span
                    style=""font-weight: bold;""><span style=""color: #cc0000; font-style: italic;"">This Is A Natural
                        Therapy With International<br />and Nigeria Seals Of Certification.</span></span></big></big>
    </div>
    <big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><big
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: 700;""><span
            style=""font-weight: normal;""></span></big><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <div class=""separator"" style=""clear: both; text-align: center;"">
        <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151856/certi_taj0ex.jpg"" imageanchor=""1""
            style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""143""
                data-original-width=""625"" height=""73""
                src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151856/certi_taj0ex.jpg"" width=""320"" /></a>
    </div>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br />
    <div align=""center"" class=""MsoNormal""
        style=""background-color: white; color: #993399; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: bold;"">
        <big><big><big><span class=""auto-style116""></span></big></big></big></div>
    <span
        style=""background-color: white; color: #6666cc; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: bold;""></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span><br /><span
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px;"">By using the
        combination inside the&nbsp;</span><strong
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px;""><em>Diabetes Wellness
            Pack above</em></strong><span
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px;"">, you
        will&nbsp;</span><span class=""auto-style117""
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-style: italic;""><strong>notice
            changes in your blood sugar level</strong></span><span
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px;"">&nbsp;which help
        reduce the effect of being diabetic.</span><br />
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px;"">
        <big>As you start to use it, you will start noticing changes in your body system and you will also be astonished
            at how far you would have gone in helping to get rid of your diabetes.<o:p></o:p></big></div>
    <div class=""auto-style103""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px;"">
        <big>And overtime, you will literally have to stop taking those medications as this natural supplement will be
            performing better than the industrial chemically produced synthetic drugs<o:p>. This supplement has no side
                effect.</o:p></big></div>
    <span
        style=""background-color: white; font-family: &quot;comic sans ms&quot;; font-size: 15px; font-weight: 700;""><br /></span><span
        style=""background-color: white; font-size: 15px; font-weight: 700;""></span>
    <br />
    <div style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <big style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;"">Okay, I'm Ready! But How Much
                is This Going To Cost Me To Get Diabetes Wellness Pack Delivered to me at My Doorstep?</span></big>
    </div>
    <div class=""auto-style11""
        style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; widows: 1;"">
        Have you ever taken time to think about how happy you will be if you finally get rid of all Forms of Diabetes in
        your Body System especially with this Diabetes Wellness Pack(a Most Effective and Result Oriented Natural
        Diabetes Therapy).&nbsp;</div>
    <div class=""auto-style11""
        style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; widows: 1;"">
        I want you to consider the value of what you are getting. It will save you lots of time, efforts and will
        finally put a smile on your face.</div>
    <div class=""auto-style18""
        style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: 15px; font-weight: 700; text-align: center;"">
        <big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
    <div class=""auto-style18"" style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
        <span class=""auto-style23""><img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559151639/tripple_facedown_l0q4jk.gif""
                style=""height: 100px; width: 245px;"" /></span></div>
    <div style=""text-align: center;"">
        <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
            style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong><small>Therefore, Get
                    Our Natural Diabetes Wellness Pack Today For Your Optimum Body
                    Function.&nbsp;</small></strong></span><br />
        <div>
            <div class=""separator"" style=""clear: both; text-align: center;"">
                <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152993/BF_2BSUMA_2Bdiabetes_2B_n6x9x8.jpg""
                    imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0""
                        data-original-height=""632"" data-original-width=""1080"" height=""187""
                        src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559152993/BF_2BSUMA_2Bdiabetes_2B_n6x9x8.jpg""
                        width=""320"" /></a></div>
        </div>
        <br />
        <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
            style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong><small>These Products
                    Combination Above Can Be Delivered To Your Door Step At A</small><span
                    style=""color: #990000;""><small><span style=""color: black;"">&nbsp;Discounted Price
                            Of;</span></small></span></strong></span><big><big><span
                    data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
                    style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong></strong></span></big></big><br />
        <table border=""1"" cellpadding=""0"" cellspacing=""0"" id=""table2""
            style=""border-collapse: collapse; border-radius: 7px; border: 3px solid black; box-shadow: rgb(0, 153, 0) 5px 5px; padding: 15px; width: 450px;"">
            <tbody>
                <tr>
                    <td
                        style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 192px;"">
                        <big><br />Desired/Duration<br />Usage Pack</big></td>
                    <td
                        style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 129px;"">
                        <big><br />Quantity To Be<br />Delivered</big></td>
                    <td
                        style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 154px;"">
                        <big><br />Total Cost In<br />Naira (#)</big></td>
                </tr>
                <tr>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <big style=""color: red;""><big><big><big>1</big></big></big></big><br />
                        Usage<br />
                        Pack</td>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        1 bottle of each<br />
                        of the products<br />
                        above will be<br />
                        delivered</td>
                    <td
                        style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <big><span style=""text-decoration-line: line-through;""><br /></span></big>
                        <br />
                        <div class=""circle c1""
                            style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                            <br />
                            <span style=""color: red;"">#38,500</span></div>
                        <big><span style=""text-decoration-line: line-through;""></span></big>
                    </td>
                </tr>
                <tr>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <big style=""color: red;""><big><big><big>2</big></big></big></big><br />
                        Usage<br />
                        Pack</td>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        2 bottle of each<br />
                        of the products<br />
                        above will be<br />
                        delivered</td>
                    <td
                        style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <br />
                        <div class=""circle c1""
                            style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                            <br />
                            <span style=""color: red;"">#75,000</span></div>
                    </td>
                </tr>
                <tr>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <big style=""color: red;""><big><big><big>3</big></big></big></big><br />
                        Usage<br />
                        Pack</td>
                    <td
                        style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        3 bottle of each<br />
                        of the products<br />
                        above will be<br />
                        delivered</td>
                    <td
                        style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">
                        <br />
                        <div class=""circle c1""
                            style=""background-color: black; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
                            <br />
                            <span style=""color: red;"">#111,500</span></div>
                    </td>
                </tr>
            </tbody>
        </table>
        <br />
        <div style=""text-align: justify;"">
            <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px; font-style: italic;""><span
                    style=""font-family: &quot;comic sans ms&quot;;""><span
                        style=""color: #990000; font-weight: bold;"">Please Note:</span>&nbsp;How long you will be taken
                    the above products combination is greatly depends on the severity of your Symptoms (either Mild or
                    Complex). But irrespective of the severity, your Diabetes Health will be reversed within 3 months of
                    usage.</span></span></div>
        <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;""
            style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong></strong></span>
    </div>
    &nbsp;&nbsp;<span style=""font-family: &quot;verdana&quot;; font-weight: bold;""><span
            style=""color: #990000;""></span></span><br />
    <span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-size: 18px; font-style: italic;""><span
            style=""font-family: &quot;comic sans ms&quot;;""><span style=""color: #990000; font-weight: bold;"">Also
                Note:</span>&nbsp;This incredible discounted price offer is open for the next few days and it comes
            with<span style=""color: #000099;"">&nbsp;</span><span style=""color: #000099; font-weight: bold;"">Free
                Shipping with No Extra Delivery Charges.</span><span
                style=""color: #990000; font-weight: bold;""></span>&nbsp;These products are manufactured in Los Angeles
            U.S.A and has been certified by several International Bodies including our own NAFDAC in
            Nigeria.<br />&nbsp;&nbsp;</span></span>
</div>",
                              ID="88ed0f17-e403-4e72-8924-ae7a9b3f73c7".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Insulin Resistance", "Insulin Deficiency" } },
                              }
                          },
                           new Ogun()
                           {
                               Header = "High Blood Pressure",
                               HtmlDescription = @"<big style=""font-family: Verdana; font-style: italic; font-weight: bold; text-align: center;""><big><big><big>Do You Care About Lowering Your High Blood Pressure Naturally Within 4 Weeks? If&nbsp; Yes, Then You Need To Pay Attention!</big></big></big></big><br />
<br style=""text-align: center;"" />
<big style=""color: #cc0000; font-family: Verdana; font-weight: bold; text-align: center;""><big><big><span style=""color: #333399; text-decoration-line: underline;"">The High Blood Pressure&nbsp;</span></big></big></big><big style=""color: #cc0000; font-family: Verdana; font-weight: bold; text-align: center;""><big><big>Effective Natural&nbsp;</big></big></big><big style=""color: #cc0000; font-family: Verdana; font-weight: bold; text-align: center;""><big><big>Solution You Desperately Need Is Here!</big></big></big><span style=""font-family: &quot;arial rounded mt bold&quot;; font-size: 25pt; text-align: center;""><span style=""font-weight: bold;""><span style=""font-style: italic;""><span style=""color: #cc0000;""><span style=""color: black;""></span></span></span></span></span><br />
<br style=""text-align: center;"" />
<big style=""color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;; text-align: center;""><big><big><span style=""color: #6600cc;""></span></big></big></big><big style=""text-align: center;""><span class=""auto-style6""></span></big><span style=""background-color: white; text-align: center;""></span><br />
<div style=""text-align: justify;"">
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>Dear Sir/Ma, high blood pressure is often called the&nbsp;<span style=""color: #000099; font-weight: bold;"">“Silent Killer”</span>&nbsp;because most people don’t even know they have it and they can die without a warning. Therefore,&nbsp; lowering your High Blood Pressure Naturally&nbsp; is possible and it's simpler than what you think. Therefore, sit back, relax and read every word on this page.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; text-decoration-line: underline;""><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big></span></div>
<table border=""0"" cellpadding=""10"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); margin-left: auto; margin-right: auto; padding: 5px; width: 348px;""><tbody>
<tr><td colspan=""2"" rowspan=""1"" style=""text-align: center; vertical-align: top;""><img alt="""" hspace=""0"" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/hbp_2.jpg"" style=""border: 0px solid; height: 270px; width: 324px;"" vspace=""0"" /></td></tr>
</tbody></table>
<br />
<div>
<span class=""auto-style10""></span></div>
<div style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; text-align: center;"">
<big><span class=""auto-style6""><span style=""font-weight: bold;"">Below are facts you should know about High Blood Pressure!</span></span></big><span style=""font-size: 14pt; font-weight: bold; line-height: 28px;""></span></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; text-decoration-line: underline;""><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big></span></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); margin-left: auto; margin-right: auto; padding: 5px; width: 348px;""><tbody>
<tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/dot1.png"" style=""height: 20px; width: 23px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">45% of death in Nigeria is due to heart problems.</span></big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/dot1.png"" style=""height: 20px; width: 23px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">51% of death globally is due to stroke</span></big>.</td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/dot1.png"" style=""height: 20px; width: 23px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">According to World health Organization (WHO), 46% of adult ages 25 years and above has the highest prevalent of High Blood Pressure.</span></big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/dot1.png"" style=""height: 20px; width: 23px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">High blood pressure affect at least one in three men and one in four women.</span></big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 340px;"" />
</td></tr>
<tr><td style=""vertical-align: top;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/dot1.png"" style=""height: 20px; width: 23px;"" /></td><td style=""text-align: justify; vertical-align: top;""><big style=""font-family: &quot;Comic Sans MS&quot;;"">According to the American Heart Association, High blood pressure is the No 1 risk factor for stroke. It also contributes to heart attacks, heart failures, kidney failures and atherosclerosis (fatty buildups in arteries). In some cases, it can cause blindness.</big></td></tr>
</tbody></table>
<big><span class=""auto-style6""><span style=""font-weight: bold;""><br /></span></span></big>
<br />
<div style=""text-align: center;"">
<big style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-style: italic;""><span class=""auto-style6""><span style=""font-weight: bold;"">Below are results from Complicated High Blood Pressure!</span></span></big><span style=""color: #cc0000; font-family: &quot;comic sans ms&quot;; font-size: 14pt; font-style: italic; font-weight: bold; line-height: 28px;""></span></div>
<big><span class=""auto-style6""></span></big><br />
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; text-decoration-line: underline;""><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big></span></div>
<table border=""0"" cellpadding=""10"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); margin-left: auto; margin-right: auto; padding: 5px; width: 348px;""><tbody>
<tr><td colspan=""2"" rowspan=""1"" style=""text-align: center; vertical-align: middle;""><img alt="""" hspace=""0"" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/hypertension.jpg"" style=""border: 0px solid; height: 319px; width: 324px;"" vspace=""0"" /><big><span class=""auto-style6""><span style=""font-weight: bold;""></span></span></big><big><span class=""auto-style6""><span style=""font-weight: bold;""></span></span></big><span style=""font-size: 14pt; font-weight: bold; line-height: 28px;""></span></td></tr>
</tbody></table>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>I believe you can see from the picture above how serious High Blood Pressure is, and why there is need for you to start looking at possible Natural Remedy that is available to you now, to ensure you don’t fall victim to the complications of High Blood Pressure shown in the picture above.<br /><br />As a researcher and a lover of the Natural Health Field, I have gained a lot of experience over the years and&nbsp;<span style=""color: #cc0000; font-style: italic; font-weight: bold;"">I can authoritative tell you that</span><span style=""font-style: italic;""><span style=""font-weight: bold;"">&nbsp;</span></span><span style=""font-weight: bold;"">w</span>hen you go through the natural approach of taking care of your health, you will be in more better shape than you have ever be before.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>Take the case of one of my clients who was type 2 diabetic and at the same time having High Blood Pressure whom after following my recommendations brought down her High Blood Pressure and High Blood Sugar to normal level. It’s all simple and a matter of you knowing exactly what needs to be done!</big></div>
</div>
<div style=""text-align: justify;"">
<div style=""font-family: &quot;Comic Sans MS&quot;;"">
</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; widows: 1;"">
<big><strong style=""color: #993399;""></strong><span style=""font-weight: bold;""></span></big></div>
<span class=""style46""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style78""></span></big><span class=""auto-style10""><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></span><big><span style=""font-family: &quot;comic sans ms&quot;;"">Information is power and can be more powerful than medicine atimes if you really make use of it. To every problem, there is alway a solution.&nbsp;</span></big><big style=""font-family: &quot;Comic Sans MS&quot;;"">Nothing is more painful than a missed privilege that brings healing and freedom from series of health challenges and restriction due to negligence.<br /><br />Your High Blood Pressure Health Challenges is a wake-up call for you to discover a new insight, that will add to your wealth of knowledge and walk you out of your Hypertension Health Challenges.<span style=""font-weight: bold;""></span></big><strong></strong></div>
<div class=""auto-style18"" style=""color: #6633ff; font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big style=""color: #cc0000; font-style: italic;""><strong>This is why I'm introducing you to, the only Natural Solution to High Blood Pressure Popularly known as Hypertension</strong></big><big><strong style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""background-color: yellow;""><span style=""color: #cc0000;""></span></span></strong></big></div>
<div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center;"">
JUST EXACTLY WHAT YOU ARE THINKING<br />
<strong>YES! THIS IS AMAZING</strong>!</div>
<div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
<big><big><big><big><span class=""auto-style23 blink_text"" style=""animation: 1s linear 0s infinite normal none running; color: #cc0000; font-size: 25px;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/bf-hbp.jpg"" style=""height: 313px; width: 534px;"" /></span></big></big></big></big></div>
<div class=""auto-style18 blink_text"" style=""animation: 1s linear 0s infinite normal none running blinker; background-color: white; color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;; font-size: 15px; font-weight: 700; text-align: center;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/3q.jpg"" style=""height: 140px; width: 290.094px;"" /></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: center;"">
<big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: center;"">
<big><span class=""auto-style82""><strong>HBP Solution Pack</strong></span><span class=""auto-style78"">&nbsp;is a Natural Supplement Pack that can help you maintain your Blood Pressure and keep it in Normal Level, it Promotes blood circulation and gives more energy.</span></big></div>
<div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: center;"">
<big></big><big><span class=""auto-style82""><strong>HBP Solution Pack</strong></span></big><big><span class=""auto-style82""><strong>&nbsp;</strong></span><span class=""auto-style78"">is made up of strictly natural ingredients. It has No negative side effects rather than improving overall body health and detoxifies body system as well.<br /><span class=""auto-style35""><strong></strong></span></span></big><big><strong></strong></big><span class=""auto-style13""></span></div>
<div class=""MsoNormal"" style=""text-align: justify;"">
<strong style=""font-style: italic;""><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></strong><span style=""font-family: &quot;comic sans ms&quot;;""><o:p></o:p></span></div>
<div style=""text-align: justify;"">
<span class=""auto-style10""></span><span class=""auto-style10""></span><br />
<div class=""auto-style23"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<span class=""auto-style10""><big><strong></strong></big></span></div>
<span class=""auto-style10"">
</span></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
</div>
<div style=""text-align: justify;"">
<div>
</div>
<big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #006600; font-style: italic;""><span style=""color: #009900;""><span style=""color: black;"">Hypertension Does Not Go Away On Its Own, Take Charge of Your Cardiovascular Health. Don't wait until you actually have a heart attack! Do something about this reversible health condition right now!&nbsp;</span>Therefore, treat your Blood Circulatory System with what they deserve, and look Healthy with this Superior Collection –</span>&nbsp;</span><span style=""color: #cc0000; font-style: italic;"">HBP Solution Pack.</span></big><br />
<big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #cc0000; font-style: italic;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #cc0000; font-style: italic;""><br /></span>The above three (4) products combination that made up of HBP Solution Pack will last for a month on purchase and to be taken morning and evening after food. During this one month, your Blood Pressure will be normalized and your overall health will be greatly improved. Honestly, a trial of our HBP Solution Pack will surely make you smile.</big></div>
<div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
So, what makes&nbsp;<span style=""color: #cc0000;"">""HBP Solution Pack""</span>&nbsp;safe to use and why do I even recommend it for you? The answer is simple!</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
The above products combination have the prestigious Kosher Seal (which makes them acceptable to the Jews. The Jews don’t take anything that isn’t 100% natural. Infact, they don’t even take bread with yeast! They believe in no additives.</div>
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big>They also have other seals including the seal of International Aloe Science Council, Halal and Islamic seals, these are seals of highest form of purity including our own NAFDAC in Nigeria.</big></div>
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/cert.jpg"" style=""height: 195px; width: 410.969px;"" /></div>
<div style=""text-align: center;"">
<big style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""><strong>“How Much is HBP Solution Pack Is Going To Cost You<br />To Get The It Delivered To You At Your Doorstep?”</strong></span></big></div>
<div style=""text-align: justify;"">
</div>
<div class=""auto-style28"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big>Have you ever taken time to think about how relieved and happy you will be if you finally get rid of High Blood Pressure and its complications from your Body System especially with our HBP Solution Pack (a Most Effective and Result Oriented Natural Hypertension Therapy) and you were finally able to overcome all your High Blood Pressure Health Challenges<span style=""font-weight: bold;"">.</span><strong style=""color: red;""></strong></big></div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: center; widows: 1;"">
<span style=""font-family: &quot;comic sans ms&quot;;"">This simply means, with our HBP Solution Pack:</span></div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: center; widows: 1;"">
<span style=""font-family: &quot;trebuchet ms&quot; , &quot;lucida sans unicode&quot; , &quot;lucida grande&quot; , &quot;lucida sans&quot; , &quot;arial&quot; , sans-serif;""></span></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 410px;""><tbody>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will never have to complain about severe headache.</big><span style=""font-size: large;""></span></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will never have to complain about dizziness</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will never have to complain about bleeding nose.</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will never have to complain about poor sleep.</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will never have to complain about poor mood.</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/arrow-right-2.png"" style=""height: 20px; width: 23px;"" /></td><td style=""font-family: &quot;Comic Sans MS&quot;; vertical-align: middle;""><big>You will experience all-round peace.</big></td></tr>
<tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 2px; width: 402px;"" />
</td></tr>
</tbody></table>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Courier New&quot;, Courier, monospace; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<span style=""font-style: italic;""><span style=""font-weight: bold;""></span></span></div>
<div style=""text-align: justify;"">
</div>
<div style=""text-align: justify;"">
</div>
<div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
<span class=""auto-style78"">Before you answer that question, I want you to consider the value of what you are getting. It will save you lots of money, time and efforts.</span>This is why I'm giving you&nbsp;<span style=""font-style: italic;""><span style=""font-weight: bold;"">HBP Solution Pack<span style=""color: #cc0000;""></span></span></span><span style=""color: #cc0000; font-style: italic; font-weight: bold;""></span><span style=""color: #cc0000;"">&nbsp;</span>at a heavily discounted Price,</div>
<div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
<div class=""auto-style40"" style=""text-align: center;"">
<strong><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong></div>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 362px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""font-family: &quot;Lucida Sans Unicode&quot;; text-align: center;"">
<big><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span></strong></big><span style=""color: #993399; font-family: &quot;comic sans ms&quot;;""></span><br />
<div class=""circle c1"" style=""background-color: black; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-transform: uppercase; width: 200px;"">
#32,500</div>
<big style=""color: #993399; font-family: &quot;Comic Sans MS&quot;;""><strong>This Discounted Price,&nbsp;</strong></big><br />
<big style=""color: #993399; font-family: &quot;Comic Sans MS&quot;;""><strong><strong></strong></strong></big><big style=""color: #993399; font-family: &quot;Comic Sans MS&quot;;""><strong>Open for just few days Only.<br />You are just Damn Lucky</strong></big></div>
</td></tr>
</tbody></table>
<div class=""auto-style18"" style=""text-align: center;"">
<strong></strong></div>
<span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic; text-align: center;""><strong></strong></span><span style=""background-color: white; text-align: center;""></span><big style=""font-style: italic; text-align: center;""><span class=""style17""><span class=""style146""><span class=""auto-style16""><span class=""auto-style6""></span></span></span></span><span class=""auto-style10""></span></big><span style=""background-color: white; text-align: center;""></span><span class=""auto-style10"" style=""text-align: center;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;""><span style=""color: #993399; font-weight: bold;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;""><span class=""style17""><span class=""style146""><span class=""auto-style16""><span class=""auto-style6""><span class=""auto-style13""><span style=""font-weight: bold;""><span style=""color: red;""></span></span></span></span></span></span></span></big><span style=""background-color: white; text-align: center;""></span><span style=""font-family: &quot;comic sans ms&quot;; text-align: center;""><span style=""font-style: italic;""></span></span><span style=""background-color: white; text-align: center;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;""><span class=""auto-style78""></span></big><span style=""background-color: white; text-align: center;""></span><span class=""style46"" style=""text-align: center;""></span><span style=""background-color: white; text-align: center;""></span><span style=""font-family: &quot;comic sans ms&quot;; text-align: center;""></span><span style=""background-color: white; text-align: center;""></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;""><strong></strong></big><span style=""font-family: &quot;comic sans ms&quot;; text-align: center;""><big>Again, I'm giving you a chance to get it at the low price of #32,500 for Just Next few Days Only, after which the price will go up to its normal retail price of&nbsp;</big><big>₦44</big><big>,500. So don't waste time! Your limited timed price for the next few days is only&nbsp;</big><big>₦</big><big>32,500.</big></span><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;""><br /></big><big style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">If you know that you want to live a healthier life that helps you in dropping off your High Blood Pressure within the next few weeks, then you need to get our HBP Solution Pack today. Therefore, what are you waiting for?</big><br />
<br />
<div style=""text-align: justify;"">
<table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 548px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""text-align: center;"">
<br />
<br />
</div>
<br />
<div style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""color: #cc0000; font-style: italic;""><strong><span class=""auto-style95""><big><big><span style=""font-family: &quot;verdana&quot;;"">DON'T WAIT A MOMENT,<br /><span style=""color: #6633ff;"">ORDER</span></span>&nbsp;<span style=""color: #6633ff; font-family: &quot;verdana&quot;;""></span></big></big></span></strong></span></small></big><span style=""color: #6633ff; font-family: &quot;verdana&quot;; font-weight: bold;""></span><big style=""color: #6633ff;""><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big><span style=""font-family: &quot;verdana&quot;;"">YOUR PACK NOW!</span></big></big></span></strong></span></small></big></div>
<span style=""font-style: italic;""></span><br />
<div style=""text-align: center;"">
<div class=""auto-style18"" style=""color: #993399; font-style: italic;"">
<big><big><big><big><img alt="""" src=""https://doctornaturalsolution.com.ng/high-blood-pressure-and-its-complication_files/bf-hbp.jpg"" style=""height: 313px; width: 534px;"" /></big></big></big></big></div>
</div>
<br />
<div class=""circle c2"" style=""background-color: #990000; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-align: center; text-transform: uppercase; width: 200px;"">
#32,500</div>
</td></tr>
</tbody></table>
<br /></div>
",
                               ID="a955780f-0bca-4dcb-b101-ca02e1754c90".Replace("-",""),
                                Rows = new List<Row>(){
                                  new Row(){ Body = new List<string>{ "High BP", "Artillery Blockage" } },
                                  }
                              }
                           }
               }, //end of group
                  new DrugGroup(){
                   Name = "Vision and Eye",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1558989677/je_a5xbpd.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="General Eye Defects",
                              HtmlDescription = @"<div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big style=""color: #cc0000; font-size: 30px; font-weight: bold; line-height: 36px;"">It Is Your Turn To Finally Get Rid Of All Forms Of Eyes Problems And Get A Sharp And Clear Vision You Have Always Wanted Within A Short Period Of Time From Now""</big></div>
    <br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big style=""color: #cc0000; font-size: 25px; font-weight: bold; line-height: 30px;""><span style=""background-color: #ffff33; color: black;"">Really, After Going Through This Page You Will Never Have Any Reason To Put On Those Glasses Or Lenses - Except For Beauty Or Fashion Sake!</span></big></div>
    <span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;"">&nbsp;&nbsp;</span><br />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 377px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle;""><div class=""auto-style18 image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); color: #993399; font-style: italic; padding: 5px;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/nomoreglaxs-02.png"" style=""height: 297px; width: 355px;"" /></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <div style=""text-align: justify;"">
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Defective vision is the usual health problem almost all the people are suffering from nowadays in one way or other. Along with other important body parts, our eyes also play a Vital Role in describing our Personality and Confidence. Suffering from eye defect may also sometimes lead to lack of Self Confidence. Of course, who loves wearing glasses at a growing age? None, and to hide the defect, people prefer using lenses instead of spectacles.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>But, have you ever thought deeply about your eye defect? Do you know about the factors leading to defective eye? Do you know that your defective eye, to some considerable extent, can also get treated?&nbsp; Defective vision is the physical problem appeared to your eyes due to several factors and you, somewhere directly or indirectly, are solely responsible for it. There are three fundamental types of eye problems.<br /><br /><span style=""font-weight: bold;"">1) Myopia</span>&nbsp;– It is also known as&nbsp;<span style=""font-weight: bold;"">“Nearsightedness”</span>. In this defect, you can easily and clearly see the nearby objects, but, you’ll find trouble seeing the objects far from you. The far objects start looking blurred to you.<br /><br /><span style=""font-weight: bold;"">2) Hypermopia</span>&nbsp;– The other name of this defect is&nbsp;<span style=""font-weight: bold;"">“Farsightedness”.</span>In this type, you will be able to see the objects far from you clearly, but, seeing the nearby objects will be a trouble for you.<br /><br /><span style=""font-weight: bold;"">3) Astigmatism&nbsp;</span>– In this case, all the light rays don’t come on the single focus point of retina. Some rays fall on retina while the others fall in front of retina or behind it. In this type of eye defect, you will not be able to see anything clearly.</big></div>
    <div style=""text-align: center;"">
    <big><big style=""color: #cc0000; font-weight: bold;"">How Does Vision Problems Starts</big></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big>The problem of defective vision starts with itching and heaviness in the eye sometimes causing mild headaches and then gradually progresses and affects your ability to see. You may not be able to see the mobile or television screen clearly and things will start appearing as faded and unclear. There are several factors responsible for your sensitive eyes getting this problem. Some of the basic reasons for the same are reading in bad light, reading in moving buses and cars, watching too much television, eating lots of junk food etc. Apart from these, there are a few unavoidable causes of defective vision. They are:<br /><br /><br /><span style=""font-weight: bold;"">Mental Strain Or Stress:</span>&nbsp;You may be surprised to read this fact, but, mental stress also plays an important role in giving you a mild symptom of the problem named defective vision. When you take strain like overwork, anxiety, fear or any other negative emotion, it affects the nerves and muscles of your eyes too, leading to this eye problem. That is why, it is always advised to take rest from work on regular intervals and remain calm and happy.<br /><br /><span style=""font-weight: bold;"">Wrong Feeding or Unhealthy Diet:</span>&nbsp;Whatever you consume has the direct impact on your eyes too like the other organs of the body. The muscles and blood vessels surrounding the eyes get clogged due to the improper metabolism caused by the imbalance and too concentrated diet. The food having excessive starch, carbohydrates, sugar etc. mainly lead to this problem.<br /><br /><span style=""font-weight: bold;"">Improper Blood Supply To Eyes Nerves:&nbsp;</span>Like other body parts, our eyes also need proper supply of blood into eyes nerve for proper functioning. Problems with nerves supplying blood to eyes may lead to defective vision.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><span class=""auto-style6""><big style=""color: #cc0000; font-weight: bold;""><br /></big></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><span class=""auto-style6""><big style=""color: #cc0000; font-weight: bold;"">What Do You Do To Treat Your Eyes Defects?</big></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>You use spectacles, which of course, never treat the problem. You use lenses to hide from the world that you are suffering from defective vision, right? But, what about your own soul? It knows everything. Do you know that lenses can even worsen the eye problem by infecting your eyes? Moreover, there are many terms and conditions you need to take care of if you are going to use lens. And, at last, eyes-drops, which can surely improve the situation to some extent, but, can never treat your problem.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><br /></big></div>
    <div style=""color: #333399; text-align: center;"">
    <big style=""font-weight: bold;"">So, what next? Is there any way to cure the problem? Can a person wearing Specs ever be able to see the world without Specs? Can one get his/her Self Confidence and Self Esteem back after becoming the victim of defective vision once?</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big>Really, everything is possible if you have not turned your problem from mild to chronic one. You must have heard about a no side effect remedies for defective vision. And many are still thinking of it like a joke or crap, right? Well, that’s not your fault at all. It’s actually pharmaceuticals who always tend to promote the medicines of their brands and remind you again and again of it. On internet also, you might always have got some new brand name. So, you have no reason to believe the Natural Remedies.<br /><br />No problem, but, think of our fore-father. Have you ever thought about how they used to remain so healthy and strong with lesser number of pharmaceutical medicines available at their time? No reason other than Nature. They used to utilize natural remedies to get rid of whatever health issues they faced. Do, you know that nature is far Powerful than these Artificial Options? Nature can give you the best solution which pharmaceuticals have not even imagined yet.<br /><br />If you still don’t believe the power of nature, I will suggest that you should give what I'm about to share with you a try and you’ll surely get the clear vision you desperatly wanted. Therefore, the Natural Herbal Supplements that I am about to share with you work on the following Eyes Problems:</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><br /></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 290px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle; width: 38px;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle; width: 238px;""><big>Short-Sightedness (Myopia)</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Far-Sightedness (</big><big>Hypermyopia</big><big>)</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Lazy Eye (Amblyopia)</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Cross-Eye (Strabismus)</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Eye strain</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Macular Degeneration</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Cataracts</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Astigmatism</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Presbyopia (Old-Age Sight)</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Glaucoma</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Light Sensitivity</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Poor Night Vision</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big><span class=""style209"" style=""color: #009900;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet.png"" style=""height: 40px; width: 38px;"" /></span></big></td><td style=""vertical-align: middle;""><big>Diabetic Retinopathy,&nbsp;</big>And More…</td></tr>
    </tbody></table>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big>The Natural Herbal Supplements</big><big>&nbsp;have helped thousand Nigerian Men and Women to see Clearly and Better without eye glasses/lenses. Some of them literally throw away their glasses because it was of no use again.<br /><br />If you are suffering from any of the above eye conditions, then you would benefit from what I have to show you. Whether you are wearing glasses already or your eyesight is getting worse and you think you may need glasses now or in the future.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><br /></big></div>
    </div>
    <div style=""text-align: justify;"">
    <big><span style=""font-family: &quot;comic sans ms&quot;;"">Information is power and can be more powerful than medicine atimes if you really make use of it. To every problem, there is alway a solution.&nbsp;</span></big><big style=""font-family: &quot;Comic Sans MS&quot;;"">Nothing is more painful than a missed privilege that brings healing and freedom from series of health challenges and restriction due to negligence.<br /><br />Your Eyes Defects Challenges is a wake-up call for you to discover a new insight, that will add to your wealth of knowledge and walk you out of any of the above Eyes Defects.</big></div>
    </div>
    <span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;"">&nbsp;&nbsp;</span><br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big style=""color: #cc0000;""><big style=""font-weight: bold;"">&nbsp;Introducing Better Life Products<br />Perfect Combination For Clear Vision!</big></big></div>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 377px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle;""><div class=""auto-style18 blink_text"" style=""animation: 1s linear 0s infinite normal none running blinker; color: #993399; font-size: 25px; font-style: italic;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/nice=result.jpg"" style=""height: 250px; width: 276.75px;"" /></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <div style=""font-family: Verdana; font-size: 15px; text-align: justify;"">
    <big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;"">Our eye is a precious sense, and one that we should not take for granted. While we may supplement our diets with nutrients to enhance our overall well-being, we tend to overlook our eyesight as a necessary part of our health to maintain. With just 2 tablets of Pure&amp;Broken and 3 tablets of Better Life CereBrain per day, it is an easy way to help us keep looking clearly now and into the future!</big><br />
    <br />
    <div style=""text-align: center;"">
    <big><big style=""color: #cc0000; font-weight: bold;"">Better Life Products<br />Combination Above Will</big></big></div>
    <br />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 290px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle; width: 33px;""><img align=""top"" alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet5.png"" style=""height: 30px; width: 33px;"" /></td><td style=""vertical-align: middle; width: 243px;""><big>Maintain Optical Clarity</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet5.png"" style=""height: 30px; width: 33px;"" /></td><td style=""vertical-align: middle;""><big>Prevent Ocular Toxicity</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet5.png"" style=""height: 30px; width: 33px;"" /></td><td style=""vertical-align: middle;""><big>Improve and Increases Visual Acuity</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet5.png"" style=""height: 30px; width: 33px;"" /></td><td style=""vertical-align: middle;""><big>Improve Blood Circulation to the Eye</big></td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><img align=""top"" alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/bullet5.png"" style=""height: 30px; width: 33px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Nourishes the eye with all useful nutrients and improve Blurred Vision, Glaucoma, Cataract and Night Blindness</big></td></tr>
    </tbody></table>
    </div>
    <div class=""auto-style11"" style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    <big><br /></big></div>
    <div class=""auto-style11"" style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    <big>So, what makes ""The Products Combination"" above safe to use and</big></div>
    <div class=""auto-style11"" style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    <big>why do I even recommend them for you? The answer is simple!</big></div>
    <div class=""auto-style11"" style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    <big><br /></big></div>
    <div class=""auto-style11"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: justify; widows: 1;"">
    The above products combination have the prestigious Kosher Seal (which makes them acceptable to the Jews. The Jews don’t take anything that isn’t 100% natural. Infact, they don’t even take bread with yeast! They believe in no additives. They also have other seals including the seal of International Aloe Science Council, Halal and Islamic seals, these are seals of highest form of purity including our own NAFDAC in Nigeria.</div>
    <br />
    <div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/cert.jpg"" style=""height: 249px; width: 435.141px;"" /></div>
    <table border=""0"" cellpadding=""10"" cellspacing=""10"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 435px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;"">Below Are What People Are Saying!</span></big></big><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/proof-2.png"" style=""height: 87px; width: 375.25px;"" /><br />
    <big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/testimony.png"" style=""height: 91px; width: 299px;"" /></span></big></big></td></tr>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""text-align: left;"">
    </div>
    <div style=""text-align: left;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;"">I Feel Brand New!</big>&nbsp;</div>
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><br />""Hello sir, I'm here to give a personal testimonial and highly recommend your Better Life Vision Packt for anyone that wants to improve their vision. I have been suffering from short-sightness since a very young age. I was considering laser surgery but it’s expensive and dangerous. Fortunately, after giving a try to this modest products, my vision improved to a degree that I hardly need to wear contacts anymore""</big><br />
    <br />
    <div style=""color: #333399; text-align: right;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-style: italic; font-weight: bold;"">- Mrs. Ngozi - Enugu State -</big></div>
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/testimony.png"" style=""height: 91px; width: 299px;"" /></span></big></big></td></tr>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""text-align: left;"">
    </div>
    <div style=""text-align: left;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;"">The Products Is Amazing!</big>&nbsp;</div>
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><br />""Just a quick thank you. I bought your products in Mid December, i</big><big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">n hopes I could be glasses free by march. My vision was almost 20/30 in both eyes. In a little over two months and I am 20/20, which is the average! What a product!&nbsp; Thank you doesn’t feel sufficient enough. Please use this testimony as my sincere gratitude.""&nbsp;</big><br />
    <br />
    <div style=""color: #333399; font-style: italic; font-weight: bold; text-align: right;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">- Kadirat from Kaduna -</big></div>
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/testimony.png"" style=""height: 91px; width: 299px;"" /></span></big></big></td></tr>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div>
    </div>
    <div style=""text-align: left;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;"">My Vision Has Litersally Improved</big>!&nbsp;</div>
    <br />
    <hr style=""height: 2px; width: 401px;"" />
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">""Ever sin</big><big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">ce I started using your Better Life vision Pack, my vision has literally improved over night. I used to wear spectacles all the time but now I'm already getting used to live without them. It's difficult to explain but I feel like I am 10 years younger. Thanks for the product. I am totally impressed and satisfied.""</big><br />
    <br />
    <div style=""color: #333399; font-style: italic; font-weight: bold; text-align: right;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">- Mr. Caleb - Gwarimpa, Abuja -</big></div>
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/testimony.png"" style=""height: 91px; width: 299px;"" /></span></big></big></td></tr>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""text-align: left;"">
    </div>
    <div style=""text-align: left;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;"">Now I See Without My Glassesd</big>!&nbsp;</div>
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><br />""I thought I would live the rest of my life with glasses. My experience since I started taking your Forever Vision Pack. I&nbsp;</big><big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">took the product at first because it was the fastest way for me to live without glasses. After 2 months of using Pure&amp;Broken Better Life CereBrain vision and my eyes felt renewed in just a few months - as if they were reborn.""</big><br />
    <br />
    <div style=""color: #333399; text-align: right;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;""><span style=""font-style: italic;"">- Dolapo - Agege, Lagos State -</span></big></div>
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: middle;""><big style=""color: #cc0000;""><big style=""font-style: italic; font-weight: bold;""><span class=""style33"" style=""font-family: &quot;arial rounded mt bold&quot;;""><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/testimony.png"" style=""height: 91px; width: 299px;"" /></span></big></big></td></tr>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; vertical-align: top;""><div>
    </div>
    <div>
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace; font-weight: bold;"">Thump Up To Your Products Combination</big>!&nbsp;</div>
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><br />""Thank you for putting together such an awesome products! My vision is improving consistently and my eyes just feel much more relaxed now. A must have for anyone with glasses or if such person just want to see better.""</big><br />
    <br />
    <div style=""color: #333399; font-style: italic; font-weight: bold; text-align: right;"">
    <big style=""font-family: &quot;Courier New&quot;, Courier, monospace;"">- Mr. Aribisala - Benue -</big></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <big style=""font-family: Verdana; text-align: justify;""><span data-mce-style=""font-family: Cabin,sans-serif;"" style=""font-family: &quot;comic sans ms&quot;;"">It’s Up to you to grab your Pack today or risk never getting this amazing solution Pure&amp;Broken Better Life CereBrain. Therefore, you can't afford to leave this page without placing your order now at this period of Heavily Discounted Price. The Discount Price is Just Valid for few days.</span></big><br />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big><span data-mce-style=""font-family: Cabin,sans-serif;"" style=""font-family: &quot;comic sans ms&quot;;""><br /></span></big></div>
    <br />
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 435px;""><tbody>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""text-align: center;"">
    <div class=""auto-style18"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/limited-offer-3.jpg"" style=""height: 262px; width: 421px;"" /></div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 378px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle; width: 378px;""><div class=""auto-style18"" style=""color: #993399; font-style: italic;"">
    <img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/nice=result.jpg"" style=""height: 250px; width: 283.5px;"" /></div>
    </td></tr>
    </tbody></table>
    <br />
    <big style=""color: #cc0000;""><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""><strong><span class=""auto-style85""></span></strong></big></big></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <div style=""font-family: Verdana; font-size: 15px; line-height: 30px; text-align: center;"">
    <big style=""color: #cc0000;""><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""><strong><strong><span class=""auto-style85""><big>Here Below The Cost Analysis</big></span></strong></strong></big></big><br />
    <big style=""color: #cc0000;""><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""><strong><strong><span class=""auto-style85""><big>For You To Place Your Order</big></span></strong></strong></big></big>&nbsp;&nbsp;</div>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <table border=""1"" cellpadding=""0"" cellspacing=""0"" id=""table2"" style=""border-collapse: collapse; border-radius: 7px; border: 3px solid black; box-shadow: rgb(0, 153, 0) 5px 5px; font-family: sans-serif; margin-left: auto; margin-right: auto; padding: 15px; width: 402px;""><tbody>
    <tr><td style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 245.6px;""><big><br />Desired/Duration<br />Usage Pack</big></td><td style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 224.8px;""><big><br />Quantity To Be<br />Delivered</big></td><td style=""color: #006600; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: center; vertical-align: middle; width: 224.8px;""><big><br />Total Cost In<br />Naira (#)</big></td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><big style=""color: #000099;""><big><big><big>1</big></big></big></big><br />
    Usage<br />
    Pack</td><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">1 bottle of each<br />
    of the products<br />
    above will be<br />
    delivered</td><td style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><big><span style=""text-decoration-line: line-through;""><br /></span></big>
    <br />
    <div class=""circle c2"" style=""background-color: #000099; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
    <br />
    <span style=""color: #ffcc00;"">#35,500</span></div>
    <big><span style=""text-decoration-line: line-through;""></span></big></td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><big style=""color: #000099;""><big><big><big>2</big></big></big></big><br />
    Usage<br />
    Pack</td><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">2 bottle of each<br />
    of the products<br />
    above will be<br />
    delivered</td><td style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><br />
    <div class=""circle c2"" style=""background-color: #000099; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
    <br />
    <span style=""color: #ffcc00;"">#69,000</span></div>
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><big style=""color: #000099;""><big><big><big>3</big></big></big></big><br />
    Usage<br />
    Pack</td><td style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;"">3 bottle of each<br />
    of the products<br />
    above will be<br />
    delivered</td><td style=""color: #990000; font-family: &quot;Comic Sans MS&quot;; font-style: italic; font-weight: bold; text-align: center; vertical-align: middle;""><br />
    <div class=""circle c2"" style=""background-color: #000099; border-radius: 50%; color: white; font-size: 20px; height: 100px; line-height: 25px; margin: 0px auto 40px; padding: 10px; text-transform: uppercase; width: 100px;"">
    <br />
    <span style=""color: #ffcc00;"">#102,500</span></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 435px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle;""><span style=""color: #cc0000; font-weight: bold;"">Please Note:</span>&nbsp;How long you will be taken the above products combination is greatly depends on the&nbsp;<span style=""font-weight: bold;"">Severity of your Eye Problems (Mild or Complex).</span>&nbsp;But irrespective of the severity, your sight will be restored within 3 months of usage.</td></tr>
    </tbody></table>
    <div class=""auto-style20"" style=""font-family: &quot;Comic Sans MS&quot;; font-size: 15px; text-align: center;"">
    <strong><br /><br /><img alt="""" src=""https://doctornaturalsolution.com.ng/eyesight-clear_files/guarant.png"" style=""height: 176px; width: 213px;"" /></strong><br />
    <big><strong></strong></big></div>
    ",
                              ID="4badda59-56e1-4e17-937d-5e3082cebc62".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Pinching Effects", "Swollen Eyes" } },
                                 new Row(){ Body = new List<string>{ "Long & Short Sightedness", "Eye Discharge" } },
                              }
                          }
                           }
               }, //end of group
                   new DrugGroup(){
                   Name = "Bones & Joints",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559033233/jj_nmbhwb.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Arthritis / Rheumatism",
                              HtmlDescription=@"<big style=""color: #cc0000; font-family: Verdana; text-align: center;""><big><big><span style=""color: black;""><span style=""font-style: italic;""><span style=""color: #990000; font-weight: bold;""><span style=""color: #cc0000;""><span style=""color: black;"">Good News! You Can't Just Afford To Miss!</span></span></span></span></span></big></big></big><span style=""background-color: white; text-align: center;""></span><br />
<hr style=""height: 2px; text-align: center; width: 386.797px;"" />
<big style=""color: #cc0000; font-family: Verdana; text-align: center;""><big><big><span style=""color: black;""><span style=""font-style: italic;""><span style=""color: #990000; font-weight: bold;""><span style=""color: #cc0000;""><span style=""color: #000099;"">If you want to get rid of your&nbsp;<span style=""color: #cc0000;"">Joint Pains, Arthritis and Rheumatism,</span>&nbsp;just in a Natural and Safe way without any Side Effect within a short period of time then, this is the most important report you will ever read.</span></span><span style=""color: #000099;""></span></span></span></span></big></big></big><a href=""http://doctor-paul-natural-care.com.ng/joint-pain-arthritis-rheumatism.html"" style=""text-align: center;""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/Jp_arthritis_rheumatism_2.jpg"" style=""border: 0px solid; height: 300px; width: 386.797px;"" /></a><br />
<br style=""text-align: center;"" />
<br />
<div style=""text-align: justify;"">
<div style=""text-align: center;"">
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><big><span style=""color: #cc0000; font-weight: bold;"">Joint Pain, Arthritis and Rheumatism</span></big></big></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br />Formed in the body as a result of degenerative changes that generally develop in the second half of life and are a part of the aging process. But due to today's way of life and nutritional deficiency, the onset of these changes is being shifted towards younger age.<br /><br />Arthritis includes many different types, but regardless of the type, Arthritis is a chronic illness and remains in the body for life. For many, it is an inevitable part of aging. Most people start suffering from some Arthritis symptoms around the age of 50<br /><br />The degenerative changes usually start manifesting themselves through intermittent pain in the joints. This is followed by&nbsp;<span style=""font-weight: bold;"">joint stiffness, swelling, inflammations, redness and permanent joint and muscle pain.</span><br /><br />These are often followed by secondary symptoms, such as&nbsp;<span style=""font-weight: bold;"">insomnia, chronic fatigue, crapping and depression</span>. The changes in weather generally cause worsening of some of these symptoms.</big><br />
<div style=""text-align: center;"">
<big style=""color: #cc0000; font-weight: bold;""><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; text-align: justify;"">The Effects Of Drugs On Arthritis</big></big></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br />Medicinal Treatment of Arthritis is usually tailored to each patient, depending on his on his condition, with the patient usually becoming dependant on the Arthritis drugs for life.<br /><br />The most commonly prescribed are Non-Steroidal Anti-Inflammatory Drugs (NSAIDs). NSAIDs are medications which, in addition to having pain relieving (Analgestic) effects, have the effect of reducing inflammation when used over a period of time.<br /><br />However, they also cause a multitude of adverse side effects, such as&nbsp;<span style=""font-weight: bold;"">digestion problems, internal bleedings, fatigue, confusion and depression and toxicity of liver and kidneys.</span>&nbsp;<span style=""color: #cc0000; font-weight: bold;"">These adverse side effects are sometimes so severe that they outweigh the benefits.</span><br style=""color: #cc0000; font-weight: bold;"" /><br style=""font-weight: bold;"" /><span style=""font-weight: bold;"">VIOXX,</span>&nbsp;the most popular Arthritis drug since 1999, was taken off the market after it has been proven that, in addition to the above-mentioned side effects, it also increases the risk of heart attacks and strokes.<br /><br />What is known for sure is that none of these drugs cures Arthritis, and neither slows down its progression.&nbsp;<span style=""color: #cc0000; font-weight: bold;"">This mean that none of these drugs treat the cause of the illness, only the symptoms</span></big><br />
<div style=""text-align: center;"">
<big style=""background-color: white; color: #333399; font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><span style=""font-weight: bold;""><big>Therefore, Are You Suffering From Arthritis, Body And Back Pain And You Are Not Doing Anything About It?</big></span></big></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big>
<br />
<div style=""text-align: center;"">
<a href=""http://doctor-paul-natural-care.com.ng/joint-pain-arthritis-rheumatism.html""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/back-pains.png"" style=""border: 0px solid; height: 100px; width: 386.797px;"" /></a><br />
<a href=""http://doctor-paul-natural-care.com.ng/joint-pain-arthritis-rheumatism.html""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/back-painss.png"" style=""border: 0px solid; height: 100px; width: 386.797px;"" /></a></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big>
<br />
<div style=""text-align: center;"">
<big style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><span style=""font-weight: bold;""><big><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/fire.png"" style=""height: 110px; width: 122px;"" /><br />If Yes, Then You Are Playing With Fire.<br /><span style=""color: #000099;""><br /></span></big></span></big></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Although many people know that Arthritis is an inflammation that leads to&nbsp;<span style=""color: #cc0000; font-weight: bold;"">""Radiating Pain""</span>&nbsp;and<span style=""color: #cc0000; font-weight: bold;"">""Swelling of All Joints"".</span>&nbsp;What many of them don't know is that there are various kinds of Arthritis and Joint Pains and when not taking care of, it can lead to deformity and untold sorrowful pains for a life time.</big><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big><br />
<div style=""text-align: center;"">
<big style=""background-color: white; color: #cc0000; font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><span style=""font-weight: bold;""><big><span style=""color: black;"">Studies Showed That Older People With Severe Arthritis Can be Cripple!</span><br style=""color: black;"" /><br style=""color: black;"" /><span style=""color: black;"">These Pains Radiate From Your Bone, Then Extends To Yours Muscles, Then Signal Are Sent To Your Nerves Which Resolved To Severe Pains. Therefore,</span><span style=""color: #000099;""></span></big></span></big></div>
<div style=""line-height: 24px;"">
<ul style=""padding-left: 20px;"">
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Are you suffering from Chronic Arthritis that seems to never go away?</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Do You feel serious inflammatory pains all over your Back, Waist &amp; Legs? Pains so seriously they practically hinder you from doing anything</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Do you feel excruciating pains in all the Joint of your body; pains so serious you find it difficult to hold a common pen.</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Are you sick and tired of using all sorts of pains killers?</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">Is your Arthritis, Body or Back Pain Affecting your sexual life so much</big></li>
</ul>
</div>
<br />
<div style=""text-align: center;"">
<big><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; font-weight: bold; text-align: justify;"">If your Answer Is Yes To Any Of The Above Questions, Then Right Here &amp; Now Is Your Turning Point And You Really Need To Read This Report To The End.</big></big></div>
<br />
<div style=""text-align: center;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/picture_text.png"" style=""height: 511px; width: 386.797px;"" /></div>
<big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;""><br /></big>
<br />
<div style=""text-align: center;"">
<big style=""background-color: white; color: #333399; font-family: &quot;Comic Sans MS&quot;; text-align: justify;""><span style=""font-weight: bold;""><big>This Simply Means</big></span></big></div>
<div style=""line-height: 24px;"">
<ul style=""padding-left: 20px;"">
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">You will never have to complain about weak bone, again!</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">You will never have to complain about Arthritis (Osteo-Arthritis, Gout &amp; Rheumatoid)</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">You will say bye-bye to pain killers</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">You will regain your precious good night sleep</big></li>
<li><big style=""background-color: white; font-family: &quot;Comic Sans MS&quot;;"">You will live a healthy life without diseases, thus prolonging your life</big></li>
</ul>
</div>
<big><big><big><big><span class=""auto-style23""></span></big></big></big></big><br />
<div class=""auto-style18"" style=""background-color: white; font-size: 15px; font-weight: 700; text-align: center;"">
<span class=""auto-style23""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/tripplefacedown.gif"" style=""height: 100px; width: 245px;"" /></span></div>
<div style=""text-align: center;"">
<span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong><small style=""color: #cc0000;"">Therefore, I'm Introducing You To A Naturally Made -&nbsp;<span style=""color: #000099;"">Arthrithis And Joint Pains Remedy</span>&nbsp;For Your Optimum Body And Bone Wellness.&nbsp;</small></strong></span><br />
<div>
<div>
<img alt="""" class=""blink_text"" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/joint-pain-result.jpg"" style=""animation: 1s linear 0s infinite normal none running blinker; color: #cc0000; font-size: 25px; height: 300px; width: 362.625px;"" /></div>
<div class=""auto-style18"" style=""background-color: white; color: #cc0000; font-family: &quot;Arial Rounded MT Bold&quot;; font-size: 15px; font-weight: 700;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/massive-result.jpg"" style=""height: 400px; width: 483.5px;"" /></div>
<div>
<a href=""http://doctor-paul-natural-care.com.ng/joint-pain-arthritis-rheumatism.html""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/back-pains.png"" style=""border: 0px solid; height: 100px; width: 386.797px;"" /></a><br />
<a href=""http://doctor-paul-natural-care.com.ng/joint-pain-arthritis-rheumatism.html""><img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/back-painss.png"" style=""border: 0px solid; height: 100px; width: 386.797px;"" /></a></div>
<br /></div>
<br />
<span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong><small>These Products Combination Above Can Be Delivered To Your Door Step At A</small><span style=""color: #990000;""><small><span style=""color: black;"">&nbsp;Discounted Price Of;</span></small></span></strong></span><big><big><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong></strong></span></big></big><br />
<div class=""circle c1"" style=""background-color: black; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-transform: uppercase; width: 200px;"">
#42,500</div>
</div>
<table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 584px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""text-align: center;"">
<br />
<br />
<br /></div>
<div style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""color: #cc0000; font-style: italic;""><strong><span class=""auto-style95""><big><big><span style=""font-family: &quot;verdana&quot;;"">DON'T WAIT A MOMENT,<br /><span style=""color: #6633ff;"">ORDER</span></span>&nbsp;<span style=""color: #6633ff; font-family: &quot;verdana&quot;;""></span></big></big></span></strong></span></small></big><span style=""color: #6633ff; font-family: &quot;verdana&quot;; font-weight: bold;""></span><big style=""color: #6633ff;""><small style=""font-family: &quot;Arial Rounded MT Bold&quot;;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big><span style=""font-family: &quot;verdana&quot;;"">YOUR PACK NOW!</span></big></big></span></strong></span></small></big></div>
<span style=""font-style: italic;""></span><br />
<div style=""text-align: center;"">
<img alt="""" src=""https://doctornaturalsolution.com.ng/arthritis-and-rheumatism_files/joint-pain-result.jpg"" style=""height: 300px; width: 427.5px;"" /></div>
<br />
<div class=""circle c2"" style=""background-color: #990000; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-align: center; text-transform: uppercase; width: 200px;"">
#42,500</div>
</td></tr>
</tbody></table>
<br /></div>
",
                              ID="b3865d5c-dc82-4890-8295-b939950b3ac3".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Joint Pain", "Swollen of Joint", "Body Pain"} },
                              }
                          }
                           }
               },
                    //end of group
                   new DrugGroup(){
                   Name = "Body Mass",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559033233/jb_jve0fm.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Weight Reduction",
                              HtmlDescription = @"<div style=""background-color: white; font-family: roboto, sans-serif; font-size: 15px; text-align: center;"">
    <div style=""color: #757575;"">
    <a href=""#"" style=""background: transparent; color: #2196f3; text-decoration-line: none;""><img alt="""" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/weightloss.jpg"" style=""border: 0px solid; height: 400px; max-width: 100%; width: 648px;"" /></a></div>
    <div class=""post-body entry-content float-container"" id=""post-body-1894789682904998512"" style=""font-stretch: normal; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: 1.6em; margin: 1.5em 0px 2em;"">
    <div style=""color: #757575;"">
    <br /></div>
    <div class=""style13"" style=""color: black; font-family: &quot;Times New Roman&quot;; font-size: 24px; font-variant-east-asian: normal; font-variant-numeric: normal; line-height: normal; text-align: left;"">
    <strong><span lang=""en-gb"" xml:lang=""en-gb""><i><span style=""font-family: &quot;times new roman&quot; , serif;"">You Can't Afford To Miss This...</span></i></span></strong></div>
    <h1 align=""center"" style=""font-size: 50px; font-weight: 300; letter-spacing: -0.4px; line-height: 52.5px; margin: 35px 0px 25px;"">
    <span class=""style79"" style=""font-family: &quot;times new roman&quot;; font-size: x-small; font-weight: bold; letter-spacing: normal; line-height: normal;""><span lang=""en-gb"" style=""font-family: &quot;times new roman&quot; , serif;"" xml:lang=""en-gb""><span style=""color: navy; font-size: 26pt;"">You Are Guaranteed To Lose Between&nbsp;</span><span style=""color: #274e13; font-size: 26pt;"">5-10kg</span><span style=""color: navy; font-size: 26pt;""><span class=""Apple-converted-space"">&nbsp;</span>Of Fat</span></span></span></h1>
    <h1 align=""center"" style=""color: #757575; margin: 0.67em 0px;"">
    <span class=""style150""><span class=""style178""><span class=""style152"">Transform Your Body</span>&nbsp;Into That Confident, Sexy And Slim Body<br />You've Always Wanted&nbsp;<span class=""style152"">In Just 9 Days&nbsp;</span>From Now...""</span></span></h1>
    <div align=""justify"" class=""style17"" style=""color: #757575;"">
    Dear Friend,</div>
    <div align=""justify"" class=""style17"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style17"" style=""color: #757575;"">
    If you want to get rid of your Ugly body Fat in a&nbsp;<strong><u>Natural And Safe Way</u>&nbsp;without Any Health Challenge</strong>&nbsp;or Side Effect within the short time possible, this is the most important letter you'll ever read.</div>
    <div align=""justify"" class=""style17"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style47"" style=""color: #757575;"">
    Why did I say that?</div>
    <div align=""justify"" class=""style47"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style17"" style=""color: #757575;"">
    Considering those Ugly experiences of being Fat... It shatters self esteem, it crushes self confidence. It makes you look older than your partner, It disrupts your sex life and it can cause embarrassing moments like:</div>
    <blockquote style=""color: #444444; font-size: x-large; font-stretch: normal; font-style: italic; line-height: normal;"">
    <div align=""justify"" class=""style20"">
    Being Called A ""Madam"" by your age mates when you are yet to hit 35 or even 40yrs old by colleagues, friends and families who are even older than you.&nbsp;</div>
    </blockquote>
    <blockquote style=""color: #444444; font-size: x-large; font-stretch: normal; font-style: italic; line-height: normal;"">
    <div align=""justify"" class=""style20"">
    <strong>Being Refused By Bank security Doors when you try to enter the bank and the security would have to override the system just to let you in.</strong>&nbsp;</div>
    </blockquote>
    <blockquote style=""color: #444444; font-size: x-large; font-stretch: normal; font-style: italic; line-height: normal;"">
    <div align=""justify"" class=""style20"">
    Being refused by Okada Rider simply because they are afraid the “heavy load you carry” will flatten their tyres and even when they agree…charge you double for it.</div>
    <div align=""justify"" class=""style20"">
    <strong>Being asked if you are pregnant by people who are surprised at how big your belly is.</strong>&nbsp;</div>
    </blockquote>
    <blockquote style=""color: #444444; font-size: x-large; font-stretch: normal; font-style: italic; line-height: normal;"">
    <div align=""justify"" class=""style20"">
    Being Ignored by your partner who hardly comes close to you simply because “fat people irritates him”&nbsp;</div>
    </blockquote>
    <blockquote style=""color: #444444; font-size: x-large; font-stretch: normal; font-style: italic; line-height: normal;"">
    <div align=""justify"" class=""style20"">
    If any of these situations relates to you...then you are NOT alone and I know how you feel.</div>
    </blockquote>
    <div align=""center"" class=""style160"" style=""color: #757575;"">
    It is NOT your Fault!</div>
    <div align=""center"" class=""style160"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    I'm sure you might have tried a lot of things in an attempt to get rid of your Ugly Fat&nbsp;<strong>and The Result Were Always The Same. No Success! Nothing To Show For It.</strong>&nbsp;And you probably have been wondering why they never worked for you and maybe even blame yourself for not making it work...but not to worry anymore as this is about to change everything!</div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    Have you ever taken time to think about it... if you finally grab this Most Effective,&nbsp;<strong>result oriented Natural Fat Loss Therapy&nbsp;</strong>and you were finally able to burn off those tummy fat within few days while you lose weight...</div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    This simply means...</div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    </div>
    <ul style=""color: #757575;"">
    <li>You will never have to complain about&nbsp;<u>fat arms</u>,&nbsp;<u>thighs</u>&nbsp;and&nbsp;<u>buttocks</u>, again!</li>
    <li>You will now look very attractive just as you've ever wanted, causing everyone who walks past you to turn and look back at you again</li>
    <li>You will say bye bye to those ugly pot belly of yours</li>
    <li>You will regain your confidence back, and the fear of losing your spouse to a younger, slim woman because of your weight problem will be gone forever</li>
    <li>You will live a healthy life without diseases, thus prolonging your life</li>
    <li>Even in your place of work, you will gain control, more effective and energetic unlike your previous overweight body and fat tummy which normally make you feel weak and tired often</li>
    </ul>
    <div style=""color: #757575;"">
    <br /></div>
    <div align=""justify"" class=""style20"" style=""color: #757575;"">
    If You would Like to Naturally get rid of those stubborn Fat or Lose Weight within the short time possible&nbsp;<strong>WITHOUT Side effect</strong>, Then ...<br />
    <br />
    In the next few minutes I am going to show you some amazing facts about how you can Naturally get rid of your excessive body fat in a safe way.</div>
    <div align=""center"" class=""style20"" style=""color: #757575;"">
    <br />

    <a href=""https://res.cloudinary.com/fzany-inc/image/upload/v1559157035/weightLoss_wlgbpr.jpg"" imageanchor=""1"" style=""margin-left: 1em; margin-right: 1em;""><img border=""0"" data-original-height=""800"" data-original-width=""800"" height=""400"" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559157035/weightLoss_wlgbpr.jpg"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://3.bp.blogspot.com/-c1NAwEMiogs/W2L9r_GTW_I/AAAAAAAABu0/kd_e2V8Yhn0JFL1Tac9pNHWefnEDJvMDQCLcBGAs/s1600/1012808_1424532077780807_53350857_n.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""332"" data-original-width=""332"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/1012808_1424532077780807_53350857_n.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://2.bp.blogspot.com/-Dw5ws8xhYzg/W2L92ygRquI/AAAAAAAABu4/EGLAmaqhRp4Pf1cZ8c4XHSKWsf6eBU56wCLcBGAs/s1600/1476563_1426083700958978_1013469685_n.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""333"" data-original-width=""333"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/1476563_1426083700958978_1013469685_n.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://4.bp.blogspot.com/-DK1-p988Vtw/W2L9-irJIHI/AAAAAAAABvA/-DwT5USjp1cPH0-quLAcfmW2XZ4t0-NUQCLcBGAs/s1600/1613967_1459957497571598_1933496320_n.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""400"" data-original-width=""400"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/1613967_1459957497571598_1933496320_n.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""http://doctornaturalsolution.com.ng/weight-loss-nigeria_files/wait.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""95"" data-original-width=""284"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/wait.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <h3 style=""color: #757575; font-size: 16px;"">
    </h3>
    <div style=""color: #757575;"">
    <b><span style=""color: red;"">ARE YOU THINKING IF THIS PROGRAM</span></b></div>
    <div style=""color: #757575;"">
    <b><b><span style=""color: red;"">WORKS FOR MEN ALSO?</span></b></b></div>
    <div align=""center"" class=""style163"" style=""color: #757575;"">
    </div>
    <div style=""color: #757575;"">
    <br /></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div align=""center"" class=""style47"" style=""color: #757575;"">
    SEE BELOW FEEDBACK FROM HAPPY CLIENTS:</div>
    <div align=""center"" class=""style47"" style=""color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://1.bp.blogspot.com/-7iP3-wig9h4/W2L_Zk1wvSI/AAAAAAAABvU/JGsedTX9PJg5SNIyqMHJAiztD0J2HVDcgCLcBGAs/s1600/1517499_1461924407374907_2472870715562102536_n.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""365"" data-original-width=""371"" height=""392"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/1517499_1461924407374907_2472870715562102536_n.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://2.bp.blogspot.com/-3D-DQgUKsfs/W2L_iQT15SI/AAAAAAAABvY/Z0DSVCCOVSE3C6byWG1sNLhA1xvJSeLxwCLcBGAs/s1600/a.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""320"" data-original-width=""320"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/a.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://2.bp.blogspot.com/--utmFjEhgrc/W2L_pjDTmTI/AAAAAAAABvg/GizJgSVhJh8jILTBVVEo88k4bUuiPj-owCLcBGAs/s1600/another.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""283"" data-original-width=""283"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/another.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://1.bp.blogspot.com/-x9pZHc29PK4/W2L_xXDuzqI/AAAAAAAABvk/WfW-DtFDBdwRVMrLp1__opPwwFHWj3KLQCLcBGAs/s1600/b.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""320"" data-original-width=""320"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/b.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""400"" /></a></div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    </div>
    <div align=""center"" class=""style47"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px; font-weight: bold;"">
    YES! THIS IS AMAZING...</div>
    <div align=""center"" class=""style181"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 36px; font-weight: bold;"">
    <br /></div>
    <div align=""center"" class=""style181"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 36px; font-weight: bold;"">
    <span class=""style182"" style=""color: #3e1556; font-family: &quot;geneva&quot; , &quot;arial&quot; , &quot;helvetica&quot; , sans-serif; font-size: 45px;"">Veggie Veggie and Ez-xlim</span><br />
    <span class=""style182"" style=""color: #3e1556; font-family: &quot;geneva&quot; , &quot;arial&quot; , &quot;helvetica&quot; , sans-serif; font-size: 45px;""><br /></span>
    <span class=""style182"" style=""color: #3e1556; font-family: &quot;geneva&quot; , &quot;arial&quot; , &quot;helvetica&quot; , sans-serif; font-size: 45px;"">&nbsp;THERAPY</span><br />
    <span class=""style182"" style=""color: #3e1556; font-family: &quot;geneva&quot; , &quot;arial&quot; , &quot;helvetica&quot; , sans-serif; font-size: 45px;""><br /></span></div>
    <div align=""center"" class=""style181"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 36px; font-weight: bold;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/weightloss.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; display: inline-block; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""365"" data-original-width=""525"" height=""400"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/weightloss.jpg"" style=""border: 0px; height: inherit; max-width: 100%;"" width=""500"" /></a></div>
    <div align=""center"" class=""style181"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 36px; font-weight: bold;"">
    </div>
   
<div align=""justify"" class=""style165"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">

    <div align=""justify"" class=""style47"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px; font-weight: bold;"">
    Benefits include:</div>
    <div align=""justify"" style=""color: #757575;"">
    <ol>
    <li class=""style20"" style=""font-family: &quot;Times New Roman&quot;, Times, serif; font-size: 19px;"">Detoxification and maintenance of healthy digestive tract;</li>
    <li class=""style20"" style=""font-family: &quot;Times New Roman&quot;, Times, serif; font-size: 19px;"">Lowering of blood pressure, blood sugar, cholesterol, anti-pain and so on.</li>
    </ol>
    
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    The product has the prestigious&nbsp;<strong>Kosher Seal</strong>&nbsp;(which makes it acceptable to the Jews.&nbsp;<strong>The Jews don’t take anything that isn’t 100% natural</strong>. Infact, they don’t even take bread with yeast! They believe in no&nbsp;additives.</div>
    <div class=""style181"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 36px; font-weight: bold;"">
    </div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    <br />
    It&nbsp;has other seals including the&nbsp;<strong>Halal</strong>&nbsp;and Islamic seals as well. (<strong>These are Seals of highest form of purity including our own NAFDAC in Nigeria)</strong>.</div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    </div>
    <div class=""separator"" style=""clear: both; color: #757575;"">
    <a href=""https://3.bp.blogspot.com/-ivSi3md1CgM/W2MCol90EBI/AAAAAAAABv4/7cGPHPqcHfE31iaYqxJUlgRxe7VYJ9caQCLcBGAs/s1600/cert.jpg"" imageanchor=""1"" style=""background: transparent; color: #2196f3; margin-left: 1em; margin-right: 1em; text-decoration-line: none;""><img border=""0"" data-original-height=""143"" data-original-width=""625"" height=""146"" src=""https://doctornaturalsolution.com.ng/weight-loss-nigeria_files/cert.jpg"" style=""border: 0px; max-width: 100%;"" width=""640"" /></a></div>
    <div align=""center"" style=""color: #757575;"">
    </div>
    <div align=""center"" style=""color: #757575;"">
    <span class=""style15"" style=""color: #ff0066; font-family: &quot;georgia&quot; , &quot;times new roman&quot; , &quot;times&quot; , serif; font-size: 24px; font-weight: bold;""><span class=""style174"" style=""color: #660099;"">Okay,&nbsp;</span><span class=""style174"" style=""color: #660099;"">But How Much Will It Cost Me To<br />Get the product delivered to me at my doorstep?</span></span></div>
    <div align=""center"" style=""color: #757575;"">
    </div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    Now let me ask you a question: What is your value for getting a flat belly or losing weight?</div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    What is your value for eating healthy, tasty and delicious fat-burning foods EVERY single day on YOUR table without putting on weight...while getting more healthy everyday?</div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    Before you answer that question, I want you to consider the value of what you are getting. It will save you lots of time and efforts.</div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    I have spent a huge amount of time and money when I was researching to get you everything you need PLUS my personal experience...</div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    <br /></div>
    <div align=""justify"" class=""style20"" style=""color: #757575; font-family: &quot;times new roman&quot;, times, serif; font-size: 19px;"">
    </div>
    <div align=""center"" class=""style38"" style=""font-family: &quot;Times New Roman&quot;, Times, serif; font-size: 40px; font-weight: bold;"">
    <span class=""style42"" style=""color: #757575; font-size: 35px;"">For Just</span><span style=""color: #757575;"">&nbsp;</span><span class=""style39"" style=""font-family: &quot;arial&quot; , &quot;helvetica&quot; , sans-serif;""><span style=""color: blue;""><span class=""style41"" style=""font-size: 45px;"">#38,500</span>&nbsp;</span><span class=""style42"" style=""color: #757575; font-size: 35px;"">only</span></span><span class=""style42"" style=""color: #757575; font-size: 35px;"">!!!</span></div>
    </div>
    ",
                              ID="d8fb20f6-c5a1-48ad-88ca-1d4753e26a81".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Lower your body mass"} },
                                  new Row(){ Body = new List<string>{ "Control Overweight"} },
                                  new Row(){ Body = new List<string>{ "Control Obesity"} },
                              }
                          }
                           }
               }, 
                    //end of group
                    new DrugGroup(){
                   Name = "Liver",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559033233/jb_jve0fm.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Liver Problems",
                              HtmlDescription = @"<div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <big style=""color: #cc0000; font-size: 30px; font-weight: bold; line-height: 36px;""><span style=""color: black;""><span style=""color: #333399;"">When Your Liver Is Healthy</span>&nbsp;- So Are You! Therefore, Here Is How To Keep Your Liver Healthy&nbsp;</span>""The Master Detoxification Organ""</big></div>
    <span style=""background-color: white; font-family: &quot;verdana&quot;; font-size: 15px; text-align: justify;"">&nbsp;&nbsp;&nbsp;</span><br />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""font-family: Verdana; margin-left: auto; margin-right: auto; width: 493px;""><tbody>
    <tr><td style=""text-align: center; vertical-align: middle;""><div class=""auto-style18"" style=""color: #993399; font-style: italic;"">
    <img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/healthy_liver_1.png"" style=""height: 297px; width: 412.25px;"" /></div>
    </td></tr>
    </tbody></table>
    <br style=""font-family: Verdana; font-size: 15px; text-align: justify;"" />
    <div style=""font-family: Verdana; font-size: 15px; text-align: center;"">
    <div style=""text-align: justify;"">
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>A healthy liver keeps you nourished, energized, strong, active, and toxin-free. You feel better and more youthful for years to come. Really, your liver is a&nbsp;<span style=""font-weight: bold;"">Priceless Gift!</span><br /><br />Yet the liver is the most under appreciated and forgotten organ in the body – even by doctors. Your doctor will never talk about your liver until problems begin but the latest research shows that when you’re suffering from any health issues, your liver is usually part of the trouble. This is because ...</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big><span class=""auto-style6""></span></big></div>
    <div style=""text-align: center;"">
    <big style=""color: #cc0000; font-size: 25px; font-weight: bold; line-height: 30px;""><span style=""color: black;"">Your Liver Is The&nbsp;<span style=""color: #cc0000;"">‘Missing Link’&nbsp;</span>For Feeling<br />Younger, Stronger And Healthier</span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big><span class=""auto-style6""></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>Your liver is the second largest organ in your body (your skin – yes, your skin – is the first!). Your liver performs more than 500 critical biological functions, makes more than 13,000 beneficial chemicals and hormones, manages more than 50,000 enzymes and compounds that you need for good health. It processes everything you eat and drink, including your medication and supplements. It also purifies your blood from dangerous toxins.</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><br /></big></div>
    <div style=""text-align: center;"">
    <big style=""color: #cc0000; font-size: 25px; font-weight: bold; line-height: 30px;""><span style=""color: black;"">On The Other Hand,&nbsp;<span style=""color: #cc0000;"">A Tired Or Unhealthy Liver&nbsp;</span>Can Leave You Feeling Old, Tired, And Weak</span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br /></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>But unlike your joints, which cry out loud by aching, burning, or creaking whenever there is internal issues, your liver suffers in near silence. To make matters worse, the few signs that your liver is tired and over-burdened are easy to confuse with the common signs of aging. For instance, you could experience:</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br /></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style49"" style=""background-color: yellow; font-size: 15pt; font-weight: bold;""><span style=""font-family: &quot;arial rounded mt bold&quot;;""></span></span></div>
    <big style=""font-style: italic;""><span class=""style17""><span class=""style146""><span class=""auto-style16""><span class=""auto-style6""><span class=""auto-style13""></span></span></span></span></span><span class=""auto-style10""></span></big><br />
    <div class=""MsoNormal"">
    <big style=""font-style: italic;""><span class=""auto-style10""><strong><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></strong><span style=""font-family: &quot;comic sans ms&quot;;""><o:p></o:p></span></span></big></div>
    <big style=""font-style: italic;""><span class=""auto-style10"">
    </span></big><br />
    <div>
    <span class=""auto-style10""></span><span class=""auto-style10""></span><br />
    <div class=""auto-style23"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style10""><big><strong></strong></big></span></div>
    <span class=""auto-style10"">
    </span></div>
    <span class=""auto-style10""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #993399; font-weight: bold;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style6""></span></big><span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; font-family: &quot;comic sans ms&quot;; text-decoration-line: underline;""><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big></span><br />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); margin-left: auto; margin-right: auto; padding: 5px; width: 421px;""><tbody>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top; width: 5px;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle; width: 95px;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">Low Energy &amp;&nbsp;</span></big><big>Weight Gain</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Indigestion, Bloating, Constipation, Gas Or Diarrhea</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Foggy Thinking And Trouble Focusing Attention</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Stiffness, Aching And Weak Muscles – Especially In Your Low Back And Shoulders</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Worries Over Cholesterol &amp;&nbsp;</big><big>Concerns About Blood Sugar</big></td></tr>
    </tbody></table>
    <big><span style=""font-weight: bold;""></span></big><big><br /></big>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big>But it’s only the beginning of what an unhealthy liver can lead to. If your liver is over-burdened you can also suffer from;</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br /></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><span class=""auto-style6""></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style49"" style=""background-color: yellow; font-size: 15pt; font-weight: bold;""><span style=""font-family: &quot;arial rounded mt bold&quot;;""></span></span></div>
    <big style=""font-style: italic;""><span class=""style17""><span class=""style146""><span class=""auto-style16""><span class=""auto-style6""><span class=""auto-style13""></span></span></span></span></span><span class=""auto-style10""></span></big><br />
    <div class=""MsoNormal"">
    <big style=""font-style: italic;""><span class=""auto-style10""><strong><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></strong><span style=""font-family: &quot;comic sans ms&quot;;""><o:p></o:p></span></span></big></div>
    <big style=""font-style: italic;""><span class=""auto-style10"">
    </span></big><br />
    <div>
    <span class=""auto-style10""></span><span class=""auto-style10""></span><br />
    <div class=""auto-style23"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style10""><big><strong></strong></big></span></div>
    <span class=""auto-style10"">
    </span></div>
    <span class=""auto-style10""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #993399; font-weight: bold;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style6""></span></big><span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; font-family: &quot;comic sans ms&quot;; text-decoration-line: underline;""><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big><big><strong><big><span style=""color: #cc0000;""></span></big></strong></big></span><br />
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); margin-left: auto; margin-right: auto; padding: 5px; width: 421px;""><tbody>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top; width: 5px;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle; width: 95px;""><big><span style=""font-family: &quot;comic sans ms&quot;;"">Poor Sleep</span></big><big><span class=""auto-style6""></span></big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Kidney Problems</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Heart Problem</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""font-family: &quot;Comic Sans MS&quot;; text-align: center; vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Diabtes And Slow Wound Healing</big></td></tr>
    <tr><td colspan=""2"" rowspan=""1"" style=""vertical-align: top;""><hr style=""height: 1px; width: 413px;"" />
    </td></tr>
    <tr><td style=""vertical-align: top;""><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/liver_bullet.png"" style=""height: 47px; width: 55px;"" /></td><td style=""text-align: justify; vertical-align: middle;""><big>Diarrhea Or Irregular Bowel Movements; etc</big><big><span class=""auto-style6""></span></big></td></tr>
    </tbody></table>
    <big><span class=""auto-style6""></span></big><big><span class=""auto-style6""></span></big><br />
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style49"" style=""background-color: yellow; font-size: 15pt; font-weight: bold;""><span style=""font-family: &quot;arial rounded mt bold&quot;;""></span></span></div>
    <big style=""font-style: italic;""><span class=""style17""><span class=""style146""><span class=""auto-style16""><span class=""auto-style6""><span class=""auto-style13""></span></span></span></span></span><span class=""auto-style10""></span></big><br />
    <div class=""MsoNormal"">
    <big style=""font-style: italic;""><span class=""auto-style10""><strong><span style=""font-family: &quot;comic sans ms&quot;; font-size: 13.5pt; line-height: 20.7px;""></span></strong><span style=""font-family: &quot;comic sans ms&quot;;""><o:p></o:p></span></span></big></div>
    <big style=""font-style: italic;""><span class=""auto-style10"">
    </span></big><br />
    <div>
    <span class=""auto-style10""></span><span class=""auto-style10""></span><br />
    <div class=""auto-style23"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <span class=""auto-style10""><big><strong></strong></big></span></div>
    <span class=""auto-style10"">
    </span></div>
    <span class=""auto-style10""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #993399; font-weight: bold;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;;""><span class=""auto-style6""></span></big><span class=""auto-style13""></span><span class=""auto-style10""></span><span class=""auto-style10"" style=""text-decoration-line: underline;""></span><span class=""auto-style10"" style=""color: #3333ff; font-family: &quot;comic sans ms&quot;; text-decoration-line: underline;""><big><strong></strong></big></span><big><span style=""font-weight: bold;""></span></big><big><br /></big>
    <div style=""text-align: center;"">
    <big style=""background-color: #ffff33; font-weight: bold;""><span class=""auto-style6"">If You’re Suffering From One Of The Symptoms<br />Above, Your Liver Could Be Crying Out For Help</span></big><br />
    <big><span class=""auto-style6""></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big><span class=""auto-style6""></span></big></div>
    <div style=""text-align: center;"">
    <big style=""color: #cc0000; font-size: 25px; font-weight: bold; line-height: 30px;"">Therefore, Don’t Ignore Your Liver Cry!</big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <br />
    <big><span class=""auto-style6""></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big>If you ignore your liver problems, you risk making your condition worse, and increase your chance of getting more serious health issues down the road, like&nbsp;<span style=""font-weight: bold;"">Cirrhosis, Diabetes, Heart Attack, Stroke, even Liver Cancer.</span><br /><br />I’m not trying to scare you, but to let you know how important your liver is. Liver issues are NOT something you should ""put aside"" or “leave till later.” And believe me, they’re not going to fix themselves. You must take immediate action, because quite honestly,&nbsp;<span style=""font-weight: bold;"">you may be living on borrowed time.</span></big><br />
    <big><span class=""auto-style6""></span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    <big><br /></big></div>
    <div style=""text-align: center;"">
    <big style=""color: #cc0000; font-size: 25px; font-weight: bold; line-height: 30px;""><span style=""color: black;""><span style=""color: #cc0000;"">But I Have Some Great News For!</span>&nbsp;You Can Support Your Liver Optimum Health And Functionalities With Our 3in1 For Liver Health</span></big></div>
    <div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
    </div>
    <div class=""auto-style18"" style=""text-align: center;"">
    <img alt="""" class=""blink_text"" src=""https://livebetterhealthy.com.ng/liversolution_files/tripplefacedown.gif"" style=""animation: 1s linear 0s infinite normal none running blinker; color: #cc0000; font-size: 25px; height: 66px; width: 245px;"" /></div>
    <div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
    <img alt="""" class=""blink_text"" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559235281/jognMerge_h87tpx.png"" style=""animation: 1s linear 0s infinite normal none running blinker; color: #cc0000; font-size: 25px; height: 300px; width: 377.109px;"" /></div>
    <br />
    <div class=""auto-style11"" style=""font-family: &quot;Courier New&quot;, Courier, monospace; text-align: center;"">
    <big><span class=""auto-style82"" style=""color: #993399;""><strong></strong></span></big></div>
    <table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 435px;""><tbody>
    <tr style=""font-family: &quot;Courier New&quot;, Courier, monospace;""><td colspan=""2"" rowspan=""1"" style=""text-align: justify; vertical-align: top;""><div class=""auto-style11"">
    <big><span class=""auto-style82"" style=""color: #666666;""><strong>3in1 For Liver Health</strong></span><span class=""auto-style78"">&nbsp;is a Natural Supplement Pack that can help you maintain your optimum Liver Health for Life.</span></big></div>
    <div class=""auto-style11"">
    <big><br /></big></div>
    <span style=""font-weight: bold;""></span><big><span class=""auto-style82""><strong></strong></span><span class=""auto-style78"">They are made up of strictly natural ingredients. They have No negative side effects rather than improving your overall liver health and detoxifies your body system as well.</span></big><big><span class=""auto-style82"" style=""color: #666666;""><strong></strong></span></big><big><span class=""auto-style78""><br /></span></big></td></tr>
    </tbody></table>
    <span class=""style46""></span><br />
    <div class=""auto-style11"" style=""background-color: white; color: #009900; font-family: &quot;Comic Sans MS&quot;; font-size: large; font-variant-east-asian: normal; font-variant-numeric: normal; font-weight: bold; line-height: normal; text-align: center; widows: 1;"">
    <span style=""font-style: italic;""></span></div>
    <big><span style=""font-family: &quot;comic sans ms&quot;; font-style: italic;""></span></big><br />
    <div style=""font-size: 25px; line-height: 30px; text-align: center;"">
    <span style=""color: #cc0000; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>You Need To Decide TODAY, To Restore<br />And Keep Your Liver Health For Good!</strong></span></div>
    <br />
    <span style=""font-family: &quot;comic sans ms&quot;;""><span style=""font-style: italic;""></span></span><br />
    <div>
    <big style=""font-family: &quot;Comic Sans MS&quot;;""><span style=""color: #cc0000; font-style: italic;""></span></big><big style=""font-family: &quot;Comic Sans MS&quot;; font-style: italic;""></big><span data-mce-style=""font-size: 18px; color: #000000;"" style=""font-family: &quot;comic sans ms&quot;; font-size: 18px;"">This therapy<span data-mce-style=""color: #ff0000;"" style=""color: red;""><strong style=""color: #cc0000;""></strong>&nbsp;</span>will also detoxify your body system, and also improve your overall body health. So not only will you eliminate your Liver problems, you will prolong your life as well.&nbsp;</span><span data-mce-style=""font-size: 18px; color: #000000;"" style=""color: #cc0000; font-size: 18px;""><strong>These Supplements has no harsh side effect.</strong></span></div>
    <br />
    <div style=""font-size: 25px; line-height: 30px; text-align: center;"">
    <span style=""color: #cc0000; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>These Products Are Cerified By NAFDAC<br />And Other International Organisations!</strong></span></div>
    <br />
    <div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/cert-2.jpg"" style=""height: 200px; width: 435.141px;"" /></div>
    <div>
    </div>
    <div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
    <div class=""auto-style40"" style=""text-align: center;"">
    <strong><img alt="""" src=""https://livebetterhealthy.com.ng/liversolution_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong></div>
    <br />
    <div style=""font-size: 25px; line-height: 30px; text-align: center;"">
    <span style=""color: #cc0000; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>3in1 For Liver Health<br /><span style=""color: #cc0000;"">~~</span></strong></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""color: #cc0000; font-size: 28px; font-style: italic;""><strong>~</strong><strong>~</strong><strong>~</strong><strong>~&nbsp;</strong><strong>@&nbsp;</strong><strong>~</strong><strong>~</strong><strong>~</strong><strong>~</strong><strong>~~</strong></span><br />
    <span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>The Discount Price Of</strong></span></div>
    <div class=""circle c1"" style=""background-color: black; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-align: center; text-transform: uppercase; width: 200px;"">
    <small>#37,500</small><big style=""background-color: transparent;""><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""><big style=""font-family: Verdana;""><big><span style=""color: black;""></span></big></big></span></span></strong></big><big style=""background-color: transparent;""><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span></strong></big><big><strong></strong></big></div>
    <span style=""font-family: &quot;comic sans ms&quot;;""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""></big><br />
    <div style=""font-size: 25px; line-height: 30px; text-align: center;"">
    <span style=""color: #cc0000; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-size: 28px; font-style: italic;""><strong>You can't go wrong with<br />this incredible Solution!</strong></span></div>
    <table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 584px;""><tbody>
    <tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""text-align: center;""></div>
    <span style=""font-family: &quot;arial rounded mt bold&quot;;""><span style=""font-style: italic;""><span style=""font-weight: bold;""><br /></span></span></span>
    <div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><small style=""font-family: Verdana;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big>Don't Wait A Moment, Order<br />Your 3-in-1 Now For Peak</big></big></span></strong></span></small></big></div>
    <div class=""auto-style96"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
    <big><small style=""font-family: Verdana;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big>Liver Health!</big></big></span></strong></span></small></big></div>
    <br />
    <div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
    <img alt="""" src=""https://res.cloudinary.com/fzany-inc/image/upload/v1559235281/jognMerge_h87tpx.png"" style=""height: 220px; width: 370.5px;"" /></div>
    </td></tr>
    </tbody></table>
    </div>
    </div>
    ",
                              ID="9e7325a3-6e1e-4b43-9508-c5cf0fd2756d".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Low Energy & Weight Gain."} },
                                  new Row(){ Body = new List<string>{ "Indigestion, Bloating, Constipation, Diarrhea."} },
                                  new Row(){ Body = new List<string>{ "Foggy Thinking & Trouble Focusing Attention."} },
                                  new Row(){ Body = new List<string>{ "Stiffness, Aching and Weak Muscle Especially in the low-back and shoulder. "} },
                                  new Row(){ Body = new List<string>{ "Worries over Cholesterol & Concern about Blood Sugar."} },
                              }
                          }
                           }
               }, 
                    //end of group
                      new DrugGroup(){
                   Name = "Excretory Problems ",
                    Photo = "https://res.cloudinary.com/fzany-inc/image/upload/v1559157887/jemo_yvxtyt.png",
                     AwonOgun = new List<Ogun>()
                     {
                          new Ogun()
                          {
                              Header ="Hemorrhoids ",
                              HtmlDescription = @"<img align=""top"" alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/hemorrhoids-cure-naturally.jpg"" style=""height: 215px; width: 483.5px;"" /><big style=""font-family: &quot;Arial Rounded MT Bold&quot;; font-style: italic; font-weight: bold;""><big><big><big><br /></big></big></big></big><br />
<div style=""font-family: Verdana; line-height: 35px; text-align: center;"">
<big style=""font-style: italic; font-weight: bold;""><big><big><big>Here Is How To Permanently Treat Your Hemorrhoids And&nbsp;<span style=""color: #6633ff;"">Stop Your Unnecessary Pains and Embarrassments For Good,</span><br />Using A Unique Products Combination No One Else Will Tell You About</big></big></big></big><br />
<big style=""font-style: italic; font-weight: bold;""><big><big><big><span style=""color: #993399; text-decoration-line: underline;""></span></big></big></big></big></div>
<div class=""auto-style31"" style=""font-family: Verdana;"">
<big><span class=""auto-style6""><span style=""font-style: italic; font-weight: bold;""><br /></span></span></big></div>
<div class=""auto-style31"" style=""color: #cc0000; font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""><span style=""font-style: italic; font-weight: bold;"">Dear Piles Sufferer,</span></span></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span style=""font-style: italic; font-weight: bold;""></span><br /></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>Are you struggling with hemorrhoids? Are you frustrated for not being able to treat your hemorrhoids and get relief from the pains despite all your efforts of applying creams and taking drugs?<br /><br />If you answered yes, you're about to discover what might be the most powerful hemorrhoids treatment ever developed. It's the same natural remedy thousands of men and women, just like you, used to permanently tackle their hemorrhoids and achieve permanent freedom from hemorrhoids' related symptoms.&nbsp;</big><big>.</big><big>You might have probably tried to tackle your Pile</big><big>&nbsp;by following a strict diet plan, spending money on all kinds of creams and medications that only treat the symptoms and provide a Temporary Relief, rather than tackle the main cause of hemorrhoids. This can be very expensive and time-consuming, yet the results that you got don't last for long.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div style=""font-family: Verdana; line-height: 37px; text-align: center;"">
<span style=""font-weight: bold;""></span><big style=""font-style: italic;""><big><big><strong><span style=""background-color: yellow;"">Therefore, before you spend another dime on medications that won't give you the relieve you want, take a few minutes to read below the truth about hemorrhoids (Piles).</span></strong></big></big></big><big style=""font-style: italic; font-weight: bold;""><big><big><big><span style=""color: #993399; text-decoration-line: underline;""></span></big></big></big></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>The truth is that, everyone has hemorrhoids, because they are just pillow-like veins located in the lower part of the rectum, around the anus, which help to pass out stools. However, what most of us call ""hemorrhoids"", is when these veins become&nbsp;<span style=""font-weight: bold;"">Inflamed or Swollen</span>, often causing:&nbsp;<span style=""font-weight: bold;"">Itching, Bleeding, Severe Pain and Discomfort.</span><br /><br />If the above symptoms sound familiar, then it's most likely you have hemorrhoids, but it's nothing to be ashamed&nbsp; of, since it's a condition that affects millions of men and women of all ages out there. See the picture below:</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""></span></big></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 314px;""><tbody>
<tr><td style=""text-align: center; vertical-align: middle;""><div class=""auto-style18 image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); color: #993399; font-style: italic; padding: 5px;"">
<img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/piles-samples.jpg"" style=""height: 465px; width: 292px;"" /></div>
</td></tr>
</tbody></table>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""></span></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""></span></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""><span style=""font-style: italic; font-weight: bold;""><br /></span></span></big></div>
<div style=""font-family: Verdana; line-height: 37px; text-align: center;"">
<span style=""background-color: white;""><span style=""font-weight: bold;""></span><big style=""font-style: italic;""><big><big><strong>The Only Way You Can Ever Get Rid Of Your Hemorrhoids is From Within by Correctly Feeding Your Body With What It Needs and Free Yourself. See Below Success Stories.</strong></big></big></big></span><big style=""font-style: italic; font-weight: bold;""><big><big><big><span style=""color: #993399; text-decoration-line: underline;""></span></big></big></big></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div class=""auto-style48"" style=""background-color: white; color: #3333ff; font-family: &quot;Comic Sans MS&quot;; font-size: 3.75403e-39px; text-align: justify;"">
<strong></strong></div>
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td style=""text-align: center; vertical-align: middle;""><img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/proof-2.png"" style=""height: 111px; width: 330px;"" /></td></tr>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; padding: 7px; text-align: center;"">
<span style=""font-style: italic; font-weight: bold;""><span style=""color: #333399;"">Success Story #1:&nbsp;</span>No More Pile</span></div>
<big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" /></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;"">Hi Olumide, thanks for your great natural Piles therapy and priceless advice. I totally understand what you mean about never-ending hemorrhoid creams, they are just there to make money for pharmaceutical companies. I have suffered from chonic hemorrhoids for more than 5 years now, but just after 2 weeks of using your Natural Piles Remedy, my hemorrhoids are gone! I still can't believe it.</span></big><br />
<big></big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;"">I am definitely going to share this with some of my friends who also have hemorrhoids. Thanks again for what you are doing and I really appreciate your help. Who would have thought that this problem could be solved so easily and naturally!</span></big><br />
<big></big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace; font-style: italic; font-weight: bold;"">Kunlele, Jos!</span></big></div>
</td></tr>
</tbody></table>
<big style=""font-family: Verdana;""><big><big><strong><span style=""background-color: yellow;""></span></strong></big></big><strong><span style=""background-color: yellow;""></span></strong></big><br />
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; padding: 7px; text-align: center;"">
<span style=""color: #333399; font-style: italic; font-weight: bold;"">Success Story #2:</span><span style=""font-style: italic; font-weight: bold;""><span style=""color: #333399;"">&nbsp;</span>I'm Back To Jogging</span></div>
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><br /></span></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;"">Dear Olumide, Before starting your Natural Piles Remedy, my pains were almost unbearable. I could not go for a long walk, as it would get very uncomfortable on the way and I would also get bleeding during my regular bowel movements. I seriously didn't know what to do about it, but one thing for sure - I didn't want to go for surgery.</span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></big><br style=""font-style: italic;"" />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;"">Thanks to your Natural Therapy. I'm now back to jogging (my favourite sport). It did take a couple of months for my hemorrhoids to go away completely, but it was well worth it.</span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic; font-weight: bold;"">Johnson.</span></span></big></div>
</td></tr>
</tbody></table>
<br />
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; padding: 7px; text-align: center;"">
<span style=""color: #333399; font-style: italic; font-weight: bold;"">Success Story #3:</span><span style=""font-style: italic; font-weight: bold;"">&nbsp;Bleeding Is Gone""</span></div>
<big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" /></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;"">Olumide, your Natural Piles Therapy is absolutely amazing and I love the fact that it has no side effects. It's really great that you've decided to share this information with everyone.</span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></big><br style=""font-style: italic;"" />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;"">My doctor was convinced that surgery was the only option for me, but despite his diagnosis, my bleeding is now gone thanks to the power of nature. Hemorrhoids are no bother for me anymore.</span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic; font-weight: bold;"">Michael Salawu.</span></span></big></div>
</td></tr>
</tbody></table>
<br />
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; padding: 7px; text-align: center;"">
<span style=""color: #333399; font-style: italic; font-weight: bold;"">Success Story #4:</span><span style=""font-style: italic; font-weight: bold;""><span style=""color: #333399;"">&nbsp;</span>My Pile has disappeared</span></div>
<big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" /></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;"">Since giving birth to my daughter Mary, I've had hemorrhoids that would often bleed, cause itching and just get in the way of my everyday life. I tried all the popular hemorrhoidal creams, but they didn't last long and the symptoms would come back. But after using your Natural Piles Remedy for two months, my hemorrhoids have disappeared. You definitely got this right. Thanks!&nbsp;<span style=""font-weight: bold;""></span></span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;""><span style=""font-weight: bold;""></span></span></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic;""><span style=""font-weight: bold;"">Abbey, Warri.</span></span></span><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace; font-style: italic; font-weight: bold;""></span></big></div>
</td></tr>
</tbody></table>
<br />
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; padding: 7px; text-align: center;"">
<span style=""font-style: italic; font-weight: bold;""><span style=""color: #333399;"">Success Story #5:</span>&nbsp;</span><span style=""font-style: italic; font-weight: bold;"">Pile gone, In One Month!</span></div>
<big><br style=""font-family: &quot;Courier New&quot;, Courier, monospace;"" /></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;"">I was pretty desperate to find a solution for curing my Piles [hemorrhoids], but whatever I tried didn't seem to make a difference. It was a huge of wasted time and money. So when I came across your Natural Therapy on Intenert, I thought I would give it a try, as I had nothing to lose. To my surprise, hemorrhoids eased-up the next day and was completely gone in one week and since then I've had no problems at all. Feels like I've never even had hemorrhoids before! Thank you so much!</span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""></span></big><br />
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><span style=""font-style: italic; font-weight: bold;"">Felix, Onitsha.</span></span></big></div>
</td></tr>
</tbody></table>
<br />
<table border=""0"" cellpadding=""2"" cellspacing=""2"" style=""margin-left: auto; margin-right: auto; width: 338px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: middle;""><div style=""background-color: gainsboro; color: #cc0000; font-family: Verdana; font-weight: bold; padding: 7px; text-align: center;"">
<span style=""color: #333399; font-style: italic;"">Success Story #6:</span><span style=""font-style: italic;"">&nbsp;Really Helped To Reduce Swelling</span></div>
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;""><br /></span></big>
<div style=""text-align: center;"">
<big><span style=""font-family: &quot;courier new&quot; , &quot;courier&quot; , monospace;"">Hi Olumide, just wanted to drop you a quick email saying that I have recently purchased your Natural Piles Remedy and it has really helped to reduce the swelling of my hemorrhoids. You are doing an excellent job and it's good to know there's someone out there who knows how to solve this embarrassing problem for real.</span></big></div>
</td></tr>
</tbody></table>
<br />
<div style=""text-align: center;"">
<big style=""font-family: Verdana; font-style: italic; font-weight: bold;""><big><big>Really, This Simply Works - Period!</big></big></big></div>
<br />
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big>Of course, all our bodies are unique and the results will vary from one person another, but the great thing is that there are many different Natural Home Remedies to choose from. Over 90% of the people who have tried this Natural Therapy have managed to get rid of their hemorrhoids within 2-4weeks, and some within 2months.<br /><br />Therefore, I would love to share this Remedy with YOU as well because, I believe this is the only natural, fast and time-proven way to safely get rid of hemorrhoids without any unwanted consequences.</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div style=""text-align: center;"">
<img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/what-youll-find.png"" style=""height: 81px; width: 338.438px;"" /><br />
<big style=""font-weight: bold;"">Here are the product combinations that made<br />up OUR NATURAL PILES REMEDY for fast<br />relieve from Piles (Hemorrhoids):</big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><span class=""auto-style6""></span></big></div>
<div class=""auto-style31"" style=""font-family: &quot;Comic Sans MS&quot;;"">
<big><br /></big></div>
<div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
<img alt="""" class=""blink_text"" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/pile_combo_01.png"" style=""animation: 1s linear 0s infinite normal none running blinker; color: #cc0000; font-size: 25px; height: 270px; width: 314.266px;"" /></div>
<div class=""auto-style18"" style=""color: #993399; font-style: italic; text-align: center;"">
<br />
<big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
<br />
<div style=""text-align: center;"">
<big style=""font-family: Verdana; font-style: italic; font-weight: bold;""><big><big>Are There Side Effects?</big></big></big></div>
<br />
<big>There are no side effects when you use the products combination above. They are non-hormonal and non-habit forming and can be used as often as youÃ¢â‚¬â„¢d like. If you have any serious medical conditions or you are currently on other medication, you should check with your doctor first.</big><br />
<br />
<div style=""line-height: 40px; text-align: center;"">
<span style=""color: #cc0000; font-family: &quot;verdana&quot;; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong>These Products Are Cerified By NAFDAC<br />And Other International Organisations!</strong></span></div>
<br />
<div class=""auto-style103"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/cert-2.jpg"" style=""height: 200px; width: 362.625px;"" /></div>
<div style=""text-align: justify;"">
</div>
<div class=""auto-style18"" style=""font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><big><big><big><span class=""auto-style23""></span></big></big></big></big></div>
<div class=""auto-style40"" style=""text-align: center;"">
<strong><img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/visit_us.gif"" style=""height: 70px; width: 125px;"" /></strong></div>
<div style=""line-height: 30px; text-align: center;"">
<span style=""color: #cc0000; font-family: &quot;verdana&quot;; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong>Natural Remedy For Pile</strong></span></div>
<br />
<div class=""circle c1"" style=""background-color: black; border-radius: 50%; color: white; font-size: 45px; font-weight: bold; height: 200px; line-height: 200px; margin: 0px auto 40px; text-align: center; text-transform: uppercase; width: 200px;"">
<small>#30,500</small><big style=""background-color: transparent;""><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""><big style=""font-family: Verdana;""><big><span style=""color: black;""></span></big></big></span></span></strong></big><big style=""background-color: transparent;""><strong><span style=""color: #993399;""><span style=""font-family: &quot;comic sans ms&quot;;""></span></span></strong></big><big><strong></strong></big></div>
<div class=""auto-style18"" style=""text-align: center;"">
<strong></strong></div>
<div style=""line-height: 40px; text-align: center;"">
<span style=""color: #cc0000; font-family: &quot;verdana&quot;; font-style: italic;""></span><span data-mce-style=""font-family: book antiqua, palatino; font-size: 28px; color: #000000;"" style=""font-family: &quot;verdana&quot;; font-size: 28px; font-style: italic;""><strong>You can't go wrong with<br />this incredible Solution!</strong></span></div>
<span style=""font-family: &quot;comic sans ms&quot;;""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""></big><span style=""font-family: &quot;comic sans ms&quot;;""></span><span style=""font-family: &quot;comic sans ms&quot;;""></span><big style=""font-family: &quot;Comic Sans MS&quot;;""></big><br />
<table border=""0"" cellpadding=""10"" cellspacing=""0"" style=""margin-left: auto; margin-right: auto; width: 584px;""><tbody>
<tr><td class=""image-border"" style=""border-radius: 7px; border: 2px solid rgb(100, 100, 100); padding: 5px; text-align: justify; vertical-align: top;""><div style=""background-color: white; font-family: Verdana; text-align: center;"">
</div>
<br />
<div class=""auto-style96"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><small style=""font-family: Verdana;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big>Don't Wait A Moment, Order<br />Your 3-in-1 For Getting</big></big></span></strong></span></small></big></div>
<div class=""auto-style96"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<big><small style=""font-family: Verdana;""><span style=""font-style: italic;""><strong><span class=""auto-style95""><big><big>Rid Of Pile</big></big></span></strong></span></small></big></div>
<div class=""auto-style96"" style=""background-color: white; font-family: &quot;Comic Sans MS&quot;; text-align: center;"">
<br />
<big><small style=""font-family: Verdana;""><span style=""font-style: italic;""><strong><span class=""auto-style95""></span></strong></span></small></big></div>
<div class=""auto-style18"" style=""background-color: white; color: #993399; font-family: Verdana; font-style: italic; text-align: center;"">
<img alt="""" src=""https://livebetterhealthy.com.ng/hemorrhoids_files/pile_combo_01.png"" style=""height: 200px; width: 370.5px;"" /></div>
<div>
<br /></div>
</td></tr>
</tbody></table>
",
                              ID="a1c86b6d-2e0d-460f-ad56-c7851210aa7a".Replace("-",""),
                              Rows = new List<Row>(){
                                 new Row(){ Body = new List<string>{ "Inflamed or Swollen Vein" } },
                                  new Row(){ Body = new List<string>{ "Itching, Bleeding" } },
                                  new Row(){ Body = new List<string>{ "Severe Pain and Discomfort" } },
                              }
                          }
                           }
               }, 
                    //end of group

            };
        }

    }

}