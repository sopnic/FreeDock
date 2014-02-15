﻿// Type: TD.SandDock.xedb4922162c60d3d
// Assembly: SandDock, Version=3.0.6.1, Culture=neutral, PublicKeyToken=75b7ec17dd7c14c3
// MVID: 86A16A8A-6BB9-495D-A857-1A3306E497E9
// Assembly location: C:\Program Files (x86)\Divelements Limited\SandDock for Windows Forms\SandDock.dll

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FQ.FreeDock
{
  internal class xedb4922162c60d3d : x890231ddf317379e
  {
    private System.Drawing.Size xca874006c41dfe29 = System.Drawing.Size.Empty;
    private System.Drawing.Point x2a2e0ce22e62c94e = System.Drawing.Point.Empty;
    private const int x92d9c1851cace8e0 = 30;
    private SandDockManager x91f347c6e97f1846;
    private DockContainer x0467b00af7810f0c;
    private LayoutSystemBase x83e1554f4315a375;
    private DockControl x493191df254612e4;
    private int x9562cf1322eeedf1;
    private xedb4922162c60d3d.DockTarget x521249670374b9ee;
    private Cursor x90ce1c0ec8c6028d;
    private Cursor x52988e63e407fffa;
    private ControlLayoutSystem[] xcd940949dfd37534;

    protected ControlLayoutSystem[] xcdb018cc067a38ae
    {
      get
      {
        return this.xcd940949dfd37534;
      }
    }

    public SandDockManager x460ab163f44a604d
    {
      get
      {
        return this.x91f347c6e97f1846;
      }
    }

    public int xf8ec28822747d4db
    {
      get
      {
        return this.x9562cf1322eeedf1;
      }
    }

    public DockContainer xc99dabdb533b119a
    {
      get
      {
        return this.x0467b00af7810f0c;
      }
    }

    public LayoutSystemBase xf333586e50dccad2
    {
      get
      {
        return this.x83e1554f4315a375;
      }
    }

    public DockControl x59ae058c4a0dec87
    {
      get
      {
        return this.x493191df254612e4;
      }
    }

    private System.Drawing.Point x6fbe0a6d89f5dffb
    {
      get
      {
        return new System.Drawing.Point(Cursor.Position.X - this.x2a2e0ce22e62c94e.X, Cursor.Position.Y - this.x2a2e0ce22e62c94e.Y);
      }
    }

    public bool xd065d1541e1bea63
    {
      get
      {
        return this.x0467b00af7810f0c.x972331c8ecf83413;
      }
    }

    public bool x74e31f9641656e0b
    {
      get
      {
        if (this.xd065d1541e1bea63)
          return false;
        if (this.x59ae058c4a0dec87 != null)
          return this.x59ae058c4a0dec87.DockingRules.AllowFloat;
        else
          return this.xf333586e50dccad2.x74e31f9641656e0b;
      }
    }

    public xedb4922162c60d3d.DockTarget x42f4c234c9358072
    {
      get
      {
        return this.x521249670374b9ee;
      }
    }

    public event xedb4922162c60d3d.DockingManagerFinishedEventHandler x67ecc0d0e7c9a202;

    public xedb4922162c60d3d(SandDockManager manager, DockContainer container, LayoutSystemBase sourceControlSystem, DockControl sourceControl, int dockedSize, System.Drawing.Point startPoint, DockingHints dockingHints)
      : base((Control) container, dockingHints, true, container.x631afe05fcecf1f4.TabStripMetrics.Height)
    {
      this.x91f347c6e97f1846 = manager;
      this.x0467b00af7810f0c = container;
label_18:
      this.x83e1554f4315a375 = sourceControlSystem;
      this.x493191df254612e4 = sourceControl;
      if (0 == 0)
        goto label_19;
label_9:
      Rectangle bounds;
      do
      {
        bounds = sourceControlSystem.Bounds;
        if (0 != 0 || bounds.Width > 0)
          goto label_7;
      }
      while (0 != 0);
      goto label_6;
label_3:
      if (sourceControl != null)
        goto label_2;
      else
        goto label_4;
label_1:
      this.x2a2e0ce22e62c94e.Y = Math.Max(this.x2a2e0ce22e62c94e.Y, 0);
      this.x2a2e0ce22e62c94e.Y = Math.Min(this.x2a2e0ce22e62c94e.Y, this.xca874006c41dfe29.Height);
      this.xcd940949dfd37534 = this.x0ce9d68830aba643();
      this.x0467b00af7810f0c.OnDockingStarted(EventArgs.Empty);
      goto label_11;
label_2:
      this.x2a2e0ce22e62c94e = new System.Drawing.Point(startPoint.X, this.xca874006c41dfe29.Height - (bounds.Bottom - startPoint.Y));
      goto label_1;
label_4:
      this.x2a2e0ce22e62c94e = new System.Drawing.Point(startPoint.X, startPoint.Y - bounds.Top);
      if ((uint) dockedSize >= 0U)
        goto label_1;
label_11:
      if (0 == 0)
        return;
      else
        goto label_14;
label_6:
      startPoint.X = this.xca874006c41dfe29.Width / 2;
      if (0 != 0)
        goto label_18;
      else
        goto label_3;
label_7:
      startPoint.X -= bounds.Left;
      startPoint.X = Convert.ToInt32((float) startPoint.X / (float) bounds.Width * (float) this.xca874006c41dfe29.Width);
      goto label_3;
label_14:
      if (sourceControl == null)
      {
        while (sourceControlSystem is ControlLayoutSystem && ((ControlLayoutSystem) sourceControlSystem).SelectedControl != null)
        {
          this.xca874006c41dfe29 = ((ControlLayoutSystem) sourceControlSystem).SelectedControl.FloatingSize;
          if (-1 != 0)
            goto label_9;
        }
        this.xca874006c41dfe29 = sourceControlSystem.Bounds.Size;
        goto label_9;
      }
      else
      {
        this.xca874006c41dfe29 = sourceControl.FloatingSize;
        goto label_9;
      }
label_19:
      this.x9562cf1322eeedf1 = dockedSize;
      if (container is DocumentContainer)
        goto label_17;
      else
        goto label_20;
label_15:
      this.xca874006c41dfe29 = ((x410f3612b9a8f9de) container).xb1090c5821a633b5;
      goto label_9;
label_16:
      if (!(sourceControlSystem is SplitLayoutSystem))
        goto label_14;
      else
        goto label_15;
label_17:
      this.x90ce1c0ec8c6028d = new Cursor(this.GetType().Assembly.GetManifestResourceStream("TD.SandDock.Resources.splitting.cur"));
      this.x52988e63e407fffa = new Cursor(this.GetType().Assembly.GetManifestResourceStream("TD.SandDock.Resources.splittingno.cur"));
      goto label_16;
label_20:
      if (8 != 0)
        goto label_16;
      else
        goto label_15;
    }

    public bool xe302f2203dc14a18(ContainerDockLocation xb9c2cfae130d9256)
    {
      if (this.x59ae058c4a0dec87 != null)
        return this.x59ae058c4a0dec87.xe302f2203dc14a18(xb9c2cfae130d9256);
      else
        return this.xf333586e50dccad2.xe302f2203dc14a18(xb9c2cfae130d9256);
    }

    public override void OnMouseMove(System.Drawing.Point position)
    {
      xedb4922162c60d3d.DockTarget dockTarget = (xedb4922162c60d3d.DockTarget) null;
      if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
        goto label_39;
label_37:
      if (dockTarget != null)
        goto label_40;
      else
        goto label_36;
label_34:
      if (dockTarget.type == xedb4922162c60d3d.DockTargetType.Undefined)
        dockTarget.type = xedb4922162c60d3d.DockTargetType.None;
      if (dockTarget.type != xedb4922162c60d3d.DockTargetType.Float)
        goto label_28;
      else
        goto label_32;
label_3:
      if (this.x0467b00af7810f0c is DocumentContainer)
      {
        if (dockTarget.type != xedb4922162c60d3d.DockTargetType.AlreadyActioned)
        {
          if (dockTarget.type != xedb4922162c60d3d.DockTargetType.None)
            Cursor.Current = this.x90ce1c0ec8c6028d;
          else
            goto label_5;
        }
        else
        {
          Cursor.Current = Cursors.Default;
          goto label_20;
        }
      }
label_4:
      this.x521249670374b9ee = dockTarget;
      return;
label_5:
      Cursor.Current = this.x52988e63e407fffa;
      if ((int) byte.MaxValue == 0)
        goto label_25;
      else
        goto label_4;
label_8:
      if (dockTarget.type != xedb4922162c60d3d.DockTargetType.None)
      {
        this.xe5e4149f382149cc(dockTarget.bounds, dockTarget.type == xedb4922162c60d3d.DockTargetType.JoinExistingSystem);
        if (2 != 0)
          goto label_3;
        else
          goto label_20;
      }
      else
      {
        this.x11972e8742c570b8();
        goto label_3;
      }
label_13:
      if (2 != 0)
      {
        if (0 == 0)
        {
          if (0 == 0)
            goto label_8;
          else
            goto label_8;
        }
        else
          goto label_3;
      }
label_17:
      ControlLayoutSystem controlLayoutSystem;
      if (dockTarget.dockSide == DockSide.None)
      {
        this.x11972e8742c570b8();
        controlLayoutSystem = (ControlLayoutSystem) this.x83e1554f4315a375;
        if (dockTarget.index == controlLayoutSystem.Controls.IndexOf(this.x493191df254612e4))
          goto label_24;
        else
          goto label_23;
      }
label_18:
      if (0 == 0)
      {
        if (0 != 0)
          goto label_13;
        else
          goto label_8;
      }
      else if (0 == 0)
      {
        if (2 == 0)
          goto label_22;
        else
          goto label_13;
      }
      else
        goto label_8;
label_20:
      if (15 == 0)
      {
        if (2 != 0)
          goto label_36;
      }
      else
        goto label_4;
label_22:
      dockTarget.type = xedb4922162c60d3d.DockTargetType.AlreadyActioned;
      goto label_3;
label_23:
      if (dockTarget.index != controlLayoutSystem.Controls.IndexOf(this.x493191df254612e4) + 1)
      {
        controlLayoutSystem.Controls.SetChildIndex(this.x493191df254612e4, dockTarget.index);
        goto label_22;
      }
      else
        goto label_22;
label_24:
      if (2 == 0)
        goto label_23;
label_25:
      if (0 == 0)
      {
        if (0 == 0)
          goto label_22;
        else
          goto label_3;
      }
      else
        goto label_18;
label_28:
      if (dockTarget.layoutSystem == this.x83e1554f4315a375)
      {
        if (0 == 0)
        {
          if (0 == 0)
          {
            if (0 == 0)
            {
              if (this.x493191df254612e4 != null || 0 != 0)
                goto label_17;
              else
                goto label_13;
            }
            else
              goto label_41;
          }
          else
            goto label_5;
        }
      }
      else
        goto label_8;
label_32:
      dockTarget.bounds = new Rectangle(this.x6fbe0a6d89f5dffb, this.xca874006c41dfe29);
      dockTarget.bounds = this.x90c590fcd758eaee(dockTarget.bounds);
      if (0 == 0)
        goto label_28;
      else
        goto label_24;
label_36:
      dockTarget = this.x91f347c6e97f1846 == null || !this.x74e31f9641656e0b ? new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.None) : new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.Float);
      goto label_34;
label_40:
      if (dockTarget.type != xedb4922162c60d3d.DockTargetType.Undefined)
        goto label_34;
label_41:
      if (this.x91f347c6e97f1846 == null || 2 != 0 && !this.x74e31f9641656e0b)
        goto label_34;
      else
        goto label_36;
label_39:
      dockTarget = this.FindDockTarget(position);
      goto label_37;
    }

    private Rectangle x90c590fcd758eaee(Rectangle xda73fcb97c77d998)
    {
      if (xda73fcb97c77d998.X >= Screen.PrimaryScreen.Bounds.X && (-1 == 0 || 15 == 0 || xda73fcb97c77d998.Right <= Screen.PrimaryScreen.Bounds.Right) && xda73fcb97c77d998.Y > Screen.PrimaryScreen.WorkingArea.Bottom)
        xda73fcb97c77d998.Y = Screen.PrimaryScreen.WorkingArea.Bottom - xda73fcb97c77d998.Height;
      Screen screen = Screen.FromRectangle(xda73fcb97c77d998);
      if (screen != null && xda73fcb97c77d998.Y < screen.WorkingArea.Y)
        xda73fcb97c77d998.Y = screen.WorkingArea.Y;
      return xda73fcb97c77d998;
    }

    protected Rectangle x8a1b221df357d098(ContainerDockLocation x9c911703d455884e, bool x24c3791e61dc49c9)
    {
      int num;
      if (x24c3791e61dc49c9)
      {
        if ((uint) num + (uint) num <= uint.MaxValue)
          return this.x257d5a0e25592705(x9c911703d455884e, 30, true);
      }
      else
        goto label_9;
label_6:
      if (0 == 0)
        goto label_7;
label_2:
      int width;
      int y;
      int height;
      return new Rectangle(width, y, 30, height - y);
label_7:
      y = 0;
      Control dockSystemContainer;
      height = dockSystemContainer.ClientRectangle.Height;
      int x;
      switch (x9c911703d455884e)
      {
        case ContainerDockLocation.Left:
          return new Rectangle(x - 30, y, 30, height - y);
        case ContainerDockLocation.Right:
          goto label_2;
        case ContainerDockLocation.Top:
          return new Rectangle(x, y - 30, width - x, 30);
        case ContainerDockLocation.Bottom:
          return new Rectangle(x, height, width - x, 30);
        default:
          goto label_10;
      }
label_9:
      dockSystemContainer = this.x460ab163f44a604d.DockSystemContainer;
      x = 0;
      width = dockSystemContainer.ClientRectangle.Width;
      if ((num | int.MaxValue) != 0)
        goto label_6;
label_10:
      return Rectangle.Empty;
    }

    public static Rectangle x41c62f474d3fb367(Control xd3311d815ca25f02)
    {
      int x = 0;
      int y;
      int num1;
      if (0 == 0)
      {
        num1 = xd3311d815ca25f02.ClientRectangle.Width;
        y = 0;
      }
      int num2 = xd3311d815ca25f02.ClientRectangle.Height;
      if (int.MinValue != 0)
      {
        IEnumerator enumerator = xd3311d815ca25f02.Controls.GetEnumerator();
        try
        {
          while (true)
          {
            Rectangle bounds1;
            Control control;
            do
            {
              if (!enumerator.MoveNext())
              {
                if ((uint) y + (uint) num1 >= 0U)
                  goto label_10;
                else
                  goto label_6;
              }
              else
                goto label_31;
label_5:
              Rectangle bounds2;
              if (bounds2.Top < num2)
                goto label_16;
              else
                continue;
label_6:
              continue;
label_7:
              Rectangle bounds3;
              if (bounds3.Left >= num1)
              {
                if ((uint) num2 + (uint) num1 <= uint.MaxValue)
                  continue;
                else
                  goto label_5;
              }
              else
                goto label_18;
label_10:
              if ((uint) y > uint.MaxValue)
              {
                if ((uint) num2 + (uint) x >= 0U)
                {
                  if ((uint) x + (uint) num2 < 0U)
                    continue;
                  else
                    goto label_31;
                }
                else
                  goto label_28;
              }
              else
                goto label_38;
label_13:
              Rectangle bounds4;
              if (bounds4.Right <= x)
              {
                if ((uint) y >= 0U)
                {
                  if ((uint) num1 - (uint) num2 <= uint.MaxValue)
                    continue;
                }
                else
                  goto label_16;
              }
              else
                goto label_27;
label_21:
              if ((uint) y + (uint) y >= 0U)
                goto label_6;
label_22:
              bounds3 = control.Bounds;
              goto label_7;
label_26:
              bounds4 = control.Bounds;
              goto label_13;
label_28:
              DockStyle dock = control.Dock;
              if ((uint) num1 >= 0U)
              {
                if ((uint) y <= uint.MaxValue)
                {
                  switch (dock)
                  {
                    case DockStyle.Top:
                      bounds1 = control.Bounds;
                      if ((uint) num2 + (uint) num1 < 0U)
                        continue;
                      else
                        goto label_6;
                    case DockStyle.Bottom:
                      bounds2 = control.Bounds;
                      if ((uint) num1 - (uint) num1 <= uint.MaxValue)
                        goto label_5;
                      else
                        goto label_16;
                    case DockStyle.Left:
                      goto label_26;
                    case DockStyle.Right:
                      goto label_22;
                    default:
                      continue;
                  }
                }
                else
                  goto label_6;
              }
label_31:
              control = (Control) enumerator.Current;
              if (int.MaxValue != 0)
              {
                if ((uint) x + (uint) y >= 0U && !control.Visible)
                {
                  if (-2 != 0)
                  {
                    if ((uint) num2 - (uint) num2 >= 0U)
                    {
                      if ((uint) x <= uint.MaxValue && (x | 1) != 0)
                      {
                        if ((uint) y + (uint) num1 < 0U)
                          goto label_10;
                      }
                      else
                        goto label_13;
                    }
                    else
                      goto label_21;
                  }
                  else
                    goto label_7;
                }
                else
                  goto label_28;
              }
              else
                goto label_26;
            }
            while (bounds1.Bottom <= y);
            goto label_24;
label_16:
            num2 = control.Bounds.Top;
            continue;
label_18:
            num1 = control.Bounds.Left;
            continue;
label_24:
            y = control.Bounds.Bottom;
            continue;
label_27:
            x = control.Bounds.Right;
          }
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if (disposable != null)
            disposable.Dispose();
        }
      }
label_38:
      return new Rectangle(x, y, num1 - x, num2 - y);
    }

    protected Rectangle x257d5a0e25592705(ContainerDockLocation x9c911703d455884e, int x73f61fa085749e85, bool x24c3791e61dc49c9)
    {
      Rectangle rectangle1 = xedb4922162c60d3d.x41c62f474d3fb367(this.x460ab163f44a604d.DockSystemContainer);
      if ((x73f61fa085749e85 | -1) != 0)
        goto label_7;
label_3:
      Rectangle rectangle2;
      int val1;
      return new Rectangle(rectangle2.Left, rectangle2.Top, Math.Min(val1, Convert.ToInt32((double) rectangle1.Width * 0.9)), rectangle2.Height);
label_7:
      rectangle2 = rectangle1;
      if (!x24c3791e61dc49c9)
        rectangle2 = this.x460ab163f44a604d.DockSystemContainer.ClientRectangle;
      val1 = x73f61fa085749e85 + 4;
      switch (x9c911703d455884e)
      {
        case ContainerDockLocation.Left:
          goto label_3;
        case ContainerDockLocation.Right:
          return new Rectangle(rectangle2.Right - Math.Min(val1, Convert.ToInt32((double) rectangle1.Width * 0.9)), rectangle2.Top, Math.Min(val1, Convert.ToInt32((double) rectangle1.Width * 0.9)), rectangle2.Height);
        case ContainerDockLocation.Top:
          return new Rectangle(rectangle2.Left, rectangle2.Top, rectangle2.Width, Math.Min(val1, Convert.ToInt32((double) rectangle1.Height * 0.9)));
        case ContainerDockLocation.Bottom:
          return new Rectangle(rectangle2.Left, rectangle2.Bottom - Math.Min(val1, Convert.ToInt32((double) rectangle1.Height * 0.9)), rectangle2.Width, Math.Min(val1, Convert.ToInt32((double) rectangle1.Height * 0.9)));
        default:
          return rectangle2;
      }
    }

    protected bool xecd95d3d6bb4afc3()
    {
      return this.x460ab163f44a604d.FindDockedContainer(DockStyle.Fill) is DocumentContainer;
    }

    private ControlLayoutSystem[] x0ce9d68830aba643()
    {
      ArrayList x3c4da2980d043c95 = new ArrayList();
      bool flag1;
      if (((flag1 ? 1 : 0) & 0) != 0)
        goto label_13;
      else
        goto label_29;
label_2:
      int index;
      ++index;
label_3:
      DockContainer[] dockContainerArray1;
      ControlLayoutSystem[] controlLayoutSystemArray;
      if (index >= dockContainerArray1.Length)
        controlLayoutSystemArray = new ControlLayoutSystem[x3c4da2980d043c95.Count];
      else
        goto label_28;
label_5:
      x3c4da2980d043c95.CopyTo((Array) controlLayoutSystemArray, 0);
      if (int.MinValue != 0)
        goto label_34;
      else
        goto label_2;
label_28:
      DockContainer xd3311d815ca25f02 = dockContainerArray1[index];
      bool isFloating = xd3311d815ca25f02.IsFloating;
      bool flag2 = xd3311d815ca25f02.Dock == DockStyle.Fill && !xd3311d815ca25f02.IsFloating;
      bool flag3 = this.xc99dabdb533b119a.Dock == DockStyle.Fill && !this.xc99dabdb533b119a.IsFloating;
      while (isFloating && this.xf333586e50dccad2.DockContainer == xd3311d815ca25f02)
      {
        if (this.xf333586e50dccad2 is SplitLayoutSystem)
        {
          if (4 != 0)
          {
            if ((uint) index < 0U)
              goto label_7;
            else
              goto label_2;
          }
          else
            goto label_18;
        }
        else if (((isFloating ? 1 : 0) & 0) == 0)
          break;
      }
      goto label_24;
label_7:
      if (!this.xe302f2203dc14a18(LayoutUtilities.x3650f3b579b2b4d2(xd3311d815ca25f02.Dock)))
      {
        if ((uint) flag3 + (uint) isFloating >= 0U)
          goto label_2;
      }
      else
        goto label_17;
label_8:
      if (this.xc99dabdb533b119a == xd3311d815ca25f02)
        goto label_13;
label_9:
      if ((uint) index - (uint) isFloating >= 0U)
      {
        if (((isFloating ? 1 : 0) | 2) == 0)
        {
          if ((uint) flag2 - (uint) index <= uint.MaxValue)
            goto label_20;
          else
            goto label_16;
        }
        else if ((uint) flag2 + (uint) flag3 >= 0U)
          goto label_2;
        else
          goto label_34;
      }
      else
        goto label_24;
label_12:
      if (!flag3)
        goto label_13;
      else
        goto label_8;
label_16:
      if ((uint) flag3 < 0U)
        goto label_9;
      else
        goto label_12;
label_17:
      if (!flag2)
        goto label_12;
label_18:
      if (flag3)
      {
        if (1 != 0)
          goto label_16;
      }
      else
        goto label_2;
label_20:
      if (!isFloating)
      {
        if ((uint) flag2 + (uint) index > uint.MaxValue)
        {
          if ((index & 0) == 0)
          {
            if ((uint) index < 0U)
              goto label_32;
            else
              goto label_17;
          }
          else
            goto label_5;
        }
        else
          goto label_7;
      }
      else
        goto label_17;
label_24:
      if (!isFloating || this.x74e31f9641656e0b || this.xf333586e50dccad2.DockContainer == xd3311d815ca25f02)
        goto label_20;
      else
        goto label_2;
label_34:
      return controlLayoutSystemArray;
label_13:
      this.x53faf379dc10cd0f(xd3311d815ca25f02, x3c4da2980d043c95);
      goto label_2;
label_27:
      DockContainer[] dockContainerArray2;
      dockContainerArray1 = dockContainerArray2;
      index = 0;
      goto label_3;
label_29:
      DockContainer[] dockContainerArray3;
      if (this.x91f347c6e97f1846 != null)
      {
        dockContainerArray2 = this.x91f347c6e97f1846.GetDockContainers();
        goto label_27;
      }
      else
        dockContainerArray3 = new DockContainer[1]
        {
          this.xc99dabdb533b119a
        };
label_32:
      dockContainerArray2 = dockContainerArray3;
      goto label_27;
    }

    private void x53faf379dc10cd0f(DockContainer xd3311d815ca25f02, ArrayList x3c4da2980d043c95)
    {
      int num;
      if (xd3311d815ca25f02.Width <= 0)
      {
        if (-1 != 0)
        {
          if (0 != 0)
            return;
          num = xd3311d815ca25f02.Height > 0 ? 1 : 0;
          goto label_10;
        }
      }
      else
        goto label_9;
label_2:
      if (!xd3311d815ca25f02.Visible)
        return;
label_5:
      this.xabdf625bc93be733(xd3311d815ca25f02, xd3311d815ca25f02.LayoutSystem, x3c4da2980d043c95);
      bool flag;
      if ((uint) flag - (uint) flag >= 0U)
        return;
label_6:
      if (!flag || !xd3311d815ca25f02.Enabled)
        return;
      if ((uint) flag + (uint) flag >= 0U)
        goto label_2;
      else
        goto label_5;
label_9:
      num = 1;
label_10:
      flag = num != 0;
      goto label_6;
    }

    private void xabdf625bc93be733(DockContainer xd3311d815ca25f02, SplitLayoutSystem x35c76d526f88c3c8, ArrayList x3c4da2980d043c95)
    {
      IEnumerator enumerator = x35c76d526f88c3c8.LayoutSystems.GetEnumerator();
      try
      {
label_3:
        while (enumerator.MoveNext())
        {
          LayoutSystemBase layoutSystemBase;
          do
          {
            layoutSystemBase = (LayoutSystemBase) enumerator.Current;
            if (!(layoutSystemBase is SplitLayoutSystem))
            {
              bool flag;
              do
              {
                if (layoutSystemBase is ControlLayoutSystem)
                  goto label_11;
                else
                  goto label_7;
label_2:
                continue;
label_7:
                if (15 == 0)
                {
                  if (((flag ? 1 : 0) | 8) != 0)
                    goto label_2;
                  else
                    goto label_15;
                }
                else
                  break;
label_11:
                flag = (this.x493191df254612e4 == null || (layoutSystemBase != this.x83e1554f4315a375 || this.x493191df254612e4.LayoutSystem.Controls.Count != 1)) && !((ControlLayoutSystem) layoutSystemBase).Collapsed;
                do
                {
                  if (flag)
                  {
                    x3c4da2980d043c95.Add((object) layoutSystemBase);
                    if ((uint) flag <= uint.MaxValue)
                    {
                      if (0 != 0)
                        goto label_17;
                    }
                    else
                      goto label_10;
                  }
                  else
                    goto label_3;
                }
                while (int.MinValue == 0);
                goto label_2;
              }
              while ((uint) flag < 0U);
              goto label_3;
label_10:;
            }
            else
              break;
          }
          while (0 == 0);
          goto label_12;
label_15:
          break;
label_12:
          this.xabdf625bc93be733(xd3311d815ca25f02, (SplitLayoutSystem) layoutSystemBase, x3c4da2980d043c95);
          continue;
label_17:
          break;
        }
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
    }

    protected virtual xedb4922162c60d3d.DockTarget FindDockTarget(System.Drawing.Point position)
    {
      xedb4922162c60d3d.DockTarget dockTarget1 = (xedb4922162c60d3d.DockTarget) null;
      int num1;
      int num2;
      if ((uint) num1 + (uint) num2 <= uint.MaxValue)
        goto label_30;
      else
        goto label_28;
label_16:
      ContainerDockLocation containerDockLocation;
      dockTarget1.dockLocation = containerDockLocation;
      dockTarget1.bounds = xedb4922162c60d3d.xc68a4bb946c59a9e(this.x257d5a0e25592705(containerDockLocation, this.x9562cf1322eeedf1, true), this.x460ab163f44a604d.DockSystemContainer);
      dockTarget1.middle = true;
      return dockTarget1;
label_26:
      ControlLayoutSystem[] controlLayoutSystemArray = this.xcd940949dfd37534;
      int index = 0;
      while (true)
      {
        if (index < controlLayoutSystemArray.Length)
          goto label_27;
        else
          goto label_29;
label_20:
        ++index;
        continue;
label_25:
        ControlLayoutSystem x6e150040c8d97700;
        dockTarget1 = this.xede53ab1a4b2e20b(x6e150040c8d97700.DockContainer, x6e150040c8d97700, position, true);
        if (dockTarget1 != null)
          goto label_22;
        else
          goto label_20;
label_27:
        x6e150040c8d97700 = controlLayoutSystemArray[index];
        Rectangle rectangle1 = new Rectangle(x6e150040c8d97700.DockContainer.PointToScreen(x6e150040c8d97700.Bounds.Location), x6e150040c8d97700.Bounds.Size);
        while (-1 != 0 && !rectangle1.Contains(position))
        {
          if (0 == 0)
            goto label_20;
        }
        goto label_25;
label_29:
        int num3;
        if ((uint) index - (uint) num3 <= uint.MaxValue)
          goto label_17;
        else
          goto label_12;
label_1:
        if ((num3 & 0) == 0)
          break;
label_3:
        if (this.x460ab163f44a604d != null)
          goto label_18;
        else
          break;
label_5:
        if (num3 > 4)
        {
          if ((uint) index - (uint) num3 < 0U || (uint) num3 >= 0U)
            goto label_1;
          else
            goto label_3;
        }
        else
        {
          containerDockLocation = (ContainerDockLocation) num3;
          if ((uint) index - (uint) num3 > uint.MaxValue)
            goto label_25;
        }
label_12:
        if (this.xe302f2203dc14a18(containerDockLocation))
          goto label_13;
label_4:
        ++num3;
        goto label_5;
label_13:
        Rectangle rectangle2 = xedb4922162c60d3d.xc68a4bb946c59a9e(this.x8a1b221df357d098(containerDockLocation, true), this.x460ab163f44a604d.DockSystemContainer);
        if (-1 != 0)
        {
          if (!rectangle2.Contains(position))
          {
            Rectangle rectangle3 = xedb4922162c60d3d.xc68a4bb946c59a9e(this.x8a1b221df357d098(containerDockLocation, false), this.x460ab163f44a604d.DockSystemContainer);
            if ((uint) index <= uint.MaxValue)
            {
              if (0 == 0)
              {
                if ((num3 | 8) == 0 || rectangle3.Contains(position))
                  goto label_10;
                else
                  goto label_4;
              }
              else
                goto label_3;
            }
            else
              goto label_7;
          }
          else
            goto label_15;
        }
        else
          goto label_1;
label_17:
        if ((num3 | 8) != 0)
          goto label_3;
label_18:
        num3 = 1;
        goto label_5;
      }
      return (xedb4922162c60d3d.DockTarget) null;
label_7:
      dockTarget1.bounds = xedb4922162c60d3d.xc68a4bb946c59a9e(this.x257d5a0e25592705(containerDockLocation, this.x9562cf1322eeedf1, false), this.x460ab163f44a604d.DockSystemContainer);
      return dockTarget1;
label_10:
      dockTarget1 = new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.CreateNewContainer);
      dockTarget1.dockLocation = containerDockLocation;
      goto label_7;
label_15:
      dockTarget1 = new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.CreateNewContainer);
      goto label_16;
