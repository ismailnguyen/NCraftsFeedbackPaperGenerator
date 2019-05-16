using System;
using IronPdf;
using Newtonsoft.Json;

namespace NCraftsFeedbackPaperGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJsonString = @"[{""title"":""DDD Modelling vs Implementation"",""speakerName"":""Mathias Verraes""},{""title"":""EventStorming and Example Mapping From Problem Space to Solution Space"",""speakerName"":""Kenny Baas-Schwegler, Bruno Boucard & Thomas Pierrain""},{""title"":""Refactoring to Immutability"",""speakerName"":""Kevlin Henney""},{""title"":""Mob Programming"",""speakerName"":""Woody Zuill""},{""title"":""KEYNOTE : The one with the compiler always wins"",""speakerName"":""Ulrika Malmgren""},{""title"":""Teaching a machine to code"",""speakerName"":""Samir Talwar""},{""title"":""Bourdieu's Social theory and our work in tech"",""speakerName"":""Romeu Moura""},{""title"":""Applicatives IRL"",""speakerName"":""Jérémie Chassaing""},{""title"":""Community based design"",""speakerName"":""Emanuela Damiani""},{""title"":""Music tech hacking"",""speakerName"":""Helen Leigh""},{""title"":""KEYNOTE : The gordian knot → Hatching Software Development Ecosystems"",""speakerName"":""Alberto Brandolini""},{""title"":""KEYNOTE : The one with the compiler always wins"",""speakerName"":""Ulrika Malmgren""},{""title"":""Application design with a stack of monads"",""speakerName"":""Clément Delafargue""},{""title"":""Security by Stealth"",""speakerName"":""Gwen Diagram""},{""title"":""Non-Euclidean Software Delivery"",""speakerName"":""Anna Savarin""},{""title"":""Railroad-Driven Programming"",""speakerName"":""Aki Salmi""},{""title"":""Brutal refactoring, lying code, the Churn, and other emotional stories from Legacy Land"",""speakerName"":""Matthias Noback""},{""title"":""KEYNOTE : The gordian knot → Hatching Software Development Ecosystems"",""speakerName"":""Alberto Brandolini""},{""title"":""KEYNOTE : The one with the compiler always wins"",""speakerName"":""Ulrika Malmgren""},{""title"":""Test && commit || revert"",""speakerName"":""Xavier Detant""},{""title"":""Talking with Tech Leads"",""speakerName"":""Patrick Kua""},{""title"":""The Passions of Programming"",""speakerName"":""Kevlin Henney""},{""title"":""How to rewrite, a bit at a time"",""speakerName"":""Sabrina Leandro""},{""title"":""Continuous Delivery and the Theory of Constraints"",""speakerName"":""Steve Smith""},{""title"":""KEYNOTE : The gordian knot → Hatching Software Development Ecosystems"",""speakerName"":""Alberto Brandolini""},{""title"":""KEYNOTE : The one with the compiler always wins"",""speakerName"":""Ulrika Malmgren""},{""title"":""Storage Systems: The Old, The New, The Overlooked"",""speakerName"":""Alex Petrov""},{""title"":""Escher in Elm"",""speakerName"":""Einar Høst""},{""title"":""Plankalkül: a high-level language from the 1940s"",""speakerName"":""Eric Lefevre-Ardant""},{""title"":""How to lose your feature overload ?"",""speakerName"":""Estelle Landry""},{""title"":""How video games taught me event sourcing"",""speakerName"":""Jean Paliès""},{""title"":""Slim Down Diet & TDD"",""speakerName"":""Dorra Bartaguiz""},{""title"":""Event Sourcing Done Right - Experiences from the Trenches"",""speakerName"":""Dennis Doomen""},{""title"":""KEYNOTE : The gordian knot → Hatching Software Development Ecosystems"",""speakerName"":""Alberto Brandolini""},{""title"":""KEYNOTE : The one with the compiler always wins"",""speakerName"":""Ulrika Malmgren""},{""title"":""Devils, Wizards and Decision Making Heuristics: Magic 8 Balls to the Rescue"",""speakerName"":""Gien Verschatse""},{""title"":""Iterating on domain models"",""speakerName"":""Marijn Huizendveld""},{""title"":""Rescuing legacy - from legacy to TDD"",""speakerName"":""Johan Martinsson""},{""title"":""KEYNOTE : The gordian knot → Hatching Software Development Ecosystems"",""speakerName"":""Alberto Brandolini""},{""title"":""KEYNOTE : Crafting Compassionate Code"",""speakerName"":""April Wensel""},{""title"":""Four Languages from Forty Years Ago"",""speakerName"":""Scott Wlaschin""},{""title"":""In defence of uncertainty"",""speakerName"":""Abeba Birhane""},{""title"":""The Search for Fundamental Software Engineering Principles"",""speakerName"":""Tomas Petricek""},{""title"":""Learning from how science and philosophy progress"",""speakerName"":""Brian Marick""},{""title"":""Are Programming Languages Languages?"",""speakerName"":""Alvaro Videla""},{""title"":""KEYNOTE : Nihilism and Technology"",""speakerName"":""Nolen Gertz""},{""title"":""KEYNOTE : Crafting Compassionate Code"",""speakerName"":""April Wensel""},{""title"":""Domain Driven UI"",""speakerName"":""Marco Heimeshoff""},{""title"":""Socio-technical DDD - Essential social heuristics"",""speakerName"":""Evelyn Van Kelle""},{""title"":""Domain Modelling for Digital Transformations"",""speakerName"":""Cyrille Martraire""},{""title"":""Evolving with the changing requirements - Using DDD and Saga Message Pattern"",""speakerName"":""Indu Alagarsamy""},{""title"":""I got Trapped! Systems thinking traps of IT Teams and how to battle them"",""speakerName"":""Kenny Baas-Schwegler""},{""title"":""KEYNOTE : Nihilism and Technology"",""speakerName"":""Nolen Gertz""},{""title"":""KEYNOTE : Crafting Compassionate Code"",""speakerName"":""April Wensel""},{""title"":""Exploratory testing for everyone"",""speakerName"":""Alexandra Schladebeck""},{""title"":""Exploratory testing for everyone"",""speakerName"":""Thomas Garus""},{""title"":""Temporal Modelling"",""speakerName"":""Mathias Verraes""},{""title"":""Your Brain doesn't have a Fix Flag"",""speakerName"":""Sara Vieira""},{""title"":""Domain Prototyping, or Design is How it Works."",""speakerName"":""Tobias Goeschel""},{""title"":""Technical Leadership for Empowered Teams"",""speakerName"":""Emily Bache""},{""title"":""KEYNOTE : Nihilism and Technology"",""speakerName"":""Nolen Gertz""},{""title"":""KEYNOTE : Crafting Compassionate Code"",""speakerName"":""April Wensel""},{""title"":""Collaborating on Open Source Software; How I Started contributing to Open Source and Why You Should Too"",""speakerName"":""Marit van Dijk""},{""title"":""Continuous reteaming: adopt self-selection and start moving people to the work!"",""speakerName"":""Julien Lavigne du Cadet""},{""title"":""From Feature Team to Mission Teams"",""speakerName"":""Frédéric Rivain""},{""title"":""(Quick) kata to explain D from SOLID principles"",""speakerName"":""Michelle Avomo""},{""title"":""Easy functional programming with elm"",""speakerName"":""Pascal Le Merrer""},{""title"":""KEYNOTE : Nihilism and Technology"",""speakerName"":""Nolen Gertz""},{""title"":""KEYNOTE : Crafting Compassionate Code"",""speakerName"":""April Wensel""},{""title"":""Xtrem Reading - Read differently and cultivate your collective intelligence"",""speakerName"":""Yoan Thirion""},{""title"":""Xtrem Reading - Read differently and cultivate your collective intelligence"",""speakerName"":""Cédric Tamavond""},{""title"":""Estimates or No Estimates, Let's explore the possibilities"",""speakerName"":""Woody Zuill""},{""title"":""Let's discover event-based programming!"",""speakerName"":""Thomas Bracher""},{""title"":""KEYNOTE : Nihilism and Technology"",""speakerName"":""Nolen Gertz""}]";

            FeedbackForm[] feedbackForms = JsonConvert.DeserializeObject<FeedbackForm[]>(myJsonString);

            foreach (var form in feedbackForms)
            {
                var fileName = $"{ form.speakerName.Replace(" ", "_") }-{ form.title.Replace(" ", "_").Replace(":", "-").Replace("?", "").Replace("|", "").Replace("&", "") }.pdf";

                try
                {
                    HtmlToPdf Renderer = new HtmlToPdf();

                    Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
                    Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape;

                    var pdf = Renderer.RenderHtmlAsPdf($@"
                        <h1 style='text-align:center;font-size:56px;'>{ form.title }</<h1>
                        <h2 style='text-align:center;font-size:48px;'>{ form.speakerName }</h2>

                        <h3 style='font-size:20px;'>Message</h3>
                        <div style='width: 3000px; height: 900px;position: relative;border-bottom: 5px solid #262627;border-left: 5px solid #262627;'></div>
                        <h3 style='text-align:center;font-size:20px;'>Delivery</h3>
                    ");

                    pdf.SaveAs(fileName);

                    Console.WriteLine($"PDF file created for { fileName }");
                }
                catch(Exception e) {
                    Console.WriteLine($"Error while createing { fileName } : { e.Message }");
                }
            }

            Console.ReadKey();
        }

        public class FeedbackForm
        {
            public string title;
            public string speakerName;
        }
    }
}
