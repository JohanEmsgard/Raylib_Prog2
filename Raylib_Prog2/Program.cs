global using Raylib_cs;

Raylib.InitWindow(900,700, "Bäst");
Raylib.SetTargetFPS(60);

Avatar Scepitle = new Avatar();

while (!Raylib.WindowShouldClose())
{

    //Logik
    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE);
    Scepitle.Draw();



    Raylib.EndDrawing();

}

