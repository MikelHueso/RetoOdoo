using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ODOO.Models {
    public partial class OdooDBContext : DbContext {
        public OdooDBContext() {
        }

        public OdooDBContext(DbContextOptions<OdooDBContext> options)
            : base(options) {
        }

        public virtual DbSet<EventEvent> EventEvent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=OdooDB;Username=openpg;Password=openpgpwd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<EventEvent>(entity => {
                entity.ToTable("event_event");

                entity.ForNpgsqlHasComment("Event");

                entity.HasIndex(e => e.MessageMainAttachmentId)
                    .HasName("event_event_message_main_attachment_id_index");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .ForNpgsqlHasComment("Active");

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .ForNpgsqlHasComment("Location");

                entity.Property(e => e.AutoConfirm)
                    .HasColumnName("auto_confirm")
                    .ForNpgsqlHasComment("Autoconfirm Registrations");

                entity.Property(e => e.BadgeBack)
                    .HasColumnName("badge_back")
                    .ForNpgsqlHasComment("Badge Back");

                entity.Property(e => e.BadgeFront)
                    .HasColumnName("badge_front")
                    .ForNpgsqlHasComment("Badge Front");

                entity.Property(e => e.BadgeInnerleft)
                    .HasColumnName("badge_innerleft")
                    .ForNpgsqlHasComment("Badge Inner Left");

                entity.Property(e => e.BadgeInnerright)
                    .HasColumnName("badge_innerright")
                    .ForNpgsqlHasComment("Badge Inner Right");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .ForNpgsqlHasComment("Kanban Color Index");

                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .ForNpgsqlHasComment("Company");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .ForNpgsqlHasComment("Country");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .ForNpgsqlHasComment("Created on");

                entity.Property(e => e.CreateUid)
                    .HasColumnName("create_uid")
                    .ForNpgsqlHasComment("Created by");

                entity.Property(e => e.DateBegin)
                    .HasColumnName("date_begin")
                    .ForNpgsqlHasComment("Start Date");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("date_end")
                    .ForNpgsqlHasComment("End Date");

                entity.Property(e => e.DateTz)
                    .IsRequired()
                    .HasColumnName("date_tz")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Timezone");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .ForNpgsqlHasComment("Description");

                entity.Property(e => e.EventLogo)
                    .HasColumnName("event_logo")
                    .ForNpgsqlHasComment("Event Logo");

                entity.Property(e => e.EventTypeId)
                    .HasColumnName("event_type_id")
                    .ForNpgsqlHasComment("Category");

                entity.Property(e => e.IsOnline)
                    .HasColumnName("is_online")
                    .ForNpgsqlHasComment("Online Event");

                entity.Property(e => e.IsPublished)
                    .HasColumnName("is_published")
                    .ForNpgsqlHasComment("Is published");

                entity.Property(e => e.MenuId)
                    .HasColumnName("menu_id")
                    .ForNpgsqlHasComment("Event Menu");

                entity.Property(e => e.MessageMainAttachmentId)
                    .HasColumnName("message_main_attachment_id")
                    .ForNpgsqlHasComment("Main Attachment");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Event");

                entity.Property(e => e.OrganizerId)
                    .HasColumnName("organizer_id")
                    .ForNpgsqlHasComment("Organizer");

                entity.Property(e => e.SeatsAvailability)
                    .IsRequired()
                    .HasColumnName("seats_availability")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Maximum Attendees");

                entity.Property(e => e.SeatsAvailable)
                    .HasColumnName("seats_available")
                    .ForNpgsqlHasComment("Available Seats");

                entity.Property(e => e.SeatsMax)
                    .HasColumnName("seats_max")
                    .ForNpgsqlHasComment("Maximum Attendees Number");

                entity.Property(e => e.SeatsMin)
                    .HasColumnName("seats_min")
                    .ForNpgsqlHasComment("Minimum Attendees");

                entity.Property(e => e.SeatsReserved)
                    .HasColumnName("seats_reserved")
                    .ForNpgsqlHasComment("Reserved Seats");

                entity.Property(e => e.SeatsUnconfirmed)
                    .HasColumnName("seats_unconfirmed")
                    .ForNpgsqlHasComment("Unconfirmed Seat Reservations");

                entity.Property(e => e.SeatsUsed)
                    .HasColumnName("seats_used")
                    .ForNpgsqlHasComment("Number of Participants");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Status");

                entity.Property(e => e.TwitterHashtag)
                    .HasColumnName("twitter_hashtag")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Twitter Hashtag");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .ForNpgsqlHasComment("Responsible");

                entity.Property(e => e.WebsiteId)
                    .HasColumnName("website_id")
                    .ForNpgsqlHasComment("Website");

                entity.Property(e => e.WebsiteMenu)
                    .HasColumnName("website_menu")
                    .ForNpgsqlHasComment("Dedicated Menu");

                entity.Property(e => e.WebsiteMetaDescription)
                    .HasColumnName("website_meta_description")
                    .ForNpgsqlHasComment("Website meta description");

                entity.Property(e => e.WebsiteMetaKeywords)
                    .HasColumnName("website_meta_keywords")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Website meta keywords");

                entity.Property(e => e.WebsiteMetaOgImg)
                    .HasColumnName("website_meta_og_img")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Website opengraph image");

                entity.Property(e => e.WebsiteMetaTitle)
                    .HasColumnName("website_meta_title")
                    .HasColumnType("character varying")
                    .ForNpgsqlHasComment("Website meta title");

                entity.Property(e => e.WriteDate)
                    .HasColumnName("write_date")
                    .ForNpgsqlHasComment("Last Updated on");

                entity.Property(e => e.WriteUid)
                    .HasColumnName("write_uid")
                    .ForNpgsqlHasComment("Last Updated by");
            });

            modelBuilder.HasSequence("base_cache_signaling");

            modelBuilder.HasSequence("base_registry_signaling");

            modelBuilder.HasSequence("ir_sequence_002");

            modelBuilder.HasSequence("ir_sequence_003");

            modelBuilder.HasSequence("ir_sequence_004");

            modelBuilder.HasSequence("ir_sequence_005");

            modelBuilder.HasSequence("ir_sequence_006");

            modelBuilder.HasSequence("ir_sequence_013");

            modelBuilder.HasSequence("ir_sequence_014");

            modelBuilder.HasSequence("ir_sequence_015");

            modelBuilder.HasSequence("ir_sequence_016");

            modelBuilder.HasSequence("ir_sequence_017");

            modelBuilder.HasSequence("ir_sequence_018");

            modelBuilder.HasSequence("ir_sequence_019");

            modelBuilder.HasSequence("ir_sequence_020");

            modelBuilder.HasSequence("ir_sequence_021");

            modelBuilder.HasSequence("ir_sequence_022");
        }
    }
}