label_22:
      xedb4922162c60d3d.DockTarget dockTarget2 = dockTarget1;
      goto label_57;
label_28:
      if (this.x74e31f9641656e0b)
      {
        IEnumerator enumerator = this.x91f347c6e97f1846.xd27fa35d10494112.GetEnumerator();
        try
        {
label_35:
          if (!enumerator.MoveNext())
          {
            if ((uint) num1 - (uint) num1 <= uint.MaxValue)
              goto label_26;
          }
          DockContainer dockContainer = (DockContainer) enumerator.Current;
          if ((uint) num1 <= uint.MaxValue && dockContainer.IsFloating && ((x410f3612b9a8f9de) dockContainer).xd936980ea1aac341.Visible)
          {
label_36:
            do
            {
              if ((dockContainer.HasSingleControlLayoutSystem || 0 != 0) && dockContainer.LayoutSystem != this.x83e1554f4315a375)
              {
                do
                {
                  Rectangle rectangle = ((x410f3612b9a8f9de) dockContainer).x5de6fa99acd93adb;
                  if ((uint) num2 - (uint) num1 >= 0U)
                  {
                    if (!rectangle.Contains(position))
                    {
                      if ((uint) num1 - (uint) num2 >= 0U)
                        goto label_35;
                    }
                    else
                      goto label_42;
label_39:
                    if (!rectangle.Contains(position))
                    {
                      dockTarget1 = new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.JoinExistingSystem);
                      dockTarget1.dockContainer = dockContainer;
                      continue;
                    }
                    else
                      goto label_40;
label_42:
                    rectangle = new Rectangle(dockContainer.PointToScreen(dockContainer.LayoutSystem.LayoutSystems[0].Bounds.Location), dockContainer.LayoutSystem.LayoutSystems[0].Bounds.Size);
                    goto label_39;
                  }
                  else
                    goto label_36;
                }
                while (4 == 0);
                goto label_41;
label_40:;
              }
              else
                break;
            }
            while ((uint) num2 - (uint) num1 > uint.MaxValue);
            goto label_35;
label_41:
            dockTarget1.layoutSystem = (ControlLayoutSystem) dockContainer.LayoutSystem.LayoutSystems[0];
            dockTarget1.bounds = ((x410f3612b9a8f9de) dockContainer).x5de6fa99acd93adb;
            dockTarget2 = dockTarget1;
            goto label_57;
          }
          else
            goto label_35;
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          if ((num1 & 0) == 0)
            ;
          do
          {
            if (disposable != null)
              goto label_53;
            else
              goto label_51;
label_49:
            if (0 == 0)
            {
              if (-2 != 0 && (num1 & 0) == 0)
                break;
            }
            else
              continue;
label_51:
            if ((num2 | 15) != 0)
              continue;
            else
              goto label_49;
label_53:
            disposable.Dispose();
            goto label_49;
          }
          while ((uint) num2 > uint.MaxValue);
        }
      }
      else
        goto label_26;
