namespace FlyoutTabNavPrefi.Pages;

public partial class SabrinaCarpenterPage : ContentPage
{
    String SabrinaPageText = "This is one of the works of Sabrina.";

    String SabrinaAlbum = "On February 2022, she released emails I can't send. " +
        "In that album, she wrote my favorite song called Fast Times.";

    String SabrinaPageFavoriteSong = "Fast Times is about seizing the moment of youth, " +
        "of love, and of everything else because time is fast and will run out. It's also very danceable" +
        " and entertaining, which puts me in a jolly mood.";

    public SabrinaCarpenterPage()
	{
		InitializeComponent();
        ChangeSabrinaLabel();
	}

    public void ChangeSabrinaLabel()
    {
        sabrinaText.Text = SabrinaPageText;
        sabrinaAlbum.Text = SabrinaAlbum;
        sabrinaFavorite.Text = SabrinaPageFavoriteSong;
    }
}