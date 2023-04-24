--Wypożyczalnia Samochodów--
Projekt wypożyczalni samochodów umożliwia użytkownikom wynajęcie samochodu na określony czas.

--Wymagania systemowe--
Aplikacja wymaga systemu operacyjnego Windows i środowiska .NET Framework w wersji 4.7.2 lub wyższej. Do obsługi bazy danych wymagany jest serwer SQL Server.

--Instalacja i uruchamianie--
Aby zainstalować aplikację, należy wykonać następujące kroki:

Sklonuj repozytorium na swoje urządzenie.
Otwórz projekt w środowisku programistycznym Visual Studio.
Utwórz bazę danych na serwerze SQL Server i zmodyfikuj połączenie w pliku conn.cs
Uruchom aplikację w trybie debugowania lub skompiluj plik wykonywalny i uruchom go.
--Funkcjonalności--
Aplikacja umożliwia:

dodawanie, usuwanie, modyfikowanie, przegladanie specyfikacji samochodów
dodawanie, usuwanie, modyfikowanie klientów
wypozyczanie samochodow na okreslony czas
monitorowanie ubezpieczeni OC i AC w samochodach
przeglądanie historii rezerwacji samochodów

--Użytkowanie--
Aby korzystać z aplikacji, należy:

Zalogować się na swoje konto administratora
Przejrzeć dostępne samochody i wybrać jeden z nich.
Wybrać daty rozpoczęcia i zakończenia wypożyczenia oraz potwierdzić wypozyczenie
Po zakończeniu okresu wypożyczenia zwrócić samochód do wypożyczalni.

--Konfiguracja--
W pliku conn.cs znajdują się ustawienia połączenia z bazą danych. Można je zmodyfikować, aby użyć innej bazy danych lub serwera SQL Server.

--Autorzy i licencja--
Autorami aplikacji są Filip Kościsty i Kacper Gołąbek. Aplikacja jest dostępna na licencji MIT.
