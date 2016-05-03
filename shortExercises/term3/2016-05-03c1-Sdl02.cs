// Nacho Cabanes
// sdl02.cs
// Segundo acercamiento a SDL

using Tao.Sdl;
using System; // Para IntPtr (puntero: imágenes, etc)

public class Sdl02
{

    public static void Main()
    {

        short anchoPantalla = 800;
        short altoPantalla = 600;
        int bitsColor = 24;
        int flags = Sdl.SDL_HWSURFACE | Sdl.SDL_DOUBLEBUF | Sdl.SDL_ANYFORMAT
          | Sdl.SDL_FULLSCREEN;
        IntPtr pantallaOculta;

        // Inicializamos SDL
        Sdl.SDL_Init(Sdl.SDL_INIT_EVERYTHING);
        pantallaOculta = Sdl.SDL_SetVideoMode(
          anchoPantalla,
          altoPantalla,
          bitsColor,
          flags);

        // Indicamos que se recorte lo que salga de la pantalla oculta
        Sdl.SDL_Rect rect2 =
          new Sdl.SDL_Rect(0,0, (short) anchoPantalla, (short) altoPantalla);
        Sdl.SDL_SetClipRect(pantallaOculta, ref rect2);

        // Cargamos una imagen
        IntPtr imagen;
        imagen = Sdl.SDL_LoadBMP("personaje.bmp");
        if (imagen == IntPtr.Zero) {
            System.Console.WriteLine("Imagen inexistente!");
            Environment.Exit(1);
        }

        // Parte repetitiva
        bool terminado = false;
        short x = 400;
        short y = 300;
        short anchoImagen = 50;
        short altoImagen = 50;
        Sdl.SDL_Event suceso;
        int numkeys;
        byte[] teclas;

        do
        {
            // Comprobamos sucesos
            Sdl.SDL_PollEvent(out suceso);
            teclas = Sdl.SDL_GetKeyState(out numkeys);

            // Miramos si se ha pulsado alguna flecha del cursor
            if (teclas[Sdl.SDLK_UP] == 1)
                y -= 2;
            if (teclas[Sdl.SDLK_DOWN] == 1)
                y += 2;
            if (teclas[Sdl.SDLK_LEFT] == 1)
                x -= 2;
            if (teclas[Sdl.SDLK_RIGHT] == 1)
                x += 2;
            if (teclas[Sdl.SDLK_ESCAPE] == 1)
                terminado = true;

            // Borramos pantalla
            Sdl.SDL_Rect origen = new Sdl.SDL_Rect(0,0,
              anchoPantalla,altoPantalla);
            Sdl.SDL_FillRect(pantallaOculta, ref origen, 0);
            // Dibujamos en sus nuevas coordenadas
            origen = new Sdl.SDL_Rect(0,0,anchoImagen,altoImagen);
            Sdl.SDL_Rect dest = new Sdl.SDL_Rect(x,y,
              anchoImagen,altoImagen);
            Sdl.SDL_BlitSurface(imagen, ref origen,
              pantallaOculta, ref dest);

            // Mostramos la pantalla oculta
            Sdl.SDL_Flip(pantallaOculta);

            // Y esperamos 20 ms
            System.Threading.Thread.Sleep( 20 );

        }  while (!terminado);

        // Finalmente, cerramos SDL
        Sdl.SDL_Quit();
    }
}
