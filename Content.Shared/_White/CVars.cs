using Robust.Shared.Configuration;

namespace Content.Shared._White;

[CVarDefs]
public sealed class WhiteCVars
{
    #region Aspects

    public static readonly CVarDef<bool> IsAspectsEnabled =
        CVarDef.Create("aspects.enabled", false, CVar.SERVERONLY);

    public static readonly CVarDef<double> AspectChance =
        CVarDef.Create("aspects.chance", 0.1d, CVar.SERVERONLY);

    #endregion

    #region Locale

    public static readonly CVarDef<string>
        ServerCulture = CVarDef.Create("white.culture", "ru-RU", CVar.REPLICATED | CVar.SERVER);

    #endregion

    #region OptionsMisc

    public static readonly CVarDef<bool> LogInChat =
        CVarDef.Create("white.log_in_chat", true, CVar.CLIENT | CVar.ARCHIVE | CVar.REPLICATED);

    public static readonly CVarDef<string> EmotesMenuStyle =
        CVarDef.Create("white.emotes_menu_style", "Window", CVar.CLIENT | CVar.ARCHIVE);

    public static readonly CVarDef<bool> CoalesceIdenticalMessages =
        CVarDef.Create("white.coalesce_identical_messages", true, CVar.CLIENT | CVar.ARCHIVE | CVar.CLIENTONLY);

    #endregion

    #region Character Customization

    /// <summary>
    /// Players to set their own clown names.
    /// </summary>
    public static readonly CVarDef<bool> AllowCustomClownName =
        CVarDef.Create("customize.allow_custom_clown_name", true, CVar.REPLICATED);

    #endregion

    #region TTS

        /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<bool> TTSEnabled =
        CVarDef.Create("tts.enabled", false, CVar.SERVER | CVar.REPLICATED | CVar.ARCHIVE);

    /// <summary>
    /// URL of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiUrl =
        CVarDef.Create("tts.api_url", "", CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Auth token of the TTS server API.
    /// </summary>
    public static readonly CVarDef<string> TTSApiToken =
        CVarDef.Create("tts.api_token", "", CVar.SERVERONLY | CVar.CONFIDENTIAL);

    /// <summary>
    /// Amount of seconds before timeout for API
    /// </summary>
    public static readonly CVarDef<int> TTSApiTimeout =
        CVarDef.Create("tts.api_timeout", 5, CVar.SERVERONLY | CVar.ARCHIVE);

    /// <summary>
    /// Default volume setting of TTS sound
    /// </summary>
    public static readonly CVarDef<float> TTSVolume =
        CVarDef.Create("tts.volume", 0f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Count of in-memory cached tts voice lines.
    /// </summary>
    public static readonly CVarDef<int> TTSMaxCache =
        CVarDef.Create("tts.max_cache", 250, CVar.SERVERONLY | CVar.ARCHIVE);

    #endregion

    public static readonly CVarDef<bool> PMMEnabled =
        CVarDef.Create("pmm.enabled", true, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<bool> ChatFancyFont =
    	CVarDef.Create("chat.chat_fancy_font", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> ColoredBubbleChat =
    	CVarDef.Create("chat.colored_bubble_chat", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> PixelSnapCamera =
    	CVarDef.Create("experimental.pixel_snap_camera", false, CVar.CLIENTONLY | CVar.ARCHIVE);

    #region Shoving
    /// <summary>
    /// Arbitrary shove range multiplier. Does not affect entities with ItemComponent.
    /// </summary>
    public static readonly CVarDef<float> ShoveRange =
        CVarDef.Create("game.shove_range", 8f, CVar.SERVER | CVar.ARCHIVE);

    /// <summary>
    /// Arbitrary shove speed multiplier, does not affect range (unless you put it too high).
    /// </summary>
    public static readonly CVarDef<float> ShoveSpeed =
        CVarDef.Create("game.shove_speed", 3f, CVar.SERVER | CVar.ARCHIVE);

    /// <summary>
    /// How much should the mass difference affect shove range & speed.
    /// </summary>
    public static readonly CVarDef<float> ShoveMassFactor =
        CVarDef.Create("game.shove_mass_factor", 3f, CVar.SERVER | CVar.ARCHIVE);
    #endregion

    #region Graphics

    /// <summary>
    /// What intensity will the grain shader be at
    /// </summary>
    public static readonly CVarDef<float> FilmGrainStrength =
        CVarDef.Create("graphics.film_grain_strength", 50f, CVar.CLIENTONLY | CVar.ARCHIVE);

    /// <summary>
    /// Grain shader on/off
    /// </summary>
    public static readonly CVarDef<bool> FilmGrain =
            CVarDef.Create("graphics.film_grain", true, CVar.CLIENTONLY | CVar.ARCHIVE);

    #endregion

    #region Asteroid field generation

    public static readonly CVarDef<bool> SalvageMagnetEnabled =
        CVarDef.Create("white.salvage_magnet_enabled", false, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<bool> AsteroidFieldEnabled =
        CVarDef.Create("asteroidfield.enabled", true, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<bool> AsteroidFieldSpawnBeacon =
        CVarDef.Create("asteroidfield.beacon_enabled", true, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<string> AsteroidFieldBeaconGridPath =
        CVarDef.Create("asteroidfield.beacon_grid_path", "/Maps/_White/Shuttles/asteroid_beacon.yml", CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<string> AsteroidFieldBeaconName =
        CVarDef.Create("asteroidfield.beacon_name", "asteroid-beacon-name", CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<float> AsteroidFieldDistanceMin =
        CVarDef.Create("asteroidfield.min_distance", 2000f, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<float> AsteroidFieldDistanceMax =
        CVarDef.Create("asteroidfield.max_distance", 2000f, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<int> AsteroidFieldAsteroidCount =
        CVarDef.Create("asteroidfield.asteroid_count", 15, CVar.SERVER | CVar.ARCHIVE);

    public static readonly CVarDef<int> AsteroidFieldDerelictCount =
        CVarDef.Create("asteroidfield.derelict.count", 5, CVar.SERVER | CVar.ARCHIVE);
    #endregion
}
