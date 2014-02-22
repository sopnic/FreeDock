﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using FQ.FreeDock;

namespace FQ.FreeDock.Rendering
{
    /// <summary>
    /// Provides a renderer that mimics the appearance of Microsoft Visual Studio.NET 2003.
    /// 
    /// </summary>
    public class EverettRenderer : RendererBase
    {
        private Color inactiveTitleBarColor = SystemColors.InactiveCaption;
        private Color activeTitleBarColor = SystemColors.ActiveCaption;
        private Color shadowColor = SystemColors.ControlText;
        private Color highlightColor = SystemColors.ControlLightLight;
        private Color backgroundTabForeColor = SystemColors.ControlDarkDark;
        private Color collapsedTabOutlineColor = SystemColors.ControlDark;
        private Color normalColor = SystemColors.ControlDarkDark;
        private static StringFormat standardStringFormat;
        private static StringFormat standardVerticalStringFormat;
        private Color tabStripBackgroundColor;
        private SolidBrush backBrush;
        private SolidBrush foreBrush;
        private Pen shadowPen;
        private Pen highlightPen;
        private Pen outlinePen;
        private StringFormat stringFormat;
        private BoxModel tabStripMetrics;
        private BoxModel tabMetrics;
        private BoxModel titleBarMetrics;

        internal static StringFormat StandardStringFormat
        {
            get
            {
                if (EverettRenderer.standardStringFormat == null)
                {
                    EverettRenderer.standardStringFormat = new StringFormat(StringFormat.GenericDefault);
                    EverettRenderer.standardStringFormat.Alignment = StringAlignment.Near;
                    EverettRenderer.standardStringFormat.LineAlignment = StringAlignment.Center;
                    EverettRenderer.standardStringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    EverettRenderer.standardStringFormat.FormatFlags |= StringFormatFlags.NoWrap;
                }
                return EverettRenderer.standardStringFormat;
            }
        }

        internal static StringFormat StandardVerticalStringFormat
        {
            get
            {
                if (EverettRenderer.standardVerticalStringFormat == null)
                {
                    EverettRenderer.standardVerticalStringFormat = new StringFormat(StringFormat.GenericDefault);
                    EverettRenderer.standardVerticalStringFormat.Alignment = StringAlignment.Near;
                    EverettRenderer.standardVerticalStringFormat.LineAlignment = StringAlignment.Center;
                    EverettRenderer.standardVerticalStringFormat.Trimming = StringTrimming.EllipsisCharacter;
                    EverettRenderer.standardVerticalStringFormat.FormatFlags |= StringFormatFlags.NoWrap;
                    EverettRenderer.standardVerticalStringFormat.FormatFlags |= StringFormatFlags.DirectionVertical;
                }
                return EverettRenderer.standardVerticalStringFormat;
            }
        }

        /// <summary>
        /// The colour to draw the outline of collapsed tabs.
        /// 
        /// </summary>
        public Color CollapsedTabOutlineColor
        {
            get
            {
                return this.collapsedTabOutlineColor;
            }
            set
            {
                this.collapsedTabOutlineColor = value;
                this.CustomColors = true;
            }
        }

        /// <summary>
        /// The colour to draw the text on non-selected tabs.
        /// 
        /// </summary>
        public Color BackgroundTabForeColor
        {
            get
            {
                return this.backgroundTabForeColor;
            }
            set
            {
                this.backgroundTabForeColor = value;
            }
        }

        /// <summary>
        /// The colour to draw the highlights on 3d objects with.
        /// 
        /// </summary>
        public Color HighlightColor
        {
            get
            {
                return this.highlightColor;
            }
            set
            {
                this.highlightColor = value;
                this.CustomColors = true;
            }
        }

        /// <summary>
        /// The colour to draw the shadows on 3d objects with.
        /// 
        /// </summary>
        public Color ShadowColor
        {
            get
            {
                return this.shadowColor;
            }
            set
            {
                this.shadowColor = value;
                this.CustomColors = true;
            }
        }

