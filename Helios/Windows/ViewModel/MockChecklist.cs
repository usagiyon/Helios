﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GadrocsWorkshop.Helios.Interfaces.Common;

namespace GadrocsWorkshop.Helios.Windows.ViewModel
{
    public class MockChecklistItem: DependencyObject
    {
        public bool HasRecommendation => TextLine2 != null;
        public string Status { get; internal set; }
        public string TextLine1 { get; internal set; }
        public string TextLine2 { get; internal set; }
    }

    public class MockChecklistSection: DependencyObject
    {
        public MockChecklistSection Data => this;

        public string Status { get; internal set; }

        public Visibility DetailsVisibility => Visibility.Visible;

        public Visibility GoThereVisibility => Visibility.Visible;

        public class ItemsList : List<MockChecklistItem>
        {

            public void Add(string text1, string text2 = null, string status = null)
            {
                Add(new MockChecklistItem
                {
                    TextLine1 = text1,
                    TextLine2 = text2,
                    Status = status ?? "Info"
                });
            }
        }
        public ItemsList Items { get; internal set; }
        public List<string> Recommendations { get; internal set; }
        public string Name { get; internal set; }
    }

    public class MockChecklistViewModel: DependencyObject
    {
        public MockChecklistViewModel Data => this;

        public IList<MockChecklistSection> Items { get; } = new List<MockChecklistSection>
        {
            new MockChecklistSection
            {
                Name = "Some sort of name with stuff",
                Status = "Error",
                Items = new MockChecklistSection.ItemsList
                {
                    {
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        "Pellentesque pellentesque ligula porttitor, molestie diam ut, viverra lectus.", "Error"
                    },
                    {
                        "Quisque vel est gravida, consectetur diam eget, volutpat mi.",
                        "In sit amet sem mattis, rhoncus massa nec, dapibus quam."
                    },
                    {
                        "Nunc bibendum libero vitae arcu porta accumsan."
                    },
                    {"Proin a tellus dignissim, feugiat enim id, lacinia dui."},
                    {
                        "Phasellus in est sit amet diam tincidunt tempus.",
                        "Integer faucibus risus ac dignissim tempus.", "Warning"
                    },
                    {
                        "Nulla sed arcu commodo turpis consectetur elementum in aliquet lacus."
                    },
                    {"Phasellus feugiat nisl eget sem ullamcorper rutrum eget gravida libero."},


                    {"Maecenas convallis nunc sed nisi accumsan lobortis."},
                    {"Donec in ex ac purus efficitur vehicula sit amet rutrum erat."},
                    {"Morbi elementum eros sit amet sapien viverra dictum."},
                    {"Duis ac massa commodo, sagittis augue at, porttitor quam."},
                    {"Nullam a odio vehicula, blandit nibh nec, dignissim ante."}
                },
                Recommendations = new List<string>
                {
                    "Pellentesque pellentesque ligula porttitor, molestie diam ut, viverra lectus.",
                    "In sit amet sem mattis, rhoncus massa nec, dapibus quam.",
                    "Integer faucibus risus ac dignissim tempus."
                }
            }
        };
    }
}
