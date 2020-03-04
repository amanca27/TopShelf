using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TopShelf.Extensions;
using TopShelf.Models;


namespace TopShelf.Controllers
{
    public class TurnUpController : Controller
    {

        public async Task<IActionResult> Index()
        {

            PlaylistListModel  playlists = await GetPlaylists();

            return View(playlists);
        }


        private async Task<PlaylistListModel> GetPlaylists()
        {

            HttpClient client = new HttpClient();

            string path = "https://api.spotify.com/v1/me/playlists";

            //Need to store this OAuth token in the Session or Cookie and pull from there

            client.DefaultRequestHeaders.Add("Authorization", "Bearer BQAxYJ3txT4YK7vkr2L3yaeC2j2p_BTK2fCjhQdbM2axzbSgFvXet4i8x0KAaw00KOUK5jk09dtnOiBeHlxp0luoJePIjFydlvbwW-KAW65_nqZulsBcsVWPVPh_pQjZUUtdf58xU2nM");

            HttpResponseMessage response = await client.GetAsync(path);

            PlaylistListModel playlists = await response.Content.ReadAsJsonAsync<PlaylistListModel>();

            return playlists;

        }

        
    }
}