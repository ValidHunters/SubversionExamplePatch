using Content.Shared.Overlays;
using Robust.Shared.GameObjects;
using Robust.Shared.Player;

public static class SubverterPatch
{
    public static string Name = "HUD Overlays patch";
    public static string Description = "Includes all hud overlays for the player";
}

/// <summary>
/// Добавляет все компоненты к игроку из https://github.com/space-wizards/space-station-14/tree/master/Content.Shared/Overlays
/// </summary>

public sealed class IconsSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<LocalPlayerAttachedEvent>(OnLocalPlayerAttached);
    }

    void OnLocalPlayerAttached(LocalPlayerAttachedEvent args)
    {
        var localPlayer = args.Entity;
        ShowJobIcons(localPlayer);
        ShowMindShieldIcons(localPlayer);
        ShowHealthBars(localPlayer);
        ShowSyndicateIcons(localPlayer);
        ShowCriminalRecordIcons(localPlayer);
    }

    void ShowJobIcons(EntityUid uid)
    {
        if (!HasComp<ShowJobIconsComponent>(uid))
        {
            var component = new ShowJobIconsComponent
            {
                NetSyncEnabled = false
            };
            AddComp(uid, component);
        }
    }

    void ShowMindShieldIcons(EntityUid uid)
    {
        if (!HasComp<ShowMindShieldIconsComponent>(uid))
        {
            var component = new ShowMindShieldIconsComponent
            {
                NetSyncEnabled = false
            };
            AddComp(uid, component);
        }
    }

    void ShowCriminalRecordIcons(EntityUid uid)
    {
        if (!HasComp<ShowCriminalRecordIconsComponent>(uid))
        {
            var component = new ShowCriminalRecordIconsComponent
            {
                NetSyncEnabled = false
            };
            AddComp(uid, component);
        }
    }

    void ShowSyndicateIcons(EntityUid uid)
    {
        if (!HasComp<ShowSyndicateIconsComponent>(uid))
        {
            var component = new ShowSyndicateIconsComponent
            {
                NetSyncEnabled = false,
            };
            AddComp(uid, component);
        }
    }

    void ShowHealthBars(EntityUid uid)
    {
        if (!HasComp<ShowHealthBarsComponent>(uid))
        {
            var component = new ShowHealthBarsComponent
            {
                NetSyncEnabled = false,
                DamageContainers =
                {
                    "Biological",
                    "Inorganic",
                    "Silicon"
                }
            };
            AddComp(uid, component);
        }
    }
}
