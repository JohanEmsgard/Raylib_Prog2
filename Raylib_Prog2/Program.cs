global using Raylib_cs;

Raylib.InitWindow(900,700, "Bäst");
Raylib.SetTargetFPS(60);

Avatar Scepitle = new Avatar();

while (!Raylib.WindowShouldClose())
{

    //Logik
    Scepitle.Update();


    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Scepitle.Draw();



    Raylib.EndDrawing();

}

