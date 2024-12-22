using DATA_ACCES_LAYER.Interface;
using DATA_ACCES_LAYER.Model;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DATA_ACCES_LAYER.Response_ErrorHandling;
using OxyPlot.Axes;

namespace WinFormsApp1.Controls
{
    public partial class Statistics : UserControl
    {
        private readonly IDataAcces _dataAcces;

        public Statistics(IDataAcces dataAcces)
        {
            _dataAcces = dataAcces;
            InitializeComponent();
            LoadAnimalStatistics();
        }

        // Method to reload the statistics
        private void btnReloadStats_Click(object sender, EventArgs e)
        {
            LoadAnimalStatistics();
        }

        // Method to load animal statistics
        private void LoadAnimalStatistics()
        {
            try
            {
                // Retrieve animals from the data access layer
                ResponseObject<Animal> response = _dataAcces.GetAllAnimal();
                List<Animal> animals = response.Object;

                // Group by species and count the number of animals for each species
                var statistics = animals
                    .GroupBy(a => a.Species)
                    .Select(g => new
                    {
                        Species = g.Key,
                        Count = g.Count()
                    })
                    .ToList();

                // initial isation de mon plot
                var plotModel = new PlotModel
                {
                    Title = "Animal Statistics by Species",  
                    TitleFontSize = 18,
                    TitleFontWeight = OxyPlot.FontWeights.Bold,
                    TitleColor = OxyColors.Black,
                    Background = OxyColor.FromRgb(255, 255, 255)  
                };

                // Add an axis 
                plotModel.Axes.Add(new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    Key = "CountAxis",
                    Title = "Number of Animals",  
                    TitleFontWeight = OxyPlot.FontWeights.Bold,
                    TextColor = OxyColors.Black,
                    FontSize = 14,  
                    MinimumPadding = 0.1,  
                    MaximumPadding = 0.1
                });

                //  
                plotModel.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "SpeciesAxis",
                    ItemsSource = statistics.Select(s => s.Species).ToList(),
                    Title = "Species",  
                    TitleFontWeight = OxyPlot.FontWeights.Bold,
                    TextColor = OxyColors.Black,  
                    FontSize = 14,  
                });

                 // je cree ma bar serie
                var barSeries = new BarSeries
                {
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0}",
                    StrokeColor = OxyColors.White,  
                    StrokeThickness = 1
                };

                // Generate a color palette
                var colorPalette = new List<OxyColor>
                {
                    OxyColor.FromRgb(0, 102, 204),  // Blue
                    OxyColor.FromRgb(255, 69, 0),   // Red-Orange
                    OxyColor.FromRgb(34, 139, 34),  // Forest Green
                    OxyColor.FromRgb(255, 215, 0),  // Gold
                    OxyColor.FromRgb(75, 0, 130),   // Indigo
                    OxyColor.FromRgb(255, 20, 147)  // Deep Pink
                };

                
                for (int i = 0; i < statistics.Count; i++)
                {
                    barSeries.Items.Add(new BarItem
                    {
                        Value = statistics[i].Count,
                        Color = colorPalette[i % colorPalette.Count] // Rotate through colors
                    });
                }

                // Add the series to the model
                plotModel.Series.Add(barSeries);

                // Create a PlotView and add it dynamically
                var plotView = new OxyPlot.WindowsForms.PlotView
                {
                    Dock = DockStyle.Fill,
                    Model = plotModel
                };

                // Clear the old controls and add the new ones
                Controls.Clear();

                // Add a panel for the button and plot for proper alignment
                var panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Top,
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Padding = new Padding(10)
                };

                // Add button and plot to the panel
                panel.Controls.Add(this.btnReloadStats);
                panel.Controls.Add(this.lblTitle);

                // Add the plot view
                Controls.Add(panel);
                Controls.Add(plotView);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message); 
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
