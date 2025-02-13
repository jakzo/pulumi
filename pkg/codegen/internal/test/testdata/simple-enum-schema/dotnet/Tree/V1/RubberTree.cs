// *** WARNING: this file was generated by test. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Plant.Tree.V1
{
    [PlantResourceType("plant:tree/v1:RubberTree")]
    public partial class RubberTree : Pulumi.CustomResource
    {
        [Output("container")]
        public Output<Pulumi.Plant.Outputs.Container?> Container { get; private set; } = null!;

        [Output("diameter")]
        public Output<Pulumi.Plant.Tree.V1.Diameter> Diameter { get; private set; } = null!;

        [Output("farm")]
        public Output<string?> Farm { get; private set; } = null!;

        [Output("size")]
        public Output<Pulumi.Plant.Tree.V1.TreeSize?> Size { get; private set; } = null!;

        [Output("type")]
        public Output<Pulumi.Plant.Tree.V1.RubberTreeVariety> Type { get; private set; } = null!;


        /// <summary>
        /// Create a RubberTree resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RubberTree(string name, RubberTreeArgs args, CustomResourceOptions? options = null)
            : base("plant:tree/v1:RubberTree", name, args ?? new RubberTreeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RubberTree(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("plant:tree/v1:RubberTree", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RubberTree resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RubberTree Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new RubberTree(name, id, options);
        }
    }

    public sealed class RubberTreeArgs : Pulumi.ResourceArgs
    {
        [Input("container")]
        public Input<Pulumi.Plant.Inputs.ContainerArgs>? Container { get; set; }

        [Input("diameter", required: true)]
        public Input<Pulumi.Plant.Tree.V1.Diameter> Diameter { get; set; } = null!;

        [Input("farm")]
        public InputUnion<Pulumi.Plant.Tree.V1.Farm, string>? Farm { get; set; }

        [Input("size")]
        public Input<Pulumi.Plant.Tree.V1.TreeSize>? Size { get; set; }

        [Input("type", required: true)]
        public Input<Pulumi.Plant.Tree.V1.RubberTreeVariety> Type { get; set; } = null!;

        public RubberTreeArgs()
        {
            Diameter = Pulumi.Plant.Tree.V1.Diameter.Sixinch;
            Farm = "(unknown)";
            Size = Pulumi.Plant.Tree.V1.TreeSize.Medium;
            Type = Pulumi.Plant.Tree.V1.RubberTreeVariety.Burgundy;
        }
    }
}
