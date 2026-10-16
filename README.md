# Setsunary
An itinerary, with focus on creating memories through photography.

*Setsuna means "**moment**", combined with Itinerary: **Setsunary***


### Notes for peer-review (in case)
Tailwind is not included in this repository. In order to set it up:

1. Download the Tailwind standalone CLI from the Tailwind GitHub release.
2. Rename it to `tailwindcss.exe` and put it in `Tools/` *(add it if it doesn't exist)*.
3. From the root, run these two watch commands (in different terminals) while developing:

```
dotnet watch
```

```
.\Tools\tailwindcss.exe -i .\Styles\app.css -o .\wwwroot\css\tailwind.css --watch
```