        /// <summary>
        /// The colour to draw the background of tabstrips with.
        /// 
        /// </summary>
        public Color TabStripBackgroundColor
        {
            get
            {
                return this.tabStripBackgroundColor;
            }
        }

        /// <summary>
        /// The colour to draw the background of inactive titlebars with.
        /// 
        /// </summary>
        public Color InactiveTitleBarColor
        {
            get
            {
                return this.inactiveTitleBarColor;
            }
            set
            {
                this.inactiveTitleBarColor = value;
                this.CustomColors = true;
            }
        }

        /// <summary>
        /// The colours to draw the background of active titlebars with.
        /// 
        /// </summary>
        public Color ActiveTitleBarColor
        {
            get
            {
                return this.activeTitleBarColor;
            }
            set
            {
                this.activeTitleBarColor = value;
                this.CustomColors = true;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override TabTextDisplayMode TabTextDisplay
        {
            get
            {
                return TabTextDisplayMode.SelectedTab;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override BoxModel TitleBarMetrics
        {
            get
            {
                if (this.titleBarMetrics == null)
                    this.titleBarMetrics = new BoxModel(0, SystemInformation.ToolWindowCaptionHeight + 2, 0, 0, 0, 0, 0, 0, 0, 2);
                return this.titleBarMetrics;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override BoxModel TabMetrics
        {
            get
            {
                if (this.tabMetrics == null)
                    this.tabMetrics = new BoxModel(0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
                return this.tabMetrics;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override BoxModel TabStripMetrics
        {
            get
            {
                if (this.tabStripMetrics == null)
                    this.tabStripMetrics = new BoxModel(0, Control.DefaultFont.Height + 9, 4, 0, 5, 1, 0, 2, 0, 0);
                return this.tabStripMetrics;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        public override Size TabControlPadding
        {
            get
            {
                return new Size(3, 3);
            }
        }

        internal virtual int DocumentTabPadding
        {
            get
            {
                return 5;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override int DocumentTabSize
        {
            get
            {
                return Control.DefaultFont.Height + 6;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override int DocumentTabStripSize
        {
            get
            {
                return Control.DefaultFont.Height + 8;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override int DocumentTabExtra
        {
            get
            {
                return 0;
            }
        }

        static EverettRenderer()
        {
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected override void GetColorsFromSystem()
        {
            this.tabStripBackgroundColor = this.x2c04503a704e817c(SystemColors.Control);
        }
        // borrowed from 2.4
        private Color x2c04503a704e817c(Color color)
        {
            byte r = color.R;
            byte g = color.G;
            byte b = color.B;
            byte max = Math.Max(Math.Max(r, g), b);
            if ((int)max == 0)
                return Color.FromArgb(35, 35, 35);
            byte num2 = (int)max > 220 ? (byte)((uint)byte.MaxValue - (uint)max) : (byte)35;
            return Color.FromArgb((int)(byte)((uint)r + (uint)(byte)((double)num2 * ((double)r / (double)max) + 0.5)), (int)(byte)((uint)g + (uint)(byte)((double)num2 * ((double)g / (double)max) + 0.5)), (int)(byte)((uint)b + (uint)(byte)((double)num2 * ((double)b / (double)max) + 0.5)));

        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override Rectangle AdjustDockControlClientBounds(ControlLayoutSystem layoutSystem, DockControl control, Rectangle clientBounds)
        {
            if (!(layoutSystem is DocumentLayoutSystem))
                return base.AdjustDockControlClientBounds(layoutSystem, control, clientBounds);
            clientBounds.Inflate(-2, -2);
            return clientBounds;
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawControlClientBackground(Graphics graphics, Rectangle bounds, Color backColor)
        {
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawDocumentClientBackground(Graphics g, Rectangle bounds, Color backColor)
        {
            using (SolidBrush brush = new SolidBrush(backColor))
                g.FillRectangle(brush, bounds);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawDocumentStripBackground(Graphics g, Rectangle bounds)
        {
            g.FillRectangle(this.backBrush, bounds);
            g.DrawLine(this.highlightPen, bounds.X, bounds.Bottom - 1, bounds.Right, bounds.Bottom - 1);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawDockContainerBackground(Graphics g, DockContainer container, Rectangle bounds)
        {
            xa811784015ed8842.x91433b5e99eb7cac(g, container.BackColor);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override Size MeasureTabStripTab(Graphics g, Image image, string text, Font font, DrawItemState state)
        {
            return new Size((int)Math.Ceiling((double)g.MeasureString(text, font, int.MaxValue, this.stringFormat).Width) + 30, 18);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        // reviewed with 2.4
        protected internal override Size MeasureDocumentStripTab(Graphics g, Image image, string text, Font font, DrawItemState state)
        {
            int width;
            if ((state & DrawItemState.Focus) != DrawItemState.Focus)
            {
                width = (int)Math.Ceiling((double)g.MeasureString(text, font, 999, this.stringFormat).Width);
            }
            else
            {
                using (Font font1 = new Font(font, FontStyle.Bold))
                {
                    width = (int)Math.Ceiling((double)g.MeasureString(text, font1, 999, this.stringFormat).Width);
                }
            }
            width += 2 + this.DocumentTabPadding * 2 + 2;
            if (image != null)
                width += 20;
            return new Size(width + this.DocumentTabExtra, 0);
        }

        /// <summary>
        /// Overridden,
        /// 
        /// </summary>
        protected internal override void DrawDocumentStripTab(Graphics graphics, Rectangle bounds, Rectangle contentBounds, Image image, string text, Font font, Color backColor, Color foreColor, DrawItemState state, bool drawSeparator)
        {
            if ((state & DrawItemState.Selected) != DrawItemState.Selected)
                goto label_17;
            else
                goto label_20;
            label_1:
            Font font1;
            font1.Dispose();
            return;
            label_17:
            if (drawSeparator)
            {
                graphics.DrawLine(SystemPens.ControlDark, bounds.Right, bounds.Top + 3, bounds.Right, bounds.Bottom - 3);
                if (false)
                    goto label_1;
            }
            label_19:
            bounds = contentBounds;
            if (image == null)
            {
                if (0 != 0)
                    goto label_16;
            }
            else
                goto label_15;
            label_13:
            if (bounds.Width <= 8)
                return;
            font1 = font;
            if ((state & DrawItemState.Focus) == DrawItemState.Focus)
                goto label_10;
            label_8:
            if ((state & DrawItemState.Selected) == DrawItemState.Selected)
                goto label_3;
            else
                goto label_9;
            label_2:
            if ((state & DrawItemState.Focus) != DrawItemState.Focus)
                return;
            else
                goto label_1;
            label_3:
            using (SolidBrush solidBrush = new SolidBrush(foreColor))
            {
                graphics.DrawString(text, font1, (Brush)solidBrush, (RectangleF)bounds, this.stringFormat);
                goto label_2;
            }
            label_9:
            graphics.DrawString(text, font1, (Brush)this.foreBrush, (RectangleF)bounds, this.stringFormat);
            goto label_2;
            label_10:
            font1 = new Font(font, FontStyle.Bold);
            goto label_8;
            label_15:
            graphics.DrawImage(image, bounds.X + 4, bounds.Y + 2, 16, 16);
            label_16:
            bounds.X += 20;
            bounds.Width -= 20;
            goto label_13;
            label_20:
            using (SolidBrush solidBrush = new SolidBrush(backColor))
                graphics.FillRectangle((Brush)solidBrush, bounds);
            graphics.DrawLine(this.highlightPen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom - 1);
            graphics.DrawLine(this.highlightPen, bounds.Left, bounds.Top, bounds.Right - 1, bounds.Top);
            graphics.DrawLine(this.shadowPen, bounds.Right - 1, bounds.Top + 1, bounds.Right - 1, bounds.Bottom - 1);
            goto label_19;
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        // reviewed with 2.4
        public override void StartRenderSession(HotkeyPrefix hotKeys)
        {
            this.backBrush = new SolidBrush(this.tabStripBackgroundColor);
            this.shadowPen = new Pen(this.shadowColor);
            this.highlightPen = new Pen(this.highlightColor);
            this.foreBrush = new SolidBrush(this.backgroundTabForeColor);
            this.outlinePen = new Pen(this.collapsedTabOutlineColor);
            this.stringFormat = new StringFormat(StringFormat.GenericDefault);
            this.stringFormat.FormatFlags = StringFormatFlags.NoWrap;
            this.stringFormat.Alignment = StringAlignment.Center;
            this.stringFormat.LineAlignment = StringAlignment.Center;
            this.stringFormat.HotkeyPrefix = hotKeys;
        }

        /// <summary>
        /// Overridden,
        /// 
        /// </summary>
        protected internal override void DrawSplitter(Control container, Control control, Graphics graphics, Rectangle bounds, Orientation orientation)
        {
        }

        /// <summary>
        /// Overridden,
        /// 
        /// </summary>
        // reviewed with 2.4
        protected internal override void DrawDocumentStripButton(Graphics g, Rectangle bounds, SandDockButtonType buttonType, DrawItemState state)
        {
            this.x9271fbf5eef553db(g, bounds, state);

            if ((state & DrawItemState.Selected) == DrawItemState.Selected)
                bounds.Offset(1, 1);

            switch (buttonType)
            {
                case SandDockButtonType.Close:
                    using (Pen pen = new Pen(this.normalColor))
                    {
                        x9b2777bb8e78938b.xb176aa01ddab9f3e(g, bounds, pen);
                    }
                    break;
                case SandDockButtonType.Pin:
                    break;
                case SandDockButtonType.ScrollLeft:
                    x9b2777bb8e78938b.xd70a4c1a2378c84e(g, bounds, this.normalColor, (state & DrawItemState.Disabled) != DrawItemState.Disabled);
                    break;
                case SandDockButtonType.ScrollRight:
                    x9b2777bb8e78938b.x793dc1a7cf4113f9(g, bounds, this.normalColor, (state & DrawItemState.Disabled) != DrawItemState.Disabled);
                    break;
                case SandDockButtonType.WindowPosition:
                    break;
                case SandDockButtonType.ActiveFiles:
                    x9b2777bb8e78938b.xeac2e7eb44dff86e(g, bounds, SystemPens.ControlText);
                    break;
            }
        }
        // reviewed with 2.4
        internal virtual void x9271fbf5eef553db(Graphics g, Rectangle bounds, DrawItemState state)
        {
            if ((state & DrawItemState.HotLight) != DrawItemState.HotLight)
                return;
  
            Pen pen1, pen2;
            if ((state & DrawItemState.Selected) == DrawItemState.Selected)
            {
                pen2 = this.shadowPen;
                pen1 = this.highlightPen;
            }
            else
            {
                pen1 = this.shadowPen;
                pen2 = this.highlightPen;
            }
            g.DrawLine(pen2, bounds.Left, bounds.Top, bounds.Right - 1, bounds.Top);
            g.DrawLine(pen2, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom - 1);
            g.DrawLine(pen1, bounds.Right - 1, bounds.Bottom - 1, bounds.Right - 1, bounds.Top);
            g.DrawLine(pen1, bounds.Right - 1, bounds.Bottom - 1, bounds.Left, bounds.Bottom - 1);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        // reviewed with 2.4
        protected internal override void DrawTitleBarButton(Graphics g, Rectangle bounds, SandDockButtonType buttonType, DrawItemState state, bool focused, bool toggled)
        {
            --bounds.Width;
            --bounds.Height;
            this.x9271fbf5eef553db(g, bounds, state);
            if ((state & DrawItemState.Selected) == DrawItemState.Selected)
                bounds.Offset(1, 1);

            switch (buttonType)
            {
                case SandDockButtonType.Close:
                    x9b2777bb8e78938b.x26f0f0028ef01fa5(g, bounds, focused ? SystemPens.ActiveCaptionText : SystemPens.ControlText);
                    break;
                case SandDockButtonType.Pin:
                    x9b2777bb8e78938b.x1477b5a75c8a8132(g, bounds, focused ? SystemPens.ActiveCaptionText : SystemPens.ControlText, toggled);
                    break;
                case SandDockButtonType.ScrollLeft:
                    break;
                case SandDockButtonType.ScrollRight:
                    break;
                case SandDockButtonType.WindowPosition:
                    x9b2777bb8e78938b.xeac2e7eb44dff86e(g, bounds, focused ? SystemPens.ActiveCaptionText : SystemPens.ControlText);
                    break;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawTabStripBackground(Control container, Control control, Graphics g, Rectangle bounds, int selectedTabOffset)
        {
            g.FillRectangle(this.backBrush, bounds);
            g.DrawLine(this.shadowPen, bounds.X, bounds.Y, bounds.Right, bounds.Y);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawTabStripTab(Graphics graphics, Rectangle bounds, Image image, string text, Font font, Color backColor, Color foreColor, DrawItemState state, bool drawSeparator)
        {
            if ((state & DrawItemState.Selected) != DrawItemState.Selected)
                goto label_15;
            else
                goto label_23;
            label_2:
            using (SolidBrush brush = new SolidBrush(foreColor))
            {
                graphics.DrawString(text, font, brush, (RectangleF)bounds, EverettRenderer.StandardStringFormat);
                return;
            }
            label_12:
            do
            {
                if (bounds.Width >= 24)
                    goto label_13;
                label_8:
                bounds.X += 23;
                if (true)
                {
                    bounds.Width -= 25;
                    if (((drawSeparator ? 1 : 0) & 0) == 0 && bounds.Width <= 8)
                        continue;
                    else
                        goto label_1;
                }
                else
                    goto label_7;
                label_13:
                graphics.DrawImage(image, new Rectangle(bounds.X + 4, bounds.Y + 2, image.Width, image.Height));
                goto label_8;
            }
            while (false);
            goto label_14;
            label_1:
            if ((state & DrawItemState.Selected) == DrawItemState.Selected)
                goto label_2;
            label_7:
            graphics.DrawString(text, font, (Brush)this.foreBrush, (RectangleF)bounds, EverettRenderer.StandardStringFormat);
            return;
            label_14:
            if (true)
                return;
            else
                goto label_23;
            label_15:
            if (!drawSeparator)
            {
                if (true)
                {
                    if (false)
                        return;
                    if (true)
                    {
                        if (((drawSeparator ? 1 : 0) & 0) == 0)
                            goto label_12;
                        else
                            goto label_23;
                    }
                }
                else
                    goto label_2;
            }
            else
            {
                graphics.DrawLine(SystemPens.ControlDark, bounds.Right, bounds.Top + 3, bounds.Right, bounds.Bottom - 3);
                goto label_12;
            }
            label_21:
            graphics.DrawLine(this.highlightPen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom - 1);
            graphics.DrawLine(this.shadowPen, bounds.Left, bounds.Bottom - 1, bounds.Right, bounds.Bottom - 1);
            graphics.DrawLine(this.shadowPen, bounds.Right, bounds.Top, bounds.Right, bounds.Bottom - 1);
            goto label_12;
            label_23:
            using (SolidBrush solidBrush = new SolidBrush(backColor))
            {
                graphics.FillRectangle((Brush)solidBrush, bounds);
                goto label_21;
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawAutoHideBarBackground(Control container, Control autoHideBar, Graphics g, Rectangle bounds)
        {
            using (this.backBrush = new SolidBrush(this.tabStripBackgroundColor))
                g.FillRectangle(this.backBrush, bounds);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawCollapsedTab(Graphics graphics, Rectangle bounds, DockSide dockSide, Image image, string text, Font font, Color backColor, Color foreColor, DrawItemState state, bool vertical)
        {
            using (SolidBrush solidBrush = new SolidBrush(backColor))
                graphics.FillRectangle((Brush)solidBrush, bounds);
            if (dockSide == DockSide.Top)
                goto label_19;
            else
                goto label_22;
            label_6:
            graphics.DrawString(text, font, (Brush)this.foreBrush, (RectangleF)bounds, EverettRenderer.StandardVerticalStringFormat);
            if (0 != 0)
                return;
            else
                return;
            label_8:
            if (!vertical)
            {
                bounds.Offset(23, 0);
                graphics.DrawString(text, font, (Brush)this.foreBrush, (RectangleF)bounds, EverettRenderer.StandardStringFormat);
                return;
            }
            else
            {
                bounds.Offset(0, 23);
                if (15 != 0)
                    goto label_6;
            }
            label_11:
            if (dockSide != DockSide.Left)
            {
                graphics.DrawLine(this.outlinePen, bounds.Left, bounds.Top, bounds.Left, bounds.Bottom);
                goto label_16;
            }
            label_12:
            bounds.Inflate(-2, -2);
            if (!vertical)
                goto label_10;
            else
                goto label_13;
            label_7:
            graphics.DrawImage(image, new Rectangle(bounds.Left, bounds.Top, image.Width, image.Height));
            if (text.Length == 0)
                return;
            else
                goto label_8;
            label_10:
            bounds.Offset(1, 0);
            goto label_7;
            label_13:
            bounds.Offset(0, 1);
            if (((vertical ? 1 : 0) & 0) == 0)
                goto label_7;
            else
                goto label_6;
            label_16:
            if (0 == 0)
                goto label_12;
            else
                goto label_11;
            label_19:
            if (dockSide != DockSide.Right)
                goto label_25;
            else
                goto label_20;
            label_14:
            if (dockSide == DockSide.Bottom)
                goto label_11;
            label_18:
            graphics.DrawLine(this.outlinePen, bounds.Left, bounds.Bottom, bounds.Right, bounds.Bottom);
            goto label_11;
            label_20:
            if (0 == 0)
            {
                if (0 != 0)
                {
                    if (false)
                        goto label_24;
                    else
                        goto label_18;
                }
                else
                    goto label_14;
            }
            else
                goto label_16;
            label_25:
            graphics.DrawLine(this.outlinePen, bounds.Right, bounds.Top, bounds.Right, bounds.Bottom);
            goto label_14;
            label_22:
            if (0 == 0)
            {
                if (0 != 0)
                    return;
            }
            else
                goto label_8;
            label_24:
            graphics.DrawLine(this.outlinePen, bounds.Left, bounds.Top, bounds.Right, bounds.Top);
            goto label_19;
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        // reviewed with 2.4
        protected internal override void DrawTitleBarBackground(Graphics g, Rectangle bounds, bool focused)
        {
            if (focused)
                g.FillRectangle(SystemBrushes.ActiveCaption, bounds);
            else
            {
                g.FillRectangle(SystemBrushes.Control, bounds);
                g.DrawLine(SystemPens.ControlDark, bounds.X + 1, bounds.Y, bounds.Right - 2, bounds.Y);
                g.DrawLine(SystemPens.ControlDark, bounds.X + 1, bounds.Bottom - 1, bounds.Right - 2, bounds.Bottom - 1);
                g.DrawLine(SystemPens.ControlDark, bounds.X, bounds.Y + 1, bounds.X, bounds.Bottom - 2);
                g.DrawLine(SystemPens.ControlDark, bounds.Right - 1, bounds.Y + 1, bounds.Right - 1, bounds.Bottom - 2);
            }
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        protected internal override void DrawTitleBarText(Graphics g, Rectangle bounds, bool focused, string text, Font font)
        {
            Brush brush = focused ? SystemBrushes.ActiveCaptionText : SystemBrushes.ControlText;
            bounds.Inflate(-3, 0);
            g.DrawString(text, font, brush, (RectangleF)bounds, EverettRenderer.StandardStringFormat);
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        public override void FinishRenderSession()
        {
            this.backBrush.Dispose();
            this.shadowPen.Dispose();
            this.highlightPen.Dispose();
            this.foreBrush.Dispose();
            this.outlinePen.Dispose();
            this.stringFormat.Dispose();
        }

        /// <summary>
        /// Overridden.
        /// 
        /// </summary>
        public override string ToString()
        {
            return "Everett";
        }
    }
}
