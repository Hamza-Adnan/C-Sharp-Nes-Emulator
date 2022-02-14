namespace NESDOTNET.Renderers
{
    public interface IRenderer
    {
       string RendererName { get; }

       void Draw();

       void InitRendering(UI ui);

       void EndRendering();
    }
}
