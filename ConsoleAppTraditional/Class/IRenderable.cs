namespace ConsoleAppTraditional.Class
{
    public interface IRenderable
    {
        void Render();
    }

    public abstract class Component
    {
        public int Position { get; set; }

        public abstract void Move();
    }

    public class Button : Component, IRenderable
    {
        public override void Move()
        {
            Console.WriteLine("Button is moving");
        }

        public void Render()
        {
            Console.WriteLine("Button is rendered");
        }
    }

    public class ImageComponent : Component, IRenderable
    {
        public override void Move()
        {
            Console.WriteLine("Image is moving");
        }

        public void Render()
        {
            Console.WriteLine("Image is rendered");
        }
    }
}
