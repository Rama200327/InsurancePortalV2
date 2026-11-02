using Tesseract;
namespace InsuraV2.Services
{
    public class OcrService
    {
        public string ReadText(string imagePath)
        {
            using var engine = new TesseractEngine(
                @"tessdata",
                "eng",
                EngineMode.Default);

            using var img = Pix.LoadFromFile(imagePath);

            using var page = engine.Process(img);

            return page.GetText();
        }
    }
}
