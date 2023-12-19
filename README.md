A program induláskor egy mainForm ablakot nyit meg, ahol be kell vinni egy input string-et (kezeli, ha konstans van benne, átalakítja i-re), továbbá a Table Input
gombra nyomva felugrik egy másik ablak, ahol kézzel vagy .csv file-al is fel lehet tölteni a szabály táblázatot (exportálni is lehet ezt a táblázatot, .csv formátumú lesz).
Kézzel való feltöltéskor a sorok száma automatikus növekszik, az oszlopok számának növelése az Add gomb megnyomásával lehetséges.
Miután feltöltöttük a táblázatot, rá kell nyomni aSave gombra, utána lehet csak bezárni ezt az ablakot. Ha ez megvolt, akkor a mainForm-on lehetőségünk van még megadni a stack első elemét
(Ha ez üres, akkor a táblázatbal felső sarkából fogja kiszedni az automata).
Ezek után a Print gomb megnyomása után felugrik egy outPut form, ahol kiírja, hogy éppen milyen műveletet talált, illetve az inputot, a stacket és egy számsorozatot, amely a szabályok számát sorrendben tárolja, valamint, hogy elfogadja-e
(Ha nem fogadja el, akkor nem ír ki, hogy elutasítva, csak a hívási láncot).
Példa: A mellékelt táblázatot 12+12*12 inputra el kell fogadnia
Amiket nem sikerült megoldani:
- ha végtelen ciklusba kerül
- az outPut egymás mellé teszi az elemeket és nem egymás alá