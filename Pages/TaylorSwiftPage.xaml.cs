namespace FlyoutTabNavPrefi.Pages;

public partial class TaylorSwiftPage : ContentPage
{
	String TaylorPageText = "This is one of the works of Taylor.";

	String FavoriteAlbum = "On July 2020, she released Folklore. " +
		"In that album, she wrote my favorite song called Peace.";

    String TaylorPageFavoriteSong = "Peace expresses love in its purest form. However, " +
		"love for a well-known artist like Taylor Swift brings chaos to her and her lover. " +
		"In this love song, she confesses the different sacrifices she can make for love," +
		"but also the risks in loving her.";
    public TaylorSwiftPage()
	{
		InitializeComponent();
		ChangeTaylorLabel();
	}

	public void ChangeTaylorLabel()
	{
		taylorText.Text = TaylorPageText;
		taylorFavorite.Text = TaylorPageFavoriteSong;
		taylorAlbum.Text = FavoriteAlbum;
	}
}