using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpotifyAPI.Web.Models;

namespace TopShelf.Models
{
    public class PlaylistListModel
    {
        public string href { get; set; }

        [JsonPropertyName("items")]
        public List<FullPlaylist> Playlists { get; set; }
    }

}
