using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    public partial class MainForm : Form
    {
        // Seznam slov v jazyku
        string[] jazykA_slova = { "ahoj", "domov", "střecha", "kolej", "škola", "chleba", "soumrak", "cukr", "dálnice", "kousat" };
        string[] jazykB_slova = { "hello", "home", "roof", "rail", "school", "bread", "dusk", "sugar", "highway", "bite" };

        // Názvy jazků
        string   jazykA_nazev = "Čeština";
        string   jazykB_nazev = "Angličtina";

        /// <summary>
        /// Konstruktor hlavního formuláře
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Vypíšeme všechna slova jazyku A (pomocí cyklu foreach)
            foreach (string prvek in jazykA_slova)
            {
                slovaA.Items.Add(prvek);
            }

            // Vypíšeme všechna slova jazyku B (pomocí metody AddRange, šetří místo)
            slovaB.Items.AddRange(jazykB_slova);

            // Nastavíme názvy jazyků
            popisek_jazykA.Text = jazykA_nazev;
            popisek_jazykB.Text = jazykB_nazev;
        }

        /// <summary>
        /// Událost, která nastává když se změní text ve vyhledávacím boxu
        /// </summary>
        /// <param name="sender">Nějaký parametr</param>
        /// <param name="e">Nějaký druhý parametr</param>
        private void vyhledavaciBox_TextChanged(object sender, EventArgs e)
        {
            if (vyhledavaciBox.Text.Length > 0) // V případě, že délka textu ve vyhledávacím poli není nulová...
            {
                // Ušetříme místo, když si text ve vyhledávacím poli uložíme do nějaké proměnné s krátkým názvem
                string tx = vyhledavaciBox.Text;

                // Vyprázdníme oba seznamy slov
                slovaA.Items.Clear();
                slovaB.Items.Clear();

                // Projdeme všechna slova v jazyce A...
                for (int i = 0; i < jazykA_slova.Length; i++)
                {
                    // ...vybereme ta, která začínají na písmena zadaná ve vyhledávacím poli...
                    if (jazykA_slova[i].Substring(0, (tx.Length < jazykA_slova[i].Length ? tx.Length : jazykA_slova[i].Length) ) == tx)
                    {
                        // ... a umístíme je do seznamů slov.
                        slovaA.Items.Add(jazykA_slova[i]);
                        slovaB.Items.Add(jazykB_slova[i]);
                    }
                }

                // Pokud se v seznamech nachází už jenom jeden prvek, označíme ho...
                if (slovaA.Items.Count == 1)
                {
                    slovaA.SetSelected(0, true);
                    slovaB.SetSelected(0, true);
                }
                else // v opačném případě zruš všechna označení.
                {
                    slovaA.ClearSelected();
                    slovaB.ClearSelected();
                }
            }
            else // Když v políčku není žádný text, tak...
            {
                // vyčistíme seznamy slov obou jazyků...
                slovaA.Items.Clear();
                slovaB.Items.Clear();

                // ...a znovu je tam přidáme
                slovaA.Items.AddRange(jazykA_slova);
                slovaB.Items.AddRange(jazykB_slova);
            }

        }

        /// <summary>
        /// Událost, která nastává když uživatel klikne na tlačítko
        /// </summary>
        /// <param name="sender">Nějaký pro nás nepotřebný parametr</param>
        /// <param name="e">Nějaký pro nás nepotřebný parametr</param>
        private void vymenit_Click(object sender, EventArgs e)
        {
            // Vyměníme slova jazyku A za slova jazyku B a naopak
            string[] tmp = jazykA_slova;
            jazykA_slova = jazykB_slova;
            jazykB_slova = tmp;

            // Vyčistíme seznamy slov obou jazyků...
            slovaA.Items.Clear();
            slovaB.Items.Clear();

            // ...a znovu je tam přidáme
            slovaA.Items.AddRange(jazykA_slova);
            slovaB.Items.AddRange(jazykB_slova);

            // Vyměníme i názvy jazyků...
            string tmp2 = jazykA_nazev;
            jazykA_nazev = jazykB_nazev;
            jazykB_nazev = tmp2;

            // ...a znovu je nastavíme
            popisek_jazykA.Text = jazykA_nazev;
            popisek_jazykB.Text = jazykB_nazev;
        }

    }
}
