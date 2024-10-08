﻿using System;
using ContentPatcher;
using GenericModConfigMenu;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace GNMTokens
{
	/// <summary>The mod entry point.</summary>
	public class ModEntry : Mod
	{
		/*********
		** Properties
		*********/
		private ModConfig Config;

		/*********
		** Public methods
		*********/
		public override void Entry(IModHelper helper)
		{
			helper.Events.GameLoop.GameLaunched += this.OnGameLaunched;
			//Code for next release
			helper.Events.GameLoop.SaveLoaded += this.OnSaveLoaded;
			helper.Events.GameLoop.Saving += this.OnSaving;
			helper.Events.GameLoop.SaveCreating += this.OnSaveCreating;
			this.Config = this.Helper.ReadConfig<ModConfig>();
		}

		/*********
		** Private methods
		*********/

		//Code for next release
		private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
		{
            if (Config.Gender == "Nonbinary (They/Them)")
            {
                Game1.player.Gender = Gender.Undefined;
            }
            else if (Config.Gender == "Male")
            {
                Game1.player.Gender = Gender.Male;
            }
            else if (Config.Gender == "Female")
            {
                Game1.player.Gender = Gender.Female;
            }
            else
            {
                Game1.player.Gender = Gender.Undefined;
            };
        }
        private void OnSaving(object sender, EventArgs e)
        {
            if (Config.Gender == "Nonbinary (They/Them)")
            {
                Game1.player.Gender = Gender.Undefined;
            }
            else if (Config.Gender == "Male")
            {
                Game1.player.Gender = Gender.Male;
            }
            else if (Config.Gender == "Female")
            {
                Game1.player.Gender = Gender.Female;
            }
            else
            {
                Game1.player.Gender = Gender.Undefined;
            };
        }
        private void OnSaveCreating(object sender, EventArgs e)
        {
            if (Config.Gender == "Nonbinary (They/Them)")
            {
                Game1.player.Gender = Gender.Undefined;
            }
            else if (Config.Gender == "Male")
            {
                Game1.player.Gender = Gender.Male;
            }
            else if (Config.Gender == "Female")
            {
                Game1.player.Gender = Gender.Female;
            }
            else
            {
                Game1.player.Gender = Gender.Undefined;
            };
        }

        private void OnGameLaunched(object sender, GameLaunchedEventArgs e)
		{	
			var api = this.Helper.ModRegistry.GetApi<IContentPatcherAPI>("Pathoschild.ContentPatcher");
			
			//check if Content Patcher API is available
			if (api is null)
				return;

            //Register Content Patcher Tokens for the GNM
            api.RegisterToken
                (
                    this.ModManifest, "Gender", () =>
                    {
                        return new[] { this.Config.Gender };
                    }
                );
            api.RegisterToken
				(
					this.ModManifest, "Singular", () =>
					{
						return new[] { this.Config.Singular.ToString() };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "SubjectivePronoun", () =>
					{
						return new[] { this.Config.SubjectivePronoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ObjectivePronoun", () =>
					{
						return new[] { this.Config.ObjectivePronoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "PossessivePronoun", () =>
					{
						return new[] { this.Config.PossessivePronoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "Title", () =>
					{
						return new[] { this.Config.Title };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "Adjective", () =>
					{
						return new[] { this.Config.Adjective };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "SpouseNoun", () =>
					{
						return new[] { this.Config.SpouseNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "GenericNoun", () =>
					{
						return new[] { this.Config.GenericNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "AdultAntiquatedNoun", () =>
					{
						return new[] { this.Config.AdultAntiquatedNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "AdultFamilialNoun", () =>
					{
						return new[] { this.Config.AdultFamilialNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "AdultInformalNoun", () =>
					{
						return new[] { this.Config.AdultInformalNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ElderAntiquatedNoun", () =>
					{
						return new[] { this.Config.ElderAntiquatedNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ElderInformalNoun", () =>
					{
						return new[] { this.Config.ElderInformalNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ElderFamilialNoun", () =>
					{
						return new[] { this.Config.ElderFamilialNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ChildFamilialNoun", () =>
					{
						return new[] { this.Config.ChildFamilialNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ServiceFormalNoun", () =>
					{
						return new[] { this.Config.ServiceFormalNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "TraderNoun", () =>
					{
						return new[] { this.Config.TraderNoun };
					}
				);
			api.RegisterToken
				(
					this.ModManifest, "ParentalNoun", () =>
					{
						return new[] { this.Config.ParentalNoun };
					}
				);
            api.RegisterToken
                (
                    this.ModManifest, "TermOfEndearment", () =>
                    {
                        return new[] { this.Config.TermOfEndearment };
                    }
                );
            api.RegisterToken
                (
                    this.ModManifest, "SiblingNoun", () =>
                    {
                        return new[] { this.Config.SiblingNoun };
                    }
                );





            //Get Generic Mod Config Menu's API (if it's installed)
            var configMenu = this.Helper.ModRegistry.GetApi<IGenericModConfigMenuApi>("spacechase0.GenericModConfigMenu");
			
			//check if GNCM API is available
			if (configMenu is null)
				return;

			//Register Mod
			configMenu.Register
				(
					mod: this.ModManifest,
					reset: () => this.Config = new ModConfig(),
					save: () => this.Helper.WriteConfig(this.Config)
				);
            //Code for next release
			configMenu.AddTextOption
                (
                    mod: this.ModManifest,
                    name: () => "Gender",
                    tooltip: () => "Choose which gendered language to use. Use Undefined for custom language.",
                    getValue: () => this.Config.Gender,
                    setValue: value => this.Config.Gender = value,
					allowedValues: new string[] { "Nonbinary (They/Them)", "Custom", "Male", "Female"  }
                );
            //Add Section Title + Options
            configMenu.AddSectionTitle
				(
					mod: this.ModManifest,
					text: () => "Language and Pronoun Options"
				);
			configMenu.AddBoolOption
				(
					mod: this.ModManifest,
					name: () => "Singular",
					tooltip: () => "Use Singular Pronouns (i.e. \"They is\" as opposed to \"They are\")",
					getValue: () => this.Config.Singular,
					setValue: value => this.Config.Singular = value
				);		
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "SubjectivePronoun",
					tooltip: () => "The subjective pronoun to use. (i.e. He, She, They, etc.)",
					getValue: () => this.Config.SubjectivePronoun,
					setValue: value => this.Config.SubjectivePronoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ObjectivePronoun",
					tooltip: () => "The objective pronoun to use. (i.e. Him, Her, Them, etc.)",
					getValue: () => this.Config.ObjectivePronoun,
					setValue: value => this.Config.ObjectivePronoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "PosessivePronoun",
					tooltip: () => "The posessive pronoun to use. (i.e. His, Her, Their, etc.)",
					getValue: () => this.Config.PossessivePronoun,
					setValue: value => this.Config.PossessivePronoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "Title",
					tooltip: () => "The title to use. (i.e. Mr., Ms., Mx., etc.)",
					getValue: () => this.Config.Title,
					setValue: value => this.Config.Title = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "Adjective",
					tooltip: () => "The descriptive adjective to use. (i.e. Beautiful, Handsome, Gorgeous, etc.)",
					getValue: () => this.Config.Adjective,
					setValue: value => this.Config.Adjective = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "SpouseNoun",
					tooltip: () => "The noun used by your spouse and some others to refer to you. (i.e. Husband, Wife, Partner, etc.)",
					getValue: () => this.Config.SpouseNoun,
					setValue: value => this.Config.SpouseNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "GenericNoun",
					tooltip: () => "The noun used to refer to you in a generic sense. (i.e. Guy, Girl, Person, etc.)",
					getValue: () => this.Config.GenericNoun,
					setValue: value => this.Config.GenericNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "AdultAntiquatedNoun",
					tooltip: () => "The noun used by adults who speak in a somewhat antiquated fashion. (i.e. Guy, Gal, Folk, etc.)",
					getValue: () => this.Config.AdultAntiquatedNoun,
					setValue: value => this.Config.AdultAntiquatedNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "AdultFamilialNoun",
					tooltip: () => "The noun used by adults who feel a familial connection to you. (i.e. Son, Daughter, Kid, etc.)",
					getValue: () => this.Config.AdultFamilialNoun,
					setValue: value => this.Config.AdultFamilialNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "AdultInformalNoun",
					tooltip: () => "The noun used by adults who feel a familial connection to you. (i.e. Son, Daughter, Kid, etc.)",
					getValue: () => this.Config.AdultInformalNoun,
					setValue: value => this.Config.AdultInformalNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ElderAntiquatedNoun",
					tooltip: () => "The noun used by older people who speak in a somewhat antiquated fashion. (i.e. Lad, Lass, Kid, etc.)",
					getValue: () => this.Config.ElderAntiquatedNoun,
					setValue: value => this.Config.ElderAntiquatedNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ElderInformalNoun",
					tooltip: () => "The noun used by older people to address you informally. (i.e. Son, Hun, Kid, etc.)",
					getValue: () => this.Config.ElderInformalNoun,
					setValue: value => this.Config.ElderInformalNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ElderFamilialNoun",
					tooltip: () => "The noun used by older people who feel a familial connection to you. (i.e. Son, Daughter, Child, etc.)",
					getValue: () => this.Config.ElderFamilialNoun,
					setValue: value => this.Config.ElderFamilialNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ChildFamilialNoun",
					tooltip: () => "The noun used by younger people who feel a familial connection to you. (i.e. Uncle, Auntie, Cousin, etc.)",
					getValue: () => this.Config.ChildFamilialNoun,
					setValue: value => this.Config.ChildFamilialNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ServiceFormalNoun",
					tooltip: () => "The noun used by those in customer service. (i.e. Sir, Miss, Esteemed Customer, etc.)",
					getValue: () => this.Config.ServiceFormalNoun,
					setValue: value => this.Config.ServiceFormalNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "TraderNoun",
					tooltip: () => "The noun used by the trader. (i.e. Sir, Miss, Traveller, etc.)",
					getValue: () => this.Config.TraderNoun,
					setValue: value => this.Config.TraderNoun = value
				);
			configMenu.AddTextOption
				(
					mod: this.ModManifest,
					name: () => "ParentalNoun",
					tooltip: () => "The noun used by those who feel a parent/child relationship with you. (i.e. Father, Mother, Parent, etc.)",
					getValue: () => this.Config.ParentalNoun,
					setValue: value => this.Config.ParentalNoun = value
				);
            configMenu.AddTextOption
                (
                    mod: this.ModManifest,
                    name: () => "TermOfEndearment",
                    tooltip: () => "The word used by those who are very close to you, like your spouse. (i.e. Sweetie, Pookie, etc.)",
                    getValue: () => this.Config.TermOfEndearment,
                    setValue: value => this.Config.TermOfEndearment = value
                );
            configMenu.AddTextOption
                (
                    mod: this.ModManifest,
                    name: () => "SiblingNoun",
                    tooltip: () => "The word used by those who are your siblings or siblings-in-law. (i.e. Brother, Sister, Sibling, etc.)",
                    getValue: () => this.Config.SiblingNoun,
                    setValue: value => this.Config.SiblingNoun = value
                ); ;
        }
	}
}