label_30:
      while (this.x91f347c6e97f1846 != null)
      {
        if ((uint) num1 + (uint) num2 > uint.MaxValue)
        {
          if ((uint) num2 < 0U)
          {
            if (0 != 0)
              goto label_16;
            else
              goto label_28;
          }
        }
        else if ((uint) num1 <= uint.MaxValue)
          goto label_28;
        else
          goto label_57;
      }
      goto label_26;
label_57:
      return dockTarget2;
    }

    public static Rectangle xc68a4bb946c59a9e(Rectangle x337e217cb3ba0627, Control x43bec302f92080b9)
    {
      return new Rectangle(x43bec302f92080b9.PointToScreen(x337e217cb3ba0627.Location), x337e217cb3ba0627.Size);
    }

    protected xedb4922162c60d3d.DockTarget xede53ab1a4b2e20b(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, System.Drawing.Point x13d4cb8d1bd20347, bool xcef4185c23f358e0)
    {
      xedb4922162c60d3d.DockTarget dockTarget = new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.Undefined);
      System.Drawing.Point point;
      do
      {
        point = xd3311d815ca25f02.PointToClient(x13d4cb8d1bd20347);
        if ((uint) xcef4185c23f358e0 >= 0U)
          goto label_14;
        else
          goto label_19;
label_9:
        while (x6e150040c8d97700.xccb1fc68964285c2.Contains(point) || x6e150040c8d97700.xa358da7dd5364cab.Contains(point))
        {
          dockTarget = new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.JoinExistingSystem);
          if ((uint) xcef4185c23f358e0 - (uint) xcef4185c23f358e0 <= uint.MaxValue)
          {
            dockTarget.dockContainer = xd3311d815ca25f02;
            if (8 != 0 && (uint) xcef4185c23f358e0 <= uint.MaxValue)
              goto label_7;
label_4:
            dockTarget.index = x6e150040c8d97700.Controls.Count;
            break;
label_7:
            dockTarget.layoutSystem = x6e150040c8d97700;
            dockTarget.dockSide = DockSide.None;
            dockTarget.bounds = new Rectangle(xd3311d815ca25f02.PointToScreen(x6e150040c8d97700.Bounds.Location), x6e150040c8d97700.Bounds.Size);
            if ((uint) xcef4185c23f358e0 >= 0U)
            {
              if ((uint) xcef4185c23f358e0 > uint.MaxValue || x6e150040c8d97700.xa358da7dd5364cab.Contains(point))
              {
                dockTarget.index = x6e150040c8d97700.x17fd454c85fad336(point);
                break;
              }
              else
                goto label_4;
            }
          }
          else
            goto label_1;
        }
        if (dockTarget.type == xedb4922162c60d3d.DockTargetType.Undefined || (uint) xcef4185c23f358e0 > uint.MaxValue)
        {
          if (!xcef4185c23f358e0 && (uint) xcef4185c23f358e0 + (uint) xcef4185c23f358e0 <= uint.MaxValue)
            continue;
          else
            goto label_1;
        }
        else
          break;
