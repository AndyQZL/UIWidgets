using System;
using System.Collections.Generic;
using Unity.UIWidgets.rendering;
using Unity.UIWidgets.foundation;
using Unity.UIWidgets.painting;
using Unity.UIWidgets.service;
using Unity.UIWidgets.ui;
using Unity.UIWidgets.widgets;

namespace Unity.UIWidgets.material {
    public class RaisedButton : MaterialButton {
        public RaisedButton(
            Key key = null,
            VoidCallback onPressed = null,
            ValueChanged<bool> onHighlightChanged = null,
            ButtonTextTheme textTheme = ButtonTextTheme.normal,
            Color textColor = null,
            Color disabledTextColor = null,
            Color color = null,
            Color disabledColor = null,
            Color highlightColor = null,
            Color splashColor = null,
            Brightness? colorBrightness = null,
            double? elevation = null,
            double? highlightElevation = null,
            double? disabledElevation = null,
            EdgeInsets padding = null,
            ShapeBorder shape = null,
            Clip clipBehavior = Clip.none,
            MaterialTapTargetSize? materialTapTargetSize = null,
            TimeSpan? animationDuration = null,
            Widget child = null) : base(
            key: key,
            onPressed: onPressed,
            onHighlightChanged: onHighlightChanged,
            textTheme: textTheme,
            textColor: textColor,
            disabledTextColor: disabledTextColor,
            color: color,
            disabledColor: disabledColor,
            highlightColor: highlightColor,
            splashColor: splashColor,
            colorBrightness: colorBrightness,
            elevation: elevation,
            highlightElevation: highlightElevation,
            disabledElevation: disabledElevation,
            padding: padding,
            shape: shape,
            clipBehavior: clipBehavior,
            materialTapTargetSize: materialTapTargetSize,
            animationDuration: animationDuration,
            child: child) {

            D.assert(elevation == null || elevation >= 0.0);
            D.assert(highlightElevation == null || highlightElevation >= 0.0);
            D.assert(disabledElevation == null || disabledElevation >= 0.0);
        }

        public static RaisedButton icon(
            Key key = null,
            VoidCallback onPressed = null,
            ValueChanged<bool> onHighlightChanged = null,
            ButtonTextTheme textTheme = ButtonTextTheme.normal,
            Color textColor = null,
            Color disabledTextColor = null,
            Color color = null,
            Color disabledColor = null,
            Color highlightColor = null,
            Color splashColor = null,
            Brightness colorBrightness = Brightness.dark,
            double? elevation = null,
            double? highlightElevation = null,
            double? disabledElevation = null,
            EdgeInsets padding = null,
            ShapeBorder shape = null,
            Clip clipBehavior = Clip.none,
            MaterialTapTargetSize materialTapTargetSize = MaterialTapTargetSize.padded,
            TimeSpan? animationDuration = null,
            Widget icon = null,
            Widget label = null) {
            return new _RaisedButtonWithIcon(
                key: key,
                onPressed: onPressed,
                onHighlightChanged: onHighlightChanged,
                textTheme: textTheme,
                textColor: textColor,
                disabledTextColor: disabledTextColor,
                color: color,
                disabledColor: disabledColor,
                highlightColor: highlightColor,
                splashColor: splashColor,
                colorBrightness: colorBrightness,
                elevation: elevation,
                highlightElevation: highlightElevation,
                disabledElevation: disabledElevation,
                padding: padding,
                shape: shape,
                clipBehavior: clipBehavior,
                materialTapTargetSize: materialTapTargetSize,
                animationDuration: animationDuration,
                icon: icon,
                label: label);
        }

