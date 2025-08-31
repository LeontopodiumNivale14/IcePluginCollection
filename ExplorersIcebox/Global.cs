/*
 * This file is used to import all the necessary namespaces and classes that are used in the plugin.
 * This file is then imported in ALL the files in the plugin.
 *
 * you never have to worry about importing the same namespaces in every file. Especially usefull für utility classes.
 */

global using Dalamud.Interface.Windowing;
global using Dalamud.Interface;
global using Dalamud.Plugin;
global using ECommons.DalamudServices;
global using ECommons.ImGuiMethods;
global using ECommons;
global using Dalamud.Bindings.ImGui;
global using System.Linq;
global using System.Numerics;
global using System;
global using static ECommons.GenericHelpers;

global using static ExplorersIcebox.ExplorersIcebox;

global using static ExplorersIcebox.Util.VislandRoutes;
global using Dalamud.Plugin.Services;