label_14:
        while (this.x493191df254612e4 != null)
        {
          if ((uint) xcef4185c23f358e0 - (uint) xcef4185c23f358e0 <= uint.MaxValue)
            goto label_19;
        }
        if (x6e150040c8d97700 != this.x83e1554f4315a375)
          goto label_9;
        else
          goto label_17;
label_19:
        if (((xcef4185c23f358e0 ? 1 : 0) & 0) == 0)
          goto label_9;
        else
          break;
      }
      while ((int) byte.MaxValue == 0);
      goto label_20;
label_1:
      dockTarget = this.xc366f13a00f0a38d(xd3311d815ca25f02, x6e150040c8d97700, x13d4cb8d1bd20347);
      goto label_20;
label_17:
      if (x6e150040c8d97700.xccb1fc68964285c2.Contains(point))
        return new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.None);
      else
        return new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.Undefined);
label_20:
      return dockTarget;
    }

    private xedb4922162c60d3d.DockTarget xc366f13a00f0a38d(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, System.Drawing.Point x13d4cb8d1bd20347)
    {
      xedb4922162c60d3d.DockTarget x11d58b056c032b03 = (xedb4922162c60d3d.DockTarget) null;
      if (0 == 0)
      {
        System.Drawing.Point point;
        Rectangle x21ed2ecc088ef4e4;
        Rectangle rectangle;
        do
        {
          point = xd3311d815ca25f02.PointToClient(x13d4cb8d1bd20347);
          if (int.MinValue != 0)
          {
            x21ed2ecc088ef4e4 = x6e150040c8d97700.x21ed2ecc088ef4e4;
            if (!new Rectangle(x21ed2ecc088ef4e4.Left, x21ed2ecc088ef4e4.Top, x21ed2ecc088ef4e4.Width, 30).Contains(point))
            {
              rectangle = new Rectangle(x21ed2ecc088ef4e4.Left, x21ed2ecc088ef4e4.Top, 30, x21ed2ecc088ef4e4.Height);
              if (0 != 0)
                goto label_29;
            }
            else
              goto label_37;
          }
          else
            goto label_39;
        }
        while (0 != 0);
        goto label_24;
label_2:
        if (point.X > x21ed2ecc088ef4e4.Right - 30)
        {
          do
          {
            this.x4ea01976b3079611(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
          }
          while (0 != 0);
          goto label_40;
        }
label_3:
        this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Bottom);
        goto label_40;
label_15:
        this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Left);
        goto label_40;
label_20:
        if (0 == 0)
        {
          if (0 == 0 && point.Y >= x21ed2ecc088ef4e4.Top + 30)
          {
            if (point.Y > x21ed2ecc088ef4e4.Bottom - 30)
            {
              this.x6ff0606cba620904(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
              goto label_40;
            }
            else
              goto label_15;
          }
          else
          {
            this.x2a1e65376d30fca5(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
            if (0 != 0)
            {
              if (-1 != 0)
                goto label_15;
            }
            else
              goto label_40;
          }
        }
        else
          goto label_3;
label_24:
        if (0 == 0)
        {
          if (0 == 0)
            goto label_26;
label_9:
          if (point.Y <= x21ed2ecc088ef4e4.Bottom - 30)
          {
            this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Right);
            goto label_40;
          }
          else
          {
            this.x4ea01976b3079611(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
            goto label_40;
          }
label_26:
          if (!rectangle.Contains(point))
          {
            if (!new Rectangle(x21ed2ecc088ef4e4.Right - 30, x21ed2ecc088ef4e4.Top, 30, x21ed2ecc088ef4e4.Height).Contains(point))
            {
              if (new Rectangle(x21ed2ecc088ef4e4.Left, x21ed2ecc088ef4e4.Bottom - 30, x21ed2ecc088ef4e4.Width, 30).Contains(point))
              {
                x11d58b056c032b03 = this.x7aa9d6b148df47c3(xd3311d815ca25f02, x6e150040c8d97700);
                if (point.X >= x21ed2ecc088ef4e4.Left + 30)
                {
                  if (4 == 0)
                    goto label_20;
                  else
                    goto label_2;
                }
                else
                {
                  this.x6ff0606cba620904(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
                  goto label_40;
                }
              }
              else
                goto label_40;
            }
            else
            {
              x11d58b056c032b03 = this.x7aa9d6b148df47c3(xd3311d815ca25f02, x6e150040c8d97700);
              if (4 != 0)
              {
                if (0 == 0)
                {
                  if (-1 == 0 || point.Y < x21ed2ecc088ef4e4.Top + 30)
                  {
                    this.x142a59be2748bb95(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
                    goto label_40;
                  }
                  else
                    goto label_9;
                }
                else
                  goto label_40;
              }
              else
                goto label_29;
            }
          }
        }
        else
          goto label_15;
label_27:
        x11d58b056c032b03 = this.x7aa9d6b148df47c3(xd3311d815ca25f02, x6e150040c8d97700);
        if (3 != 0)
        {
          if (-1 == 0)
            goto label_2;
          else
            goto label_20;
        }
        else
          goto label_15;
label_29:
        if (1 == 0)
          goto label_34;
label_30:
        if (point.X > x21ed2ecc088ef4e4.Right - 30)
        {
          this.x142a59be2748bb95(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
          goto label_40;
        }
        else
        {
          this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Top);
          if (0 != 0 || 0 == 0)
            goto label_40;
          else
            goto label_27;
        }
label_34:
        if (point.X < x21ed2ecc088ef4e4.Left + 30)
        {
          this.x2a1e65376d30fca5(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, x21ed2ecc088ef4e4, point);
          goto label_40;
        }
        else
          goto label_30;
label_37:
        x11d58b056c032b03 = this.x7aa9d6b148df47c3(xd3311d815ca25f02, x6e150040c8d97700);
        goto label_34;
label_39:
        if (0 == 0)
          goto label_29;
        else
          goto label_24;
      }
label_40:
      return x11d58b056c032b03;
    }

    private void x4ea01976b3079611(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, xedb4922162c60d3d.DockTarget x11d58b056c032b03, Rectangle x21ed2ecc088ef4e4, System.Drawing.Point x6b2bb9f943411698)
    {
      x21ed2ecc088ef4e4.X = x21ed2ecc088ef4e4.Right - 30;
      x21ed2ecc088ef4e4.Y = x21ed2ecc088ef4e4.Bottom - 30;
      x6b2bb9f943411698.X -= x21ed2ecc088ef4e4.Left;
      x6b2bb9f943411698.Y -= x21ed2ecc088ef4e4.Top;
      x21ed2ecc088ef4e4 = new Rectangle(0, 0, 30, 30);
      while (x6b2bb9f943411698.Y > x21ed2ecc088ef4e4.Top + (int) ((double) x21ed2ecc088ef4e4.Height * ((double) x6b2bb9f943411698.X / (double) x21ed2ecc088ef4e4.Width)))
      {
        this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Bottom);
        if (int.MaxValue != 0)
          return;
      }
      this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Right);
    }

    private void x6ff0606cba620904(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, xedb4922162c60d3d.DockTarget x11d58b056c032b03, Rectangle x21ed2ecc088ef4e4, System.Drawing.Point x6b2bb9f943411698)
    {
      x21ed2ecc088ef4e4.Y = x21ed2ecc088ef4e4.Bottom - 30;
      x6b2bb9f943411698.X -= x21ed2ecc088ef4e4.Left;
      x6b2bb9f943411698.Y -= x21ed2ecc088ef4e4.Top;
      x21ed2ecc088ef4e4 = new Rectangle(0, 0, 30, 30);
      if (int.MinValue != 0)
        goto label_2;
      else
        goto label_4;
label_1:
      this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Bottom);
      return;
label_2:
      if (x6b2bb9f943411698.Y <= x21ed2ecc088ef4e4.Bottom - (int) ((double) x21ed2ecc088ef4e4.Height * ((double) x6b2bb9f943411698.X / (double) x21ed2ecc088ef4e4.Width)))
      {
        this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Left);
        return;
      }
      else
        goto label_1;
