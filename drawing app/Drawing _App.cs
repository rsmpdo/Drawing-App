using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_App
{
    public partial class Drawing_App : Form
    {
       
            private List<Shape> shapes;    // list to track drawwn shapes
            //private List<Shape> undoStack;
            //private List<Shape> redoStack ;
            private Shape currentShape;
            private Point startPoint;
            private bool isDrawing;
            private Shape selectedShape;
            private int currentIndex = 0; // count of how many shapes are there


        // Current drawing properties
            private Color currentFillColor = Color.LightGreen;
            private Color currentBorderColor = Color.Black;
            private int currentBorderWidth = 2;

            public Drawing_App()
            {
                InitializeComponent();
                shapes = new List<Shape>();
            //undoStack = new List<Shape>();

            // Initialize default properties
                FillColorButton.BackColor = currentFillColor;
                boderColorButton.BackColor = currentBorderColor;
                borderWidthUpDown.Value = currentBorderWidth;
                shapeComboBox.SelectedIndex = 0;

                statusLabel.Text = "Select a shape and drag to draw";
            }


        // selecting shape
        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevent the selected text being highlighted: move focus somewhere else            
            this.ActiveControl = null;

            string selectedShape = shapeComboBox.SelectedItem.ToString();

            // Based on selection, update UI or current shape settings
            switch (selectedShape)
            {
                case "Rectangle":
                    // Set current shape to rectangle, enable/disable controls, etc.
                    currentShape = new RectangleShape();
                    break;
                case "Circle":
                    currentShape = new CircleShape();
                    break;

                // Add other cases as needed
                default:
                    currentShape = null;
                    break;
            }

        }

        // Fill color selection
        private void fillColorButton_Click(object sender, EventArgs e)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    colorDialog.Color = currentFillColor;
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFillColor = colorDialog.Color;
                        FillColorButton.BackColor = currentFillColor;

                        // Update selected shape if any
                        if (selectedShape != null)
                        {
                            selectedShape.FillColor = currentFillColor;
                            drawingPanel.Invalidate();
                        }
                    }
                }
            }


        // Border color selection
        private void borderColorButton_Click(object sender, EventArgs e)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    colorDialog.Color = currentBorderColor;
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentBorderColor = colorDialog.Color;
                        boderColorButton.BackColor = currentBorderColor;

                        // Update selected shape if any
                        if (selectedShape != null)
                        {
                            selectedShape.BorderColor = currentBorderColor;
                            drawingPanel.Invalidate();
                        }
                    }
                }
            }


        // Border width change
        private void borderWidthUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            // remove cursor appearing: move focus somewhere else
            this.ActiveControl = null;

            currentBorderWidth = (int)borderWidthUpDown.Value;

            // Update selected shape
            if (selectedShape != null)
            {
                selectedShape.BorderWidth = currentBorderWidth;
                drawingPanel.Invalidate();
            }
        }

        // Undo (using currentIndex)
        private void undoButton_Click_1(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                selectedShape = null;
                drawingPanel.Invalidate();
                statusLabel.Text = "Undo performed";
            }
        }


        // Redo (using currentIndex)
        private void redoButton_Click(object sender, EventArgs e)
        {
            if (currentIndex < shapes.Count)
            {
                currentIndex++;
                drawingPanel.Invalidate();
                statusLabel.Text = "Redo performed";
            }
        }


        // Mouse down — select shape or start drawing
        private void drawingPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Check if clicking on existing shape for selection
                Shape clickedShape = null;
                for (int i = shapes.Count - 1; i >= 0; i--)
                {
                    if (shapes[i].Contains(e.Location))
                    {
                        clickedShape = shapes[i];
                        break;
                    }
                }

                if (clickedShape != null)
                {
                    // Select the shape
                    if (selectedShape != null)
                        selectedShape.IsSelected = false;

                    selectedShape = clickedShape;
                    selectedShape.IsSelected = true;

                    // Update UI with selected shape properties
                    FillColorButton.BackColor = selectedShape.FillColor;
                    boderColorButton.BackColor = selectedShape.BorderColor;
                    borderWidthUpDown.Value = selectedShape.BorderWidth;

                    // Update currentFillColor or currentBorderColor
                    currentFillColor = selectedShape.FillColor;
                    currentBorderColor = selectedShape.BorderColor;
                    currentBorderWidth = selectedShape.BorderWidth;

                    statusLabel.Text = "Shape selected. You can modify its properties.";
                    drawingPanel.Invalidate();
                }
                else
                {
                    // Start drawing new shape
                    if (selectedShape != null)
                    {
                        selectedShape.IsSelected = false;
                        selectedShape = null;
                    }

                    startPoint = e.Location;
                    isDrawing = true;

                    // Clear undo stack when starting new drawing
                    //undoStack.Clear();

                    statusLabel.Text = "Drawing...";
                }
            }
        }


        // Mouse move — live preview
        private void drawingPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                // Create preview shape
                Rectangle bounds = GetBounds(startPoint, e.Location);

                string shapeType = shapeComboBox.SelectedItem.ToString();
                if (shapeType == "Rectangle")
                {
                    currentShape = new RectangleShape();
                }
                else
                {
                    currentShape = new CircleShape();
                }

                currentShape.FillColor = currentFillColor;
                currentShape.BorderColor = currentBorderColor;
                currentShape.BorderWidth = currentBorderWidth;
                currentShape.Bounds = bounds;

                drawingPanel.Invalidate();
            }
        }


        // Mouse up — finish drawing
        private void drawingPanel_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                isDrawing = false;

                Rectangle bounds = GetBounds(startPoint, e.Location);

                // Only add shape if it has meaningful size
                if (bounds.Width > 10 && bounds.Height > )
                {
                    string shapeType = shapeComboBox.SelectedItem.ToString();
                    Shape newShape;

                    if (shapeType == "Rectangle")
                    {
                        newShape = new RectangleShape();
                    }
                    else
                    {
                        newShape = new CircleShape();
                    }

                    newShape.FillColor = currentFillColor;
                    newShape.BorderColor = currentBorderColor;
                    newShape.BorderWidth = currentBorderWidth;
                    newShape.Bounds = bounds;

                    if (currentIndex < shapes.Count)
                        shapes.RemoveRange(currentIndex, shapes.Count - currentIndex);


                    shapes.Add(newShape);
                    currentIndex++;
                    statusLabel.Text = $"{shapeType} added.  Total no. of shapes: {shapes.Count}";

                }

                currentShape = null;
                drawingPanel.Invalidate();
            }
        }


        // Paint event — only active shapes
        private void drawingPanel_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw all shapes using polymorphism
            for (int i = 0; i < currentIndex; i++)
            {
                shapes[i].Draw(g);
                shapes[i].DrawSelection(g);
            }

            // Draw current shape being drawn (live preview)
            if (currentShape != null)
            {
                currentShape.Draw(g);
            }
        }


        // figures out the area covered by shape
        private Rectangle GetBounds(Point start, Point end)
            {
                int x = Math.Min(start.X, end.X);
                int y = Math.Min(start.Y, end.Y);
                int width = Math.Abs(end.X - start.X);
                int height = Math.Abs(end.Y - start.Y);

                return new Rectangle(x, y, width, height);
            }


        // Clear all shapes
        private void clearButton_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            currentIndex = 0;
            selectedShape = null;
            drawingPanel.Invalidate();
            statusLabel.Text = "Canvas cleared.";
        }

        // border color button
        private void boderColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {

                colorDialog.Color = currentBorderColor;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save selected color to current settings
                    currentBorderColor = colorDialog.Color;

                    // Update the label showing border color
                    boderColorButton.BackColor = currentBorderColor;

                    // If a shape is selected, update it immediately
                    if (selectedShape != null)
                    {
                        selectedShape.BorderColor = currentBorderColor;
                        drawingPanel.Invalidate();
                    }
                }
            }
        }


        // fill color button
        private void FillColorButton_Click_1(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                
                   // colorDialog.Color = selectedShape.FillColor;
                
                
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the selected color to your shape's FillColor property
                    currentFillColor = colorDialog.Color;

                    // Optionally update UI
                    FillColorButton.BackColor = colorDialog.Color;

                    if (selectedShape != null)
                    {
                        selectedShape.FillColor = currentFillColor;
                        drawingPanel.Invalidate();
                    }
                }
            }
        }


        // to save dawing
        
            private void saveButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save Drawing As Image";
                saveFileDialog.FileName = "drawing.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Create a bitmap the size of the drawing panel
                    Bitmap bmp = new Bitmap(drawingPanel.Width, drawingPanel.Height);

                    // Draw the panel's content onto the bitmap
                    drawingPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                    // Save the bitmap to the selected file path
                    bmp.Save(saveFileDialog.FileName);

                    bmp.Dispose();

                    MessageBox.Show("Image saved successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        // status label text color change over mouse movement
        private void statusLabel_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Black;
        }

        private void statusLabel_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.ForeColor = Color.Red;
        }


        // other events

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Instructions:\n\n" +
            "1. Select a shape from the dropdown.\n" +
            "2. Choose fill and border colors.\n" +
            "3. Set border width.\n" +
            "4. Click and drag on the canvas to draw.\n" +
            "5. Use Undo/Redo buttons to revert or restore changes.\n" +
            "6. Select a shape to modify its properties.\n" +
            "7. Click 'Save' to export your drawing.",
            "How to Use",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }

        private void Help_MouseEnter(object sender, EventArgs e)
        {
            Help.BackColor = Color.LightBlue;
        }

        private void Help_MouseLeave(object sender, EventArgs e)
        {
            Help.BackColor = Color.WhiteSmoke;
        }


        /////////////////////////////////////////////////////////
        
        private void appIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void appIcon_MouseEnter(object sender, EventArgs e)
        {

        }

        private void appIcon_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void appIcon_MouseEnter_1(object sender, EventArgs e)
        {
            
        }

        private void appIcon_MouseLeave_1(object sender, EventArgs e)
        {

        }

    }
}

