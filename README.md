# Lucrare de laborator nr. 3. Bazele lucrului cu baze de date în Laravel.

## Scopul lucrării
Familiarizarea cu principiile de bază ale lucrului cu baze de date în Laravel. Învățarea creării de migrații, modele și seed-uri pe baza aplicației web To-Do App

## Condiții
În cadrul acestei lucrări de laborator, veți continua dezvoltarea aplicației To-Do App pentru echipe, începută în lucrările de laborator anterioare.

Veți adăuga funcționalitatea de lucru cu baza de date, veți crea modele și migrații, veți configura relațiile dintre modele și veți învăța să utilizați fabrici și seed-uri pentru generarea datelor de testare.

## Sarcina Nr. 1. Pregătirea pentru lucru
1. Instalați SGBD-ul MySQL, PostgreSQL sau SQLite pe calculatorul dumneavoastră.\
SGBD utilizat: SQL Server.

2. Crearea bazei de date: Creați o nouă bază de date pentru aplicația dvs. todo_app.\
[image1](./screenshots/1.2.png)

3. Configurați variabilele de mediu în fișierul .env pentru a vă conecta la baza de date.\
[image](./screenshots/1.3.png)


## Sarcina Nr. 2. Crearea modelelor și migrațiilor

1. Creați modelul Category — categoria unei sarcini.

2. Definirea structurii tabelei category în migrație: \ Adăugați câmpuri:
    - id — cheia primară;
    - name — numele categoriei;
    - description — descrierea categoriei;
    - created_at — data creării categoriei;
    - updated_at — data actualizării categoriei.\
[image](./screenshots/2.1_2.png)

3. Creați modelul Task — sarcina.

4. Definirea structurii tabelei task în migrație: \ Adăugați câmpuri:
    - id — cheia primară;
    - title — titlul sarcinii;
    - description — descrierea sarcinii;
    - created_at — data creării sarcinii;
    - updated_at — data actualizării sarcinii.\
[image](./screenshots/2.3_4.png)

5. Rulați migrarea pentru a crea tabelele în baza de date:\
[image](./screenshots/2.5.1.png)\
[image](./screenshots/2.5.2.png)\
[image](./screenshots/2.5.3.png)

6. Creați modelul Tag — eticheta unei sarcini.

7. Definirea structurii tabelei tag în migrație:\
[image](./screenshots/2.6_7.png)

## Sarcina Nr. 3. Relația dintre tabele
1. Creați o migrare pentru a adăuga câmpul category_id în tabela task.\
[image](./screenshots/3.1.1.png)

2. Creați o tabelă intermediară pentru relația de tipul multe-la-multe dintre sarcini și etichete:

3. Definirea structurii corespunzătoare a tabelei în migrație.\
[image](./screenshots/3.2.1.png)\
[image](./screenshots/3.2.2.png)

## Sarcina Nr. 4. Relația dintre tabele
1. Adăugați relații în modelul Category (O categorie poate avea multe sarcini)\
[image](./screenshots/4.1.png)

2. Adăugați relații în modelul Task
    - Sarcina este legată de o categorie.\
    [image](./screenshots/4.2.1.png)
    - Sarcina poate avea multe etichete.\
    [image](./screenshots/4.2.2.png)

3. Adăugați relații în modelul Tag (O etichetă poate fi legată de multe sarcini).\
[image](./screenshots/4.3.png)

## Sarcina Nr. 5. Crearea fabricilor și seed-urilor
1. Creați o fabrică pentru modelul Category.\
[image](./screenshots/5.1.png)

2. Creați o fabrică pentru modelul Task.\
[image](./screenshots/5.2.png)

3. Creați o fabrică pentru modelul Tag.\
[image](./screenshots/5.3.png)

4. Creați seed-uri pentru a popula tabelele cu date inițiale pentru modelele Category, Task, Tag.\
[image](./screenshots/5.4.1.png)\
[image](./screenshots/5.4.2.png)\
[image](./screenshots/5.4.3.png)

5. Actualizați fișierul DatabaseSeeder pentru a lansa seed-urile și rulați-le.\
În fișierul Program.cs:\
[image](./screenshots/5.5.png)

## Sarcina Nr. 6. Lucrul cu controlere și vizualizări
1. Deschideți controlerul TaskController
2. Actualizați metoda index pentru a obține lista sarcinilor din baza de date.\
[image](./screenshots/6.2.png)
3. Actualizați metoda show pentru a afișa o sarcină individuală.\
[image](./screenshots/6.3.png)
4. În metodele index și show, folosiți metoda with (Eager Loading) pentru a încărca modelele asociate.
5. Actualizați vizualizările corespunzătoare pentru a afișa lista de sarcini și o sarcină individuală.\
Index.chhtml\
[image](./screenshots/6.5.1.png)\
Show.chhtml\
[image](./screenshots/6.5.2.png)
6. Actualizați metoda create pentru a afișa formularul de creare a unei sarcini și metoda store pentru a salva o sarcină nouă în baza de date.\
[image](./screenshots/6.6.1.png)\
[image](./screenshots/6.6.2.png)
7. Actualizați metoda edit pentru a afișa formularul de editare a unei sarcini și metoda update pentru a salva modificările în baza de date.\
[image](./screenshots/6.7.1.png)\
[image](./screenshots/6.7.2.png)
8. Actualizați metoda destroy pentru a șterge o sarcină din baza de date.\
[image](./screenshots/6.8.png)