label_4:
      if (0 == 0)
        goto label_1;
    }

    private void x142a59be2748bb95(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, xedb4922162c60d3d.DockTarget x11d58b056c032b03, Rectangle x21ed2ecc088ef4e4, System.Drawing.Point x6b2bb9f943411698)
    {
      x21ed2ecc088ef4e4.X = x21ed2ecc088ef4e4.Right - 30;
      x6b2bb9f943411698.X -= x21ed2ecc088ef4e4.Left;
      x6b2bb9f943411698.Y -= x21ed2ecc088ef4e4.Top;
      x21ed2ecc088ef4e4 = new Rectangle(0, 0, 30, 30);
      if (x6b2bb9f943411698.Y <= x21ed2ecc088ef4e4.Top + (int) ((double) x21ed2ecc088ef4e4.Height * ((double) (x21ed2ecc088ef4e4.Right - x6b2bb9f943411698.X) / (double) x21ed2ecc088ef4e4.Width)))
        goto label_4;
      else
        goto label_5;
label_1:
      if (1 != 0)
        return;
      else
        return;
label_4:
      this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Top);
      goto label_1;
label_5:
      this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Right);
      if (int.MinValue == 0)
        goto label_1;
    }

    private void x2a1e65376d30fca5(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, xedb4922162c60d3d.DockTarget x11d58b056c032b03, Rectangle x21ed2ecc088ef4e4, System.Drawing.Point x6b2bb9f943411698)
    {
      x6b2bb9f943411698.X -= x21ed2ecc088ef4e4.Left;
      do
      {
        x6b2bb9f943411698.Y -= x21ed2ecc088ef4e4.Top;
        x21ed2ecc088ef4e4 = new Rectangle(0, 0, 30, 30);
        do
        {
          if (x6b2bb9f943411698.Y <= x21ed2ecc088ef4e4.Top + (int) ((double) x21ed2ecc088ef4e4.Height * ((double) x6b2bb9f943411698.X / (double) x21ed2ecc088ef4e4.Width)))
            goto label_4;
        }
        while (15 == 0);
        goto label_3;
label_4:
        this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Top);
      }
      while (0 != 0);
      goto label_6;
