using System.Reflection.Metadata;

namespace wizytaWeterynarz
{
    public partial class MainPage : ContentPage
    { 
        
        public MainPage()
        {
            InitializeComponent();

            string[] Animals = { "Pies", "Kot", "Świnka Morska" };
            listAnimals.ItemsSource = Animals;
        }

        /*
            Nazwa Funkcji:          onAnimalSelected
            Parametry Wejściowe:    sender - objekt klikniętej listy
            Wartość Zwracana:       brak
            Informacje:             Funkcja zależnie od wybranego zwierzęta ustawia
                                    maksymalną możliwą wartośc w sliderze "sldrAge"
            Autor:                  12362318612
         */
        private void onAnimalSelected(object sender, EventArgs e)
        {
            switch (listAnimals.SelectedItem.ToString()){
                case "Pies":
                    sldrAge.Maximum = 18;
                    break;

                case "Kot":
                    sldrAge.Maximum = 20;
                    break;

                case "Świnka Morska":
                    sldrAge.Maximum = 9;
                    break;

                default:
                    sldrAge.Maximum = 20;
                    break;   
            }
        }

        /*
            Nazwa Funkcji:          onSldrSlid
            Parametry Wejściowe:    sender - objekt przesuniętego slidera
            Wartość Zwracana:       brak
            Informacje:             Funkcja wyświetla wybrany wiek, poprzez zmianę
                                    tekstu label'a "lblAge" na ustawioną przy użyciu
                                    slider'a "sldrAge" wartość
            Autor:                  12362318612
         */
        private void onSldrSlid(object sender, EventArgs e)
        {
            lblAge.Text = $"Ile ma lat? {Math.Round(sldrAge.Value)}";

        }

        /*
            Nazwa Funkcji:          onOkClicked
            Parametry Wejściowe:    sender - objekt klikniętego przycisku
            Wartość Zwracana:       brak
            Informacje:             Funkcja informuje o zapisanej wizycie poprzez
                                    wyświetlenie komunikatu posiadającego wszystkie
                                    wpisane do formularza informacje
                                    (entName - imie, listAnimals - wybrane zwierzę,
                                    sldrAge - wiek zwierzęcia, entPurpose - cel wizyty
                                    oraz timeVisit - czas wizyty)
            Autor:                  12362318612
         */
        private async void onOkClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Zapisana Wizyta", $"{entName.Text}, {listAnimals.SelectedItem}, {Math.Round(sldrAge.Value)}, {entPurpose.Text}, {timeVisit.Time}", "OK");
        }

    }


}
