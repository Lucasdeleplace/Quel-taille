Console.WriteLine("--- Quelle taille dois-je prendre ? ---\n");

Console.Write("Entrez votre taille (en cm) : ");
int taille = int.Parse(Console.ReadLine());

Console.Write("Entrez votre poids (en kg) : ");
int poids = int.Parse(Console.ReadLine());

if ((taille >= 145 && taille <= 162) && (poids >= 43 && poids <= 65) || taille <= 163 && (poids >= 43 && poids <= 59) || taille <= 166 && (poids >= 43 && poids <= 53) || taille <= 169 && (poids >= 43 && poids <= 47))
{
    Console.WriteLine("Prennez la taille 1");
}
else if ((taille >= 160 && taille < 163) && (poids >= 66 && poids <= 71) || taille <= 166 && (poids >= 60 && poids <= 71) || taille <= 169 && (poids >= 48 && poids <= 71) || taille <= 172 && (poids >= 48 && poids <= 65) || taille <= 175 && (poids >= 48 && poids <= 59) || taille <= 178 && (poids >= 48 && poids <= 53))
{
    Console.WriteLine("Prennez la taille 2");
} 
else if ((taille >= 163 && taille < 166) && (poids >= 72 && poids <= 77) || taille <= 169 && (poids >= 72 && poids <= 77) || taille <= 172 && (taille >= 66 && poids <= 77) || taille <= 175 && (poids >= 60 && poids <= 77) || taille <= 178 && (poids >= 54 && poids <= 77) || taille <= 183 && (poids >= 54 && poids <= 77))
{
    Console.WriteLine("Prennez la taille 3");
}
else
{
    Console.WriteLine("Aucune taille ne vous correspond");
}