        public override Widget build(BuildContext context) {
            ThemeData theme = Theme.of(context);
            ButtonThemeData buttonTheme = ButtonTheme.of(context);

            return new RawMaterialButton(
                onPressed: onPressed,
                onHighlightChanged: onHighlightChanged,
                clipBehavior: clipBehavior ?? Clip.none,
                fillColor: buttonTheme.getFillColor(this),
                textStyle: theme.textTheme.button.copyWith(color: buttonTheme.getTextColor(this)),
                highlightColor: buttonTheme.getHighlightColor(this),
                splashColor: buttonTheme.getSplashColor(this),
                elevation: buttonTheme.getElevation(this),
                highlightElevation: buttonTheme.getHighlightElevation(this),
                disabledElevation: buttonTheme.getDisabledElevation(this),
                padding: buttonTheme.getPadding(this),
                constraints: buttonTheme.getConstraints(this),
                shape: buttonTheme.getShape(this),
                animationDuration: buttonTheme.getAnimationDuration(this),
                materialTapTargetSize: buttonTheme.getMaterialTapTargetSize(this),
                child: child
            );
        }

        public override void debugFillProperties(DiagnosticPropertiesBuilder properties) {
            base.debugFillProperties(properties);
            properties.add(new ObjectFlagProperty<VoidCallback>("onPressed", onPressed, ifNull: "disabled"));
            properties.add(new DiagnosticsProperty<ButtonTextTheme?>("textTheme", textTheme, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("textColor", textColor, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("disabledTextColor", disabledTextColor, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("color", color, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("disabledColor", disabledColor, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("highlightColor", highlightColor, defaultValue: null));
            properties.add(new DiagnosticsProperty<Color>("splashColor", splashColor, defaultValue: null));
            properties.add(new DiagnosticsProperty<Brightness?>("colorBrightness", colorBrightness, defaultValue: null));
            properties.add(new DiagnosticsProperty<double?>("elevation", elevation, defaultValue: null));
            properties.add(new DiagnosticsProperty<double?>("highlightElevation", highlightElevation, defaultValue: null));
            properties.add(new DiagnosticsProperty<double?>("disabledElevation", disabledElevation, defaultValue: null));
            properties.add(new DiagnosticsProperty<EdgeInsets>("padding", padding, defaultValue: null));
            properties.add(new DiagnosticsProperty<ShapeBorder>("shape", shape, defaultValue: null));
            properties.add(new DiagnosticsProperty<MaterialTapTargetSize?>("materialTapTargetSize", materialTapTargetSize, defaultValue: null));
        }
    }

    class _RaisedButtonWithIcon : RaisedButton {
        public _RaisedButtonWithIcon(
            Key key = null,
            VoidCallback onPressed = null,
            ValueChanged<bool> onHighlightChanged = null,
            ButtonTextTheme textTheme = ButtonTextTheme.normal,
            Color textColor = null,
            Color disabledTextColor = null,
            Color color = null,
            Color disabledColor = null,
            Color highlightColor = null,
            Color splashColor = null,
            Brightness colorBrightness = Brightness.dark,
            double? elevation = null,
            double? highlightElevation = null,
            double? disabledElevation = null,
            EdgeInsets padding = null,
            ShapeBorder shape = null,
            Clip clipBehavior = Clip.none,
            MaterialTapTargetSize materialTapTargetSize = MaterialTapTargetSize.padded,
            TimeSpan? animationDuration = null,
            Widget icon = null,
            Widget label = null) : base(
            key: key,
            onPressed: onPressed,
            onHighlightChanged: onHighlightChanged,
            textTheme: textTheme,
            textColor: textColor,
            disabledTextColor: disabledTextColor,
            color: color,
            disabledColor: disabledColor,
            highlightColor: highlightColor,
            splashColor: splashColor,
            colorBrightness: colorBrightness,
            elevation: elevation,
            highlightElevation: highlightElevation,
            disabledElevation: disabledElevation,
            padding: padding,
            shape: shape,
            clipBehavior: clipBehavior,
            materialTapTargetSize: materialTapTargetSize,
            animationDuration: animationDuration,
            child: new Row(
                mainAxisSize: MainAxisSize.min,
                children: new List<Widget> {
                    icon,
                    new SizedBox(width: 8.0),
                    label
                }
            )) {
            D.assert(elevation == null || elevation >= 0.0);
            D.assert(highlightElevation == null || highlightElevation >= 0.0);
            D.assert(disabledElevation == null || disabledElevation >= 0.0);
            D.assert(icon != null);
            D.assert(label != null);
        }
    }
}