label_3:
      this.xa86a93682c30b8c6(xd3311d815ca25f02, x6e150040c8d97700, x11d58b056c032b03, DockSide.Left);
      return;
label_6:;
    }

    private void xa86a93682c30b8c6(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, xedb4922162c60d3d.DockTarget x11d58b056c032b03, DockSide x4f217665270fa928)
    {
      x11d58b056c032b03.bounds = this.x3102817291e84207(xd3311d815ca25f02, x6e150040c8d97700, x4f217665270fa928);
      x11d58b056c032b03.dockSide = x4f217665270fa928;
    }

    internal Rectangle x3102817291e84207(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700, DockSide x4f217665270fa928)
    {
      Rectangle rectangle = new Rectangle(xd3311d815ca25f02.PointToScreen(x6e150040c8d97700.Bounds.Location), x6e150040c8d97700.Bounds.Size);
      if (int.MaxValue != 0)
        goto label_6;
label_1:
      rectangle.Offset(0, rectangle.Height / 2);
label_2:
      rectangle.Height /= 2;
      goto label_8;
label_6:
      switch (x4f217665270fa928)
      {
        case DockSide.Top:
          rectangle.Height /= 2;
          if (3 == 0)
            goto case 2;
          else
            break;
        case DockSide.Bottom:
          goto label_1;
        case DockSide.Left:
          rectangle.Width /= 2;
          break;
        case DockSide.Right:
          rectangle.Offset(rectangle.Width / 2, 0);
          rectangle.Width /= 2;
          break;
        default:
          if (0 != 0)
            goto label_2;
          else
            break;
      }
label_8:
      return rectangle;
    }

    private xedb4922162c60d3d.DockTarget x7aa9d6b148df47c3(DockContainer xd3311d815ca25f02, ControlLayoutSystem x6e150040c8d97700)
    {
      return new xedb4922162c60d3d.DockTarget(xedb4922162c60d3d.DockTargetType.SplitExistingSystem)
      {
        dockContainer = xd3311d815ca25f02,
        layoutSystem = x6e150040c8d97700
      };
    }

    public override void Commit()
    {
      base.Commit();
      LayoutUtilities.x3a04ba0cdf69aff2();
      try
      {
        if (this.x67ecc0d0e7c9a202 == null)
          return;
        this.x67ecc0d0e7c9a202(this.x521249670374b9ee);
      }
      finally
      {
        LayoutUtilities.x861aa05d0acfeb39();
      }
    }

    public override void Dispose()
    {
      this.x0467b00af7810f0c.OnDockingFinished(EventArgs.Empty);
      if (!(this.x90ce1c0ec8c6028d != (Cursor) null))
        goto label_2;
label_1:
      this.x90ce1c0ec8c6028d.Dispose();
label_2:
      if (this.x52988e63e407fffa != (Cursor) null)
        this.x52988e63e407fffa.Dispose();
      base.Dispose();
      if (0 != 0)
        goto label_1;
    }

    public delegate void DockingManagerFinishedEventHandler(xedb4922162c60d3d.DockTarget target);

    public class DockTarget
    {
      public DockSide dockSide = DockSide.None;
      public Rectangle bounds = Rectangle.Empty;
      public ContainerDockLocation dockLocation = ContainerDockLocation.Center;
      public xedb4922162c60d3d.DockTargetType type;
      public DockContainer dockContainer;
      public ControlLayoutSystem layoutSystem;
      public int index;
      public bool middle;

      public DockTarget(xedb4922162c60d3d.DockTargetType type)
      {
        this.type = type;
      }
    }

    public enum DockTargetType
    {
      Undefined,
      None,
      Float,
      SplitExistingSystem,
      JoinExistingSystem,
      CreateNewContainer,
      AlreadyActioned,
    }
  }
}