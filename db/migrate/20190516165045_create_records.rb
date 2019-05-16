class CreateRecords < ActiveRecord::Migration[5.2]
  def change
    create_table :records do |t|
      t.string :title, null: false 
      t.string :artist, null: false 
      t.integer :user_id, null: false 
    end
    add_index :records, :user_id, unique: true 
  end
end
